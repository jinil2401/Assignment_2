using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Myproject2024.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns 10 more than the input integer.
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>Result of adding 10 to the input</returns>
        public IHttpActionResult Get(int id)
        {
            int result = id + 10;
            return Ok(result);
        }
    }
}
