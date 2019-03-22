using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
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
}
