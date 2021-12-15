namespace StudyManagementApp.FlashCardFolder
{
    public class FlashCard
    {
        string id;
        string word;
        string definition;
        string description;

        public FlashCard(string id, string word, string definition, string description)
        {
            this.id = id;
            this.word = word;
            this.definition = definition;
            this.description = description;
        }

        public string Id { get => id; set => id = value; }
        public string Word { get => word; set => word = value; }
        public string Definition { get => definition; set => definition = value; }
        public string Description { get => description; set => description = value; }
    }
}
