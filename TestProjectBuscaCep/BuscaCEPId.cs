using NUnit.Framework;
using OpenQA.Selenium;
using TestProjectBuscaCEP.Core;

namespace TestProjectBuscaCEP
{
    class BuscarCep : Begin

    {
        [Test]

        public void Teste()
        {
            //Quando preencher o cep especifico 
            driver.FindElement(By.Id("endereco")).SendKeys("80700000");

            //Entao deve ser confirmado que o CEP não existe e voltar para tela inicial
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");
            driver.Manage().Window.Maximize();
        }
    }
}