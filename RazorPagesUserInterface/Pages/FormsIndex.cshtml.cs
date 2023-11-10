using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUserInterface.Pages
{
    public class FormsIndexModel : PageModel
    {
        [BindProperty]
        public Product produs { get; set; } = new("", 0, "");
        public string Message { get; private set; } = "Adaugare produse";
        public void OnPost()
        {
            Message = $"Adaugam produs mou: {produs.Name} ({produs.Company}) cu pretul {produs.Price}";
        }
    }
    public record class Product(string Name,double Price, string Company);
}
