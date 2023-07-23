using System;
using AutoMapper;
using studentAPI.DomainModels;
using DataModels = studentAPI.DataModels;

namespace studentAPI.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, DataModels.Student>
    {
        public void Process(UpdateStudentRequest source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Adress = new DataModels.Adress()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress=source.PostalAddress

            };
        }
    }
}

