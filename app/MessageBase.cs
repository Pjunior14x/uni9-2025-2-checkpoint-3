using System;

namespace ChatbotApp
{

    public abstract class Mensagem
    {
        private string textoMensagem;

        public string TextoMensagem
        {
            get { return textoMensagem; }
            set { textoMensagem = value; }
        }

        public abstract void ExibirDetalhes();
    }
}