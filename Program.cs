using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var selTest = new LogInPage();
            selTest.NewsLetter();
            selTest.SignIn();

            Console.ReadLine();
        }
    }
}