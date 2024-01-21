namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_06;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        FindMonthOldFiles(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE

    // ����һ����ǰ���ļ�
    public static void FindMonthOldFiles(
    string rootDirectory, string searchPattern)
    {
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            where File.GetLastWriteTime(fileName) <
                DateTime.Now.AddMonths(-1)
            #endregion HIGHLIGHT
            select new FileInfo(fileName);

        foreach(FileInfo file in files)
        {
            //  Ϊ�˼򻯣��ٶ���ǰĿ¼�Ǹ�Ŀ¼�µ�һ����Ŀ¼ 
            // ����ע����ʵ����Ϊ�˱����ж��Ƿ�Ҫ����ʾһ����ţ�
            string relativePath = file.FullName.Substring(
                Directory.GetCurrentDirectory().Length);
            Console.WriteLine(
                $".{ relativePath } ({ file.LastWriteTime })");
        }
    }
    //...
    #endregion INCLUDE
}
