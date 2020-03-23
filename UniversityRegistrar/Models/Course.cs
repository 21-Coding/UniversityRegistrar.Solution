using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<Enrollment>();
      // this.Departments = new HashSet<Enrollment>();
    }
    public int CourseId {get;set;}
    public string Name {get;set;}
    public string CourseNumber {get;set;}

    public ICollection<Enrollment> Students {get;set;}
    // public ICollection<Enrollment> Departments {get;}
  }
}