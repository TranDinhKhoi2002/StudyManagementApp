using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using StudyManagementApp.FlashCardFolder;
using StudyManagementApp.DAO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections;
using System.Drawing;

namespace StudyManagementApp.FlashCardFolder
{
    public partial class FlashCardForm : Form
    {
        
        // Enum
        private enum State { NoDeck, EmptyDeck, OK }

        // Constants
        private const string NO_DECK = "[You have no Deck]";
        private const string EMPTY_DECK = "[This deck is empty]";
        static public DataTable deckTab;
        static public  DataTable FCDetail;
        public FlashCardForm()
        {
            InitializeComponent();
            
        }

        #region API

        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "vi", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        #endregion

        #region Fields

        bool isFlip;
        bool isAddFCTabOpen;
        bool isAddFCTab_SearchResultOpen;
        bool isDeckTabOpen;
        bool isDeckTab_AddDeckOpen;
        bool isDeckTab_DeckEditOpen;
        string deckIDToEdit;
        bool isFCDetailOpen;


        bool isUpdateFCMode;

        List<FlashCardDeck> fcDeckList = new List<FlashCardDeck>();
        List<FlashCard> fcList = new List<FlashCard>();

        private string currentDeckID
        {
            get
            {
                string deckID = null;
                foreach (FlashCardDeck deck in fcDeckList)
                    if (DeckComboBox.Text == deck.Name)
                    {
                        deckID = deck.Id;
                        break;
                    }
                return deckID;
            }
        }

       

        private int currentFCIndex = -1;
        private int currentDeckIndex = -1;

        #endregion

        #region Data Manager

        private void GetDecks()
        {
            // Get Username
            string username = UserInfo.Instance.Username;

            // Load FlashCardDecks
            DataTable deckTable = FlashCardDAO.Instance.GetDecks(username);
            fcDeckList.Clear();
            if (deckTable.Rows.Count > 0)
            {
                foreach (DataRow row in deckTable.Rows)
                {
                    fcDeckList.Add(new FlashCardDeck(row["ID"].ToString(), row["NAME"].ToString()));
                }
            }
            deckTab = deckTable;
         
        }

        private void GetFlashCards()
        {
            // Load Flashcards
            DataTable flashcardTable = FlashCardDAO.Instance.GetFlashCards(currentDeckID);
            fcList.Clear();
            if (flashcardTable.Rows.Count > 0)
            {
                foreach (DataRow row in flashcardTable.Rows)
                {
                    fcList.Add(
                        new FlashCard(
                            row["ID"].ToString(),
                            row["WORD"].ToString(),
                            row["DEFINITION"].ToString(),
                            row["DESCRIPTION"].ToString()
                            ));
                }
            }
            else
                currentFCIndex = -1;

            FCDetail = flashcardTable;
        }

        private List<string> DecksToList()
        {
            // Get all deck name
            var deckNameList = new List<string>();
            foreach (var deck in fcDeckList)
            {
                deckNameList.Add(deck.Name);
            }

            return deckNameList;
        }

        #endregion

        #region Controller

        public void FlashCardFlip()
        {
            isFlip = !isFlip;
            WordPanel.Visible = !WordPanel.Visible;
            DefDesTableLayout.Visible = !DefDesTableLayout.Visible;
        }

        private void ToggleAddFCTab()
        {
            if (isAddFCTabOpen)
            {
                isAddFCTabOpen = false;
                TabsDisplayTableLayout.ColumnStyles[2].Width += 35;
                TabsDisplayTableLayout.ColumnStyles[3].Width -= 35;
            }
            else
            {
                isAddFCTabOpen = true;
                TabsDisplayTableLayout.ColumnStyles[2].Width -= 35;
                TabsDisplayTableLayout.ColumnStyles[3].Width += 35;

                // Load decks
                AddFCTab_DeckCombobox.DataSource = DecksToList();
                AddFCTab_DeckCombobox.SelectedIndex = DeckComboBox.SelectedIndex;
            }
        }

