namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_18
{
    using System;
    #region INCLUDE
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static ConsoleLogger;

    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("��ʼ...");
            DoStuff();
            if (args.Any(arg => arg.ToLower() == "-gc"))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            WriteLine("�˳�...");
        }

        public static void DoStuff()
        {
            // ...
            
            WriteLine("��ʼ...");
            SampleUnmanagedResource? sampleUnmanagedResource = null;

            try
            {
                sampleUnmanagedResource =
                    new SampleUnmanagedResource();
                // ʹ�÷��й���Դ
                // ...
            }
            finally
            {
                if (Environment.GetCommandLineArgs().Any(
                arg => arg.ToLower() == "-dispose"))
                {
                    sampleUnmanagedResource?.Dispose();
                }
            }

            WriteLine("�˳�...");

            // ...
        }
    }

    class SampleUnmanagedResource : IDisposable
    {
        public SampleUnmanagedResource(string fileName)
        {
            WriteLine("��ʼ...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WriteLine("�����й���Դ...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
            WriteLine("�������й���Դ...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WeakReference<IDisposable> weakReferenceToSelf =
                 new(this);
            ProcessExitHandler = (_, __) =>
            {
                WriteLine("��ʼ...", "ProcessExitHandler");
                if (weakReferenceToSelf.TryGetTarget(
                    out IDisposable? self))
                {
                    self.Dispose();
                }
                WriteLine("�˳�...", "ProcessExitHandler");
            };
            AppDomain.CurrentDomain.ProcessExit
                += ProcessExitHandler;
            WriteLine("�˳�...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
        }

        // �������˳�ί�д洢�������Ա����Ѿ�����
        // Dispose() or Finalize()��ǰ�����Ƴ���
        private EventHandler ProcessExitHandler { get; }

        public SampleUnmanagedResource()
            : this(Path.GetTempFileName()) { }

        ~SampleUnmanagedResource()
        {
            WriteLine("��ʼ...");
            Dispose(false);
            WriteLine("�˳�...");
        }

        public void Dispose()
        {
            Dispose(true);
            #region EXCLUDE
            // ����ҪΪ�����������ս���
            GC.SuppressFinalize(this);
            #endregion EXCLUDE
        }

        public void Dispose(bool disposing)
        {
            WriteLine("��ʼ...");

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
                WriteLine("����dispose�й���Դ...");
            }

            AppDomain.CurrentDomain.ProcessExit -=
                ProcessExitHandler;

            WriteLine("����dispose���й���Դ...");

            WriteLine("�˳�...");
        }
    }
    #endregion INCLUDE

    public static class ConsoleLogger
    {
        public static void WriteLine(string? message = null, [CallerMemberName] string? name = null)
            => Console.WriteLine($"{$"{name}: " }{ message ?? ": ����ִ��" }");
    }
}
