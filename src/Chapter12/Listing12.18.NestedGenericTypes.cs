namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_18;

#pragma warning disable 0693 // ��ֹ��ʾ����Ƕ�����Ͳ���
                             // ���ⲿ�����е����Ͳ���ͬ���ľ���
#region INCLUDE
public class Container<T, U>
{
    // Ƕ�����Ѽ̳������Ͳ�����
    // ������Щ���Ͳ�������ʾ���档
    public class Nested<U>
    {
        #region HIGHLIGHT
        static void Method(T param0, U param1)
        #endregion HIGHLIGHT
        {
        }
    }
}
#endregion INCLUDE
