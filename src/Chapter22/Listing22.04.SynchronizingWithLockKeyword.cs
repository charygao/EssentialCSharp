namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_04;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    #region HIGHLIGHT
    static readonly object _Sync = new();
    #endregion HIGHLIGHT
    static int _Total = int.MaxValue;
    static int _Count = 0;

    public static int Main(string[] args)
    {
        if (args?.Length > 0) { _ = int.TryParse(args[0], out _Total); }
        Console.WriteLine("�����͵ݼ�" +
            $"{_Total}��...");

        // .NET 4.0Ҫ��Ϊʹ��Task.Factory.StartNew
        Task task = Task.Run(() => Decrement());

        // ����
        for (int i = 0; i < _Total; i++)
        {
            #region HIGHLIGHT
            lock (_Sync)
            {
                _Count++;
            }
            #endregion HIGHLIGHT
        }

        task.Wait();
        Console.WriteLine($"Count = {_Count}");
        return _Count;
    }

    // �ݼ�
    public static void Decrement()
    {
        for (int i = 0; i < _Total; i++)
        {
            #region HIGHLIGHT
            lock (_Sync)
            {
                _Count--;
            }
            #endregion HIGHLIGHT
        }
    }
}
#endregion INCLUDE
