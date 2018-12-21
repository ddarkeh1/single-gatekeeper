using Microsoft.EntityFrameworkCore;
using VbotApp.API.Models;

namespace VbotApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {}

        public DbSet<Value> Values {get; set;}

    }
}