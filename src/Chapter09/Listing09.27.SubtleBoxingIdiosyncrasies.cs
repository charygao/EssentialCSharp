namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_27;

using System;

#region INCLUDE
interface IAngle
{
    void MoveTo(int degrees, int minutes, int seconds);
}

struct Angle : IAngle
{
    #region EXCLUDE
    public Angle(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #endregion EXCLUDE

    // ע��:  ���ʹAngle���ɱ䡱����Υ��ƹ淶
    public void MoveTo(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #region EXCLUDE
    public int Degrees
    {
        get { return _Degrees; }
    }
    private int _Degrees;

    public int Minutes
    {
        get { return _Minutes; }
    }
    private int _Minutes;

    public int Seconds
    {
        get { return _Seconds; }
    }
    private int _Seconds;
    #endregion EXCLUDE
}
public class Program
{
    public static void Main()
    {
        // ...

        Angle angle = new(25, 58, 23);
        // ��1: ��װ�����
        object objectAngle = angle;  // װ��
        Console.Write(((Angle)objectAngle).Degrees);

        // ��2: ���䣬�޸��Ѳ����ֵ��Ȼ����ֵ
        ((Angle)objectAngle).MoveTo
            (26, 58, 23);
        Console.Write(", " + ((Angle)objectAngle).Degrees);

        // ��3: װ�䣬�޸���װ���ֵ��Ȼ���������ӵ�����
        ((IAngle)angle).MoveTo(26, 58, 23);
        Console.Write(", " + ((Angle)angle).Degrees);

        // ��4: ֱ���޸���װ���ֵ
        ((IAngle)objectAngle).MoveTo(26, 58, 23);
        Console.WriteLine(", " + ((Angle)objectAngle).Degrees);

        // ...
    }
}
#endregion INCLUDE
