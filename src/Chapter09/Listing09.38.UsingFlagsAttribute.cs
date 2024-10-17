namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_38;

#region INCLUDE
// FileAttributes��System.IO�ж���
// FileAttributes��System.IO�ж���
/*
[Flags]
public enum FileAttributes
{
    ReadOnly = 0x0001,
    Hidden   = 0x0002,
    // ...
}
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string fileName = @"enumtest.txt";
        #region EXCLUDE
        // ����һЩ���������Է���Ϊ�ļ�����ֻ��״̬���޷�����
        if (File.Exists(fileName))
        {
            FileAttributes attrs = File.GetAttributes(fileName);
            if (attrs.HasFlag(FileAttributes.ReadOnly))
                File.SetAttributes(fileName, attrs & ~FileAttributes.ReadOnly);
        }
        #endregion EXCLUDE
        FileInfo file = new(fileName);
        file.Open(FileMode.OpenOrCreate).Dispose();

        FileAttributes startingAttributes =
            file.Attributes;

        file.Attributes = FileAttributes.Hidden |
            FileAttributes.ReadOnly;

        Console.WriteLine("ԭ�����\"{1}\"���滻Ϊ\"{0}\"��",
            file.Attributes.ToString().Replace(",", " |"),
            file.Attributes);

        FileAttributes attributes =
            (FileAttributes)Enum.Parse(typeof(FileAttributes),
            file.Attributes.ToString());

        Console.WriteLine(attributes);

        File.SetAttributes(fileName,
            startingAttributes);
        file.Delete();
    }
}
#endregion INCLUDE
