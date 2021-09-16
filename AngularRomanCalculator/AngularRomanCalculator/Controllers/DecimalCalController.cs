using AngularRomanCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularRomanCalculator.Controllers
{
    [Route("api/addDecimal")]
    public class DecimalCalController : Controller 
    {
        DecimalCalHelper decimalCalHelper;
        [HttpGet("{num1}/{num2}")]
        public ActionResult<String> addDecimalNum(String num1, String num2)
        {
            decimalCalHelper = new DecimalCalHelper();
            return decimalCalHelper.addDeciaml(Double.Parse(num1), Double.Parse(num2));
       
            
        }
    }
}
