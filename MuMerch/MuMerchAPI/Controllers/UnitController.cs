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
    public class UnitController : ApiController
    {
        [Route("api/unit/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = UnitService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/unit/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = UnitService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/unit/add")]
        public HttpResponseMessage Add(UnitDTO unitDTO)
        {
            try
            {
                var data = UnitService.Add(unitDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/unit/edit")]
        public HttpResponseMessage Edit(UnitDTO unitDTO)
        {
            try
            {
                var data = UnitService.Edit(unitDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/unit/delete")]
        public HttpResponseMessage Delete(UnitDTO dto)
        {
            try
            {
                var data = UnitService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
