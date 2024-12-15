using System.IO;

namespace course_work
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ������������� ������ ����� Photos ��� ������� ���������
            CreatePhotosDirectory();

            // ��������� ������� ���� ����������
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        // ����� ��� �������� ����� Photos
        private static void CreatePhotosDirectory()
        {
            // �������� ���� � ����� Photos ����� � ����� �����������
            string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Photos");

            // ���������, ���������� �� �����
            if (!Directory.Exists(photosDirectory))
            {
                // ���� �� ����������, ������ �
                Directory.CreateDirectory(photosDirectory);
            }
        }
    }
}
