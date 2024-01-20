namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_29;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var worldCup2006Finalists = new[]
        {
            new
            {
                TeamName = "����",
                Players = new string[]
                {
                    "Fabien Barthez", "Gregory Coupet",
                    "Mickael Landreau", "Eric Abidal",
                    // ...
                }
            },
            new
            {
                TeamName = "�����",
                Players = new string[]
                {
                    "Gianluigi Buffon", "Angelo Peruzzi",
                    "Marco Amelia", "Cristian Zaccardo",
                    // ...
                }
            }
        };

        Print(worldCup2006Finalists);
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
