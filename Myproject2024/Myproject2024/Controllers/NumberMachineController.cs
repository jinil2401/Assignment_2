using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace Myproject2024.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Applies four mathematical operations to the input integer.
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>Result of the mathematical operations</returns>
        public IHttpActionResult Get(int id)
        {
            int result = ((id + 5) * 2) / 3 - 7;
            return Ok(result);
        }
    }
}