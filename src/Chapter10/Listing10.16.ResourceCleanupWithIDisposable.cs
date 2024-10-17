namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_16;

#region INCLUDE
using System;
using System.IO;

public static class Program
{
    // ...
    public static void Search()
    {
        TemporaryFileStream fileStream =
            new();

        // ʹ����ʱ�ļ���
        // ...

        #region HIGHLIGHT
        fileStream.Dispose();
        #endregion HIGHLIGHT

        // ...
    }
}

class TemporaryFileStream : IDisposable
{
    public TemporaryFileStream(string fileName)
    {
        File = new FileInfo(fileName);
        Stream = new FileStream(
            File.FullName, FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
    }

    public TemporaryFileStream()
        : this(Path.GetTempFileName()) { }

    ~TemporaryFileStream()
    {
        #region HIGHLIGHT
        Dispose(false);
        #endregion HIGHLIGHT
    }

    public FileStream? Stream { get; private set; }
    public FileInfo? File { get; private set; }

    #region IDisposable Members
    #region HIGHLIGHT
    public void Dispose()
    {
        Dispose(true);

        // ȡ�����ս���еĵǼǣ���ʱ�������ս�����
        System.GC.SuppressFinalize(this);
    }
    #endregion HIGHLIGHT
    #endregion
    #region HIGHLIGHT
    public void Dispose(bool disposing)
    {
        // ��ƹ淶������Ϊ�Դ��ս����Ķ������Dispose()���෴�������ս��������ʵ����
        // ����Ľ����ǣ�����Dispose����ʱ�����disposing����Ϊfalse��
        // ��ô�����������ս������õģ�������ͨ�����������ʽ���õġ�
        // ����������£�Ӧ��ֻ������й���Դ�������ļ�������Ϊ�����ռ���
        // ���Զ������й���Դ����������жϺ󣬿��Ա������ս�����Dispose
        // ����֮�䷢����Դ�ظ���������⡣
        // ��֮������disposingΪtrue��ʱ����ͷ��й���Դ���������κ�ʱ��
        // ֻ�ͷŷ��й���Դ�������Disposeģʽ����ȷ���ơ�
        if (disposing)
        {
            Stream?.Dispose();
        }
    #endregion HIGHLIGHT
        try
        #region HIGHLIGHT
        {
            File?.Delete();
        }
        #endregion HIGHLIGHT
        catch (IOException exception)
        #region HIGHLIGHT
        {
            Console.WriteLine(exception);
        }
        #endregion HIGHLIGHT
        Stream = null;
        File = null;
    }
}
#endregion INCLUDE
