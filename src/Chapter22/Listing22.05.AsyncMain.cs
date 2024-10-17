namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_05;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    static readonly object _Sync = new();
    static int _Total = int.MaxValue;
    static int _Count = 0;

    #region HIGHLIGHT
    public static async Task<int> Main(string[] args)
    #endregion HIGHLIGHT
    {
        if (args?.Length > 0) { _ = int.TryParse(args[0], out _Total); }
        Console.WriteLine("�����͵ݼ�" +
            $"{_Total}��...");

        // .NET 4.0Ҫ��Ϊʹ��Task.Factory.StartNew
        Task task = Task.Run(() => Decrement());

        // ����
        for(int i = 0; i < _Total; i++)
        {
            lock(_Sync)
            {
                _Count++;
            }
        }

        #region HIGHLIGHT
        await task;
        #endregion HIGHLIGHT
        Console.WriteLine($"Count = {_Count}");
        return _Count;
    }

    // �ݼ�
    static void Decrement()
    {
        for(int i = 0; i < _Total; i++)
        {
            lock(_Sync)
            {
                _Count--;
            }
        }
    }
}
#endregion INCLUDE
