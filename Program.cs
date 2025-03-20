class SimpleDataBase<T>
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
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.addNewData(10);
        data.addNewData(30);
        data.addNewData(22);
        data.PrintAllData();
    }
}


