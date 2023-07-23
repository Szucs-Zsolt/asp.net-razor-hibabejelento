using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Hibabejelento.Models.DataLayer
{
    public class TicketsDbContext : DbContext
    {
        // Tábla
        public DbSet<TicketModel> Tickets { get; set; }

        public TicketsDbContext(DbContextOptions<TicketsDbContext> option)
            : base(option)
        {


        }
    }
}
