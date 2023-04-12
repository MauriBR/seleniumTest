namespace SelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var selTest = new SeleniumAutomation();
            selTest.NewsLetter();
            selTest.SignIn();

            Console.ReadLine();
        }
    }
}
