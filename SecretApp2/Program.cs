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
        static void Main(string[] args)
        {
            WriteLine("Press enter if you are sure you want to proceed. ");
            ReadLine();
                       
            var path = @"C:\tmp\tmp2\cos.txt.";
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