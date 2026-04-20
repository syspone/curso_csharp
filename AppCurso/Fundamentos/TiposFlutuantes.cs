namespace AppCurso.Fundamentos;

public class TiposFlutuantes
{
    
    public static void Executar()
    {
        float f = 0.1f;
        double d = 0.1;
        decimal m = 0.1m;
        
        float somaFloat = 0f;
        double somaDouble = 0.0;
        decimal somaDecimal = 0.0m;
        
        for (int i = 0; i < 10; i++)
        {
            somaFloat += f;
            somaDouble += d;
            somaDecimal += m;
        }
        
        Console.WriteLine($"float (10x0.1): {somaFloat:F20} - Diferente de 1.0!");
        Console.WriteLine($"double (10x0.1): {somaDouble:F20} - Também diferente!");
        Console.WriteLine($"decimal (10x0.1): {somaDecimal} - Exato!");
    }
}
