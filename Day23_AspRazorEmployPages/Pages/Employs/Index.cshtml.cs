using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployCrud_AspRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployCrud_AspRazor.Pages.Employs
{
    public class IndexModel : PageModel
    {
        private readonly EFCoreDbContext _context;

        public IndexModel(EFCoreDbContext context)
        {
            _context = context;
        }

        public IList<Employ> Employ { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Employ = await _context.Employees.ToListAsync();
        }
    }
}
