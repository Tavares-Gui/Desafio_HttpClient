using System;
using Microsoft.AspNetCore.Mvc;

namespace MASQUEICO.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    [HttpGet("monkey")]
    
    public ActionResult TestObj2()
    {
        return Ok(new {
            Nome = "Caco"
        });
    }

    [HttpGet("macaco")]
    
    public ActionResult TestObj()
    {
        Macaco macaco = new Macaco();
        macaco.Nome = "Reimi";

        return Ok(macaco);
    }

    [HttpGet]
    
    public ActionResult TestSum2(string a = "1", string b = "1", string c = "1", string d = "1", string e = "1")
    {
        var data = new string[] {a, b, c, d, e};
        int soma = 0;

        foreach(var item in data)
        {
            if (int.TryParse(item, out var i))
                soma += i;
        }
        
        return Ok(soma);
    }

    [HttpGet("{x}/{y}")]
    
    public ActionResult TestSum(string x, string y)
    {
        var isNum1 = int.TryParse(x, out var n1);
        var isNum2 = int.TryParse(y, out var n2);

        if(!isNum1 && !isNum2)
            return BadRequest("Os dois valores devem numericos");

        if(!isNum1)
            return BadRequest("O primeiro valor deve ser numerico");

        if(!isNum2)
            return BadRequest("O segundo valor deve ser numerico");

        return Ok(n1 + n2);
    }

    // [HttpGet]

    // public string Test()
    // {
    //     return "API TEST is runing";
    // }
    
    // [HttpPost]
    // public string Test2()
    // {
    //     return "API POST is runing";
    // }

    public class Macaco
    {
        public string Nome { get; set; }
    }
}
