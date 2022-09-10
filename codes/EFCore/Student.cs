namespace EFCore;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double Cgpa { get; set; }

    public DateTime DateOfBirth { get; set; }

    public bool IsDeleted { get; set; }

    public Guid StudentId { get; set; }

    public List<CourseEnrollment> StudentEnrollments { get; set; }
}
