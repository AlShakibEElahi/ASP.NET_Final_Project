using BLL.DTOs;
using BLL.Services;
using MuMerchAPI.Auth;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MuMerchAPI.Controllers
{
    [EnableCors("*","*","*")]

    public class GradeController : ApiController
    {
        [HttpGet]
        [Route("api/grade/all")]
        public HttpResponseMessage AllGrades()
        {
            try
            {
                var data = GradeService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/grade/{id}")]
        public HttpResponseMessage Grade(int id)
        {
            try
            {
                var data = GradeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/grade/add")]
        public HttpResponseMessage Add(GradeDTO gradeDTO)
        {
            try
            {
                var data = GradeService.Add(gradeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse (HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/grade/edit")]
        public HttpResponseMessage Edit(GradeDTO gradeDTO)
        {
            try
            {
                var data = GradeService.Edit(gradeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/grade/delete")]
        public HttpResponseMessage Delete(GradeDTO dto)
        {
            try
            {
                var data = GradeService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data) ;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
