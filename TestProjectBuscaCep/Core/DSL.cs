﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProjectBuscaCEP.Core
{
    public class DSL : GlobalVariables
    {
        public void EscreveConteudo(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
    }
}
