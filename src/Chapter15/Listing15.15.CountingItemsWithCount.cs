namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<Patent> patents = PatentData.Patents;
        #region HIGHLIGHT
        Console.WriteLine($"ר������: { patents.Count() }");
        #endregion HIGHLIGHT
        Console.WriteLine($@"19����ר������: {
            patents.Count(patent =>
                patent.YearOfPublication.StartsWith("18"))}");
        #endregion INCLUDE
    }
}
