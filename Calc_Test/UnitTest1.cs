namespace Calc_Test
{
    public class UnitTest1
    {

        Calc calc = new Calc();
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(5,2, 7)]
        [InlineData(6,4.2,10.2)]
        public void Somar(double n1, double n2, double result)
        {
            var resultado = calc.Somar(n1, n2);
            Assert.Equal(resultado, result.ToString("0.00"));
        }

        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(5,2, 3)]
        [InlineData(6,4.2,1.80)]
        public void Subtrair(double n1, double n2, double result)
        {
            var resultado = calc.Subtrair(n1, n2);
            Assert.Equal(resultado, result.ToString("0.00"));
        }
        
        [Theory]
        [InlineData(1,-2,-2)]
        [InlineData(5,2, 10)]
        [InlineData(6,4,24)]
        public void Multiplicar(double n1, double n2, double result)
        {
            var resultado = calc.Multiplicar(n1, n2);
            Assert.Equal(resultado, result.ToString("0.00"));
        }

        [Theory]
        [InlineData(4,2, 2)]
        [InlineData(5,5, 1)]
        [InlineData(6,2, 3)]

        public void Dividir(double n1, double n2, double result)
        {
            var resultado = calc.Dividir(n1, n2);
            Assert.Equal(resultado, result.ToString("0.00"));
        }

        [Fact]
        public void Historico()
        {
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            //calc.Somar(1, 2);
            //calc.Somar(1, 2);
            var resultado = calc.Historico();
            Assert.Equal(2, resultado.Count);
        }
        [Fact]
        public void Historico2()
        {
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            //calc.Somar(1, 2);
            var resultado = calc.Historico();
            Assert.Equal(3, resultado.Count);
        }
        [Fact]
        public void Historico3()
        {
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            var resultado = calc.Historico();
            Assert.Equal(3, resultado.Count);
        }
    }
}