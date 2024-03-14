namespace Strategy;

public class CalculoHora(decimal valorHora) : ICalculo
{
    private decimal valorHora = valorHora;
    
    public decimal CalcularTarifa(int qtdadeHoras)
    {
        return valorHora * qtdadeHoras;
    }
}