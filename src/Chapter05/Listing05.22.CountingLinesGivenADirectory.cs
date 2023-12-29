namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_22;

#region INCLUDE
using System.IO;

public static class LineCounter
{
    // 使用第一个实参作为要搜索的目录，
    // 或者默认为当前目录。
    public static void Main(string[] args)
    {
        int totalLineCount = 0;
        string directory;
        if(args.Length > 0)
        {
            directory = args[0];
        }
        else
        {
            directory = Directory.GetCurrentDirectory();
        }
        totalLineCount = DirectoryCountLines(directory);
        Console.WriteLine(totalLineCount);
    }

    #region HIGHLIGHT
    static int DirectoryCountLines(string directory)
    #endregion HIGHLIGHT
    {
        int lineCount = 0;
        foreach(string file in
            Directory.GetFiles(directory, "*.cs"))
        {
            lineCount += CountLines(file);
        }

        foreach(string subdirectory in
            Directory.GetDirectories(directory))
        {
            #region HIGHLIGHT
            lineCount += DirectoryCountLines(subdirectory);
            #endregion HIGHLIGHT
        }

        return lineCount;
    }

    private static int CountLines(string file)
    {
        string? line;
        int lineCount = 0;
        // 可以使用一个using语句改进，但目前还没有讲到
        FileStream stream = new(file, FileMode.Open);
        StreamReader reader = new(stream);
        line = reader.ReadLine();

        while(line != null)
        {
            if(line.Trim() != "")
            {
                lineCount++;
            }
            line = reader.ReadLine();
        }

        reader.Dispose();  // 自动关闭流
        return lineCount;
    }
}
#endregion INCLUDE
