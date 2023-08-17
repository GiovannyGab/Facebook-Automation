
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class Program
{

    //Criando a referencia pro crhome browser
    IWebDriver driver = new ChromeDriver();


    [SetUp]
    public void Initialize()
    {

        //Indo para a pagina do Facebook
        driver.Navigate().GoToUrl("https://www.facebook.com/");
       
    }

    [Test]
    public void ExecuteTest()
    {
        try
        {
            //fazendo o browser ficar em fullscreen
            driver.Manage().Window.Maximize();
            

            IWebElement createAccount = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div[1]/form/div[5]/a"));
            createAccount.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            //tela de  login
            IWebElement FristName = driver.FindElement(By.Name("firstname"));
            IWebElement NickName = driver.FindElement(By.Name("lastname"));
            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            IWebElement emailValidation = driver.FindElement(By.Name("reg_email_confirmation__"));

            IWebElement password = driver.FindElement(By.Id("password_step_input"));

            FristName.SendKeys("Terice");
            NickName.SendKeys("Tapic");
            email.SendKeys("TericeTapic@gmail.com");
            emailValidation.SendKeys("TericeTapic@gmail.com");
            password.SendKeys("tericeTerice");

            IWebElement day = driver.FindElement(By.Id("day"));
            IWebElement month = driver.FindElement(By.Id("month"));
            IWebElement year = driver.FindElement(By.Id("year"));

            var selectElementDay = new SelectElement(day);
            var selectElementMonth = new SelectElement(month);
            var selectElementYear = new SelectElement(year);

            selectElementDay.SelectByValue("23");
            selectElementMonth.SelectByValue("4");
            selectElementYear.SelectByValue("2003");

            IWebElement genderInput = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[2]/input"));

            genderInput.Click();


            IWebElement buttonRegister = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[11]/button"));
            buttonRegister.Click();


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    [TearDown]
    public void CloseProgram()
    {
        //fechando a tela
        //driver.Quit();
    }


}