        private void ToggleAddFCTab_SearchResult()
        {
            if (isAddFCTab_SearchResultOpen)
            {
                isAddFCTab_SearchResultOpen = false;
                AddFCTabTableLayout.RowStyles[0].Height = 10;
                AddFCTabTableLayout.RowStyles[1].Height = 15;
                AddFCTabTableLayout.RowStyles[2].Height = 15;
                AddFCTabTableLayout.RowStyles[3].Height = 15;
                AddFCTabTableLayout.RowStyles[4].Height = 35;
                AddFCTabTableLayout.RowStyles[5].Height = 10;
                AddFCTabTableLayout.RowStyles[6].Height = 0;
            }
            else
            {
                isAddFCTab_SearchResultOpen = true;
                AddFCTabTableLayout.RowStyles[0].Height = 10;
                AddFCTabTableLayout.RowStyles[1].Height = 15;
                AddFCTabTableLayout.RowStyles[2].Height = 15;
                AddFCTabTableLayout.RowStyles[3].Height = 15;
                AddFCTabTableLayout.RowStyles[4].Height = 25;
                AddFCTabTableLayout.RowStyles[5].Height = 0;
                AddFCTabTableLayout.RowStyles[6].Height = 20;
            }
        }

        private void ToggleDeckTab()
        {
            if (isDeckTabOpen)
            {
                isDeckTabOpen = false;
                if (isFCDetailOpen)
                    ToggleFCDetail();
                TabsDisplayTableLayout.ColumnStyles[1].Width -= 35;
                TabsDisplayTableLayout.ColumnStyles[2].Width += 35;

                DeckTab_InstructionLabel.Text = "Decks";
            }
            else
            {
                isDeckTabOpen = true;
                TabsDisplayTableLayout.ColumnStyles[1].Width += 35;
                TabsDisplayTableLayout.ColumnStyles[2].Width -= 35;
            }
        }

        private void ToggleFCDetail()
        {
            if (isFCDetailOpen)
            {
                isFCDetailOpen = false;
                TabsDisplayTableLayout.ColumnStyles[0].Width -= 35;
                TabsDisplayTableLayout.ColumnStyles[1].Width += 35;
            }
            else
            {
                isFCDetailOpen = true;
                TabsDisplayTableLayout.ColumnStyles[0].Width += 35;
                TabsDisplayTableLayout.ColumnStyles[1].Width -= 35;
            }
        }

        private void ToggleDeckTab_AddDeck()
        {
            if (isDeckTab_AddDeckOpen)
            {
                isDeckTab_AddDeckOpen = false;
                DeckTabTableLayout.RowStyles[0].Height = 10;
                DeckTabTableLayout.RowStyles[1].Height = 80;
                DeckTabTableLayout.RowStyles[2].Height = 10;
                DeckTabTableLayout.RowStyles[3].Height = 0;
                DeckTabTableLayout.RowStyles[4].Height = 0;
            }
            else
            {
                isDeckTab_AddDeckOpen = true;
                DeckTabTableLayout.RowStyles[0].Height = 10;
                DeckTabTableLayout.RowStyles[1].Height = 60;
                DeckTabTableLayout.RowStyles[2].Height = 0;
                DeckTabTableLayout.RowStyles[3].Height = 30;
                DeckTabTableLayout.RowStyles[4].Height = 0;

                DeckTab_AddDeck_DeckNameTxt.Select();
            }
        }

        private void ToggleDeckTab_DeckEdit()
        {
            if (isDeckTab_DeckEditOpen)
            {
                isDeckTab_DeckEditOpen = false;

                DeckTabTableLayout.RowStyles[0].Height = 10;
                DeckTabTableLayout.RowStyles[1].Height = 80;
                DeckTabTableLayout.RowStyles[2].Height = 10;
                DeckTabTableLayout.RowStyles[3].Height = 0;
                DeckTabTableLayout.RowStyles[4].Height = 0;
            }
            else
            {
                isDeckTab_DeckEditOpen = true;

                DeckTabTableLayout.RowStyles[0].Height = 10;
                DeckTabTableLayout.RowStyles[1].Height = 60;
                DeckTabTableLayout.RowStyles[2].Height = 0;
                DeckTabTableLayout.RowStyles[3].Height = 0;
                DeckTabTableLayout.RowStyles[4].Height = 30;
            }
        }

        private void SetState(State state)
        {
            switch (state)
            {
                case State.EmptyDeck:
                    WordLabel.Text = EMPTY_DECK;
                    FlashCardCountLabel.Text = "[0/0]";
                    break;
                case State.NoDeck:
                    WordLabel.Text = NO_DECK;
                    FlashCardCountLabel.Text = "[0/0]";
                    DeckComboBox.Text = "No deck";
                    break;
                case State.OK:
                    break;
            }
        }

