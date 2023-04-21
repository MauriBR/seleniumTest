namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            var selTest = new SeleniumAutomation.SelTest();
            //selTest.SecondPage();
            selTest.NewsLetter();
            selTest.SignIn();
            selTest.FillUserData();
            //selTest.SignOut();
            
            
            Console.ReadLine();
        }
    }
}