using System;

namespace ChatbotApp
{
    public class FotoMensagem : Mensagem
    {
        private string arquivo;
        private string formato;

        public string Arquivo
        {
            get { return arquivo; }
            set { arquivo = value; }
        }

        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Foto - Texto: {TextoMensagem}, Arquivo: {Arquivo}, Formato: {Formato}");
        }
    }
}