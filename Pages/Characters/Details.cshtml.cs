using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace ADV_Bus_Pro_FinalProject_1.Pages.Characters
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.CharacterContext _context;

        public DetailsModel(FinalProject.Models.CharacterContext context)
        {
            _context = context;
        }

        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Character.Include(c => c.Weapon).FirstOrDefaultAsync(m => m.CharacterId == id);

            if (Character == null)
            {
                return NotFound();
            }
            return Page();
            // mine
        }

    }
}
