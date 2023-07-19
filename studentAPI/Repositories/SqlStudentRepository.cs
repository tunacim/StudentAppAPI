using System;
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
        public List<Student> GetStudents()
        {
            return _studentAdminContext.Student.ToList();
        }
    }
}

