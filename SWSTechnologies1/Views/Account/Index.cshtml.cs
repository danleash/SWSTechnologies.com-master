using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWSTechnologies1.Models;

namespace SWSTechnologies1.Views.Account
{
    public class IndexModel : PageModel
    {
        private readonly SWSTechnologies1.Models.SWSTechDBContext _context;

        public IndexModel(SWSTechnologies1.Models.SWSTechDBContext context)
        {
            _context = context;
        }

        public IList<RegisterViewModel> RegisterViewModel { get;set; }

        public async Task OnGetAsync()
        {
            RegisterViewModel = await _context.RegisterViewModel.ToListAsync();
        }
    }
}
