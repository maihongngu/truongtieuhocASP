using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace THPT.Controllers
{
    public class tintucController : Controller
    {
        // GET: /tintuc/       
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        // GET: /tintuc/Browse       
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        // GET: /tintuc/Details        
        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }
}