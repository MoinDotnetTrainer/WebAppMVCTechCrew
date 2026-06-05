using Microsoft.EntityFrameworkCore;

namespace WebAppMVCTechCrew.Models
{
    public class AppDb : DbContext
    {

        // connection string
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
        }
        public DbSet<UsersModel> Users { get; set; }

        public DbSet<BooksModel> Books { get; set; }

        public DbSet<ProductsModel> Products { get; set; }

        public DbSet<Aadhar> aadhar { get; set; }
        public DbSet<Pan> pan { get; set; }

        public DbSet<Dept> dept { get; set; }
        public DbSet<Emp> emp { get; set; }
    }
}
