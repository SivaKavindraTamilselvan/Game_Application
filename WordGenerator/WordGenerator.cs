namespace WordGame.WordGenerator
{
    public class WordProvider
    {
        //private usage for security and abstraction
        //own words used for getting random words in a list
        private List<string> words = new List<string>
        {
            "APPLE",
            "BREAD",
            "CHAIR",
            "DREAM",
            "EAGLE",
            "FLAME",
            "GRAPE",
            "HOUSE",
            "JELLY",
            "KNIFE",
            "LEMON",
            "MANGO",
            "NIGHT",
            "OCEAN",
            "PIANO",
            "QUEEN",
            "RIVER",
            "SMILE",
            "TIGER",
            "WORLD"
        };
        //implementation of getting the elements from the list randomly
        private Random random = new Random();
        public string GetRandomWord()
        {
            return words[random.Next(words.Count)];
        }
    }

}