using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cep")]

public class CepController : ControllerBase
{

    [HttpGet("{cep}")]

    public async Task<ActionResult> Get(string cep)
    {

        HttpClient client = new HttpClient();

        string resultado = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json");

        return Ok(resultado);
    }
}