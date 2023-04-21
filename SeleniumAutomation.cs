using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumAutomation;
public class SelTest
{
    private readonly IWebDriver _driver;
    // private enum AccountFields
    // {
    //     Email,
    //     Name,
    //     Surname,
    //     Company,
    //     Profession
    // }
    public SelTest()
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
        SendKeys(name, "Placeholder");
        
        var email = _driver.FindElement(By.Name("et_pb_contact_email_0"));
        SendKeys(email, "placeholder@test.com");
    }

    private void ClickSubmit()
    {
        Thread.Sleep(1000);
        var submit =
            _driver.FindElement(
                By.CssSelector("button[name='et_builder_submit_button'][class='et_pb_contact_submit et_pb_button']"));
        submit.Click();
    }

    public void ClickLogin()
    {
        var loginButton = _driver.FindElement(By.CssSelector(
            "a[class='et_pb_button et_pb_promo_button'][href='https://courses.ultimateqa.com/users/sign_in']"));
        loginButton.Click();
        Thread.Sleep(2000);
    }

    public void FillCredentials()
    {
        var email = _driver.FindElement(By.Name("user[email]"));
        SendKeys(email, "placeholder@test.com");

        var password = _driver.FindElement(By.Name("user[password]"));
        SendKeys(password, "seleniumTest23!");
    }

    public void ClickSignIn()
    {
        Thread.Sleep(1000);
        var signInButton =
            _driver.FindElement(By.CssSelector("button[class='button button-primary g-recaptcha'][type='submit']"));
        signInButton.Click();
    }

    public void SignOut()
    {
        ClickOnDropDown();
        var signOut = _driver.FindElement(By.CssSelector("a[href='/users/sign_out']"));
        signOut.Click();
        Thread.Sleep(2000);
        _driver.Quit();
    }

    private void ClickOnDropDown()
    {
        var dropDown = _driver.FindElement(By.CssSelector("i.fa.fa-caret-down[aria-hidden='true']"));
        dropDown.Click();
    }

    // public void FillUserData()
    // {
    //     ClickOnDropDown();
    //     var accountInfo = _driver.FindElement(By.CssSelector("a[href='/account']"));
    //     accountInfo.Click();
    //     
    //     var parentDiv = _driver.FindElement(By.CssSelector("div[class='my-account__form-contents']"));
    //     ReadOnlyCollection<IWebElement> childDivs = parentDiv.FindElements(By.CssSelector("div[class='form__group']"));
    //     //var childDivs = parentDiv.FindElements(By.CssSelector("div[class='form__group']"));
    //
    //     foreach (var childDiv in childDivs)
    //     {
    //         ReadOnlyCollection<IWebElement> formElements = childDiv.FindElements(By.CssSelector("input"));
    //
    //         foreach (var formElement in formElements)
    //         {
    //             var emailInput = formElement.FindElement(By.CssSelector("input[type='email'][id='user[email]']"));
    //             emailInput.Clear();
    //             SendKeys(emailInput, "p.holder@test.com");
    //             
    //             var nameInput = formElement.FindElement(By.Id("user[first_name]"));
    //             nameInput.Clear();
    //             SendKeys(nameInput, "Mario");
    //             
    //             var surnameInput = formElement.FindElement(By.Id("user[last_name]"));
    //             surnameInput.Clear();
    //             SendKeys(surnameInput, "Super");
    //             
    //             var companyInput = formElement.FindElement(By.Id("user[profile_attributes][company]"));
    //             SendKeys(companyInput, "Codermine");
    //             
    //             var professionInput = formElement.FindElement(By.Id("user[profile_attributes][profession]"));
    //             SendKeys(professionInput, "Trying to be a developer");
    //         }
    //     }
    // }

    public void FillUserData()
    {
        ClickOnDropDown();
        var accountInfo = _driver.FindElement(By.CssSelector("a[href='/account']"));
        accountInfo.Click();
        
        var emailInput = _driver.FindElement(By.CssSelector("input[type='email'][id='user[email]']"));
        emailInput.Clear();
        SendKeys(emailInput, "p.holder@gmail.com");
        
        var nameInput = _driver.FindElement(By.Id("user[first_name]"));
        nameInput.Clear();
        SendKeys(nameInput, "Mario");
        
        var surnameInput = _driver.FindElement(By.Id("user[last_name]"));
        surnameInput.Clear();
        SendKeys(surnameInput, "Super");
        
        var companyInput = _driver.FindElement(By.Id("user[profile_attributes][company]"));
        SendKeys(companyInput, "Codermine");
        
        var professionInput = _driver.FindElement(By.Id("user[profile_attributes][headline]"));
        SendKeys(professionInput, "Trying to be a developer");
    }
    
    /*public void FillUserData()
    {
        ClickOnDropDown();
        var accountInfo = _driver.FindElement(By.CssSelector("a[href='/account']"));
        accountInfo.Click();
        
        var parentDiv = _driver.FindElement(By.CssSelector("div[class='my-account__form-contents']"));
        
        IList<IWebElement> childDivs = parentDiv.FindElements(By.CssSelector("div[class='form__group']"));
        
        foreach(var childDiv in childDivs)
        {
            IList<IWebElement> userDataForms = childDiv.FindElements(By.CssSelector("input"));

            foreach (var userDataForm in userDataForms)
            {
                //var field = (AccountFields)Enum.Parse(typeof(AccountFields), userDataForm.GetAttribute("name"));
                var field = Enum.Parse<AccountFields>(userDataForm.GetAttribute("name"));
                

                switch (field)
                {
                    case AccountFields.Email:
                        var email = userDataForm.FindElement(By.CssSelector("input[data-field='email']"));
                        email.Clear();
                        SendKeys(email, "placeholder@test.com");
                        break;
                    
                    case AccountFields.Name:
                        //userDataForm.FindElement(By.CssSelector("input[name='user[first_name]']")).SendKeys("Mario");
                        userDataForm.SendKeys("Mario");
                        break;

                    case AccountFields.Surname:
                        //userDataForm.FindElement(By.CssSelector("input[name='user[last_name]']")).SendKeys("Brescia");
                        userDataForm.SendKeys("Brescia");
                        break;

                    case AccountFields.Company:
                        //userDataForm.FindElement(By.CssSelector("input[name='user[profile_attributes][company]']")).SendKeys("Codermine");
                        userDataForm.SendKeys("Codermine");
                        break;
                    
                    case AccountFields.Profession:
                        //userDataForm.FindElement(By.CssSelector("input[name='user[profile_attributes][headline]']")).SendKeys("Trying to be a developer");
                        userDataForm.SendKeys("Trying to be a developer");
                        break;
                }
            }
        }
    }*/
    
    private static void SendKeys(IWebElement element, string text)
    { 
        element.SendKeys(text);
    }
}