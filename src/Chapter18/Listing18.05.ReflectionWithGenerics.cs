namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05;

#region INCLUDE

public class Program
{
    public static void Main()
    {
        Type type;
        type = typeof(System.Nullable<>);
        Console.WriteLine($"System.Nullable<>�Ƿ�������Ͳ�����" +
            $"{type.ContainsGenericParameters}");
        Console.WriteLine($"System.Nullable<>�Ƿ������ͣ�" +
            $"{type.IsGenericType}");

        type = typeof(System.Nullable<DateTime>);
        Console.WriteLine($"System.Nullable<DateTime>�Ƿ�������Ͳ�����" +
            $"{type.ContainsGenericParameters}");
        Console.WriteLine($"System.Nullable<DateTime>�Ƿ������ͣ�" +
            $"{type.IsGenericType}");
    }
}
#endregion INCLUDE
