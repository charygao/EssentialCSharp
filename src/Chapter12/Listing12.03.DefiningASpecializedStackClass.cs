namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_03;

using Listing12_02;
#region INCLUDE
public class CellStack
{
    public virtual Cell Pop() { return new Cell(); } // �������һ����ӵ�cell��
                                                     // ��������ջ���Ƴ���
    public virtual void Push(Cell cell) { }
    // ...
}
#endregion INCLUDE
