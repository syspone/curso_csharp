namespace AppCurso.Fundamentos;

public class TiposInter
{
    public static void Executar()
    {
        // Literais e sufixos
        int a = 42;
        uint b = 42u;
        long c = 42L;
        ulong d = 42UL;
        int bin = 0b_1010_0110;
        int hex = 0x_FF_10;
        
        Console.WriteLine(bin);
        Console.WriteLine(hex);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    
    public static void Executar2()
    {
        int e = 100;
        long f = e;

        Console.WriteLine(f);
        
        long g = 9_000_000_000;
        int y = (int)g; // aviso = possivel perda de dados
        
        Console.WriteLine(y);
    }
}