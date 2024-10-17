// Remove unused parameter disabled for elucidation.
#pragma warning disable IDE0060
using Chapter10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12;

#region INCLUDE
/// <summary>
/// DataStorage���������ļ��д洢�ͼ���Ա������
/// </summary>
class DataStorage
{
    /// <summary>
    /// ��Ա�����󱣴浽��Ա�������������ļ���    
    /// </summary>
    /// <remarks>
    /// �÷���ʹ��<seealso cref="System.IO.FileStream"/>
    /// �Լ�
    /// <seealso cref="System.IO.StreamWriter"/>
    /// </remarks>
    /// <param name="employee">
    /// Ҫ�洢���ļ��е�Ա��</param>
    /// <date>January 1, 2000</date>
    public static void Store(Employee employee)
    {
        // ...
    }

    /** <summary>
     * ����Ա������
     * </summary>
     * <remarks>
     * �÷���ʹ��<seealso cref="System.IO.FileStream"/>
     * �Լ�
     * <seealso cref="System.IO.StreamReader"/>
     * </remarks>
     * <param name="firstName">
     * Ա�������֣�first name��</param>
     * <param name="lastName">
     * Ա�������ϣ�last name��</param>
     * <returns>
     * ��������Ӧ��Ա������
     * </returns>
     * <date>January 1, 2000</date> **/
    public static Employee Load(string firstName, string lastName)
    {
        #region EXCLUDE
        return new Employee();
        #endregion EXCLUDE
    }
}

class Program
{
    // ...
}
#endregion INCLUDE
