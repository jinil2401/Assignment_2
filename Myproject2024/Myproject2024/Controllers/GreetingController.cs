using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace Myproject2024.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World!".
        /// </summary>
        /// <returns>Greeting string</returns>
        public string post()
        {
            return ("Hello World!");
        }

        /// <summary>
        /// Returns a greeting string based on the input integer.
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>Greeting string</returns>
        public string Get(int id)
        {
            string result = $"Greetings to {id} people!";
            return result;
        }
    }
}
