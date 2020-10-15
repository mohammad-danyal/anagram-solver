using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Anagram.Solver
{
    /**
    * Class which reads through a word list comparing it to a given word's properties.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class WordList : IWordList
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
            var client = new WebClient();
            string result = client.DownloadString("http://www-personal.umich.edu/~jlawler/wordlist");
            var tempFile = CreateTmpFile();

            StreamWriter streamWriter = File.AppendText(tempFile);
            streamWriter.WriteLine(result);
            streamWriter.Flush();
            streamWriter.Close();

            using (StreamReader sr = File.OpenText(tempFile))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    CheckWords(words, mainWord);
                }
            }

            File.Delete(tempFile);

            return possibleWords;
        }


        private static string CreateTmpFile()
        {
            string fileName = string.Empty;

            try
            {
                fileName = Path.GetTempFileName();

                FileInfo fileInfo = new FileInfo(fileName);

                fileInfo.Attributes = FileAttributes.Temporary;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to create TEMP file or set its attributes: " + ex.Message);
            }

            return fileName;
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
