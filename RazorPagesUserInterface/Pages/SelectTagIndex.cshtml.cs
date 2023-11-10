using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesUserInterface.Pages
{
    public class SelectTagIndexModel : PageModel
    {
        static List<Company> companies { get; } = new()
        {
            new Company(1,"Apple"),
            new Company(2,"Samsung"),
            new Company(3,"Microsoft")
        };
        public SelectList Companies { get; } = new SelectList(companies, "Id", "Name");

        [BindProperty]
        public Produs Produs { get; set; } = new("", 1000, 0);
        public string message { get; set; } = "Adaugare produs";

        public void OnPost()
        {
            Company? company = companies.FirstOrDefault(c => c.Id == Produs.CompanyId);
            message = $"Добавлен новый товар: {Produs.Name} ({company?.Name}) cu pretul {Produs.Price}";
        }
    }
    public record class Produs(string Name, int Price, int CompanyId);
    public record class Company(int Id, string Name);
}
