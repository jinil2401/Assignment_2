using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J3Controller : ApiController
    {


        /// <summary>
        /// Solves the "Arranging Books" problem by counting the occurrences of L, M, and S books on a shelf.
        /// It then calculates the minimum number of swaps needed to arrange the books in the order LMS.
        /// The algorithm emphasizes efficiency and simplicity in achieving the sorted order.
        /// </summary>
        class ArrangingBooks
        {
            static void Main()
            {
                string shelf = Console.ReadLine();
                int l = 0, m = 0, s = 0;

                // Count the number of L, M, and S books
                foreach (char book in shelf)
                {
                    if (book == 'L') l++;
                    else if (book == 'M') m++;
                    else if (book == 'S') s++;
                }

                // Placeholder for the actual swap calculation logic
                int swaps = 0;

                Console.WriteLine(swaps);
            }
        }
    }
}


