using AutoMapper;
using AutoMapper.Configuration.Conventions;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        public static List<CourseDTO> GetAllCourses(int id)
        {
            var data = DAF.AccessCourses().viewAll();
            var courses = (from i in data where i.tid == id select i).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Course, CourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<CourseDTO>>(data);
            return cnvt;
        }
        public static CourseDTO GetCourses(int id)
        {
            var data = DAF.AccessCourses().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Course, CourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<CourseDTO>(data);
            return cnvt;
        }
        public static bool UpdateCourses( CourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CourseDTO, Course>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Course>(c);
            var data = DAF.AccessCourses().update(cnvt);
            return data;
        }
        public static bool DeleteCourse(int id)
        {
            var data = DAF.AccessCourses().delete(id);
            return data;
        }
        public static bool CreateCourse(CourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CourseDTO, Course>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Course>(c);
            var data = DAF.AccessCourses().create(cnvt);
            return data;

        }

    }
}