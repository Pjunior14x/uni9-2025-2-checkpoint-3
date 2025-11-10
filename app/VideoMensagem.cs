using System;

namespace ChatbotApp
{
    public class VideoMensagem : Mensagem
    {
        private string arquivo;
        private string formato;
        private TimeSpan duracao;

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

        public TimeSpan Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Vídeo - Texto: {TextoMensagem}, Arquivo: {Arquivo}, Formato: {Formato}, Duração: {Duracao}");
        }
    }
}