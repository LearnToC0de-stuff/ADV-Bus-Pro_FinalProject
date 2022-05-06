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

        public async Task OnGetAsync()
        {
            Character = await _context.Character.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
