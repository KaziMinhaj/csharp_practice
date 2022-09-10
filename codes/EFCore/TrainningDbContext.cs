namespace EFCore;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class TrainningDbContext : DbContext
{
    private readonly string _connectionString;

    private readonly string _assemblyName;

    public TrainningDbContext()
    {
        _connectionString = @"Server=LAPTOP-88GU3220\SQLEXPRESS08;Database=CsharpB11;Trusted_Connection=True";
        _assemblyName = Assembly.GetExecutingAssembly().GetName().Name; 
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*Changing the name of the table. as we did not add the course enrollment table in the trainning db context class so if we want to change the table name then we need to follow this procedure 
         */
        modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");

        /*
         * For creating a composite foreign key follow this HasKey method 
         */

        modelBuilder.Entity<CourseEnrollment>().HasKey(cs => new { cs.CourseId, cs.StudentId });

        //Fluent api

        /*
         * "Course" Has Many "Topics" , "Topics" has one "course"
         */
        modelBuilder.Entity<Course>()
            .HasMany(p => p.Topics)
            .WithOne(i => i.Course);

        /*
         * "CourseEnrollment" has one "Course"
         * "Course" has many "CourseRegistrations"
         * "CourseRegistrations" has foreign key course Id
         */
        modelBuilder.Entity<CourseEnrollment>()
            .HasOne(i => i.Course)
            .WithMany(p => p.CourseRegistrations)
            .HasForeignKey(i => i.CourseId);

        /*
         * "CourseEnrollment" has one "Course"
         * "Course" has many "CourseRegistrations"
         * "CourseRegistrations" has foreign key course Id

         */
        modelBuilder.Entity<CourseEnrollment>()
            .HasOne(i => i.Student)
            .WithMany(p => p.StudentEnrollments)
            .HasForeignKey(i => i.StudentId);

        /*
         * At the end call base.OnModelCreating
         * it means we are adding these two line 34/40 with the base class implementation 
         */
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Student> Students { get; set; }

    public DbSet<Course> Courses { get; set; }
}
