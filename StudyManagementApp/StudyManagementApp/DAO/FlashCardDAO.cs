using System.Data;

namespace StudyManagementApp.DAO
{
    public class FlashCardDAO
    {
        private static FlashCardDAO instance;

        public static FlashCardDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FlashCardDAO();
                return instance;
            }
            private set => instance = value;
        }

        private FlashCardDAO() { }

        #region Data Manage

        //
        // Flashcard Deck
        //
        public DataTable GetDecks(string username)
        {
            string query = "GetDecks @username";

            object[] parameters = new object[] { username };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            return result;
        }

        public bool InsertDeck(string username, string name)
        {
            string query = "InsertDeck @username , @name";

            object[] parametes = new object[] { username, name };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        public bool DeleteDeck(string deckID)
        {
            string query = "DeleteDeck @deckID";

            object[] parametes = new object[] { deckID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        public bool UpdateDeck(string deckID, string name)
        {
            string query = "UpdateDeck @deckID , @name";

            object[] parametes = new object[] { deckID, name };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        //
        // FlashCard
        //
        public DataTable GetFlashCards(string deckID)
        {
            string query = "GetFlashCards @deckID";

            object[] parameters = new object[] { deckID };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            return result;
        }

        public bool InsertFlashCard(string deckID, string word, string definition, string description)
        {
            string query = "InsertFlashCard @deckID , @word , @definition , @description";

            object[] parametes = new object[] { deckID, word, definition, description };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        public bool DeleteFlashCard(string id)
        {
            string query = "DeleteFlashCard @id";

            object[] parametes = new object[] { id };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        public bool UpdateFlashCard(string id, string deckID, string word, string definition, string description)
        {
            string query = "UpdateFlashCard @id , @deckID , @word , @definition , @description";

            object[] parametes = new object[] { id, deckID, word, definition, description };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parametes);

            return result > 0;
        }

        #endregion
    }
}
