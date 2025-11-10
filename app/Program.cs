using System;

namespace ChatbotApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TextoMensagem texto = new TextoMensagem { TextoMensagem = "Olá!", DataEnvio = DateTime.Now };
            VideoMensagem video = new VideoMensagem { TextoMensagem = "Vídeo legal", Arquivo = "video.mp4", Formato = "MP4", Duracao = TimeSpan.FromMinutes(2) };
            FotoMensagem foto = new FotoMensagem { TextoMensagem = "Foto bonita", Arquivo = "foto.jpg", Formato = "JPG" };
            ArquivoMensagem arquivo = new ArquivoMensagem { TextoMensagem = "Documento", Arquivo = "doc.pdf", Formato = "PDF" };

            WhatsAppCanal whatsapp = new WhatsAppCanal("++5511999584999");
            TelegramCanal telegram = new TelegramCanal("@usuario_telegram");
            FacebookCanal facebook = new FacebookCanal("usuario_facebook");
            InstagramCanal instagram = new InstagramCanal("usuario_instagram");


            whatsapp.EnviarMensagem(texto);
            telegram.EnviarMensagem(video);
            facebook.EnviarMensagem(foto);
            instagram.EnviarMensagem(arquivo);

            Console.ReadLine();
        }
    }
}