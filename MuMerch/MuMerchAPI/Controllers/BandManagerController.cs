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
    public class BandManagerController : ApiController
    {
        [HttpGet]
        [Route("api/bandManager/all")]
        public HttpResponseMessage AllBandManagers()
        {
            try
            {
                var data = BandManagerService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/bandManager/{id}")]
        public HttpResponseMessage BandManager(int id)
        {
            try
            {
                var data = BandManagerService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/bandManager/add")]
        public HttpResponseMessage Add(BandManagerDTO bandManagerDTO)
        {
            try
            {
                var data = BandManagerService.Add(bandManagerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/bandManager/edit")]
        public HttpResponseMessage Edit(BandManagerDTO bandManagerDTO)
        {
            try
            {
                var data = BandManagerService.Edit(bandManagerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/bandManager/delete")]
        public HttpResponseMessage Delete(BandManagerDTO dto)
        {
            try
            {
                var data = BandManagerService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
