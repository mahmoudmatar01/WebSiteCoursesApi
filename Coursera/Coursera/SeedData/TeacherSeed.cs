using Coursera.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursera.SeedData
{
    public static class TeacherSeed
    {

        public static void SeedTeacher(this ModelBuilder modelBuilder) {

            modelBuilder.Entity<TeacherET>().HasData(

                new TeacherET
                {
                    TeacherAge=45,
                    TeacherEmail="Mahmoud@yahoo.com",
                    TeacherGender="Male",
                    Teacherid=1,
                    TeacherPassword="2563245584",
                    Teacherphone="01128673348",
                   
                }


                );
        
        }

    }
}
