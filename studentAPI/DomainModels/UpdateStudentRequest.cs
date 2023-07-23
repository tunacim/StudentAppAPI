﻿using System;
namespace studentAPI.DomainModels
{
	public class UpdateStudentRequest
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public Guid GenderId { get; set; }

        public string? PhysicalAddress { get; set; }

        public string? PostalAddress { get; set; }
    }
}

