using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MuMerchAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/department/all")]
        public HttpResponseMessage AllDepartments()
        {
            try
            {
                var data = DepartmentService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/department/{id}")]
        public HttpResponseMessage Department(int id)
        {
            try
            {
                var data = DepartmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/department/add")]
        public HttpResponseMessage Add(DepartmentDTO departmentDTO)
        {
            try
            {
                var data = DepartmentService.Add(departmentDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/department/edit")]
        public HttpResponseMessage Edit(DepartmentDTO departmentDTO)
        {
            try
            {
                var data = DepartmentService.Edit(departmentDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/department/delete")]
        public HttpResponseMessage Delete(DepartmentDTO dto)
        {
            try
            {
                var data = DepartmentService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
