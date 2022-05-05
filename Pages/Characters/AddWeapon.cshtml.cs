using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ADV_Bus_Pro_FinalProject_1.Pages
{
    public class AddWeaponModel : PageModel
    {
        private readonly ILogger<AddWeaponModel> _logger;
        private readonly CharacterContext _context; // Character Database context
        [BindProperty]
        public Weapon Weapon { get; set; }
        public SelectList CharactersDropDown { get; set; }

        public AddWeaponModel(CharacterContext context, ILogger<AddWeaponModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            CharactersDropDown = new SelectList(_context.Character.ToList(), "CharacterId", "FirstName");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Weapon.Add(Weapon);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}