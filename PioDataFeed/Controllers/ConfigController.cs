using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PioDataFeed.Models;

namespace PioDataFeed.Controllers
{
    [Route("")]
    [ApiController]
    public class ConfigController : ControllerBase
    {

        EGIDContext egid = new EGIDContext();

        [HttpGet("{ruiters}")]
        public ActionResult Config([FromQuery]string ruiters, Int32 fromTime, Int32 toTime)
        {

       
           var res = egid.SptSymbolhistory.FromSql($"EXEC SP_SYMBOLHISTORY {ruiters}, {fromTime}, {toTime}").ToList();
       return Ok(res);

        }

        
    }
}