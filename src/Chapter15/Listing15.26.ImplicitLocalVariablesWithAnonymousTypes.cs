namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_26;

#region INCLUDE
using System;

public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        var patent1 =
            new
            {
                Title = "˫�����۾�",
                YearOfPublication = "1784"
            };
        var patent2 =
            new
            {
                Title = "������",
                YearOfPublication = "1877"
            };
        var patent3 =
            new
            {
                patent1.Title,
                // ����������ʾ��������
                Year = patent1.YearOfPublication
            };
        #endregion HIGHLIGHT

        Console.WriteLine(
            $"{ patent1.Title } ({ patent1.YearOfPublication })");
        Console.WriteLine(
            $"{ patent2.Title } ({ patent2.YearOfPublication })");


        Console.WriteLine();
        Console.WriteLine(patent1);
        Console.WriteLine(patent2);

        Console.WriteLine();
        Console.WriteLine(patent3);
    }
}
#endregion INCLUDE
