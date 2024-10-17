namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // �߸�С����
        List<string> list = new() { "Sneezy", "Happy", "Dopey",  "Doc",
                                    "Sleepy", "Bashful",  "Grumpy"};

        list.Sort();

        Console.WriteLine(
            $"����ĸ˳��{ list[0] }�ǵ�һ��С���ˣ�"
            + $"��{ list[^1] }�����һ����");

        list.Remove("Grumpy");
    }
}
#endregion INCLUDE
