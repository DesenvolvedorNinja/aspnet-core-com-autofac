namespace WebDemoAutofac
{
    public class CalculoFrete : ICalculoFrete
    {
        public double Calcular(double pesoProdutos, double valorProdutos) => (valorProdutos * 0.05) + pesoProdutos;
    }
}
