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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.CharacterContext _context;

        public IndexModel(FinalProject.Models.CharacterContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }

        public async Task OnGetAsync()
        {
            Character = await _context.Character.ToListAsync();
        }
    }
}
