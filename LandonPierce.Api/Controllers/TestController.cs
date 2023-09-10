using LandonPierce.Api.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using System.Data.Entity;

namespace LandonPierce.Api.Controllers
{
    public class TestController : ApiController
    {
        private LandonPierceDB db = new LandonPierceDB();

        [Route("api/Test"), HttpGet]
        public async Task<IHttpActionResult> GetTestData()
        {
            return Ok(db.Test);
        }
    }
}
