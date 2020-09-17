using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace Project.Controllers
{
    [RoutePrefix("api/PropertyOwner")]
    public class PropertyOwnerController : ApiController
    {
        [Route("AddPropertyOwner")]
        public  IHttpActionResult AddPropertyOwner([FromBody]PropertyOwnerDTO po)
        {
            bool b = BL.PropertyOwnerBL.AddPropertyOwner(po);
            if (b)
                return Ok();
            return BadRequest();

        }
        [Route("UpdatePropertyOwner")]
        public IHttpActionResult UpdatePropertyOwner(PropertyOwnerDTO po)
        {
            bool b = BL.PropertyOwnerBL.UpdatePropertyOwner(po);
            if (b)
                return Ok();
            return BadRequest();
        }
        [Route("Search")]
        public IHttpActionResult Search(string OwnerFirstName,string OwnerLastName,string Phone,string Email)
        {
            return Ok(BL.PropertyOwnerBL.Search(OwnerFirstName, OwnerLastName, Phone, Email));
        }
    }
}
