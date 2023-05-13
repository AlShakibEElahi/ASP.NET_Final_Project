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
    public class GigManagerController : ApiController
    {
        [HttpGet]
        [Route("api/gigManager/all")]
        public HttpResponseMessage AllGigManagers()
        {
            try
            {
                var data = GigManagerService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/gigManager/{id}")]
        public HttpResponseMessage GigManager(int id)
        {
            try
            {
                var data = GigManagerService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gigManager/add")]
        public HttpResponseMessage Add(GigManagerDTO gigManagerDTO)
        {
            try
            {
                var data = GigManagerService.Add(gigManagerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gigManager/edit")]
        public HttpResponseMessage Edit(GigManagerDTO gigManagerDTO)
        {
            try
            {
                var data = GigManagerService.Edit(gigManagerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/gigManager/delete")]
        public HttpResponseMessage Delete(GigManagerDTO dto)
        {
            try
            {
                var data = GigManagerService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}