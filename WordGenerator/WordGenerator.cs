namespace WordGame.WordGenerator
{
    public class WordProvider
    {
        private List<string> words = new List<string>{"APPLE","MANGO","GRAPE","TRAIN","PLANT","BRAIN"};
        private Random random = new Random();
        public string GetRandomWord()
        {
            return words[random.Next(words.Count)];
        }
    }
    
}