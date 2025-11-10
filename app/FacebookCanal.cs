namespace App
{
    public class FacebookCanal : Canal
    {
        public FacebookCanal(string nome) : base(nome) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"[Facebook - {Nome}] {mensagem}");
        }
    }
}
