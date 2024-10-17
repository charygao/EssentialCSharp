namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17;

#region INCLUDE
public class Thermostat
{
    public class TemperatureArgs : System.EventArgs
    #region EXCLUDE
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }
 
    // ����ί����������
    public delegate void EventHandler<TemperatureArgs>(
        object sender, TemperatureArgs newTemperature);
    #endregion EXCLUDE
    #region HIGHLIGHT
    // �����¼�������
    public event EventHandler<TemperatureArgs> OnTemperatureChange
    {
        add
        {
            _OnTemperatureChange = 
                (EventHandler<TemperatureArgs>)
                    System.Delegate.Combine(value, _OnTemperatureChange);
        }
        remove
        {
            _OnTemperatureChange = 
                (EventHandler<TemperatureArgs>?)
                    System.Delegate.Remove(_OnTemperatureChange, value);
        }
    }
    protected EventHandler<TemperatureArgs>? _OnTemperatureChange;
    #endregion HIGHLIGHT

    public float CurrentTemperature
    #region EXCLUDE
    {
        set
        {
            if (value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                // ��������κζ����ߣ��͵���
                // ����ע���ί�У����¶ȵı仯
                // ֪ͨ���ǡ�
                _OnTemperatureChange?.Invoke( // C# 6.0
                      this, new TemperatureArgs(value));
            }
        }
        get { return _CurrentTemperature; }
    }
    #endregion EXCLUDE
    private float _CurrentTemperature;
}
#endregion INCLUDE
