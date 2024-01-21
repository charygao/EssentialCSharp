namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_09;

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Program
{
    public static void Main()
    {
        ListByFileSize3(Directory.GetCurrentDirectory(), "*");
    }

    static void ListByFileSize3(
        string rootDirectory, string searchPattern)
    {
        #region INCLUDE
        //...
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            let file = new FileInfo(fileName)
            orderby file.Length, fileName
            select file;
        #endregion HIGHLIGHT
        //...
        #endregion INCLUDE


        foreach (FileInfo file in files)
        {
            //  Ϊ�˼򻯣��ٶ���ǰĿ¼�Ǹ�Ŀ¼�µ�һ����Ŀ¼ 
            // ����ע����ʵ����Ϊ�˱����ж��Ƿ�Ҫ����ʾһ����ţ�
            string relativePath = file.FullName.Substring(
                Directory.GetCurrentDirectory().Length);
            Console.WriteLine( 
                $".{ relativePath }({ file.Length })" );
        }
    }
}
