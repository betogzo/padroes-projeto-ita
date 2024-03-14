namespace Strategy;

public class CalculoDiaria(decimal valorDiaria) : ICalculo
{
    private decimal valorDiaria = valorDiaria;
    
    public decimal CalcularTarifa(int qtdadeHoras)
    {
        return (int) Math.Ceiling((decimal)qtdadeHoras / 24) * valorDiaria;
    }
}