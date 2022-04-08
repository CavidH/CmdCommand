using System;

namespace CmdCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string command = "ipconfig";
            string command = "ping 192.168.1.254";
            string result = ExecuteCmd.ExecuteCommandSync(command);
            Console.WriteLine(result);
        }
        //static string Command(string CmdCommand)
        //{


        //    Process CommandProcess = new Process();
        //    CommandProcess.StartInfo.FileName = "cmd.exe";
        //    CommandProcess.StartInfo.UseShellExecute = false;
        //    CommandProcess.StartInfo.Arguments = CmdCommand;
        //    CommandProcess.StartInfo.RedirectStandardOutput = true;
        //    CommandProcess.Start();
        //    return CommandProcess.StandardOutput.ReadToEnd();

        //}
    }
}