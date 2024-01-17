namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21;

using System;
using Listing13_11;
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("������һ������:");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}'����һ����Ч��������");
                return;
            }
        }

        #region INCLUDE
        int comparisonCount = 0;
        
        DelegateSample.BubbleSort(items,
        #region HIGHLIGHT
            static (int first, int second) =>
        #endregion HIGHLIGHT
            {
            #if COMPILEERROR // EXCLUDE
                // ���� CS8820����̬�����������ܰ�����comparisonCount�����á�
                comparisonCount++;
            #endif // COMPILEERROR // EXCLUDE
                return first < second;
            }
        );

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        #region HIGHLIGHT
        Console.WriteLine("items���Ƚ���{0}�Ρ�",
            comparisonCount);
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
