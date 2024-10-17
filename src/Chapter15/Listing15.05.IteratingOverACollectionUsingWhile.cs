namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        int number;
        // ...

        // �����Դ��룬��ʵ�ʴ���
        #if ConceptualCode
        while(stack.MoveNext())
        {   
            number = stack.Current();
            Console.WriteLine(number);
        }
        #endif // ConceptualCode

        #endregion INCLUDE

        // ʵ�ʴ���
        while(stack.Pop() != -1) // ��ʵ�ʲ�������ȷ���߼������ص�����while����������ջ
        {
            number = stack.Peek();
            Console.WriteLine(number);
        }
    }
}
