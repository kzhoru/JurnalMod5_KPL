

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

﻿class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        PemrosesData data1 = new PemrosesData();
        Console.WriteLine("Nilai Max: " + data1.DapatkanNilaiTerbesar<float>(10, 30, 22));
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.addNewData(10);
        data.addNewData(30);
        data.addNewData(22);
        data.PrintAllData();
    }
}
