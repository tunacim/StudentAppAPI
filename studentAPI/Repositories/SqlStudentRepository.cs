﻿using System;
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

        
    }
}

