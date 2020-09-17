using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace Project.Controllers
{
    [RoutePrefix("api/Renter")]
    public class RenetalController : ApiController
    {
        [Route("Search")]
        public IHttpActionResult Search(Nullable<int> propertyID, Nullable<bool> subPropertyID, String user, Nullable<double> rentPayment, Nullable<int> paymentTypeID, Nullable<DateTime> enteryDate, Nullable<DateTime> endDate, Nullable<bool> contactRenew)
        {
            return Ok( BL.RentalBL.Search(propertyID, subPropertyID, user, rentPayment, paymentTypeID, enteryDate, endDate, contactRenew));
        }
    }
}
