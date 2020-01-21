﻿using System;
using System.Diagnostics;
using static System.Console;
using System.IO;
using System.Threading;
using static System.Convert;
using System.Threading.Tasks;

namespace SecretApp2
{
    public partial class Program
    {    
        static void Main(string[] args)
        {
            WriteLine("Do you want to edit path to your file? Press 1. Leave default? Press 0 or wait...");

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

            autoSetting.Start();
            Task.Delay(5000);
            autoSetting.Wait();
            //manaulSetting.Start();

            string path = "";


            WriteLine("Press enter if you are sure you want to proceed. ");
            ReadLine();
                       
            int i = 0;            
            int n = 0;
            
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        sr.ReadLine();
                        n++;
                    }
                }
                WriteLine("N is equal to:" + n);
            }
            catch(Exception ex)
            {
                WriteLine("Wait what?");
            }

            string[] links2 = new string[n];

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        links2[i] = sr.ReadLine();
                        i++;
                    }                    
                }
            }
            catch(Exception ex)
            {
                WriteLine("Error code: " + ex);
            }
            
            var t0i1 = new Threads(0);
            t0i1.Launch(0, links2.Length, links2);
        }
    }
}