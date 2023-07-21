using System;
using studentAPI.DataModels;

namespace studentAPI.Repositories
{
	public interface IStudentRepository
	{
		Task<List<Student> > GetAllStudentsAsync();

		Task<Student> GetStudentAsync(Guid studentId);

    }
}

