using System;
using Microsoft.EntityFrameworkCore;

namespace studentAPI.DataModels
{
	public class StudentAdminContext:DbContext
	{
		public StudentAdminContext(DbContextOptions<StudentAdminContext> options):base(options)
		{
			
		}
		public DbSet<Student> Student { get; set; }
		public DbSet<Gender> Gender { get; set; }
		public DbSet<Adress> Address { get; set; }

        
    }
}

