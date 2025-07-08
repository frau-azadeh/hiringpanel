using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HiringPanel.Razor.Data;
using HiringPanel.Razor.Models;
using System.Threading.Tasks;

namespace HiringPanel.Razor.Pages.Applicants
{
    public class DeleteModel : PageModel
    {
        private readonly HiringPanelDbContext _db;

        public DeleteModel(HiringPanelDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Applicant Applicant { get; set; } = new Applicant();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Applicant = await _db.Applicants.FindAsync(id);

            if (Applicant == null) return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            var applicant = await _db.Applicants.FindAsync(id);

            if (applicant == null) return NotFound();

            _db.Applicants.Remove(applicant);
            await _db.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
