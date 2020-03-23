namespace UniversityRegistrar.Models
{
  public class Enrollment
  {
    public int EnrollmentId {get;set;}
    public int ItemId {get;set;}
    public int CategoryId {get;set;}
    public Student Student {get;set;}
    public Course Course {get;set;}
  }
}