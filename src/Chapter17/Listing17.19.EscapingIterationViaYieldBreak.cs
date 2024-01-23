namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_19;

using System;
using Listing17_10;
using System.Collections.Generic;

public struct Pair<T> : IPair<T>, IEnumerable<T>
{
    #region Members
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
    public T First { get; }
    public T Second { get; }

    public T this[PairItem index]
    {
        get
        {
            switch(index)
            {
                case PairItem.First:
                    return First;
                case PairItem.Second:
                    return Second;
                default:
                    throw new NotImplementedException(
                        string.Format(
                        "��δʵ��{0}ö��",
                        index.ToString()));
            }
        }
    }
    #endregion Members

    // �����嵥17.19  ��yield breakȡ������
    #region INCLUDE
    public System.Collections.Generic.IEnumerable<T> GetNotNullEnumerator()
    {
        #region HIGHLIGHT
        if ((First is null) || (Second is null))
        {
            yield break;
        }
        #endregion HIGHLIGHT
        yield return Second;
        yield return First;
    }
    #endregion INCLUDE

    

    #region IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }
    #endregion IEnumerable<T>

    #region IEnumerable�ĳ�Ա
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
}
