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
        static bool AutoSet()
        {            
                var sw = new Stopwatch();
                var wtc = new WantToChange();

                for (int i = 5; i >= 0; i--)
                {
                    WriteLine($"Time left: {i}s");
                    if (sw.ElapsedMilliseconds > 5000)
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                }
            return wtc.ReturnBool();
        }
        
        static bool ManaualSet()
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

            return wtc.ReturnBool();
        }

        static void ShutDownTheOtherTask()
        {

        }
    }
}
