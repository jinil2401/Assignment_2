using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Myproject2024.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the input integer.
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>Square of the input integer</returns>
        public IHttpActionResult Get(int id)
        {
            int result = id * id;
            return Ok(result);
        }
    }
}