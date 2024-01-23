using AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_12;

#region INCLUDE
using System;

public class BinaryTree<T> 
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }

    /// <summary>
    /// ����λ���ض�λ�õ�BinaryTree<typeparamref name="T"/>
    /// </summary>
    /// <param name="branches">ָ���ض���֧��һ��PairItems���顣</param>
    /// <example>
    /// familyTree.SubItems.Second.SubItems[PairItem.First].Value
    /// </example>
    #endregion EXCLUDE
    public BinaryTree<T> this[params PairItem[]? branches]
    {
        get
        {
            BinaryTree<T> currentNode = this;

            // ����ʹ�ÿ������null�����ø��ڵ�
            int totalLevels = branches?.Length ?? 0;
            int currentLevel = 0;

            while (currentLevel < totalLevels)
            {
                System.Diagnostics.Debug.Assert(branches is not null,
                    $"{ nameof(branches) }��Ϊnull");

                currentNode = currentNode.SubItems[
                    branches[currentLevel]];
                if (currentNode is null)
                {
                    // ��λ�õĶ�����Ϊnull
                    throw new IndexOutOfRangeException();
                }
                currentLevel++;
            }
            return currentNode;
        }
    }
    #region EXCLUDE

    public T Value { get; set; }

    public Pair<BinaryTree<T>> SubItems {get;set;}
    #endregion EXCLUDE
}
#endregion INCLUDE

public class Program
{
    public static void Main()
    {
        // JFK(�����)��������
        var jfkFamilyTree = new BinaryTree<string>(
            "John Fitzgerald Kennedy")
        {
            SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Joseph Patrick Kennedy")
                {
                    // �游ĸ�������Ǳߣ�
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("Patrick Joseph Kennedy"),
                        new BinaryTree<string>("Mary Augusta Hickey"))
                },
                new BinaryTree<string>("Rose Elizabeth Fitzgerald")
                {
                    // ���游ĸ��ĸ���Ǳߣ�
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("John Francis Fitzgerald"),
                        new BinaryTree<string>("Mary Josephine Hannon"))
                })
        };

        // �����������Ľṹ������ʾ��
        // John Fitzgerald Kennedy�����Ǵ����֪��������ͳ����ϣ�
        //     Joseph Patrick Kennedy������ϵ��ϰ֣�
        //         Patrick Joseph Kennedy������ϵ��游��
        //         Mary Augusta Hickey������ϵ���ĸ��
        //     Rose Elizabeth Fitzgerald������ϵ����裩
        //         John Francis Fitzgerald������ϵ����游��
        //         Mary Josephine Hannon������ϵ�����ĸ��

        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.First].Value);
        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.Second].Value);
    }
}
