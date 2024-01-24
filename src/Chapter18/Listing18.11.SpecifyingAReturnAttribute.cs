namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11;

public class Program
{
#pragma warning disable CA1822 // ����Ա���Ϊstatic
    #region INCLUDE
    [return: Description(
       "�����������Ч״̬���ͷ���true��")]
    public bool IsValid()
    {
        // ...
        return true;
    }
    #endregion INCLUDE
#pragma warning restore CA1822 // ����Ա���Ϊstatic
}

public class DescriptionAttribute : Attribute
{
    private readonly string _Description;
    public string Description { get { return _Description; } }

    public DescriptionAttribute(string description)
    {
        this._Description = description;
    }
}