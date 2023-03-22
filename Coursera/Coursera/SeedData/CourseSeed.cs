using Coursera.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursera.SeedData
{
    public static class CourseSeed
    {

        public static void  SeedCourse(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseET>().HasData(

                new CourseET
                {
                    CourseID = 1,
                    CourseCapacity = 10,
                    CourseDescription = "this course will Teach you every Thing in Datastructure",
                    CourseName = "DataStructure",
                    CourseTeacher = "MahmoudMatar",
                    
                }

                ); 
        }

    }
}
