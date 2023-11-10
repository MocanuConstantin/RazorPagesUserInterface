using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUserInterface.Pages
{
    public class Forms1Index : PageModel
    {
      
        IEnumerable<Persoana> people = new List<Persoana>
       {
            new ("Alex", 61),
            new ("Petrea", 18),
            new ("Kolea", 35),
            new ("Vadim", 40)
        };
        public IEnumerable<Persoana> PersoaneAfisate { get; private set; } = new List<Persoana>();
      
        public void OnGet()
        {
            PersoaneAfisate = people;
        }
       
        public void OnPostGreaterThan(int age)
        {
            PersoaneAfisate = people.Where(p => p.Age > age);
        }
       
        public void OnPostLessThan(int age)
        {
            PersoaneAfisate = people.Where(p => p.Age < age);
        }
    }
    public record class Persoana(string Name, int Age);
}