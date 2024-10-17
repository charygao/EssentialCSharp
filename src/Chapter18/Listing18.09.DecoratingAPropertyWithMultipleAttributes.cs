namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_09;

public class CommandLineInfo
{
    [CommandLineSwitchAlias("?")]
    public bool Help { get; set; }

    //Two Ways to do it
    //[CommandLineSwitchRequired]
    //[CommandLineSwitchAlias("FileName")]
    #region INCLUDE
    [CommandLineSwitchRequired, CommandLineSwitchAlias("FileName")]
    public string? Out { get; set; }

    public System.Diagnostics.ProcessPriorityClass Priority
        { get; set; } = 
            System.Diagnostics.ProcessPriorityClass.Normal;
}
#endregion INCLUDE

// ��ֹ���棬������δʵ�֣�����δ������н���
#pragma warning disable CA1018 // ��AttributeUsageAttribute�������
internal class CommandLineSwitchRequiredAttribute : Attribute
{
    // δʵ��
}

internal class CommandLineSwitchAliasAttribute : Attribute
{
    public CommandLineSwitchAliasAttribute(string _)
    {
        // δʵ��
    }
}
