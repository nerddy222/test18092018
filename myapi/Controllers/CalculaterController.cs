using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaterController : ControllerBase
    {
       [HttpGet("[action]/{num1}/{num2}")]
       public int Plus(int num1, int num2){       
           var call = new CheckCalculater();
           return call.Plus(num1,num2);
       }

       [HttpGet("{change}")]
       public int[] WithdrawCash(int change){
           var call = new CheckCalculater();
           return call.WithdrawCash(change);
       }
       
    }

}
