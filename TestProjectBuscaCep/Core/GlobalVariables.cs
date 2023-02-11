using OpenQA.Selenium;

namespace TestProjectBuscaCEP.Core
{
    public class GlobalVariables
    {
        // Define 'driver' como trigger para os WebElements
        public IWebDriver driver;

        //Define 'fechar navegador ao final do teste' como padrão
        public bool driverQuit = true;
    }
}
