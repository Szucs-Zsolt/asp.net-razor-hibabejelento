using Hibabejelento.Models;
using Hibabejelento.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class ShowAllTicketsModel : PageModel
    {
        public List<TicketModel> TicketList = new List<TicketModel>();
        private readonly TicketsDbContext _context;

        public ShowAllTicketsModel(TicketsDbContext context)
        {
                _context = context;
        }

        public void OnGet()
        {
            TicketList = _context.Tickets.ToList();
        }
    }
}
