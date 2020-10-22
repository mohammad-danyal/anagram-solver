using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Anagram.Solver
{
    /**
    * Class which retrieves a word list from a URL comparing it to a given word's properties.
    *
    * @author Mohammad Danyal
    * @version October 2020
    */

    public class WordListWeb : IWordList
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */

        public List<string> GetWords(string mainWord)
        {
            var result = GetFileViaHttp("http://www-personal.umich.edu/~jlawler/wordlist");
            string str = Encoding.UTF8.GetString(result);
            string[] strArr = str.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            CheckWords(strArr, mainWord);

            return possibleWords;
        }

        private byte[] GetFileViaHttp(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(url);
            }
        }

        private void CheckWords(string[] words, string mainWord)
        {
            foreach (var word in words)
            {

                foreach (var c in word)
                {

                    if (!mainWord.Contains(c))
                    {
                        containsIllegalChar = true;
                        break;
                    }
                    else
                    {
                        containsIllegalChar = false;
                    }

                }

                if (containsIllegalChar == false)
                {
                    possibleWords.Add(word);

                }

            }
        }
    }


}
