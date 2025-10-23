using AutoMapper;
using DEMO.BLL.DTOs.EmployeeDtos;
using DEMO.DAL.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.BLL.MappingProfile
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<Employee, EmployeeDto>();
            //CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest=>dest.EmpGender , Options => Options.MapFrom(src=>src.Gender))
                .ForMember(dest=>dest.EmpType , Options => Options.MapFrom(src=>src.EmployeeType))
                .ReverseMap();
      
            
            CreateMap<Employee, EmployeeDetailsDto>()
                .ForMember(dest => dest.Gender, Options => Options.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmployeeType, Options => Options.MapFrom(src => src.EmployeeType))
                .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => DateOnly.FromDateTime(src.HiringDate)))
                .ReverseMap();
    
            
            CreateMap<CreatedEmployeeDto, Employee>()
                    .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(new TimeOnly())))
                    .ReverseMap();



            CreateMap<UpdatedEmployeeDto, Employee>()
                          .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(new TimeOnly())))
                          .ReverseMap();
            //CreateMap<Employee, Employee>().ReverseMap();


        }
    }
}
