namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_31;

using System;
#region INCLUDE
public class EntityBase<T> where T : IComparable<T>
{
    // ...
}

// ����: 
// ����'U'���������������ͻ򷽷�'EntityBase<T>'
// �е����Ͳ���'T'��û�д�'U'��'System.IComparable<U>'
// ��װ��ת�������Ͳ���ת����	
// class Entity<U> : EntityBase<U>
// {
//     ...
// }
#endregion INCLUDE
