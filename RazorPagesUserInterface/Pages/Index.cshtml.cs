using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUserInterface.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public record class Person(string Name, int Age);
}
