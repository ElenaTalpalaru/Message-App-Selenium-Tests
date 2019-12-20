using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MessageAppTestFrame
{
    public class RegisterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidRegistration()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.RegisterURL);
                IWebElement casutaEmail = driver.FindElement(By.Id(PageObjects.RegistrationPage.emailBoxID));
                casutaEmail.Clear();
                casutaEmail.SendKeys(TestData.RegistrationCredentials.RegValidEmail);
                IWebElement casutaPassword = driver.FindElement(By.CssSelector(PageObjects.RegistrationPage.passwordBoxCSS));
                casutaPassword.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement confirmarePassword = driver.FindElement(By.Id(PageObjects.RegistrationPage.confirmPaswwBoxId));
                confirmarePassword.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement registerButton = driver.FindElement(By.Id(PageObjects.RegistrationPage.registerButtonID));
                registerButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.AssertIdeRegister.RegisterConf));

            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void UserLessThan8()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();

            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.RegisterURL);
                IWebElement casutaEmail = driver.FindElement(By.Id(PageObjects.RegistrationPage.emailBoxID));
                casutaEmail.Clear();
                casutaEmail.SendKeys(TestData.RegistrationCredentials.EmailLessThan8);
                IWebElement casutaPassword = driver.FindElement(By.CssSelector(PageObjects.RegistrationPage.passwordBoxCSS));
                casutaPassword.SendKeys(TestData.RegistrationCredentials.ValidPassword);
                IWebElement confirmarePassword = driver.FindElement(By.Id(PageObjects.RegistrationPage.confirmPaswwBoxId));
                confirmarePassword.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement registerButton = driver.FindElement(By.Id(PageObjects.RegistrationPage.registerButtonID));
                registerButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsFalse(totTextulDePePagina.Contains(PageObjects.AssertIdeRegister.RegisterConf));
            
            }

            catch (AssertionException UserLess8)
            {
                IWebElement confirmAccountLink = driver.FindElement(By.CssSelector(PageObjects.RegistrationPage.confirmAccountLinkCSS));
                confirmAccountLink.Click();
                IWebElement LoginLink = driver.FindElement(By.CssSelector(PageObjects.RegistrationPage.loginLinkCSS));
                LoginLink.Click();
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.RegistrationCredentials.EmailLessThan8);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.RegistrationCredentials.ValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                IWebElement myAccountLink = driver.FindElement(By.CssSelector(PageObjects.ManageAccount.goToMyAccountCss));
                myAccountLink.Click();
                IWebElement personalDataLink = driver.FindElement(By.Id(PageObjects.ManageAccount.personalDataID));
                personalDataLink.Click();
                IWebElement deleteButton = driver.FindElement(By.Id(PageObjects.ManageAccount.deleteButtonID));
                deleteButton.Click();
                IWebElement deletePassword = driver.FindElement(By.Id(PageObjects.ManageAccount.casutadeletePassdID));
                deletePassword.SendKeys(TestData.RegistrationCredentials.ValidPassword);
                IWebElement confDeleteAccountButton = driver.FindElement(By.CssSelector(PageObjects.ManageAccount.confDeleteAccButtonCss));
                confDeleteAccountButton.Click();
                
            }
             finally
            {
                driver.Close();
            }

           
        }
    }

}