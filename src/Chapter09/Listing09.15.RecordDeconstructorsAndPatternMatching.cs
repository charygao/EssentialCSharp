using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15;

public class Program
{
    public static void Main()
    {
        // ���캯������λ�ò���������
        Angle angle = new(90, 0, 0, null);

        // ��¼��һ��ʹ����λ�ò����Ľ⹹����
        #region INCLUDE
        if (angle is (int, int, int, string) angleData)
        {
            // ...
        }
        #endregion INCLUDE
    }
}
