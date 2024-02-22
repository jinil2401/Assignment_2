
using System.Web.Http;
using System.Collections.Generic;

namespace HTTP5125Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        // Renamed variable to _calorieOptionsByCategory for better clarity and descriptiveness
        private readonly Dictionary<string, int[]> _calorieOptionsByCategory = new Dictionary<string, int[]>
        {
            {"burgers", new[] { 461, 431, 420, 0 }},
            {"drinks", new[] { 130, 160, 118, 0 }},
            {"sides", new[] { 100, 57, 70, 0 }},
            {"desserts", new[] { 167, 266, 75, 0 }}
        };

        /// <summary>
        /// Computes the total calories of a meal based on the customer's selections.
        /// </summary>
        /// <param name="burger">The customer's burger selection (1-4).</param>
        /// <param name="drink">The customer's drink selection (1-4).</param>
        /// <param name="side">The customer's side selection (1-4).</param>
        /// <param name="dessert">The customer's dessert selection (1-4).</param>
        /// <returns>A response indicating the total calorie count of the selected meal.</returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public IHttpActionResult Menu(int burger, int drink, int side, int dessert)
        {
            if (IsValidChoice(burger) && IsValidChoice(drink) && IsValidChoice(side) && IsValidChoice(dessert))
            {
                int totalCalories = CalculateTotalCalories(burger, drink, side, dessert);
                return Ok($"Your total calorie count is {totalCalories}");
            }
            else
            {
                return BadRequest("One or more choices are out of the valid range. Please choose options between 1 and 4 for each category.");
            }
        }

        private bool IsValidChoice(int choice) => choice >= 1 && choice <= 4;

        private int CalculateTotalCalories(int burger, int drink, int side, int dessert)
        {
            return _calorieOptionsByCategory["burgers"][burger - 1] +
                   _calorieOptionsByCategory["drinks"][drink - 1] +
                   _calorieOptionsByCategory["sides"][side - 1] +
                   _calorieOptionsByCategory["desserts"][dessert - 1];
        }
    }
}

