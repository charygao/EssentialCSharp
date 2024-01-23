namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

using System;

// ----
#region INCLUDE
interface IPair<T>
{
    T First { get; }
    T Second { get; }
    #region HIGHLIGHT
    T this[PairItem index] { get; }
    #endregion HIGHLIGHT
}

public enum PairItem
{
    First,
    Second
}

public struct Pair<T> : IPair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; }
    public T Second { get; }

    #region HIGHLIGHT
    public T this[PairItem index]
    {
        get
        {
            #endregion HIGHLIGHT
            switch (index)
            {
                case PairItem.First:
                    return First;
                case PairItem.Second:
                    return Second;
                default:
                    throw new NotImplementedException(
                        $"��δʵ��{index.ToString()}ö�١�");

            }
        }
        #region EXCLUDE

        /*  
        // Ϊ���롰�ṹӦֻ����ԭ��һ�£����ｫsetterע�͵���

        set
        {
            switch(index)
            {
                case PairItem.First:
                    First = value;
                    break;
                case PairItem.Second:
                    Second = value;
                    break;
                default:
                    throw new NotImplementedException(
                        string.Format(
                        "{0}ö����δʵ��",
                        index.ToString()));
            }
        }
        */
        #endregion EXCLUDE
        #region HIGHLIGHT
    }
    #endregion HIGHLIGHT
}
#endregion INCLUDE
