
using Login.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using NoteEditor.Models;

namespace Login.Context
{
    public class MyContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-OPEVRDN;Database=NotesManagment;Trusted_Connection=True;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Note> Notes { get; set; }  
        public virtual DbSet<Category> Categories { get; set; }  

         
    }
}
