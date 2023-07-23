using Hibabejelento.Models;
using Hibabejelento.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class ActiveTicketsModel : PageModel
    {
        public List<TicketModel> TicketList = new List<TicketModel>();

        private readonly TicketsDbContext _context;
        public ActiveTicketsModel(TicketsDbContext context)
        {
                _context = context;
        }
        public void OnGet()
        {
            // Csak akkor mutat egy jegyet, ha az 
            // 1) nincs lezárva és  2) nincs ideiglesen sem kiadva ügyintézõnek
            TicketList = _context.Tickets
                .Where(x => !(x.IsClosed || x.IsInProcess))
                .ToList();
        }
    }
}
