using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /// <summary>
    /// Helper class 
    /// </summary>
    public static class Features
    {
        /// <summary>
        /// Method returns current server time
        /// </summary>
        /// <returns>Return current server time as String</returns>
        public static string GetServerTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
        public static string GetServerTime2()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
