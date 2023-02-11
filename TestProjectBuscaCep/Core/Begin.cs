using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace TestProjectBuscaCEP.Core
{

    public class Begin : DSL 
    {
   
        [SetUp]

        public void InicioTeste()
        {
        //PRE-CONDIÇÕES

            //Dado que esteja acessando o busca cep dos correios
            driver = new ChromeDriver();

            //Dado que esteja acessando o rastreamento dos correios
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
            driverQuit = false;
        }


        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }


    }
}

