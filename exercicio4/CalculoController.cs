using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

                      // Feito por Daniel Gama RU: 4121047

[Route("api/[controller]")]          // Rota base da API
[ApiController]
public class CalculoController : ControllerBase
{
    private readonly ILogger<CalculoController> _logger;

    public CalculoController(ILogger<CalculoController> logger)     //  Registra informações e define um método que responde a solicitação POST
    {
        _logger = logger;
    }

    [HttpPost]                      // Tratamento de solicitações POST

    public String Post(string ruAluno)                                // Faz o calculo do Teorema de Pitágoras
    {

        var b = Math.Pow(int.Parse(ruAluno.ElementAt(ruAluno.Length - 7).ToString()),2);  // Pega o primeiro dígito do RU
        var c = Math.Pow(int.Parse(ruAluno.ElementAt(ruAluno.Length - 6).ToString()),2);  // Pega o segundo dígito do RU
        var aAoQuadrado = (c - b);                // Calcula A ao quadrado
        var realA = Math.Sqrt(aAoQuadrado);        // Calcula a raiz quadrada de A

        var resultado = realA.ToString();          // Recebe o resultado final que será exibido como string para evitar erro

        if  (resultado == "NaN")              // Evita o erro caso a conta seja impossível
        {
            resultado = "Resultado impossível de ser calculado!";
        }

        var options = new JsonSerializerOptions   // Armazenando um objeto com todos os atributos
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),

            WriteIndented = true,
        };       
        
        return JsonSerializer.Serialize(resultado, options);          // Retorna o resultado

    }
}

