using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HiringPanel.Razor.Data;
using HiringPanel.Razor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringPanel.Razor.Pages.Applicants
{
    public class IndexModel : PageModel
    {
        private readonly HiringPanelDbContext _db;

        public IndexModel(HiringPanelDbContext db)
        {
            _db = db;
        }

        public List<Applicant> Applicants { get; set; }

        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.ToListAsync();
        }
    }
}
