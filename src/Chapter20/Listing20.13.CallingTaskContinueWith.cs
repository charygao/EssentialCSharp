namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_13;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        DisplayStatus("��ʼ֮ǰ");
        Task taskA =
            Task.Run(() =>
                 DisplayStatus("��ʼ..."))
            .ContinueWith(antecedent =>
                 DisplayStatus("����A..."));
        Task taskB = taskA.ContinueWith(antecedent =>
      DisplayStatus("����B..."));
        Task taskC = taskA.ContinueWith(antecedent =>
            DisplayStatus("����C..."));
        Task.WaitAll(taskB, taskC);
        DisplayStatus("����!");
    }

    private static void DisplayStatus(string message)
    {
        string text = 
                $@"{ Thread.CurrentThread.ManagedThreadId 
                    }: { message }";


        Console.WriteLine(text);
    }
}
#endregion INCLUDE





