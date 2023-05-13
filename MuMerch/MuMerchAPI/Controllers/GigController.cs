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
    public class GigController : ApiController
    {
        [Route("api/gig/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = GigService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/gig/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = GigService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gig/add")]
        public HttpResponseMessage Add(GigDTO gigDTO)
        {
            try
            {
                var data = GigService.Add(gigDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gig/edit")]
        public HttpResponseMessage Edit(GigDTO gigDTO)
        {
            try
            {
                var data = GigService.Edit(gigDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gig/delete")]
        public HttpResponseMessage Delete(GigDTO dto)
        {
            try
            {
                var data = GigService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
