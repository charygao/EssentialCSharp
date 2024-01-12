// Justification: Implementation is incomplete in the catch block.
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_15;

using System;
#region INCLUDE
using System.IO;

public class TemporaryFileStream
{
    public TemporaryFileStream(string fileName)
    {
        File = new FileInfo(fileName);
        // 更好的方案是使用FileOptions.DeleteOnClose
        Stream = new FileStream(
            File.FullName, FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
    }

    public TemporaryFileStream()
        : this(Path.GetTempFileName())
    { }

    #region HIGHLIGHT
    // 终结器
    ~TemporaryFileStream()
    {
        try
        {
            Close();
        }
        catch (Exception )
        {
            // 将事件写入日志或UI
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
