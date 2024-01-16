namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_04;

using System;

#region INCLUDE
struct NullableInt
{
    /// <summary>
    /// ��HasValue����trueʱ�ṩֵ
    /// </summary>
    public int Value { get; private set; }

    /// <summary>
    /// ������ָ���������һ��ֵ������ֵΪ"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}

struct NullableGuid
{
    /// <summary>
    /// ��HasValue����trueʱ�ṩֵ
    /// </summary>
    public Guid Value { get; private set; }

    /// <summary>
    /// ������ָ���������һ��ֵ������ֵΪ"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}

// ...
#endregion INCLUDE
