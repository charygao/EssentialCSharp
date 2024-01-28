namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01;

#region INCLUDE
using System;
using System.IO;
using System.Net;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://bookzhou.com";

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("����û������Ҫ���ҵ��ı���");
            return;
        }
        string findText = args[0];

        string url = DefaultUrl;
        if (args.Length > 1)
        {
            url = args[1];
            // Ignore additional parameters
        }
        Console.WriteLine(
            $"����ַ'{url}'����'{findText}'��");

        Console.WriteLine("��������...");
        byte[] downloadData =
            HttpClient.GetByteArrayAsync(url).Result;

        Console.WriteLine("��������...");
        int textOccurrenceCount = CountOccurrences(
            downloadData, findText);

        Console.WriteLine(
            @$"'{findText}'����ַ'{url}'������{
                textOccurrenceCount}�Ρ�");
    }

    private static int CountOccurrences(byte[] downloadData, string findText)
    {
        int textOccurrenceCount = 0;

        using MemoryStream stream = new(downloadData);
        using StreamReader reader = new(stream);

        int findIndex = 0;
        int length = 0;
        do
        {
            char[] data = new char[reader.BaseStream.Length];
            length = reader.Read(data);
            for (int i = 0; i < length; i++)
            {
                if (findText[findIndex] == data[i])
                {
                    findIndex++;
                    if (findIndex == findText.Length)
                    {
                        // δ�ҵ�ָ���ı�
                        textOccurrenceCount++;
                        findIndex = 0;
                    }
                }
                else
                {
                    findIndex = 0;
                }
            }
        }
        while (length != 0);

        return textOccurrenceCount;
    }
}
#endregion INCLUDE
