namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_25;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<object> stuff =
            new object[] { new(), 1, 3, 5, 7, 9,
                "\"����\"", Guid.NewGuid() };
        Print("����: {0}", stuff);

        IEnumerable<int> even = new int[] { 0, 2, 4, 6, 8 };
        Print("ż��: {0}", even);

        #region HIGHLIGHT
        IEnumerable<int> odd = stuff.OfType<int>();
        #endregion HIGHLIGHT
        Print("����: {0}", odd);

        #region HIGHLIGHT
        IEnumerable<int> numbers = even.Union(odd);
        #endregion HIGHLIGHT
        Print("������ż���Ĳ���: {0}", numbers);

        #region HIGHLIGHT
        Print("��ż���Ĳ���: {0}", numbers.Union(even));
        Print("�������ϲ��ɳ���: {0}", numbers.Concat(odd));
        #endregion HIGHLIGHT
        Print("��ż���Ľ���: {0}",
        #region HIGHLIGHT
            numbers.Intersect(even));
        Print("ȥ��: {0}", numbers.Concat(odd).Distinct());
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        if (!numbers.SequenceEqual(
            numbers.Concat(odd).Distinct()))
        #endregion HIGHLIGHT
        {
            throw new Exception("Unexpectedly unequal");
        }
        else
        {
            Console.WriteLine(
                @"Collection ""SequenceEquals""" +
                $" {nameof(numbers)}.Concat(odd).Distinct())");
        }
        #region HIGHLIGHT
        Print("��ת: {0}", numbers.Reverse());
        Print("ƽ��: {0}", numbers.Average());
        Print("�ܺ�: {0}", numbers.Sum());
        Print("���: {0}", numbers.Max());
        Print("��С: {0}", numbers.Min());
        #endregion HIGHLIGHT
    }

    private static void Print<T>(
            string format, IEnumerable<T> items)
            where T : notnull =>
        Console.WriteLine(format, string.Join(
            ", ", items));
    #region EXCLUDE

    private static void Print<T>(string format, T item)
    {
        Console.WriteLine(format, item);
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
