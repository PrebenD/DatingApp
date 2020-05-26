using DatinApp.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace DatinApp.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Values> Values { get; set; }
    }
}