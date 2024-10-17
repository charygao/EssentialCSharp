using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "enumtest.txt";

        // ȷ���ļ�����
        if (!File.Exists(filePath))
        {
            // ����ļ������ڣ������ļ�
            using (var stream = File.Create(filePath)) { }
            Console.WriteLine($"�Ѵ���{filePath}��");
        }

        var file = new FileInfo(filePath);

        try
        {
            // ��ȡ��ʼ�ļ�����
            FileAttributes startingAttributes = file.Attributes;
            Console.WriteLine($"��ʼ�ļ�����: {startingAttributes}");

            // �����ļ�����Ϊ���غ�ֻ��
            file.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
            Console.WriteLine($"�ѽ��ļ�������Ϊ: {file.Attributes}");

            // �޸���ʾЧ���������Ÿ�Ϊ����
            Console.WriteLine("ԭ�����\"{1}\"���滻Ϊ\"{0}\"��",
                file.Attributes.ToString().Replace(",", " |"),
                file.Attributes);
        }
        catch (IOException e)
        {
            Console.WriteLine($"����I/O����: {e.Message}");
        }

        // ɾ���ļ�ǰ�����������ֻ������
        file.Attributes &= ~FileAttributes.ReadOnly;

        // ɾ���ļ�
        file.Delete();
        Console.WriteLine($"�ļ�{filePath}��ɾ����");
    }
}
