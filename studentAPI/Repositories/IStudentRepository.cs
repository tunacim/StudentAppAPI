using System;
using studentAPI.DataModels;

namespace studentAPI.Repositories
{
	public interface IStudentRepository
	{
		List<Student> GetStudents();
	
	}
}

