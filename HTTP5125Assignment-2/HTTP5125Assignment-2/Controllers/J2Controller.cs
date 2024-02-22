using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Calculates the number of combinations to achieve a sum of 10 using two dice with specified numbers of sides.
        /// </summary>
        /// <param name="m">The count of sides on the first dice.</param>
        /// <param name="n">The count of sides on the second dice.</param>
        /// <returns>The total combinations to reach a sum of 10.</returns>
        /// <example>
        /// GET Localhost:xx/api/J2/DiceGame/{m}/{n} -> "There are {count} ways to achieve a sum of 10."
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }
            return "There are " + count + " total ways to get the sum 10.";
        }
    }
}
