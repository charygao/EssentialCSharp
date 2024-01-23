namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_17;

using System.Collections.Generic;
using Listing17_15;
#region INCLUDE
public class BinaryTree<T> :
  IEnumerable<T>
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }
    #endregion EXCLUDE
    #region IEnumerable<T>�ĳ�Ա
    public IEnumerator<T> GetEnumerator()
    {
        // ��������ڵ��item
        yield return Value;

        // ����pair��ÿ��Ԫ��
        #region HIGHLIGHT
        foreach (BinaryTree<T>? tree in SubItems)
        {
            if(tree is not null)
            {
                // ����pair�е�ÿ��Ԫ�ض�������
                // ���Ա���������yieldÿ��Ԫ�ء�
                foreach(T item in tree)
                {
                    yield return item;
                }
            }
        }
        #endregion HIGHLIGHT
    }
    #endregion IEnumerable<T>�ĳ�Ա

    #region IEnumerable�ĳ�Ա
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
    #region EXCLUDE
    public T Value { get; }  // C# 6.0��ʼ����д��getter���Զ�����

    public Pair<BinaryTree<T>> SubItems { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