        private void LoadDecks()
        {
            if (fcDeckList.Count > 0)
            {
                // Fill deck name in combobox
                DeckComboBox.DataSource = DecksToList();
                AddFCTab_DeckCombobox.DataSource = DecksToList();
            }
            else
            {
                currentFCIndex = -1;
                SetState(State.NoDeck);
            }
        }

        private void PrepareFlashCard(int index)
        {
            if (index < 0)
            {
                if (fcList.Count > 0)
                    index = 0;
                else
                {
                    SetState(State.EmptyDeck);

                    return;
                }
            }

            FlashCard currentFlashCard = fcList[index];

            WordLabel.Text = currentFlashCard.Word;
            DefinitionLabel.Text = currentFlashCard.Definition;
            DescriptionContentLabel.Text = currentFlashCard.Description;

            if (DescriptionContentLabel.Text == string.Empty)
            {
                DefDesTableLayout.RowStyles[0].Height = 100;
                DefDesTableLayout.RowStyles[1].Height = 0;
            }
            else
            {
                DefDesTableLayout.RowStyles[0].Height = 50;
                DefDesTableLayout.RowStyles[1].Height = 50;
            }

            // Change flashcardcount label
            FlashCardCountLabel.Text = string.Format("[{0}/{1}]", index + 1, fcList.Count);
        }

        private void DeckTabLoad()
        {
            DeckTab_Datagridview.DataSource = FlashCardDAO.Instance.GetDecks(UserInfo.Instance.Username);
            DeckTab_Datagridview.Columns[0].Visible = false;
            DeckTab_Datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DeckTab_Datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DeckDetailLoad()
        {
            FCDetailTab_Datagridview.DataSource = FlashCardDAO.Instance.GetFlashCards(currentDeckID);
            FCDetailTab_Datagridview.Columns[0].Visible = false;
            FCDetailTab_Datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FCDetailTab_Datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FCDetailTab_Datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DeckDetailLoad(string deckID)
        {
            FCDetailTab_Datagridview.DataSource = FlashCardDAO.Instance.GetFlashCards(deckID);
            FCDetailTab_Datagridview.Columns[0].Visible = false;
            FCDetailTab_Datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FCDetailTab_Datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FCDetailTab_Datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void AddFCTab_ChangeWithNavigation()
        {
            FlashCard currentFlashCard = fcList[currentFCIndex];
            AddFCTab_DeckCombobox.SelectedIndex = DeckComboBox.SelectedIndex;
            AddFCTab_WordTxt.Text = currentFlashCard.Word;
            AddFCTab_DefinitionTxt.Text = currentFlashCard.Definition;
            AddFCTab_DescriptionContentRichTextBox.Text = currentFlashCard.Description;
        }

        private void ToggleUpdateFCMode(bool state)
        {
            isUpdateFCMode = state;

            if (isUpdateFCMode)
            {
                AddFCTab_InstructionLabel.Text = "Update FlashCard";
                AddFCTab_ConfirmRcbtn.Text = "Update";
            }
            else
            {
                AddFCTab_InstructionLabel.Text = "Add FlashCard";
                AddFCTab_ConfirmRcbtn.Text = "Add";

                AddFCTab_WordTxt.Text = string.Empty;
                AddFCTab_DefinitionTxt.Text = string.Empty;
                AddFCTab_DescriptionContentRichTextBox.Text = string.Empty;
            }
        }

        #endregion

        #region Event Handlers
        //
        // FlashCardUC
        //
        private void FlashCardUC_Load(object sender, EventArgs e)
        {
            // Theme
            LoadMau();
     
            // Set initial state
            isFlip = false;
            WordPanel.Visible = true;
            DefDesTableLayout.Visible = false;

            isAddFCTabOpen = false;
            isAddFCTab_SearchResultOpen = false;

            isDeckTabOpen = false;
            isDeckTab_AddDeckOpen = false;
            isDeckTab_DeckEditOpen= false;
            
            isFCDetailOpen = false;

            // Load Decks
            GetDecks();

            if (fcDeckList.Count > 0)
            {
                LoadDecks();
                GetFlashCards();
                if (fcList.Count > 0)
                {
                    currentFCIndex = 0;
                    PrepareFlashCard(currentFCIndex);
                }
                else
                {
                    currentFCIndex = -1;
                    SetState(State.EmptyDeck);
                }
            }
            else
            {
                currentDeckIndex = -1;
                currentFCIndex = -1;
                SetState(State.NoDeck);
            }

            // Load decks in Decks tab
            DeckTabLoad();
        }
        //
        // FlipRcbtn
        //
        private void FlipRcbtn_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }

            if (fcList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new flash card first at '+' button]";
                return;
            }

            FlashCardFlip();
        }
        //
        // Edit Button
        //
        private void FCEditButton_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }
            if (fcList.Count <= 0)
            {
                WordLabel.Text = "[There's no flashcard to edit, add new flash card at '+' button]";
                return;
            }

