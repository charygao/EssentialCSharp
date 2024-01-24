#region INCLUDE
#define CONDITION_A
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_24;

#endregion EXCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("��ʼ...");
        MethodA();
        MethodB();
        Console.WriteLine("����...");
    }

    [Conditional("CONDITION_A")]
    public static void MethodA()
    {
        Console.WriteLine("MethodA()����ִ��...");
    }

    [Conditional("CONDITION_B")]
    public static void MethodB()
    {
        Console.WriteLine("MethodB()����ִ��...");
    }
}
#endregion INCLUDE
