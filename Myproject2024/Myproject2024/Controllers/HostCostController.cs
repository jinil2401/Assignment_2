using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace Myproject2024.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the hosting cost based on the elapsed days since the beginning.
        /// </summary>
        /// <param name="id">Number of days elapsed</param>
        /// <returns>Strings describing the hosting cost</returns>
        public IHttpActionResult Get(int id)
        {
            double fortnightCost = 5.50;
            double hstRate = 0.13;

            int fortnights = (int)Math.Ceiling((double)id / 14);
            double totalCost = fortnights * fortnightCost;
            double hst = totalCost * hstRate;

            string result = $"1 fortnight at ${fortnightCost}/FN = ${fortnightCost:F2} CAD\n" +
                            $"HST {hstRate * 100}% = ${hst:F2} CAD\n" +
                            $"Total = ${(totalCost + hst):F2} CAD";

            return Ok(result);
        }
    }
}