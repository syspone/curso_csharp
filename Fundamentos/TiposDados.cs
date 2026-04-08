namespace AppCurso.Fundamentos;
using System.Globalization;

public class TiposDados
{
    public static void Executar()
    {
        double x = 10.35784;
        int y = 32;
        string z = "Maria";
        char w = 'F';
        
        Console.Write("Olá mundo!");
        Console.WriteLine("Bom dia!");
        Console.WriteLine("Até mais.");
        Console.WriteLine();
        Console.WriteLine(x);
        Console.WriteLine(x.ToString("F2")); 
        Console.WriteLine(x.ToString("F4"));
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.WriteLine("RESULTADO = " + x);
        Console.WriteLine("O valor do troco é " + x + " reais");
        Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
        Console.WriteLine();
        Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
        
        //Console.ReadLine();
    }
    
    public static void Executar2()
    {
        double x = 10.35784;
        float y = 10.35784f;

        decimal z;
        z = 10.35784m;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        
        Console.ReadLine();

        Console.WriteLine("Comparando a precisão do float, double e decimal");

        float a = 1f / 3f;
        double b = 1d / 3d;
        decimal c = 1m / 3m;
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        
        Console.ReadLine();
    }
}