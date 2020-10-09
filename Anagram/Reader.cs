using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Anagram.Solver
{
    /**
    * Class which provides the source of the word list.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class Reader
    {

        public static string GetFile()
        {
            string path = @"C:\Users\danya\Desktop\anagram-solver\wordlist.txt";

            return path;
        }

    }
}
