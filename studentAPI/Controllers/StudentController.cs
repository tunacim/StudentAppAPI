using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using studentAPI.DomainModels;
using studentAPI.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentAPI.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
            var students=_studentRepository.GetStudents();

            var domainModelStudents = new List<Student>();
            foreach (var student in students)
            {
                domainModelStudents.Add(new Student()
                {
                    Id=student.Id,
                    FirstName=student.FirstName,
                    LastName=student.LastName,
                    DateOfBirth=student.DateOfBirth,
                    Email=student.Email,
                    Mobile=student.Mobile,
                    ProfileImageUrl=student.ProfileImageUrl,
                    GenderId=student.GenderId,
                    Adress=new Address()
                    {
                        Id=student.Address.Id,
                        PhysicalAddress=student.Address.PhysicalAddress,
                        PostalAddress=student.Address.PostalAddress
                    },
                    Gender=new Gender()
                    {
                        Id=student.Gender.Id,
                        Description=student.Gender.Description
                    }
                });
            }
            return Ok(domainModelStudents);
        }
    }
}

