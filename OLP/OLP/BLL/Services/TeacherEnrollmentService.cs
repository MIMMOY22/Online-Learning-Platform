using AutoMapper;
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
    public class TeacherEnrollmentService
    {
        public static EnrollmentsDTO GetEnrollment(int id)
        {
            var data = DAF.AccessEnrollments().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Enrollments, EnrollmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<EnrollmentsDTO>(data);
            return cnvt;
        }
        public static List<EnrollmentsDTO> GetEnrollmentByCid(int cid, int tid)
        {
            var data = DAF.AccessEnrollments().viewAll();
            var res = (from e in data where e.cid == cid && e.tid == tid select e).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Enrollments, EnrollmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<EnrollmentsDTO>>(data);
            return cnvt;
        }
        public static bool DeleteEnrollment(int id)
        {
            var data = DAF.AccessEnrollments().delete(id);
            return data;
        }
    }
}