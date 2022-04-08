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
    }
}