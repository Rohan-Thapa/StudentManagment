using AutoMapper;
using StudentManagment.Application.DTOs;
using StudentManagment.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Enrollment, EnrollmentDTO>().ReverseMap();
            CreateMap<Grade, GradeDTO>().ReverseMap();
        }
    }
}
// HandCrafted By Rohan Thapa