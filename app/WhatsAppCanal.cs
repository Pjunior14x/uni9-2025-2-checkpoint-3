namespace App
{
    public class WhatsAppCanal : Canal
    {
        public WhatsAppCanal(string nome) : base(nome) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"[WhatsApp - {Nome}] {mensagem}");
        }
    }
}
