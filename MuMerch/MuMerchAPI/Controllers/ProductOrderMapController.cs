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
        public class ProductOrderMapController : ApiController
        {
            [HttpGet]
            [Route("api/productordermap/all")]
            public HttpResponseMessage AllProductOrderMaps()
            {
                try
                {
                    var data = ProductOrderMapService.GetAll();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
            [HttpGet]
            [Route("api/productordermap/{id}")]
            public HttpResponseMessage ProductOrderMap(int id)
            {
                try
                {
                    var data = ProductOrderMapService.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
                }
            }
            [HttpPost]
            [Route("api/productordermap/add")]
            public HttpResponseMessage Add(ProductOrderMapDTO productordermapDTO)
            {
                try
                {
                    var data = ProductOrderMapService.Add(productordermapDTO);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
                }
            }
            [HttpPost]
            [Route("api/productordermap/edit")]
            public HttpResponseMessage Edit(ProductOrderMapDTO productordermapDTO)
            {
                try
                {
                    var data = ProductOrderMapService.Edit(productordermapDTO);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
                }
            }
            [HttpPost]
            [Route("api/productordermap/delete")]
            public HttpResponseMessage Delete(ProductOrderMapDTO dto)
            {
                try
                {
                    var data = ProductOrderMapService.Delete(dto);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
                }
            }
        }
    }

