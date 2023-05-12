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
    public class SizeController : ApiController
    {
        [Route("api/size/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = SizeService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/size/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = SizeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/size/add")]
        public HttpResponseMessage Add(SizeDTO sizeDTO)
        {
            try
            {
                var data = SizeService.Add(sizeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/size/edit")]
        public HttpResponseMessage Edit(SizeDTO sizeDTO)
        {
            try
            {
                var data = SizeService.Edit(sizeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/size/delete")]
        public HttpResponseMessage Delete(SizeDTO dto)
        {
            try
            {
                var data = SizeService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
