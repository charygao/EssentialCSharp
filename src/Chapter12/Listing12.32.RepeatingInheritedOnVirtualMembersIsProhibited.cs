namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_32;

using System;
#region INCLUDE
public class EntityBase
{
    public virtual void Method<T>(T t)
        where T : IComparable<T>
    {
        // ...
    }
}
public class Order : EntityBase
{
    public override void Method<T>(T t)
    //    ��д��Աʱ��Լ���������ظ�
    //    where T : IComparable<T>
    {
        // ...
    }
}
#endregion INCLUDE
