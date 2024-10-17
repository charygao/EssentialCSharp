namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    static int _Total = int.MaxValue;
    static int _Count = 0;

    public static int Main(string[] args)
    {
        if (args?.Length > 0) { _ = int.TryParse(args[0], out _Total); }

        Console.WriteLine("�����͵ݼ�" + $"{_Total}��...");

        //  .NET 4.0Ҫ��Ϊʹ��Task.Factory.StartNew
        Task task = Task.Run(() => Decrement());

        // ����
        for(int i = 0; i < _Total; i++)
        {
            _Count++;
        }

        task.Wait();
        Console.WriteLine($"Count = {_Count}");

        return _Count;
    }

    public static void Decrement()
    {
        // �ݼ�
        for(int i = 0; i < _Total; i++)
        {
            _Count--;
        }
    }
}
#endregion INCLUDE
