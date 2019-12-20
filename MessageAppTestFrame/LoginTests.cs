using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MessageAppTestFrame
{
    public class TestsLogin
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidLogin()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.ValidEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.SucceesLogin));
                
            }
            finally
            {
                driver.Close();
            }
        
        }
        
        [Test]
        public void LogOut()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.ValidEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                IWebElement logOutButton = driver.FindElement(By.CssSelector(PageObjects.LoginPage.LogOutButtonCCSs));
                logOutButton.Click();
                Thread.Sleep(2000);
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.SuccessLogout));
                Assert.IsFalse(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.SucceesLogin));
            }
            finally
            {
                driver.Close();
            }
                                       
        }

        [Test]
        public void IncorrectEmail()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
            driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
            IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
            casutaEmeail.Clear();
            casutaEmeail.SendKeys(TestData.LoginCredentials.InValidEmail);
            IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
            casutaParola.Clear();
            casutaParola.SendKeys(TestData.LoginCredentials.ValidPassword);
            IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
            loginButton.Click();
            Thread.Sleep(2000);
            string totTextulDePePagina = driver.PageSource;
            Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.InvalidLogin));

            }
            finally 
            {
               driver.Close();
            }
                       
        }

        [Test]
        public void IncorrectPassword()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.ValidEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.InValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                Thread.Sleep(2000);
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.InvalidLogin));

            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void EmptyCredentials()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.EmptyEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.EmptyPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                Thread.Sleep(2000);
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.EmptyEmail));
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.EmptyPassword));
            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void EmptyEmail()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.EmptyEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.EmptyEmail));
            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void EmptyPassword()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.EmptyEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.ValidPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.EmptyPassword));
            }
            finally
            {
                driver.Close();
            }

        }
        
        [Test]
        public void ResetPasswordButton()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement ForgotPasswordButton = driver.FindElement(By.Id(PageObjects.LoginPage.ForgotPasswordButtonID));
                ForgotPasswordButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Thread.Sleep(2000);
               Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.ForgotPasswPage));
            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void SQLInjectionCredentials()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.SQLInjectionEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.SQLInjectionPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.InvalidEmail));

            }
            finally
            {
                driver.Close();
            }

        }

        [Test]
        public void SQLInjectionPassword()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.ValidEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.SQLInjectionPassword);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.InvalidLogin));

            }
            finally
            {
                driver.Close();
            }

        }
        [Test]
        public void SQLInjectionEmail()
        {
            IWebDriver driver = new ChromeDriver(Resources.DriverPaths.ChromeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                driver.Navigate().GoToUrl(Resources.URLList.LoginURL);
                IWebElement casutaEmeail = driver.FindElement(By.Id(PageObjects.LoginPage.EmailTextBoxID));
                casutaEmeail.Clear();
                casutaEmeail.SendKeys(TestData.LoginCredentials.SQLInjectionEmail);
                IWebElement casutaParola = driver.FindElement(By.Id(PageObjects.LoginPage.PasswordTextBoxID));
                casutaParola.Clear();
                casutaParola.SendKeys(TestData.LoginCredentials.ValidEmail);
                IWebElement loginButton = driver.FindElement(By.Id(PageObjects.LoginPage.LoginButtonID));
                loginButton.Click();
                string totTextulDePePagina = driver.PageSource;
                Assert.IsTrue(totTextulDePePagina.Contains(PageObjects.IdentifierForAssert.InvalidEmail));

            }
            finally
            {
                driver.Close();
            }

        }
    }
}