using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace Project.Controllers
{
    [RoutePrefix("api/Property")]
    public class PropertyController : ApiController
    {
        [Route("Search")]
        public  IHttpActionResult Search(string cityName, string streetName, string number, Nullable<int> floor, Nullable<double> roomsNum)
        {
            return Ok( BL.PropertyBL.Search(cityName, streetName, number, floor, roomsNum));
        }
        [Route("AdvancedSearch")]
        public IHttpActionResult AdvancedSearch(Nullable<int> propertyID, string owner, string cityName, string streetName, string number, Nullable<int> apartmentNum, Nullable<double> roomsNum, Nullable<double> size, Nullable<int> floor, Nullable<bool> isDivided, Nullable<double> managmentPayment, Nullable<bool> isPaid, Nullable<bool> isExclusivity, string exclusivity, Nullable<bool> isWarranty, Nullable<bool> isRented)
        {
            return Ok( BL.PropertyBL.AdvancedSearch(propertyID, owner, cityName, streetName, number, apartmentNum, roomsNum, size, floor, isDivided, managmentPayment, isPaid, isExclusivity, exclusivity, isWarranty, isRented));
        }
    }
}