            if (isAddFCTabOpen)
            {
                if (isUpdateFCMode)
                    ToggleAddFCTab();
                else
                    ToggleUpdateFCMode(true);
            }
            else
            {
                ToggleAddFCTab();
                ToggleUpdateFCMode(true);
            }
            //Get current FC data
            AddFCTab_ChangeWithNavigation();
        }
        //
        // DeckComboBox
        //
        private void DeckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDeckIndex = DeckComboBox.SelectedIndex;

            GetFlashCards();
            if (fcList.Count > 0)
            {
                currentFCIndex = 0;
                PrepareFlashCard(currentFCIndex);
            }
            else
            {
                currentFCIndex = -1;
                SetState(State.EmptyDeck);
            }

            if (isAddFCTabOpen && isUpdateFCMode)
                AddFCTab_ChangeWithNavigation();
        }
        //
        // Navigation
        //
        private void NextRcbtn_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }

            if (fcList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new flash card first at '+' button]";
                return;
            }

            currentFCIndex = (currentFCIndex + 1) % fcList.Count;
            PrepareFlashCard(currentFCIndex);
            if (isFlip)
                FlashCardFlip();

            // Change edit fc tab
            if (isAddFCTabOpen && isUpdateFCMode)
                AddFCTab_ChangeWithNavigation();
        }


        private void PreviousRcbtn_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }

            if (fcList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new flash card first at '+' button]";
                return;
            }

            currentFCIndex--;
            if (currentFCIndex < 0)
                currentFCIndex = fcList.Count - 1;

            PrepareFlashCard(currentFCIndex);
            if (isFlip)
                FlashCardFlip();

            // Change edit fc tab
            if (isAddFCTabOpen && isUpdateFCMode)
                AddFCTab_ChangeWithNavigation();
        }

        List<bool> randomArr = new List<bool>();
        Random random = new Random();
        private void RandomRcbtn_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }

            if (fcList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new flash card first at '+' button]";
                return;
            }

            if (randomArr.Count < fcList.Count)
            {
                int difference = fcList.Count - randomArr.Count;
                for (int i = 0; i < difference; i++)
                    randomArr.Add(false);
            }
            else if (randomArr.Count > fcList.Count)
            {
                int difference = randomArr.Count - fcList.Count;
                for (int i = 0; i < difference; i++)
                    randomArr.RemoveAt(randomArr.Count - 1);
            }

            // Check if there's any false value in randomArr
            for (int i = 0; i < randomArr.Count; i++)
            {
                if (randomArr[i] == false)
                    break;
                if (i == randomArr.Count - 1)
                {
                    for (int j = 0; j < randomArr.Count; j++)
                        randomArr[j] = false;
                    break;
                }

            }

            // Find a random index
            int index = random.Next(0, randomArr.Count);
            while (index == currentFCIndex && randomArr[index] == true)
                index = random.Next(0, randomArr.Count);

            // Prepare flashcard and flip value of Random arr
            currentFCIndex = index;
            PrepareFlashCard(currentFCIndex);

            // Change edit fc tab
            if (isAddFCTabOpen && isUpdateFCMode)
                AddFCTab_ChangeWithNavigation();

            randomArr[index] = true;
        }
        //
        // SearchBackgroundWorker
        //
        private void SearchBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string wordToTranslate = AddFCTab_WordTxt.Text;
            string result = TranslateText(wordToTranslate);
            e.Result = result;
        }

        private void SearchBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            AddFCTab_SearchResultLabel.Text = e.Result.ToString();
            AddFCTab_Search_ButtonsPanel.ColumnStyles[0].Width = 50;
            AddFCTab_Search_ButtonsPanel.ColumnStyles[1].Width = 50;
        }
        //
        // Deck Tab
        //
        private void DeckMoreRcbtn_Click(object sender, EventArgs e)
        {
            ToggleDeckTab();
        }

        private void DeckTabDeckAddAccpetButton_Click(object sender, EventArgs e)
        {
            if (DeckTab_AddDeck_DeckNameTxt.Texts.Equals(string.Empty))
            {
                DeckTab_InstructionLabel.Text = "Deck name empty";
            }
            else
            {
                string deckName = DeckTab_AddDeck_DeckNameTxt.Texts;
                string username = UserInfo.Instance.Username;
                bool isHasNoDeck = fcDeckList.Count == 0;

                try
                {
                    FlashCardDAO.Instance.InsertDeck(username, deckName);
                }
                catch
                {
                    DeckTab_InstructionLabel.Text = "Deck name existed";
                    return;
                }

                DeckTab_InstructionLabel.Text = "Deck added";

                // Reload Decks (Decks tab)
                DeckTabLoad();

                // Reload Decks (Bar)
                GetDecks();
                if (isHasNoDeck)
                {
                    if (fcDeckList.Count > 0)
                    {
                        LoadDecks();
                        GetFlashCards();
                        if (fcList.Count > 0)
                        {
                            currentFCIndex = 0;
                            PrepareFlashCard(currentFCIndex);
                        }
                        else
                        {
                            currentFCIndex = -1;
                            SetState(State.EmptyDeck);
                        }
                    }
                    else
                    {
                        currentDeckIndex = -1;
                        currentFCIndex = -1;
                        SetState(State.NoDeck);
                    }
                }
                else
                {
                    LoadDecks();
                }

                DeckTab_AddDeck_DeckNameTxt.Texts = string.Empty;
                ToggleDeckTab_AddDeck();
            }
        }

        private void DecksTabCloseButton_Click(object sender, EventArgs e)
        {
            ToggleDeckTab();
        }

        private void DeckTabRemoveDeckButton_Click(object sender, EventArgs e)
        {
            if (DeckTab_Datagridview.SelectedRows.Count <= 0 || DeckTab_Datagridview.Rows.Count <= 1)
            {
                DeckTab_InstructionLabel.Text = "No deck to remove";
                return;
            }

            if (DeckTab_Datagridview.SelectedRows.Count == 1)
            {
                try
                {
                    string id = DeckTab_Datagridview.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch
                {
                    DeckTab_InstructionLabel.Text = "No deck to remove";
                    return;
                }
            }

            if (MessageBox.Show("Delete these decks?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isCurrentDeckDeleted = false;
                int deckDeletedCount = 0;

                foreach (DataGridViewRow row in DeckTab_Datagridview.SelectedRows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() == currentDeckID)
                            isCurrentDeckDeleted = true;
                        FlashCardDAO.Instance.DeleteDeck(row.Cells[0].Value.ToString());
                    }
                    catch
                    {
                        deckDeletedCount--;
                    }

                    deckDeletedCount++;
                }

                // Reload Decks (Decks tab)
                DeckTabLoad();

                // Reload Decks (Bar)
                GetDecks();

                if (isCurrentDeckDeleted)
                {
                    if (fcDeckList.Count > 0)
                    {
                        LoadDecks();
                        GetFlashCards();
                        if (fcList.Count > 0)
                        {
                            currentFCIndex = 0;
                            PrepareFlashCard(currentFCIndex);
                        }
                        else
                        {
                            currentFCIndex = -1;
                            SetState(State.EmptyDeck);
                        }
                    }
                    else
                    {
                        currentDeckIndex = -1;
                        currentFCIndex = -1;
                        SetState(State.NoDeck);
                    }
                }
                else
                {
                    LoadDecks();
                }

                // Notify
                DeckTab_InstructionLabel.Text = string.Format("{0} decks deleted", deckDeletedCount);
                if (fcDeckList.Count == 0)
                {
                    if (isAddFCTabOpen)
                    {
                        if (isUpdateFCMode)
                            ToggleUpdateFCMode(false);
                        ToggleAddFCTab();
                    }
                }
            }
        }

        private void DeckTabAddDeckButton_Click(object sender, EventArgs e)
        {
            ToggleDeckTab_AddDeck();
        }

        

        private void DeckTabDeckAddCancelButton_Click(object sender, EventArgs e)
        {
            ToggleDeckTab_AddDeck();
        }

        private void DeckTab_Datagridview_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DeckTab_Datagridview.Rows.Count > 1)
            {
                fcDetailID = DeckTab_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (fcDetailID != string.Empty)
                {
                    FCDetailTab_Datagridview.DataSource = FlashCardDAO.Instance.GetFlashCards(fcDetailID);
                    FCDetailTab_Datagridview.Columns[0].Visible = false;
                    FCDetailTab_Datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    FCDetailTab_Datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    FCDetailTab_Datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    FCDetailTab_InstructionLabel.Text = DeckTab_Datagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                    ToggleFCDetail();
                }
            }
        }

        

        private void DeckTab_EditButton_Click(object sender, EventArgs e)
        {
            if (DeckTab_Datagridview.Rows.Count <= 1)
            {
                DeckTab_InstructionLabel.Text = "No deck to edit";
                return;
            }
            if (DeckTab_Datagridview.SelectedRows.Count != 1)
            {
                DeckTab_InstructionLabel.Text = "One deck only";
                return;
            }
            try
            {
                DeckTab_EditDeck_DeckNameTxt.Text = DeckTab_Datagridview.SelectedRows[0].Cells[1].Value.ToString();
                deckIDToEdit = DeckTab_Datagridview.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                DeckTab_InstructionLabel.Text = "No deck to edit";
                return;
            }

            if (isDeckTab_AddDeckOpen)
                ToggleDeckTab_AddDeck();
            ToggleDeckTab_DeckEdit();
        }

        private void DeckTab_EditDeck_AccpetButton_Click(object sender, EventArgs e)
        {
            if (DeckTab_EditDeck_DeckNameTxt.Text.Equals(string.Empty))
            {
                DeckTab_InstructionLabel.Text = "Deck name empty";
                return;
            }

            try
            {
                FlashCardDAO.Instance.UpdateDeck(deckIDToEdit, DeckTab_EditDeck_DeckNameTxt.Text);
            }
            catch
            {
                DeckTab_InstructionLabel.Text = "Deck name existed";
            }

            DeckTab_InstructionLabel.Text = "Deck's name updated";

            // Reload Decks (Decks tab)
            DeckTabLoad();

            // Reload Decks (Bar)
            GetDecks();
            LoadDecks();

            ToggleDeckTab_DeckEdit();
        }

        private void DeckTab_EditDeck_CancelButton_Click(object sender, EventArgs e)
        {
            ToggleDeckTab_DeckEdit();
        }

        //
        // FlashCard Add Tab
        //
        private void FCAddButton_Click(object sender, EventArgs e)
        {
            if (fcDeckList.Count <= 0)
            {
                WordLabel.Text = "[Please add a new deck first at 'More' button]";
                return;
            }

            if (isAddFCTabOpen)
            {
                if (!isUpdateFCMode)
                    ToggleAddFCTab();
                else
                    ToggleUpdateFCMode(false);
            }
            else
            {
                ToggleAddFCTab();
                ToggleUpdateFCMode(false);
            }
            //Clear textbox
            AddFCTab_WordTxt.Text = string.Empty;
            AddFCTab_DefinitionTxt.Text = string.Empty;
            AddFCTab_DescriptionContentRichTextBox.Text = string.Empty;
        }

        private void FCAddConfirmRcbtn_Click(object sender, EventArgs e)
        {
            if (AddFCTab_WordTxt.Text.Equals(string.Empty))
            {
                AddFCTab_InstructionLabel.Text = "Word is empty";
                return;
            }
            if (AddFCTab_DefinitionTxt.Text.Equals(string.Empty))
            {
                AddFCTab_InstructionLabel.Text = "Definition is empty";
                return;
            }
            string word = AddFCTab_WordTxt.Text;
            string definition = AddFCTab_DefinitionTxt.Text;
            string description = AddFCTab_DescriptionContentRichTextBox.Text;

            if (isUpdateFCMode)
            {
                string id = fcList[currentFCIndex].Id;
                string deckID = fcDeckList[AddFCTab_DeckCombobox.SelectedIndex].Id;

                FlashCardDAO.Instance.UpdateFlashCard(id, deckID, word, definition, description);
                // Notify update flashcard successfully
                AddFCTab_InstructionLabel.Text = "Flashcard updated";

                GetFlashCards();
                PrepareFlashCard(currentFCIndex);

                // Update datagridview in decktab and detail deck tab
                DeckTabLoad();
                if (isFCDetailOpen && fcDetailID == deckID)
                    DeckDetailLoad(deckID);

                if (fcList.Count == 0)
                {
                    ToggleUpdateFCMode(false);
                    ToggleAddFCTab();
                }
            }
            else
            {
                string deckID = fcDeckList[AddFCTab_DeckCombobox.SelectedIndex].Id;

                FlashCardDAO.Instance.InsertFlashCard(deckID, word, definition, description);

                // Clear Textbox
                AddFCTab_WordTxt.Text = string.Empty;
                AddFCTab_DefinitionTxt.Text = string.Empty;
                AddFCTab_DescriptionContentRichTextBox.Text = string.Empty;

                // Notify add flashcard successfully
                AddFCTab_InstructionLabel.Text = "Flashcard added";

                //LoadDecks();
                GetFlashCards();

                // Update datagridview in decktab and detail deck tab
                DeckTabLoad();
                if (isFCDetailOpen && fcDetailID == deckID)
                    DeckDetailLoad(deckID);
            }

        }

        private void FCAddCloseRcbtn_Click(object sender, EventArgs e)
        {
            ToggleAddFCTab();
        }

        private void FCAddSearchRcbtn_Click(object sender, EventArgs e)
        {
            if (AddFCTab_WordTxt.Text.Equals(string.Empty))
            {
                AddFCTab_InstructionLabel.Text = "Word is empty";
                return;
            }
            else
            {
                AddFCTab_SearchResultLabel.Text = "Searching";
                AddFCTab_Search_ButtonsPanel.ColumnStyles[0].Width = 0;
                AddFCTab_Search_ButtonsPanel.ColumnStyles[1].Width = 100;

                ToggleAddFCTab_SearchResult();

                if (!SearchBackgroundWorker.IsBusy)
                    SearchBackgroundWorker.RunWorkerAsync();
            }
        }

        private void AddFCTab_Search_CancelButton_Click(object sender, EventArgs e)
        {
            ToggleAddFCTab_SearchResult();
            SearchBackgroundWorker.CancelAsync();
        }

        private void AddFCTab_Search_AcceptButton_Click(object sender, EventArgs e)
        {
            ToggleAddFCTab_SearchResult();
            AddFCTab_DefinitionTxt.Text = AddFCTab_SearchResultLabel.Text;
        }

        //
        // FCDetailTab
        //

        string fcDetailID;

        private void FCDetailTab_Datagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FCDetailTab_Datagridview.Rows.Count > 1)
            {
                // Get infomation
                string fcID = FCDetailTab_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Naviage deckcombobox
                for (int i = 0; i < fcDeckList.Count; i++)
                    if (fcDeckList[i].Id == fcDetailID)
                    {
                        DeckComboBox.SelectedIndex = i;
                        break;
                    }

                // Prepare FlashCard
                currentFCIndex = e.RowIndex;
                PrepareFlashCard(currentFCIndex);

                if (isAddFCTabOpen)
                {
                    if (!isUpdateFCMode)
                        ToggleUpdateFCMode(true);
                }
                else
                {
                    ToggleAddFCTab();
                    ToggleUpdateFCMode(true);
                }

                AddFCTab_ChangeWithNavigation();
            }
        }

        private void FCDetail_FCRemoveButton_Click(object sender, EventArgs e)
        {
            if (FCDetailTab_Datagridview.SelectedRows.Count <= 0 || FCDetailTab_Datagridview.Rows.Count <= 1)
            {
                FCDetailTab_InstructionLabel.Text = "No flashcard to remove";
                return;
            }

            if (FCDetailTab_Datagridview.SelectedRows.Count == 1)
            {
                try
                {
                    string id = FCDetailTab_Datagridview.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch
                {
                    FCDetailTab_InstructionLabel.Text = "No flashcard to remove";
                    return;
                }
            }

            if (MessageBox.Show("Delete these flashcards?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool currentFCDeleted = false;
                int fcDeletedCount = 0;

                foreach (DataGridViewRow row in FCDetailTab_Datagridview.SelectedRows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() == fcList[currentFCIndex].Id)
                            currentFCDeleted = true;
                        FlashCardDAO.Instance.DeleteFlashCard(row.Cells[0].Value.ToString());
                    }
                    catch
                    {
                        fcDeletedCount--;
                    }
                    fcDeletedCount++;
                }

                // Reload deck detail
                DeckTabLoad();

                FCDetailTab_Datagridview.DataSource = FlashCardDAO.Instance.GetFlashCards(fcDetailID);
                FCDetailTab_Datagridview.Columns[0].Visible = false;
                FCDetailTab_Datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                FCDetailTab_Datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                FCDetailTab_Datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                GetFlashCards();
                if (fcList.Count > 0)
                {
                    if (currentFCDeleted)
                        currentFCIndex = 0; 
                }
                else
                {
                    if (isAddFCTabOpen)
                    {
                        if (isUpdateFCMode)
                            ToggleUpdateFCMode(false);
                        ToggleAddFCTab();
                    }
                }
                PrepareFlashCard(currentFCIndex);

                FCDetailTab_InstructionLabel.Text = string.Format("{0} flashcards deleted", fcDeletedCount);
            }
        }

        private void FCDetailReturnButton_Click(object sender, EventArgs e)
        {
            ToggleFCDetail();
        }

        private void FCDetailAddFCButton_Click(object sender, EventArgs e)
        {
            if (!isAddFCTabOpen)
            {
                ToggleAddFCTab();
                ToggleUpdateFCMode(false);
            }
            else
            {
                ToggleUpdateFCMode(false);
            }

            for (int i = 0; i < fcDeckList.Count; i++)
                if (fcDeckList[i].Id == fcDetailID)
                {
                    AddFCTab_DeckCombobox.SelectedIndex = i;
                    break;
                }
        }
        #endregion

        #region  Theme

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                this.BackColor = Color.FromArgb(236, 235, 235);
                ControlTableLayout.BackColor = Color.FromArgb(213, 208, 210);
                DeckTabTableLayout.BackColor = Color.FromArgb(213, 208, 210);
                DeckTab_Datagridview.BackgroundColor = Color.FromArgb(213, 208, 210);
                DeckTab_AddDeckTableLayout.BackColor = Color.FromArgb(100, 101, 110);
                DeckTab_EditDeck_TableLayout.BackColor = Color.FromArgb(100, 101, 110);
                AddFCTabTableLayout.BackColor = Color.FromArgb(213, 208, 210);
                AddFCTab_SearchSectionPanel.BackColor = Color.FromArgb(100, 101, 110);
                FCDetailTabTableLayout.BackColor = Color.FromArgb(100, 101, 110);
                FCDetailTab_Datagridview.BackgroundColor = Color.FromArgb(100, 101, 110);

                // Font
                FlashCardCountLabel.ForeColor = Color.FromArgb(5, 5, 5);
                WordLabel.ForeColor = Color.FromArgb(5, 5, 5);
                DefinitionLabel.ForeColor = Color.FromArgb(5, 5, 5);
                DescriptionContentLabel.ForeColor = Color.FromArgb(5, 5, 5);
                DescriptionTitleLabel.ForeColor = Color.FromArgb(5, 5, 5);
                AddFCTab_WordTitleLabel.ForeColor = Color.FromArgb(5, 5, 5);
                AddFCTab_DefinitionTitleLabel.ForeColor = Color.FromArgb(5, 5, 5);
                AddFCTab_DescriptionTitleLabel.ForeColor = Color.FromArgb(5, 5, 5);
                AddFCTab_SearchResultLabel.ForeColor = Color.FromArgb(5, 5, 5);
            }
            else
            {
                this.BackColor = SacMau.dendam;

                ControlTableLayout.BackColor = Color.FromArgb(37, 42, 45);
                DeckTabTableLayout.BackColor = Color.FromArgb(37, 42, 45);
                AddFCTabTableLayout.BackColor = Color.FromArgb(37, 42, 45);
                DeckTab_Datagridview.BackgroundColor = Color.FromArgb(37, 42, 45);

                FCDetailTabTableLayout.BackColor = Color.FromArgb(27, 32, 35);
                DeckTab_AddDeckTableLayout.BackColor = Color.FromArgb(27, 32, 35);
                DeckTab_EditDeck_ButtonsTableLayout.BackColor = Color.FromArgb(27, 32, 35);
                AddFCTab_SearchSectionPanel.BackColor = Color.FromArgb(27, 32, 35);
                FCDetailTab_Datagridview.BackgroundColor = Color.FromArgb(27, 32, 35);
            }
        }

        

        #endregion

        

    }
}
