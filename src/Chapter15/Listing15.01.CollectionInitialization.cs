namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_01;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> sevenWorldBlunders;
        sevenWorldBlunders = new List<string>()
        {
            // ��ν���ʵص����ԡ��������ߴ��
            "û�����͵ĲƸ�",
            "û�����ĵ�����",
            "û��Ʒ���֪ʶ",
            "û�е��µ���ҵ",
            "û�����ԵĿ�ѧ",
            "û�������ĳ��",
            "û��ԭ�������"            
        };

        Print(sevenWorldBlunders);
    }

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
#endregion INCLUDE
