using AutoMapper;
using EmployeeWebApiAspNetCore.Dtos;
using EmployeeWebApiAspNetCore.Entities;

namespace EmployeeWebApiAspNetCore.MappingProfiles
{
    public class EmployeeMappings : Profile
    {
        public EmployeeMappings()
        {
            CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();
        }
    }
}
