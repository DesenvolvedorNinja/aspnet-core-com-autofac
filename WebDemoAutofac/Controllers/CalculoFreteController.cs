using Microsoft.AspNetCore.Mvc;

namespace WebDemoAutofac.Controllers
{
    [Route("api/[controller]")]
    public class CalculoFreteController : Controller
    {
        private readonly ICalculoFrete calculoFrete;

        public CalculoFreteController(ICalculoFrete calculoFrete)
        {
            this.calculoFrete = calculoFrete;
        }

        [HttpGet("{peso}/{valor}")]
        public string Get(double peso, double valor) => $"O valor do frete é {calculoFrete.Calcular(peso, valor)}";
    }
}
