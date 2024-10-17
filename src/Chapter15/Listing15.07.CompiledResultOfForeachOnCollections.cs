namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_07;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        System.Collections.Generic.Stack<int>.Enumerator enumerator;
        IDisposable disposable;

        enumerator = stack.GetEnumerator();
        try
        {
            int number;
            while (enumerator.MoveNext())
            {
                number = enumerator.Current;
                Console.WriteLine(number);
            }
        }
        finally
        {
            // ö������Ҫ��ʽת��ΪIDisposable
            disposable = (IDisposable)enumerator;
            disposable.Dispose();

            // ���Ǳ���ʱ��֪֧��IDisposable������Ӧ��ʹ��
            // as��������ö����ת��ΪIDisposable
            // disposable = (enumerator as IDisposable);
            // if (disposable is not null)
            // {
            //     disposable.Dispose();
            // }
        }
        #endregion INCLUDE
    }
}
