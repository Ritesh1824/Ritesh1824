using AngularRomanCalculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularRomanCalculator.Controllers
{
    [Route("api/addRoman")]
    public class RomanCalController : Controller
    {
        RomanCalHelper romanCalHelper;
        private const string numbers = "{num1,num2}";

        //GET api/addRoman
        [HttpGet("{num1}/{num2}")]
            public ActionResult<String> addRomanNum(String num1, String num2)
        {
            romanCalHelper = new RomanCalHelper();
            return romanCalHelper.addRoman(num1,num2);

        }
        
              
    }
}
