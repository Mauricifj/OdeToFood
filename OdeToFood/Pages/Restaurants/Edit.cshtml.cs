using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages.Restaurants
{
    [Authorize]
    public class EditModel : PageModel
    {
        private IRestaurantData _restarauntData;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restarauntData = restaurantData;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant = _restarauntData.Get(id);
            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restarauntData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.Id });
            }
            return Page();
        }
    }
}