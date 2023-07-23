using Hibabejelento.Models;
using Hibabejelento.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class HandleTicketModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int TicketId { get; set; }
        

        [BindProperty]
        public TicketModel Ticket { get; set; }

        private readonly TicketsDbContext _context;
        public HandleTicketModel(TicketsDbContext context)
        {
                _context = context;
        }
        public void OnGet()
        {
            // betöltjük a hibajegyet 
            Ticket = _context.Tickets.Find(TicketId);
            // és elkezdünk rajta dolgozni
            Ticket.IsInProcess = true;
            _context.SaveChanges();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Ticket.IsInProcess = false;
            Ticket.IsClosed = true;
            _context.Tickets.Update(Ticket);
            _context.SaveChanges();
            return RedirectToPage("/ShowActiveTickets");
        }
    }
}
