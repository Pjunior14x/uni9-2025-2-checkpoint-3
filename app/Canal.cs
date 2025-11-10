namespace App
{
    public abstract class Canal
    {
        public string Nome { get; set; }

        protected Canal(string nome)
        {
            Nome = nome;
        }

        public abstract void EnviarMensagem(string mensagem);
    }
}
