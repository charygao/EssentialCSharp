namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_28;

using System;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int number;
        object thing;
        number = 42;
        // װ��
        thing = number;
        #region HIGHLIGHT
        // ���ﲻ�ᷢ������
        #endregion HIGHLIGHT
        string text = ((IFormattable)thing).ToString(
            "X", null);
        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
