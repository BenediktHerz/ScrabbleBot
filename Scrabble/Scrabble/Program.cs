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
            JObject json = JObject.Parse(File.ReadAllText(@"words.json"));
            string json1 = json.ToString(Newtonsoft.Json.Formatting.None);


            int Counter = 1;
            for(int i=0;i<34;i++)
            {
                
            }
            
            ShiftWords(Counter);
            

            foreach (string part in json["words"])
            {
                
            }



            Console.WriteLine("Finish");
            Console.ReadLine();
        }

        public static void ShiftWords(int Count)
        {
            String FileName = "words1.json";
            FileName = "words" + Count + ".json";
            String aktLine = "";
            String Temp = "";

            using (StreamReader sr = new StreamReader("words.json", Encoding.Default, true))
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    while ((aktLine = sr.ReadLine()) != null)
                    {
                        aktLine = sr.ReadLine();
                        if (aktLine == "" || aktLine == null)
                        { }
                        else
                        {
                            Temp = aktLine.Substring(0 + Count, 1);

                            aktLine = aktLine.Substring(1 + Count, aktLine.Length - Count - 1);
                            aktLine = aktLine + Temp;
                            sw.WriteLine(aktLine);
                        }
                    }
                }
            }
        }
    }

    class words
    {

    }
}
