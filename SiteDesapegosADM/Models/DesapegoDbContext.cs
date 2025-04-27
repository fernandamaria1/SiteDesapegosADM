using Microsoft.EntityFrameworkCore;

namespace SiteDesapegosADM.Models
{
    public class DesapegoDbContext : DbContext
    {
        public DesapegoDbContext(DbContextOptions<DesapegoDbContext> options) : base(options) { }


    }
    
    }

