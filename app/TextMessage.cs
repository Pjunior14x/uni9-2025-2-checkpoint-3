using System;

namespace ChatbotApp
{
    public class TextoMensagem : Mensagem
    {
        private DateTime dataEnvio;

        public DateTime DataEnvio
        {
            get { return dataEnvio; }
            set { dataEnvio = value; }
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Texto: {TextoMensagem}, Data de Envio: {DataEnvio}");
        }
    }
}