namespace App
{
    public class InstagramCanal
    {
        public string NomeCanal { get; set; }
        public List<PhotoMessage> Mensagens { get; set; }

        public InstagramCanal(string nomeCanal)
        {
            NomeCanal = nomeCanal;
            Mensagens = new List<PhotoMessage>();
        }

        public void AdicionarMensagem(PhotoMessage mensagem)
        {
            Mensagens.Add(mensagem);
        }

        public void ExibirMensagens()
        {
            Console.WriteLine($"Canal: {NomeCanal}");
            foreach (var msg in Mensagens)
            {
                msg.Display();
                Console.WriteLine();
            }
        }
    }
}
