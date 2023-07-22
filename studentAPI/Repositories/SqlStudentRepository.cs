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
            return await  _studentAdminContext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await _studentAdminContext.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x => x.Id==studentId);
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await _studentAdminContext.Gender.ToListAsync();
        }
    }
}

