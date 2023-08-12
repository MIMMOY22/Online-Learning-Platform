using BLL.DTOs;
using BLL.Services;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using System;

 

namespace OLP.Controllers

{

    public class AdminController : ApiController

    {


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

        [Route("api/get/student/{id}")]

        public HttpResponseMessage GetStudent(int id)

        {

            try

            {

                var data = StudentServices.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }



        [HttpGet]

        [Route("api/get/teacher/update")]

        public HttpResponseMessage UpdateTeacher( TeacherDTO t)

        {

            try

            {

                var data = TeacherService.UpdateTeacher( t);

                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }

        [HttpGet]

        [Route("api/get/student/update")]

        public HttpResponseMessage UpdateStudent( StudentDTO t)

        {

            try

            {

                var data = StudentServices.Update(t);

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

        [Route("api/get/student/delete/{id}")]

        public HttpResponseMessage DeleteStudent(int id)

        {

            try

            {

                var data = StudentServices.Delete(id);

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

        [HttpGet]

        [Route("api/get/student/create")]

        public HttpResponseMessage CreateStudent(StudentDTO t)

        {

            try

            {

                var data = StudentServices.Create(t);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }



        [HttpGet]

        [Route("api/get/course/{id}")]

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

        [Route("api/get/content/{id}")]

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



    }

}
