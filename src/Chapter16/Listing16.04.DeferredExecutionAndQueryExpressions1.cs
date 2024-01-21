namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        ShowContextualKeywords2();
    }
    #endregion EXCLUDE
    private static void ShowContextualKeywords2()
    {
        IEnumerable<string> selection = from word in CSharp.Keywords
                                        where IsKeyword(word)
                                        select word;
        Console.WriteLine("�Ѵ�����ѯ��");
        foreach(string keyword in selection)
        {
            // ���ﲻ����ո�
            Console.Write(keyword);
        }
    }

    // ��ν���а����˿���̨����ĸ����ã�
    // Ŀ������ʾ�Ƴ�ִ�С����ǣ��и�����
    // ��ν����������������һ�����õ�ʵ����
    private static bool IsKeyword(string word)
    {
        if(word.Contains('*'))
        {
            // ����������ո�
            Console.Write(" ");
            return true;
        }
        else
        {
            return false;
        }
    }
    //...
    #endregion INCLUDE
}