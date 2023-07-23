using Hibabejelento.Models;
using Hibabejelento.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hibabejelento.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public TicketModel Ticket { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly TicketsDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, TicketsDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Console.WriteLine(
                $"Id: {Ticket.Id}\n" +
                $"Name: {Ticket.Name}\tAddr: {Ticket.Address}\n" +
                $"Phone: {Ticket.Phone}\tEmail: {Ticket.Email}\n" +
                $"Short: {Ticket.ShortDescription}\n" +
                $"Long: {Ticket.LongDescription}\n" +
                $"IsClosed: {Ticket.IsClosed}\n" +
                $"IsConsent: {Ticket.IsConsent}\n");

            _context.Tickets.Add(Ticket);
            _context.SaveChanges();
            Console.WriteLine($"Kiírva:  Id: {Ticket.Id}\n");

            return RedirectToPage("GoodBye", new {TicketId = Ticket.Id });
        }
    }
}