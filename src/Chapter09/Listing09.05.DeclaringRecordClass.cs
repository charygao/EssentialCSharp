using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05;
#region INCLUDE
// ʹ��record class����������һ����������
public record class Coordinate(
    Angle Longitude, Angle Latitude)
#endregion INCLUDE
{
    public Type ExternalEqualityContract => EqualityContract;
}
