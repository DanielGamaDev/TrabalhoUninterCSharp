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
using Pitagoras;
using System.Runtime.CompilerServices;

                                            // Feito por Daniel Gama RU: 4121047

namespace InterfaceAluno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfaceAlunoController : ControllerBase
    {
        private readonly ILogger<InterfaceAlunoController> _logger;

        public InterfaceAlunoController(ILogger<InterfaceAlunoController> logger)
        {
            _logger = logger;    // Permite investigar e mostrar erros/falhas na aplicação
        }

        [HttpGet]                   // Protocolo HTTP que lê os dados

        public String Get()
        {
            var aluno = new Aluno
            {
                Nome = "Daniel Gama",
                RU = "4121047"
            };
            
            return JsonSerializer.Serialize(aluno);

        }


    }
}
