using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        ValidacoesString validacoesString = CreateDefaultValidacoesString();
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = validacoesString.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        ValidacoesString validacoesString = CreateDefaultValidacoesString();
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var resultado = validacoesString.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        ValidacoesString validacoesString = CreateDefaultValidacoesString();
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = validacoesString.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        ValidacoesString validacoesString = CreateDefaultValidacoesString();
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = validacoesString.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    public ValidacoesString CreateDefaultValidacoesString(){
        return new ValidacoesString();
    }
}
