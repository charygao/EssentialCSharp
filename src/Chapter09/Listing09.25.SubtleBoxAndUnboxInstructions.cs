namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_25;

using System;
#region INCLUDE
public class DisplayFibonacci
{
    public static void Main()
    {
        // ����ʹ��ArrayList����ʾװ��
        System.Collections.ArrayList list = new();

        Console.Write("����2��1000���������ҽ�������ô���쳲�������: ");
        string? inputText = Console.ReadLine();
        if (!int.TryParse(inputText, out int totalCount))
        {
            Console.WriteLine($"'{inputText}'����һ����Ч��������");
            return;
        }

        if (totalCount == 7)  // ��һ��ħ��������ִ�в���
        {
            // �����ȡ��ֵ��double����ô�ᴥ���쳣
            list.Add(0);  // Ҫ��ת��Ϊdouble�����߸���'D'��׺��
                          // ����ת�ͻ���ʹ��'D'��׺�����ɵ�CIL����һ���ġ�

        }
        else
        {
            list.Add((double)0);
        }

        list.Add((double)1);
        
        for(int count = 2; count < totalCount; count++)
        {
            list.Add(
                (double)list[count - 1]! +
                (double)list[count - 2]!);
        }

        // ��foreach������װ�������������ʹ�ã�
        // Console.WriteLine(string.Join(", ", list.ToArray()));
        foreach (double? count in list)
        {
            Console.Write($"{count}, ");
        }
    }
}
#endregion INCLUDE
