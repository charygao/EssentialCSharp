namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_07;

delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

public class Program
{
    private static readonly TemperatureChangedHandler OnTemperatureChanged = delegate { };

    public void Main()
    {
        #region INCLUDE
        // ���̰߳�ȫ
        #region HIGHLIGHT
        if (OnTemperatureChanged is not null)
        #endregion HIGHLIGHT
        {
            // �������ж����˸��¼��Ķ�����
            OnTemperatureChanged(
                this, new TemperatureEventArgs(value));
        }
        #endregion INCLUDE
    }

    // ����ʹ��Сд��value��Ϊ��������
    // ��ģ��setter�е�value�ؼ��֡�
    #pragma warning disable IDE1006 // �������
    public object? value { get; set; }
    #pragma warning restore IDE1006 // �������
}

class TemperatureEventArgs
{
    public TemperatureEventArgs(object? _)
    {
        // ...
    }
}
