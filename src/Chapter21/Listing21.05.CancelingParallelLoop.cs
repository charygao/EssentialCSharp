namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_05;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region EXCLUDE
    public static void Main()
    {
        EncryptFiles($@"{Directory.GetCurrentDirectory()}\..\..\", "*.*");
    }
    #endregion EXCLUDE

    static void EncryptFiles(
        string directoryPath, string searchPattern)
    {

        string stars =
            "*".PadRight(Console.WindowWidth - 1, '*');

        IEnumerable<string> files = Directory.GetFiles(
           directoryPath, searchPattern,
           SearchOption.AllDirectories);

        #region HIGHLIGHT
        CancellationTokenSource cts = new();
        ParallelOptions parallelOptions = new()
            { CancellationToken = cts.Token };
        cts.Token.Register(
            () => Console.WriteLine("����ȡ��..."));
        #endregion HIGHLIGHT

        Console.WriteLine("��Enter���˳�");

        Task task = Task.Run(() =>
            {
                try
                {
                    Parallel.ForEach(
                    #region HIGHLIGHT
                        files, parallelOptions,
                    #endregion HIGHLIGHT
                        (fileName, loopState) =>
                        {
                            Encrypt(fileName);
                        });
                }
                catch(OperationCanceledException) { }
            });

        // �ȴ��û�������
        Console.ReadLine();

        // ȡ����ѯ
        #region HIGHLIGHT
        cts.Cancel();
        #endregion HIGHLIGHT
        Console.Write(stars);
        task.Wait();
    }
    #region EXCLUDE

    private static void Encrypt(string fileName)
    {
        if (Path.GetExtension(fileName) == ".encrypt") return;
        Console.WriteLine($">>>>>���ڼ���'{ fileName }'.");
        Cryptographer cryptographer = new();
        File.Delete($"{fileName}.encrypt");
        byte[] encryptedText = cryptographer.Encrypt(File.ReadAllText(fileName));
        File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
        Console.WriteLine($"<<<<<��������'{ fileName}'.");
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
