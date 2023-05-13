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
    public class DesignationController : ApiController
    {
        [Route("api/designation/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = DesignationService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/designation/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = DesignationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/designation/add")]
        public HttpResponseMessage Add(DesignationDTO designationDTO)
        {
            try
            {
                var data = DesignationService.Add(designationDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/designation/edit")]
        public HttpResponseMessage Edit(DesignationDTO designationDTO)
        {
            try
            {
                var data = DesignationService.Edit(designationDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/designation/delete")]
        public HttpResponseMessage Delete(DesignationDTO dto)
        {
            try
            {
                var data = DesignationService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
