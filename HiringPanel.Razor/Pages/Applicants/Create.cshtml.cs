using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HiringPanel.Razor.Models;
using HiringPanel.Razor.Data;

namespace HiringPanel.Razor.Pages.Applicants
{
    public class CreateModel : PageModel
    {
        private readonly HiringPanelDbContext _db;

        public CreateModel(HiringPanelDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Applicant Applicant { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _db.Applicants.Add(Applicant);
            await _db.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
