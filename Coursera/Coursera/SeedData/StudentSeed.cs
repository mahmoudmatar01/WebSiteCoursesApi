using Coursera.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursera.SeedData
{
    public static class StudentSeed
    {

        public static void SeedStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentsET>().HasData(

                new StudentsET
                {
                    Studentid= 1,
                    Gender="Male",
                    Password="01227007298",
                    StudentAge=21,
                    StudentEmail="mahmoudmatar49@gmail.com",
                    StudentFirstname="mahmoud",
                    StudentLastname="Matar",
                    StudentPhone="01128673348",
                    
                }
                );

            modelBuilder.Entity<StudentsET>().HasData(

               new StudentsET
               {
                   Studentid = 2,
                   Gender = "Male",
                   Password = "01111614941",
                   StudentAge = 20,
                   StudentEmail = "Ziad12@yahoo.com",
                   StudentFirstname = "Ziad",
                   StudentLastname = "ElSadany",
                   StudentPhone = "01003246344",

               }

               );
        }

    }
}
