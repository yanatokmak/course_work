using System.IO;

namespace course_work
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Автоматически создаём папку Photos при запуске программы
            CreatePhotosDirectory();

            // Запускаем главное окно приложения
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        // Метод для создания папки Photos
        private static void CreatePhotosDirectory()
        {
            // Получаем путь к папке Photos рядом с вашим приложением
            string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Photos");

            // Проверяем, существует ли папка
            if (!Directory.Exists(photosDirectory))
            {
                // Если не существует, создаём её
                Directory.CreateDirectory(photosDirectory);
            }
        }
    }
}
