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
    public class ProductColorMapController : ApiController
    {
        [HttpGet]
        [Route("api/productcolormap/all")]
        public HttpResponseMessage AllProductColorMaps()
        {
            try
            {
                var data = ProductColorMapService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/productcolormap/{id}")]
        public HttpResponseMessage ProductColorMap(int id)
        {
            try
            {
                var data = ProductColorMapService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productcolormap/add")]
        public HttpResponseMessage Add(ProductColorMapDTO productcolormapDTO)
        {
            try
            {
                var data = ProductColorMapService.Add(productcolormapDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productcolormap/edit")]
        public HttpResponseMessage Edit(ProductColorMapDTO productcolormapDTO)
        {
            try
            {
                var data = ProductColorMapService.Edit(productcolormapDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productcolormap/delete")]
        public HttpResponseMessage Delete(ProductColorMapDTO dto)
        {
            try
            {
                var data = ProductColorMapService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
