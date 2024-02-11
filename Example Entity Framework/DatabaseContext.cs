using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MATT
{
    public class DatabaseContext : DbContext
    {
        private const string ConnectionString = "Data Source=MyDataBase.db";
        private static DatabaseContext _databaseContext = null;

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(ConnectionString);
        
        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        
        [StringLength(150)]
        public string Title { get; set; }
        
        public int Price { get; set; }
        
        [StringLength(150)]
        public string Author { get; set; }
        
        public string Description { get; set; }