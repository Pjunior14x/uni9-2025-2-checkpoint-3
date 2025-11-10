namespace ChatbotApp
{
    public class InstagramCanal : Canal
  
        public InstagramCanal(string usuario)
        {
            Identificador = usuario;
        }

        public override void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine("Enviando via Instagram:");
            base.EnviarMensagem(mensagem);
        }
    }
}