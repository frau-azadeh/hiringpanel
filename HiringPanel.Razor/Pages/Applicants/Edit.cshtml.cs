using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HiringPanel.Razor.Data;
using HiringPanel.Razor.Models;
using System.Threading.Tasks;

namespace HiringPanel.Razor.Pages.Applicants
{
    public class EditModel : PageModel
    {
        private readonly HiringPanelDbContext _db;

        public EditModel(HiringPanelDbContext db)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var applicantInDb = await _db.Applicants.FindAsync(Applicant.Id);

            if (applicantInDb == null)
                return NotFound();

            // به‌روزرسانی فیلدها
            applicantInDb.Name = Applicant.Name;
            applicantInDb.Email = Applicant.Email;
            applicantInDb.ResumeUrl = Applicant.ResumeUrl;

            await _db.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
