namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ...
        dynamic data =
          "Hello!  My name is Inigo Montoya";
        Console.WriteLine(data);
        data = (double)data.Length;
        data = data * 3.5 + 28.6;
        if(data == 2.4 + 112 + 26.2)
            // ��;�������Ironman Triathlon�����������������ֵ�����̣�
            // ��Ӿ��2.4Ӣ�Լ3.86���
            // ���г����У�112Ӣ�Լ180.25���
            // �ܲ���26.2Ӣ���һ�������ɾ��룬Լ42.2���
        {
            Console.WriteLine(
                $"{data}Ӣ����ǳ�;�������������̡�");
        }
        else
        {
            // ���·��������ڣ�������ʱ������
            data.NonExistentMethodCallStillCompiles();
        }
        // ...
        #endregion INCLUDE
    }
}
