using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_10;

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Angle angle = new(90, 0, 0, null);

         // with�������ȼ��ڣ�
        // Angle copy = new(degrees, minutes, seconds);
        Angle copy = angle with { };
        Trace.Assert(angle == copy);

        // with������֧���ö����ʼ������ʽ��
        // �﷨��ʵ����һ���޸ĺ�Ŀ�����
        Angle modifiedCopy = angle with { Degrees = 180 };
        Trace.Assert(angle != modifiedCopy);
        #endregion INCLUDE
    }
}
