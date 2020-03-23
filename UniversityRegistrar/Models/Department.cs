using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    // public Department()
    // {
    //   this.Students = new HashSet<Enrollment>();
    //   this.Courses = new HashSet<Enrollment>();
    // }
    public int DepartmentId {get;set;}
    public string DepartmentName {get;set;}

    // public ICollection<Enrollment> Students { get; set; }
    // public ICollection<Enrollment> Courses { get; set; }
  }
}