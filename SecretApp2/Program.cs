using System;
using System.Diagnostics;
using static System.Console;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SecretApp2
{
    class Program
    {

        public static void ThreadsWork(int start, int end, string[]links2)
        {
            try
            {
                Task T = new Task(() =>
                {
                    for (int i = start; i < end / 2; i++)
                    {
                        WriteLine($"W lini {i} odczytano link: {links2[i]}");
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--incognito " + links2[i]);

                        if (i % 4 == 0)
                        {
                            Thread.Sleep(5000);
                            WriteLine("Enter by odtworzyć 4 kolejne");
                            ReadLine();
                        }
                    }
                });
                T.Start();
                   
            
                Task T2 = new Task(() =>
                {
                    for (int i = end/2; i <= end; i++)
                    {
                        WriteLine($"W lini {i} odczytano link: {links2[i]}");
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--incognito " + links2[i]);

                        if (i % 4 == 0)
                        {
                            Thread.Sleep(5000);
                            WriteLine("Enter by odtworzyć 4 kolejne");
                            ReadLine();
                        }
                    }
                });
                T2.Start();
                T.Wait();
                T2.Wait();
            }
            catch (Exception ex)
            {
                WriteLine("Error code:" + ex);
            }            
        }



        static void Main(string[] args)
        {
            WriteLine("Press enter if you are sure you want to proceed. ");
            ReadLine();
                       
            var path = @"C:\tmp\Linki\Nowy.txt.";
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

            ThreadsWork(0, links2.Length, links2);   
        }
    }
}