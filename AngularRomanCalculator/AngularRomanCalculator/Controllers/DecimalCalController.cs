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
        [HttpGet("{num1}/{num2}")]
        public ActionResult<String> addDecimalNum(String num1, String num2)
        {
           
            return Models.DecimalCalHelper.addDeciaml(Double.Parse(num1), Double.Parse(num2));
       
            
        }
    }
}
