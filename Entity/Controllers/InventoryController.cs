using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        //[HttpPost]
        [Route("PostItem")]
        public ActionResult<ObjectTest> PostItem(ObjectTest obj)
        {
            return obj;
        }
    }

    public class ObjectTest
    {
        public string Name { get; set; }
        public string Name2 { get; set; }
    }
}