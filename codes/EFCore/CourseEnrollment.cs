namespace EFCore;

public class CourseEnrollment
{
    public int CourseId { get; set; }

    public Course Course { get; set; }

    public int StudentId { get; set; } //by convention studnet class Id would be StudentId else wont work

    public Student Student { get; set; }
}
