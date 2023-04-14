using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
public class SeleniumAutomation
{
    private readonly IWebDriver _driver;
    public SeleniumAutomation()
    {
        _driver = new FirefoxDriver();
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

    }
    public void SecondPage()
    {
        var button = _driver.FindElement(By.Id("button1"));
        button.Click();
        Thread.Sleep(2000);
        
        var alert = _driver.SwitchTo().Alert();
        alert.Accept();
        Thread.Sleep(2000);
        
        _driver.Navigate().Back();
    }
    public void NewsLetter()
    {
        FillNewsletter();
        Thread.Sleep(1000);
        ClickSubmit();
    }
    public void SignIn()
    {
        ClickLogin();
        FillCredentials();
        Thread.Sleep(2000);
        ClickSignIn();
    }
    
    private void FillNewsletter()
    {
        var name = _driver.FindElement(By.Name("et_pb_contact_name_0"));
        name.SendKeys("Placeholder");
        var email = _driver.FindElement(By.Name("et_pb_contact_email_0"));
        email.SendKeys("placeholder@test.com");
    }

    private void ClickSubmit()
    {
        Thread.Sleep(1000);
        var submit = _driver.FindElement(By.CssSelector("button[name='et_builder_submit_button'][class='et_pb_contact_submit et_pb_button']"));
        submit.Click();
    }
    
    public void ClickLogin()
    {
        var loginButton = _driver.FindElement(By.CssSelector("a[class='et_pb_button et_pb_promo_button'][href='https://courses.ultimateqa.com/users/sign_in']"));
        loginButton.Click();
        Thread.Sleep(2000);
    }
    
    public void FillCredentials()
    {
        var email = _driver.FindElement(By.Name("user[email]"));
        email.SendKeys("placeholder@test.com");

        var password = _driver.FindElement(By.Name("user[password]"));
        password.SendKeys("seleniumTest23!");
    }

    public void ClickSignIn()
    {
        Thread.Sleep(1000);
        var signInButton = _driver.FindElement(By.CssSelector("button[class='button button-primary g-recaptcha'][type='submit']"));
        signInButton.Click();
    }
    
    public void SignOut()
    {
        Thread.Sleep(2000);
        var dropDown = _driver.FindElement(By.CssSelector("i.fa.fa-caret-down[aria-hidden='true']"));
        dropDown.Click();
        Thread.Sleep(2000);
        var signOut = _driver.FindElement(By.CssSelector("a[href='/users/sign_out']"));
        signOut.Click();
        Thread.Sleep(2000);
        _driver.Quit();
    }
}
