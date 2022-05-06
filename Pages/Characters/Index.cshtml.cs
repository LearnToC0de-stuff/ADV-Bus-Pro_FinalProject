using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ADV_Bus_Pro_FinalProject_1.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.CharacterContext _context;

        public IndexModel(FinalProject.Models.CharacterContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort { get; set; }
        // Second sorting technique with a SelectList
        //public SelectList SortList { get; set; }

        public async Task OnGetAsync()
        {
            //Professor = await _context.Professor.ToListAsync();
            // Sorting support
            // Break up query. Do basic query first that just selects all characters
            var query = _context.Character.Select(c => c);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "FirstName Ascending", Value = "first_asc" },
                new SelectListItem { Text = "FirstName Descending", Value = "first_desc"}
            };
            //SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                // If user selected "first_asc", modify query to sort by first name ascending order
                case "first_asc":
                    query = query.OrderBy(p => p.FirstName);
                    break;
                // If user selected "first_desc", modify query to sort by first name descending
                case "first_desc":
                    query = query.OrderByDescending(p => p.FirstName);
                    break;
                    // Add more sorting cases as needed
            }

            // Retrieve just the professors for the page we are on
            // Use .Skip() and .Take() to select them
            Character = await query.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
