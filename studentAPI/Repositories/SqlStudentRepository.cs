using System;
using Microsoft.EntityFrameworkCore;
using studentAPI.DataModels;

namespace studentAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _studentAdminContext;
        public SqlStudentRepository(StudentAdminContext context)
        {
            _studentAdminContext = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await  _studentAdminContext.Student.Include(nameof(Gender)).Include(nameof(Adress)).ToListAsync();
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await _studentAdminContext.Student.Include(nameof(Gender)).Include(nameof(Adress)).FirstOrDefaultAsync(x => x.Id==studentId);
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await _studentAdminContext.Gender.ToListAsync();
        }

        public async Task<bool> Exists(Guid studentId)
        {
           return await _studentAdminContext.Student.AnyAsync(x => x.Id == studentId);
        }

        public async Task<Student> UpdateStudent(Guid studentId, Student request)
        {
            var existingStudent = await GetStudentAsync(studentId);
            if (existingStudent != null)
            {
                existingStudent.FirstName = request.FirstName;
                existingStudent.LastName = request.LastName;
                existingStudent.DateOfBirth= request.DateOfBirth;
                existingStudent.Email = request.Email;
                existingStudent.Mobile = request.Mobile;
                existingStudent.GenderId = request.GenderId;
                existingStudent.Adress.PhysicalAddress = request.Adress.PhysicalAddress;
                existingStudent.Adress.PostalAddress = request.Adress.PostalAddress;

                await _studentAdminContext.SaveChangesAsync();
                return existingStudent;
            }
            return null;
        }

        public async Task<Student> DeleteStudent(Guid studentId)
        {
            var existingStudent = await GetStudentAsync(studentId);
            if (existingStudent != null)
            {
                _studentAdminContext.Student.Remove(existingStudent);

                await _studentAdminContext.SaveChangesAsync();
                return existingStudent;
            }
            return null;
        }

        public async Task<Student> AddStudent(Student request)
        {
           var student=await _studentAdminContext.AddAsync(request);
            await _studentAdminContext.SaveChangesAsync();
            return student.Entity;
        }
    }
}

