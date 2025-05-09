using System.Diagnostics;

public class ADBHelper
{
    private string RunAdbCommand(string arguments)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return output;
    }

    public string GetContacts()
    {
        return RunAdbCommand("shell content query --uri content://contacts/phones/");
    }

    public string GetSMS()
    {
        return RunAdbCommand("shell content query --uri content://sms/");
    }

    public string GetCallLogs()
    {
        return RunAdbCommand("shell content query --uri content://call_log/calls/");
    }

    public string GetCPUInfo()
    {
        return RunAdbCommand("shell cat /proc/cpuinfo");
    }

    public string GetMemoryInfo()
    {
        return RunAdbCommand("shell cat /proc/meminfo");
    }
}
