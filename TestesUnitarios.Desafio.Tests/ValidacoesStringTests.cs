using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    { 
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange
       
        @@ -12,8 +12,8 @@ public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        // Arrange
        var texto = "a";
        var resultadoEsperado = 0;
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);
        @@ -31,11 +31,11 @@ public void DeveContemAPalavraQualquerNoTexto();
        // Assert
        
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
        @@ -50,17 +50,18 public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         _validacoes.ContemCaractere(texto, textoProcurado);
         var resultado = validacoes _ContemCaractere(texto, textoProcurado);
        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(true);
        Assert.(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Comeco, meio e fim do texto procurado";
        var textoProcurado = "teste";
        var textoProcurado = "procurado";
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(true);
        Assert.(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "teste";
        var textoProcurado = "procurado";
        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
