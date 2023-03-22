using Coursera.Models;
using Coursera.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Coursera.DBContext
{
    public class DataContext:DbContext
    {


        //Public Constructor 
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
                
            //implementation
        }



        //convert EntitySet To Tables into DataBase
        public DbSet<StudentsET> StudentsET { get; set;}
        public DbSet<CourseET> CourseET { get; set;}
        public DbSet<TeacherET> TeacherET { get; set;}


        //override Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedStudent();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();
            var constring = config.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(constring);
        }


    }
}
