﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentAPI.DomainModels;
using studentAPI.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentAPI.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;


        public GendersController(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGendersAsync()
        {
            var genderList = await _studentRepository.GetGendersAsync();
            if(genderList==null|| !genderList.Any())
            {
                return NotFound();
            }


            return Ok(_mapper.Map<List<Gender>>(genderList));
        }
    }
}

