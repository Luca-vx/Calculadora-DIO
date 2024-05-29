namespace ProjetoTests;
using Projeto.Calc;

public class CalculadoraTests
{
    private Calculadora _calculadora;
    public CalculadoraTests()
    {
        _calculadora = new Calculadora();
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void DeveSomarOs2NumerosApresentadosERetornarO3Numero(int num1, int num2, int res)
    {
        //Arrange
        //Act
        int resultadoCalculadora = _calculadora.Somar(num1,num2);
        //Assert
        Assert.Equal(res, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(10, 4, 6)]
    public void DeveSubtrairOsNumeros2ApresentadosERetornarO3Numero(int num1, int num2, int res)
    {
        //Arrange
        //Act
        int resultadoCalculadora = _calculadora.Subtrair(num1, num2);

        //Assert
        Assert.Equal(res, resultadoCalculadora);
    }
    [Theory]
    [InlineData(3, 3, 9)]
    [InlineData(2, 5, 10)]
    public void DeveMultiplicarOs2NumerosERetornarO3Numero(int num1, int num2, int res)
    {
        //Arrange
        //Act
        int resultadoCalculadora = _calculadora.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(res, resultadoCalculadora);
    }
    [Theory]
    [InlineData(10, 5, 2)]
    [InlineData(20, 2, 10)]
    public void DeveDividirOs2NumerosERetornarO3Numero(int num1, int num2, int res)
    {
        //Arrange
        //Act
        var resultadoCalculadora = _calculadora.Dividir(num1, num2);

        //Assert
        Assert.Equal(res, resultadoCalculadora);
    }
    [Fact]
    public void DeveFazer4CalculosERetornarOsUltimos3()
    {
        //Arrange
        var somar = _calculadora.Somar(1,2);
        var sub = _calculadora.Subtrair(5,3);
        var mult = _calculadora.Multiplicar(3,3);
        var divd = _calculadora.Dividir(20,2);
        List<string> res = new List<string>{"20 / 2 = 10","3 * 3 = 9","5 - 3 = 2"};
        
        //Act
        var historico = _calculadora.Historico();

        //Assert
        Assert.Equal(res,historico);
    }
}