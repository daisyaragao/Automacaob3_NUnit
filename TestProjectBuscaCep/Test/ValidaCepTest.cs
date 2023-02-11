using NUnit.Framework;
using TestProjectBuscaCEP.Page;

namespace TestProjectBuscaCEP.Test
{
    public class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep()
        {
            PreencheCep();
            ClicaBtnBusca();
            ValidaResultado();
        
        }
    }
}
