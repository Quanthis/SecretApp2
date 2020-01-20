using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace SecretApp2
{
    public class Threads
    {
        int n = 0;

        public Threads(int no)
        {
            n = no;
        }

        public void Launch(int start, int end, string[] links2)
        {
            Thread t1 = new Thread(() =>
            {
                try
                {
                    for (int i = start; i < end / 2; i++)
                    {
                        WriteLine($"W lini {i} odczytano link: {links2[i]}");
                        System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--incognito " + links2[i]);

                        if (i % 4 == 0)
                        {
                            Thread.Sleep(5000);
                            WriteLine("Enter by odtworzyć 4 kolejne");
                            ReadLine();
                        }
                    }
                }
                catch(Exception ex)
                {
                    WriteLine("Error code:" + ex);
                }
            });

            Thread t2 = new Thread(() =>
            {
                try
                {
                    for (int i = end / 2; i <= end; i++)
                    {
                        WriteLine($"W lini {i} odczytano link: {links2[i]}");
                        System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "--incognito " + links2[i]);

                        if (i % 4 == 0)
                        {
                            Thread.Sleep(5000);
                            WriteLine("Enter by odtworzyć 4 kolejne");
                            ReadLine();
                        }
                    }
                }
                catch(Exception ex)
                {
                    WriteLine("Error code: " + ex);
                }                
            });

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
