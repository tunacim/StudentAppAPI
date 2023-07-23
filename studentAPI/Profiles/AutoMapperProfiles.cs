using System;
using AutoMapper;
using studentAPI.DomainModels;
using studentAPI.Profiles.AfterMaps;
using DataModels=studentAPI.DataModels;

namespace studentAPI.Profiles
{
	public class AutoMapperProfiles:Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<DataModels.Student, Student>().ReverseMap();
			CreateMap<DataModels.Gender, Gender>().ReverseMap();
			CreateMap<DataModels.Adress, Adress>().ReverseMap();
			CreateMap<UpdateStudentRequest, DataModels.Student>().AfterMap<UpdateStudentRequestAfterMap>();
			
        }
	}
}

