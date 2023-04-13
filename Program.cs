namespace SelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var selTest = new SeleniumAutomation();
            selTest.SecondPage();
            selTest.NewsLetter();
            selTest.SignIn();
            selTest.SignOut();
            
            Console.ReadLine();
        }
    }
}