namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_22;

using System;
using Listing12_13;

#region INCLUDE
public class BinaryTree<T>
    #region HIGHLIGHT
    where T : System.IComparable<T>
    #endregion HIGHLIGHT
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    public T Item { get; set; }
    public Pair<BinaryTree<T>?> SubItems
    {
        get { return _SubItems; }
        set
        {
            switch (value)
            {                
                // C# 8.0Ӧ��ʹ��ģʽƥ��(is null)��
                // ����C# 8.0֮ǰ��ֻ���������null
                #region EXCLUDE
                case { First: null }:
                    // First is null
                    break;
                case { Second: null }:
                    // Second is null
                    break;
                #endregion EXCLUDE
                case
                {
                    #region HIGHLIGHT
                    First: { Item: T first },
                    #endregion HIGHLIGHT
                    Second: { Item: T second }
                }:
                    #region HIGHLIGHT
                    if (first.CompareTo(second) < 0)
                    #endregion HIGHLIGHT
                    {
                        // firstС��second
                    }
                    else
                    {
                        // secondС�ڻ����first
                    }
                    break;
                default:
                    throw new InvalidCastException(
                        @$"���ܶ�items������Ϊ{typeof(T)}��֧��IComparable<T>�ӿڡ�"); 
            };
            _SubItems = value;
        }
    }
    private Pair<BinaryTree<T>?> _SubItems;
}
#endregion INCLUDE
