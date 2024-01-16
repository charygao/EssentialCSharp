namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_20;

using System;
using Listing12_13;
// ��ʵ�ʵ�ʵ���У�ItemӦ����һЩֵ
#pragma warning disable CS0168
#region INCLUDE
public class BinaryTree<T>
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    public T Item { get; set; }
    public Pair<BinaryTree<T>> SubItems
    {
        get { return _SubItems; }
        set
        {
            #region HIGHLIGHT
            IComparable<T> first;
            // ����: ��֧��������ʽת��...
            //first = value.First;  // ��Ҫ��ʽת��

            //if(first.CompareTo(value.Second) < 0)
            //{
            //    // firstС��second
            //    //...
            //}
            //else
            //{
            //    // first��second��ȣ�����
            //    // secondС��first
            //    //...
            //}
            _SubItems = value;
            #endregion HIGHLIGHT
        }
    }
    private Pair<BinaryTree<T>> _SubItems;
}
#endregion INCLUDE
#pragma warning restore CS0168

