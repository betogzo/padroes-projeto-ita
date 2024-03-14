namespace Strategy;

public class CalculoHoraValorInicial
    (decimal valorHoraInicial, int limiteHorasInicial, decimal valorHoraAdicional) 
    : ICalculo
{
    private decimal valorHoraInicial = valorHoraInicial;
    private int limiteHorasInicial = limiteHorasInicial;
    private decimal valorHoraAdicional = valorHoraAdicional;
    
    public decimal CalcularTarifa(int qtdadeHoras)
    {
        return qtdadeHoras <= limiteHorasInicial ? valorHoraInicial :
            valorHoraInicial + ((qtdadeHoras - limiteHorasInicial) * valorHoraAdicional);
    }
}