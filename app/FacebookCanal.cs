namespace ChatbotApp
{
    public class FacebookCanal : Canal
    {

        public FacebookCanal(string usuario)
        {
            Identificador = usuario;
        }

        public override void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine("Enviando via Facebook:");
            base.EnviarMensagem(mensagem);
        }
    }
}