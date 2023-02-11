using TestProjectBuscaCEP.Core;

namespace TestProjectBuscaCEP.Page
{
    public class ValidaCepPage : Begin 
    {

        //Quando preencher o cep especifico
        public void PreencheCep()
        {
            EscreveConteudo("//*[@id='endereco']", "01013001");
        }

        public void ClicaBtnBusca()
        {
            ClicaElemento("//*[@id='btn_pesquisar']");
        }

        //Entao deve ser confirmado que o endereço seja Rua Quinze de Novembro - lado ímpar
        public void ValidaResultado()
        {
            ValidaDados("//*[@id='resultado-DNEC']/tbody/tr/td[1]","Rua Quinze de Novembro - lado ímpar");
        }
    }
}
