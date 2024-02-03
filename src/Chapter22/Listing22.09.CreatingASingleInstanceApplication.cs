namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_09;

#region INCLUDE
using System;
using System.Reflection;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // ���ڳ���ȫ������û���������
        string mutexName =
            Assembly.GetEntryAssembly()!.FullName!;

        // firstApplicationInstanceָ�����ǲ���
        // Ӧ�ó���ĵ�һ��ʵ����
        using Mutex mutex = new(false, mutexName,
             out bool firstApplicationInstance);

        if (!firstApplicationInstance)
        {
            Console.WriteLine(
                "Ӧ�ó����Ѿ��������ˡ�");
        }
        else
        {
            Console.WriteLine("��Enter���رա�");
            Console.ReadLine();
        }
    }
}
#endregion INCLUDE
