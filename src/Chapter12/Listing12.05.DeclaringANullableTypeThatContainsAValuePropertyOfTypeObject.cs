namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_05;

#region INCLUDE
struct Nullable
{
    /// <summary>
    /// ��HasValue����trueʱ�ṩֵ
    /// </summary>
    public object Value { get; private set; }

    /// <summary>
    /// ������ָ���������һ��ֵ������ֵΪ"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}
#endregion INCLUDE
