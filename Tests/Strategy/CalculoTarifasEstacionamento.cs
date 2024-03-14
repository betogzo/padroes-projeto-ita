using Strategy;

namespace Tests;

public class CalculoTarifasEstacionamento
{
    [Fact]
    public void TarifaFixaPorHora()
    {
        TarifaEstacionamento tarifaEstacionamento = new TarifaEstacionamento(3, new CalculoHora(4));

        decimal resultado = tarifaEstacionamento.Valor();

        Assert.Equal(12M, resultado);
    }
    
    [Fact]
    public void TarifaComValorInicialDepoisFixaPorHora()
    {
        TarifaEstacionamento tarifaEstacionamento = 
            new TarifaEstacionamento(5, 
                new CalculoHoraValorInicial(5, 3, 2));

        decimal resultado = tarifaEstacionamento.Valor();

        Assert.Equal(9M, resultado);
    }
    
    [Fact]
    public void TarifaComValorInicialDentroDoLimite()
    {
        TarifaEstacionamento tarifaEstacionamento = 
            new TarifaEstacionamento(2, 
                new CalculoHoraValorInicial(5, 3, 2));

        decimal resultado = tarifaEstacionamento.Valor();

        Assert.Equal(5M, resultado);
    }
    
    [Fact]
    public void TarifaDiaria()
    {
        TarifaEstacionamento tarifaEstacionamento = 
            new TarifaEstacionamento(50, 
                new CalculoDiaria(20));

        decimal resultado = tarifaEstacionamento.Valor();

        Assert.Equal(60M, resultado);
    }
    
    [Fact]
    public void TarifaDiariaMenorQueUmDia()
    {
        TarifaEstacionamento tarifaEstacionamento = 
            new TarifaEstacionamento(10, 
                new CalculoDiaria(20));

        decimal resultado = tarifaEstacionamento.Valor();

        Assert.Equal(20M, resultado);
    }
}