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
    public class DivisionController : ApiController
    {
        [Route("api/division/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = DivisionService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/division/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = DivisionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/division/add")]
        public HttpResponseMessage Add(DivisionDTO divisionDTO)
        {
            try
            {
                var data = DivisionService.Add(divisionDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/division/edit")]
        public HttpResponseMessage Edit(DivisionDTO divisionDTO)
        {
            try
            {
                var data = DivisionService.Edit(divisionDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/division/delete")]
        public HttpResponseMessage Delete(DivisionDTO dto)
        {
            try
            {
                var data = DivisionService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
