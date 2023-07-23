using Hibabejelento.Models;
using Hibabejelento.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class ReopenTicketModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int TicketId { get; set; }
        public TicketModel Ticket { get; set; }
        [BindProperty]
        public bool IsReopened { get; set; }

        private readonly TicketsDbContext _context;
        public ReopenTicketModel(TicketsDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Ticket = _context.Tickets.Find(TicketId);
            IsReopened = false;
        }

        public IActionResult OnPost()
        {

            if (IsReopened)
            {
                Ticket = _context.Tickets.Find(TicketId);
                if (Ticket != null)
                {
                    Ticket.IsClosed = false;
                    Ticket.IsInProcess = false;
                    _context.SaveChanges();
                }
            }
            return RedirectToPage("/ShowAllTickets");
        }
    }
}
