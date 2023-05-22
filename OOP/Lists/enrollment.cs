using System;
using System.Collections.Generic;
using System.Linq;

class Enrollment
{
    public Course CourseEnrolled { get; set; }       
    public DateTime EnrolledDate { get; set; }
    public string Status { get; set; }//Enrolled, Completed, Failed, Dropped
    
    public Enrollment(Course c): this(c,DateTime.Today)
    {            
    }

    public Enrollment(Course c,  DateTime date)
    {
        CourseEnrolled = c;            
        Status = "Enrolled";
        EnrolledDate = date; 
        Console.WriteLine("Enrollment created {0} {1} {2}", c.Id, Status, EnrolledDate);           
    }

}
