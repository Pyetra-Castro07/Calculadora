namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Contar()
        {
            Assert.Equal(5, CalculadoraExemple.Calculadora.Somar(2, 3));
            Assert.Equal(1, CalculadoraExemple.Calculadora.Subtrair(3, 2));
            Assert.Equal(6, CalculadoraExemple.Calculadora.Multiplicar(2, 3));
            Assert.Equal(2, CalculadoraExemple.Calculadora.Dividir(4, 2));
        }

     
    }
}