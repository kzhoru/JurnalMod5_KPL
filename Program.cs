
public class PemrosesData
{
    public dynamic DapatkanNilaiTerbesar<T>(T x, T y, T z)
    {
        dynamic var1 = x;
        dynamic var2 = y;
        dynamic var3 = z;
        dynamic terbesar = var1;
        if (terbesar < var2)
        {
            terbesar = var2;
        }
        if (terbesar < var3) {
            terbesar = var3;
        }
        return terbesar;
    }
}

public class Program
{
    public static void Main()
    {
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai Max: " + data.DapatkanNilaiTerbesar<float>(10, 30, 22));
    }
}
