// File: `AppCurso/Fundamentos/ProcessCasting.cs`
using System;

namespace AppCurso.Fundamentos;

public class ProcessCasting
{
    public static void Executar()
    {
        /************** Metodo de conversao Simples *****************/
        int x;
        double y;

        x = 5;
        y = 2 * x;

        Console.WriteLine(x);
        Console.WriteLine(y);

        // Exemplo de uso do método Ex2 movido para dentro de um método válido
        double area = Ex2(6.0, 8.0, 5.0);
        Console.WriteLine("Área do trapézio: " + area);

        Console.ReadLine();
    }

    public static double Ex2(double b, double B, double h)
    {
        return (b + B) * h / 2.0;
    }

    public static void ExCasting()
    {
        int x, y;
        double resultado;

        x = 5;
        y = 2;
        resultado = (double) x / y; // casting explicito de int para double (saida precisa)

        Console.WriteLine(resultado);

        /************** 4° Exemplo: *****************/

        // Casting implícito (int para double)
        int numeroInteiro = 10;
        double numeroDecimal = numeroInteiro; // Conversão automática

        Console.WriteLine($"Inteiro: {numeroInteiro}, Decimal: {numeroDecimal}");

        // Casting explícito (double para int)
        double valorDouble = 15.75;
        int valorInt = (int)valorDouble; // Conversão manual (perde as casas decimais)

        Console.WriteLine($"Double: {valorDouble}, Int: {valorInt}"); // Saída: 15
        
        Console.ReadLine();
    }
}
