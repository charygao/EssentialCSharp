namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE

public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
        IEnumerable<Patent> patents = PatentData.Patents;
        bool result;
        patents = patents.Where(
            patent =>
            {
                if(result =
                    patent.YearOfPublication.StartsWith("18"))
                {
                    // ν��Ӧ��ֻ���жϣ�������������������ν���еĸ�����
                    Console.WriteLine("\t" + patent);
                }
                return result;
            });

        Console.WriteLine("1. 20����֮ǰ��ר���嵥֮һ:");
        foreach(Patent patent in patents)
        {
        }

        Console.WriteLine();
        Console.WriteLine(
            "2. 20����֮ǰ��ר���嵥֮��:");
        Console.WriteLine(
            $@"   20����֮ǰ�ܹ���{ patents.Count()
                }��ר����");


        Console.WriteLine();
        Console.WriteLine(
            "3. 18����֮ǰ��ר���嵥֮��:");
        patents = patents.ToArray();
        Console.Write("   20����֮ǰ�ܹ���");
        Console.WriteLine(
            $"{ patents.Count() }��ר����");

        //...
        #endregion INCLUDE
    }
}
