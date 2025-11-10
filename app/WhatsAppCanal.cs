namespace ChatbotApp
{
    public class WhatsAppCanal : Canal
    {
        // WhatsApp usa número de telefone
        public WhatsAppCanal(string telefone)
        {
            Identificador = telefone;
        }

        public override void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine("Enviando via WhatsApp:");
            base.EnviarMensagem(mensagem);
        }
    }
}