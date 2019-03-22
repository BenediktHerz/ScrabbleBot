using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Scrabble
{
    class WordDictionary
    {
        private List<List<string>> dic = new List<List<string>>();

        public WordDictionary()
        {
            Console.WriteLine("Im called");

            JObject json = JObject.Parse(File.ReadAllText(@"words.json"));
            JObject currentJson = json;
            string[] dictonary;

            int longest_word = 0;


            foreach (string word in json["words"])
            {
                if (longest_word < word.Length)
                {
                    longest_word = word.Length;
                }

            }

            for (int i = 1; i < longest_word; i++)
            {
                List<string> currentShift = new List<string>();

                foreach (string word in json["words"])
                {
                    if (word.Length > i)
                    {
                        string wordWithDelemiter = word.Insert(i, ",");
                        string[] arr = wordWithDelemiter.Split(',');
                        string newWord = arr[1] + "," + arr[0];

                        currentShift.Add(newWord);
                    }

                }


                dic.Add(currentShift);
            }
        }


        public void search(string[] pos)
        {

        }
    }
}
