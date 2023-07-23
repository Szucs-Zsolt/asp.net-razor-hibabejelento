using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class GoodByeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int TicketId { get; set; }
        public void OnGet()
        {
            Console.WriteLine(TicketId);
        }
    }
}
