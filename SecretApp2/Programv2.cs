using System;
using System.Diagnostics;
using static System.Console;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SecretApp2
{
    public partial class Program
    {
        static void sth(string[] args)
        {
            Task autoSetting = new Task(() =>
            {
                var sw = new Stopwatch();
                var wtc = new WantToChange();

                if (sw.ElapsedMilliseconds > 5000)
                {
                    wtc.Set(false);
                }
                wtc.ReturnBool();
            });
        
        
            Task manaulSetting = new Task(() =>
            {
                string wcS = ReadLine();
                var wtc = new WantToChange();

                if (wcS == "1")
                {
                    wtc.Set(true);
                }
                else if (wcS == "0")
                {
                    wtc.Set(false);
                }
                else
                {
                    WriteLine("Incorrect input. Restarting App");
                //Process.Start
                System.Environment.Exit(0);
                }
                wtc.ReturnBool();
            });
        }
    }
}
