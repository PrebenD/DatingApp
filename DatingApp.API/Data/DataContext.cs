using DatingApp.API.Controllers.Models;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Values> Values { get; set; }
        public DbSet<User>  Users   { get; set; }
    }
}