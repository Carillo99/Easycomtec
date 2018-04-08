using ConversorDistancias.Testes;
using NUnit.Framework;

namespace Easycomtec.Tests.Selenium
{
    [TestFixture]
    class Example
    {
        private TelaConversaoDistancias _tela;

        [SetUp]

        public void Inicializar()
        {
            _tela = new TelaConversaoDistancias(Browser.Chrome);
            _tela.CarregarPagina();
        }

        [TestCase("gleissoncarillo@gmail.com","Colcic@2018")]
        public void Validar(string email, string password)
        {
            _tela.PreencherLogin(email, password);
            _tela.ProcesssarLogin();

        }

        public void Finalizar()
        {
            _tela.Fechar();
        }

    }
}
