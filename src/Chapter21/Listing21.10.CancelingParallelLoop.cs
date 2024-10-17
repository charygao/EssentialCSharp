namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_10;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public static class Program
{
    public static List<string> ParallelEncrypt(
        List<string> data,
        CancellationToken cancellationToken)
    {
        int governor = 0;
        return data.AsParallel().WithCancellation(
            cancellationToken).Select(
                (item) =>
                {
                    if (Interlocked.CompareExchange(
                        ref governor, 0, 100) % 100 == 0)
                    {
                        Console.Write('.');
                    }
                    Interlocked.Increment(ref governor);
                    return Encrypt(item);
                }).ToList();
    }

    public static async Task Main()
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        List<string> data = Utility.GetData(100000).ToList();

        using CancellationTokenSource cts = new();

        Task task = Task.Run(() =>
        {
            data = ParallelEncrypt(data, cts.Token);
        }, cts.Token);

        Console.WriteLine("��Enter���˳���");
        Task<int> cancelTask = ConsoleReadAsync(cts.Token);

        try
        {
            Task.WaitAny(task, cancelTask);
            // ���������е��κ�һ����ɣ�
            // ����ͳ���ȡ����һ����δ��ɵ�����            
            cts.Cancel();
            await task;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n�ɹ����");
        }
        catch (OperationCanceledException taskCanceledException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"\n��ȡ��: { taskCanceledException.Message }");
        }
        finally
        {
            Console.ForegroundColor = originalColor;
        }
    }

    private static async Task<int> ConsoleReadAsync(
        CancellationToken cancellationToken = default)
    {
        return await Task.Run(async () =>
        {
            const int maxDelay = 1025;
            int delay = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                {
                    return Console.Read();
                }
                else
                {
                    await Task.Delay(delay, cancellationToken);
                    if (delay < maxDelay) delay *= 2 + 1;
                }
            }
            cancellationToken.ThrowIfCancellationRequested();
            throw new InvalidOperationException(
                "��һ�д����Ӧ���Ѿ��׳��쳣�ˣ�������һ��Ӧ����Զִ�в���");
        }, cancellationToken);
    }

    private static string Encrypt(string item)
    {
        Cryptographer cryptographer = new();
        return System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
    }
}
#endregion INCLUDE