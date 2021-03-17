using Epsic.Authx.Models;
using Microsoft.EntityFrameworkCore;

namespace Epsic.Authx.Data
{
    public class CovidDbContext : DbContext
    {
        public DbSet<TestCovid> TestsCovid { get; set; }

        public CovidDbContext(DbContextOptions<CovidDbContext> options) : base(options)
        {

        }
    }
}
