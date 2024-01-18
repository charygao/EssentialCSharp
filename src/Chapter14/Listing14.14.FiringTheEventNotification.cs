namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_14;

using System;
#region INCLUDE
public class Thermostat
#region EXCLUDE
{
    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }

    // �����¼�������
    public event EventHandler<TemperatureArgs> OnTemperatureChange =
        delegate { };
    #endregion EXCLUDE

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if(value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                // ��������κζ����ߣ��͵���
                // ����ע���ί�У����¶ȵı仯
                // ֪ͨ���ǡ�
                #region HIGHLIGHT
                OnTemperatureChange?.Invoke(
                      this, new TemperatureArgs(value));
                #endregion HIGHLIGHT
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE
