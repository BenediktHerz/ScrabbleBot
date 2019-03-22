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
    class Program
    {
        static void Main(string[] args)
        {







            WordDictionary wordDic = new WordDictionary();
            Scrabbleboard scrabbleBoard = new Scrabbleboard();

            Console.WriteLine("Finish");

            Console.ReadLine();
        }
    }

    class WordDictionary
    {
        public List<List<string>> dic = new List<List<string>>();

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

    class Scrabbleboard
    {
        private Array board;

        public Scrabbleboard()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int k = 0; k < 15; k++)
                {
                    if ((i % 7 == 0 && k % 7 == 0) && !(i == 7 && k == 7))
                    {
                        Console.WriteLine("Im dribbel Word");
                    }

                    if ((i % 4 == 2 && k % 4 == 2) && !(1 == 0))
                    {
                        Console.WriteLine("Im dribbel Letter");
                    }
                }
            }
        }

    }

    class Scrabblefield
    {

    }
}
