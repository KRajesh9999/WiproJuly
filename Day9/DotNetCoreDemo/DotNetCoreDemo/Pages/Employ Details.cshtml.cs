using DotNetCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCoreDemo.Pages
{
    public class Employ_DetailsModel : PageModel
    {
        public List<Employ>? Employ { get; set; }
        public void OnGet()
        {
            Employ = new List<Employ>
            {

                 new Employ{Empno=1,Name="Rajesh",Basic=83234},
                 new Employ{Empno=2,Name="Ramesh",Basic=89923},
                 new Employ{Empno=3,Name="Rakesh",Basic=92222},
            };
        }
    }
}
