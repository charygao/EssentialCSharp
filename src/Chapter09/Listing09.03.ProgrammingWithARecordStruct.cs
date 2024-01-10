using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03;

#region INCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        (int degrees, int minutes, int seconds) = (90, 0, 0);

        // ���캯������λ�ò���������
        Angle angle = new(degrees, minutes, seconds);

        // ��¼����һ��ToString()ʵ�֣������أ�
        // "Angle { Degrees = 90, Minutes = 0, Seconds = 0, Name =  }"
        Console.WriteLine(angle.ToString());

        // ��¼��һ��ʹ����λ�ò����Ľ⹹����
        if (angle is (int, int, int, string) angleData)
        {
            Trace.Assert(angle.Degrees == angleData.Degrees);
            Trace.Assert(angle.Minutes == angleData.Minutes);
            Trace.Assert(angle.Seconds == angleData.Seconds);
        }

        Angle copy = new(degrees, minutes, seconds);       
        // ��¼�ṩ��һ���Զ��������Բ�����
        Trace.Assert(angle == copy);

        // with�������ȼ��ڣ�
        // Angle copy = new(degrees, minutes, seconds);
        copy = angle with { };
        Trace.Assert(angle == copy);

        // with������֧�֡������ʼ�������﷨��
        // ����ʵ����һ���޸Ĺ��Ŀ�����        
        Angle modifiedCopy = angle with { Degrees = 180 };
        Trace.Assert(angle != modifiedCopy);
    }
}
#endregion INCLUDE
