namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02;

#region INCLUDE
using System;
using System.IO;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://bookzhou.com";

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("����û������Ҫ�������ı���");
            return;
        }
        string findText = args[0];

        string url = DefaultUrl;
        if (args.Length > 1)
        {
            url = args[1];
            // ���ȡ���������в��������Ը���������в���
        }
        Console.WriteLine(
            $"����ַ'{url}'����'{findText}'��");

        Console.WriteLine("��������...");
        Task task = HttpClient.GetByteArrayAsync(url)
            .ContinueWith(antecedent =>
            {
                byte[] downloadData = antecedent.Result;
                Console.Write($"{Environment.NewLine}��������...");
                return CountOccurrencesAsync(
                    downloadData, findText);
            })
            .Unwrap()
            .ContinueWith(antecedent =>
            {
                int textOccurrenceCount = antecedent.Result;
                Console.WriteLine(
                     @$"{Environment.NewLine}'{findText}'����ַ'{url}'������{
                        textOccurrenceCount}�Ρ�");

            });

        try
        {
            while (!task.Wait(100))
            {
                Console.Write(".");
            }
        }
        catch (AggregateException exception)
        {
            exception = exception.Flatten();
            try
            {
                exception.Handle(innerException =>
                {
                    // �����׳���������ʹ��if�������ж�����
                    ExceptionDispatchInfo.Capture(
                        innerException)
                        .Throw();
                    return true;
                });
            }
            catch (HttpRequestException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
            catch (IOException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
        }
    }


    private static async Task<int> CountOccurrencesAsync(
        byte[] downloadData, string findText)
    {
        #region EXCLUDE
        int textOccurrenceCount = 0;

        using MemoryStream stream = new(downloadData);
        using StreamReader reader = new(stream);

        int findIndex = 0;
        int length = 0;
        do
        {
            char[] data = new char[reader.BaseStream.Length];
            length = await reader.ReadAsync(data);
            for (int i = 0; i < length; i++)
            {
                if (findText[findIndex] == data[i])
                {
                    findIndex++;
                    if (findIndex == findText.Length)
                    {
                        // �ҵ���Ҫ�������ı�
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
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
