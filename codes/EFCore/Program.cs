using EFCore;
using Microsoft.EntityFrameworkCore;

TrainningDbContext trainningDbContext = new TrainningDbContext();

//Student student = new Student();
//student.Name = "Haider";
//student.Cgpa = 2.2;
//student.DateOfBirth = new DateTime(1997,10,21);
//student.IsDeleted = false;
//student.StudentId = Guid.NewGuid();

// Add
//trainningDbContext.Students.Add(student);

// Raed
//var oldStudent = trainningDbContext.Students.Where(s => s.Name == "kazi").FirstOrDefault();

// Update
//oldStudent.Cgpa = 4.0;

// Read 
//var oldStudent2 = trainningDbContext.Students.Where(s => s.Id == 1).FirstOrDefault();

// Delete
//trainningDbContext.Students.Remove(oldStudent2);

/*
var course = new Course();
course.Title = "C# Course";
course.Fees = 10;
course.Topics = new List<Topic>();

course.Topics.Add(new Topic() { Description = "Getting started" });
course.Topics.Add(new Topic() { Description = "Basic Syntax" });
 
trainningDbContext.Courses.Add(course);
*/

/*
var oldCourse = trainningDbContext.Courses.Where(x => x.Id == 1).Include(y => y.Topics).FirstOrDefault();
oldCourse.Title = "JS Course";

var topicToDelete = oldCourse.Topics.Where(x => x.Description == "Basic Syntax").FirstOrDefault();
oldCourse.Topics.Remove(topicToDelete);

oldCourse.Topics[0].Description = "Introduction";
oldCourse.Topics.Add(new Topic() { Description = "Loops" });
*/

Course course = new Course();
course.Title = "Python";
course.Fees = "8000";
course.CourseRegistrations = new List<CourseEnrollment>();

Student student = new Student();
student.Name = "Arif";
student.Cgpa = 3.75;
student.DateOfBirth = DateTime.Now;
student.IsDeleted = false;
student.StudentId = Guid.NewGuid();

CourseEnrollment enrollment = new CourseEnrollment();
enrollment.Student = student;

course.CourseRegistrations.Add(enrollment);

trainningDbContext.Courses.Add(course);

// always save you changes.
trainningDbContext.SaveChanges();
