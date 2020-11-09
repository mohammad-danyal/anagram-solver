namespace AnagramSolverAPI.Models
{
    /**
    * Class for the pairs of words.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class Pair
    {
        public string firstWord { get; set; }

        public string secondWord { get; set; }

        public string combinedWord
        {
            get { return (firstWord + " " + secondWord); }
        }
    }
}


