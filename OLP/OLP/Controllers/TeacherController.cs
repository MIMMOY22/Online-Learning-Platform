using BLL.DTOs;
using BLL.Services;
using OLP.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Web.Http;

namespace OLP.Controllers
{
    public class TeacherController : ApiController
    {
        [TeacherLogged]
        [HttpGet]
        [Route("api/get/teacher/{id}")]
        public HttpResponseMessage GetTeacher(int id)
        {
            try
            {
                var data = TeacherService.GetTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/teacher/update")]
        public HttpResponseMessage UpdateTeacher(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.UpdateTeacher(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/teacher/delete/{id}")]
        public HttpResponseMessage DeleteTeacher(int id)
        {
            try
            {
                var data = TeacherService.DeleteTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/teacher/create")]
        public HttpResponseMessage CreateTeacher(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.CreateTeacher(t);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [IsTeacher]
        [HttpGet]
        [Route("api/get/course/teacher/{id}")]
        public HttpResponseMessage GetAllCourses(int id)
        {
            try
            {
                var data = CourseService.GetAllCourses(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/{id}")]
        public HttpResponseMessage GetCourse(int id)
        {
            try
            {
                var data = CourseService.GetCourses(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/update")]
        public HttpResponseMessage UpdateCourses(CourseDTO c)
        {
            try
            {
                var data = CourseService.UpdateCourses(c);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/delete/{id}")]
        public HttpResponseMessage DeleteCourse(int id)
        {
            try
            {
                var data = CourseService.DeleteCourse(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/create")]
        public HttpResponseMessage CreateCourse(CourseDTO c)
        {
            try
            {
                var data = CourseService.CreateCourse(c);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/course/{id}")]
        public HttpResponseMessage GetAllContents(int id)
        {
            try
            {
                var data = ContentService.GetAllContents(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/Content/{id}")]
        public HttpResponseMessage GetContent(int id)
        {
            try
            {
                var data = ContentService.GetContent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/update")]
        public HttpResponseMessage UpdateContent( ContentsDTO c)
        {
            try
            {
                var data = ContentService.UpdateContent(c);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/delete/{id}")]
        public HttpResponseMessage DeleteContent(int id)
        {
            try
            {
                var data = ContentService.DeleteContent(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/contents/create")]
        public HttpResponseMessage CreateContent(ContentsDTO c)
        {
            try
            {
                var data = ContentService.CreateContent(c);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content created" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Course id invalid" });
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/assignments/{cid}/{tid}")]
        public HttpResponseMessage GetAllAssignments(int cid, int tid)
        {
            try
            {
                var data = AssignmentService.GetAllAssignments(cid, tid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/{id}")]
        public HttpResponseMessage GetAssignments(int id)
        {
            try
            {
                var data = AssignmentService.GetAssignments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/update")]
        public HttpResponseMessage UpdateAssignments( AssignmentsDTO a)
        {
            try
            {
                var data = AssignmentService.UpdateAssignments( a);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/delete/{id}")]
        public HttpResponseMessage DeleteAssignments(int id)
        {
            try
            {
                var data = AssignmentService.DeleteAssignments(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/Assignment/create")]
        public HttpResponseMessage CreateAssignment(AssignmentsDTO a)
        {
            try
            {
                var data = AssignmentService.CreateAssignments(a);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment created" });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/assignments/submissions/{id}")]
        public HttpResponseMessage GetSubmissionsByAid(int id)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmissionsByAid(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/submissions/{id}")]
        public HttpResponseMessage GetSubmission(int id)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmission(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/submission/delete/{id}")]
        public HttpResponseMessage DeleteSubmission(int id)
        {
            try
            {
                var data = TeacherSubmissionService.DeleteSubmission(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Submission deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/enrollments/{cid}/{tid}")]
        public HttpResponseMessage GetEnrollmentsByCid(int cid, int tid)
        {
            try
            {
                var data = TeacherEnrollmentService.GetEnrollmentByCid(cid, tid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/enrollments/{id}")]
        public HttpResponseMessage GetEnrollment(int id)
        {
            try
            {
                var data = TeacherEnrollmentService.GetEnrollment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/enrollment/delete/{id}")]
        public HttpResponseMessage DeleteEnrollment(int id)
        {
            try
            {
                var data = TeacherEnrollmentService.DeleteEnrollment(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "enrollment deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}