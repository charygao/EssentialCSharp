namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

#region INCLUDE
// ʹ��record struct����������һ��ֵ����
public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null);
#endregion INCLUDE
