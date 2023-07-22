using System;
namespace studentAPI.DomainModels
{
	public class Adress
	{
        public Guid Id { get; set; }

        public string? PhysicalAddress { get; set; }

        public string? PostalAddress { get; set; }

        public Guid StudentId { get; set; }
    }
}

