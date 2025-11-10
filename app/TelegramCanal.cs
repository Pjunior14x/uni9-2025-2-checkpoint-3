namespace ChatbotApp
{
    public class TelegramCanal : Canal
    {

        public TelegramCanal(string identificador)
        {
            Identificador = identificador; 
        }

        public override void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine("Enviando via Telegram:");
            base.EnviarMensagem(mensagem);
        }
    }
}