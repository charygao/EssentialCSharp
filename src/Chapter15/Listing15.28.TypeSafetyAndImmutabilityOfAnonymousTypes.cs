namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_28;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        var patent1 =
            new
            {
                Title = "˫�����۾�",
                YearOfPublication = "1784"
            };

        var patent2 =
            new
            {
                YearOfPublication = "1877",
                Title = "������"
            };

        var patent3 =
            new
            {
                patent1.Title,
                Year = patent1.YearOfPublication
            };

        // ����: �޷�������'AnonymousType#2'��ʽת��Ϊ'AnonymousType#1'
        // patent1 = patent2; // ����ע�ͽ��޷�����

        // ����: �޷�������'AnonymousType#3'��ʽת��Ϊ'AnonymousType#1'
        // patent1 = patent3; // ����ע�ͽ��޷�����

        // ����: �޷�Ϊ���Ի�������'AnonymousType#1.Title'��ֵ -- ����ֻ����
        // patent1.Title = "��ʿ����";  // ����ע�ͽ��޷�����
    }
}
#endregion INCLUDE
