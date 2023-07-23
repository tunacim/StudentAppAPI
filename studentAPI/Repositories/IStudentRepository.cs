using System;
using studentAPI.DataModels;

namespace studentAPI.Repositories
{
	public interface IStudentRepository
	{
		Task<List<Student> > GetAllStudentsAsync();

		Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student> UpdateStudent(Guid studentId,Student student);


    }
}

