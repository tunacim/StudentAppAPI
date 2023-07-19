using System;
using AutoMapper;
using studentAPI.DomainModels;
using DataModels=studentAPI.DataModels;

namespace studentAPI.Profiles
{
	public class AutoMapperProfiles:Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<DataModels.Student, Student>().ReverseMap();
			CreateMap<DataModels.Gender, Gender>().ReverseMap();
			CreateMap<DataModels.Address, Address>().ReverseMap();
        }
	}
}

