// ˵�� : Implementation is incomplete in the catch block.
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_15;

using System;
#region INCLUDE
using System.IO;

public class TemporaryFileStream
{
    public TemporaryFileStream(string fileName)
    {
        File = new FileInfo(fileName);
        // ���õķ�����ʹ��FileOptions.DeleteOnClose
        Stream = new FileStream(
            File.FullName, FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
    }

    public TemporaryFileStream()
        : this(Path.GetTempFileName())
    { }

    #region HIGHLIGHT
    // �ս���
    ~TemporaryFileStream()
    {
        try
        {
            Close();
        }
        catch (Exception )
        {
            // ���¼�д����־��UI
            // ...
        }
    }
    #endregion HIGHLIGHT

    public FileStream? Stream { get; private set; }
    public FileInfo? File { get; private set; }

    public void Close()
    {
        Stream?.Dispose();
        try
        {
            File?.Delete();
        }
        catch(IOException exception)
        {
            Console.WriteLine(exception);
        }
        Stream = null;
        File = null;
    }
}
#endregion INCLUDE
