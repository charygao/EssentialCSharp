namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region EXCLUDE
    // ˵�� : ��Main��ʼʱ��ʼ��
#pragma warning disable CS8618 // ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
    #endregion EXCLUDE
    static ManualResetEventSlim _MainSignaledResetEvent;
    static ManualResetEventSlim _DoWorkSignaledResetEvent;
    #region EXCLUDE
#pragma warning restore CS8618 // ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
    #endregion EXCLUDE

    public static void DoWork()
    {
        Console.WriteLine("DoWork()������....");
        #region HIGHLIGHT
        _DoWorkSignaledResetEvent.Set();
        _MainSignaledResetEvent.Wait();
        #endregion HIGHLIGHT
        Console.WriteLine("DoWork()���ڽ���....");
    }

    public static void Main()
    {
        using(_MainSignaledResetEvent = new ())
        using(_DoWorkSignaledResetEvent = new ())
        {
            Console.WriteLine(
                "Ӧ�ó���������...");
            Console.WriteLine("������������...");

            // .NET 4.0Ҫ��Ϊʹ��Task.Factory.StartNew
            Task task = Task.Run(() => DoWork());

            // ������ֱ��DoWork()����
            _DoWorkSignaledResetEvent.Wait();
            Console.WriteLine(
                "���߳�ִ���ڼ�ȴ�...");
            _MainSignaledResetEvent.Set();
            task.Wait();
            Console.WriteLine("�߳��ѽ���");
            Console.WriteLine(
                "Ӧ�ó���ر�...");
        }
    }
}
#endregion INCLUDE
