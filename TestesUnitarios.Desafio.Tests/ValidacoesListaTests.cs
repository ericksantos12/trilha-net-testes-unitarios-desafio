using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = validacoesLista.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = validacoesLista.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {

        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = validacoesLista.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        ValidacoesLista validacoesLista = CreateDefaultValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = validacoesLista.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }

    public ValidacoesLista CreateDefaultValidacoesLista()
    {
        return new ValidacoesLista();
    }
}
