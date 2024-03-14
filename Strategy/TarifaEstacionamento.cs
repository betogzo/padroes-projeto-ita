namespace Strategy;

public class TarifaEstacionamento
{
    private int qtdadeHoras;
    private ICalculo calculo;
    
    public TarifaEstacionamento(int qtdadeHoras, ICalculo calculo)
    {
        this.qtdadeHoras = qtdadeHoras;
        this.calculo = calculo;
    }

    public decimal Valor()
    {
        return calculo.CalcularTarifa(qtdadeHoras);
    }
}