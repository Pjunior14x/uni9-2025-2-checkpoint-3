namespace App
{
    public class PhotoMessage
    {
        public string Sender { get; set; }
        public string ImageUrl { get; set; }
        public string Caption { get; set; }

        public PhotoMessage(string sender, string imageUrl, string caption)
        {
            Sender = sender;
            ImageUrl = imageUrl;
            Caption = caption;
        }

        public void Display()
        {
            Console.WriteLine($"[{Sender}] enviou uma foto: {ImageUrl}");
            if (!string.IsNullOrEmpty(Caption))
            {
                Console.WriteLine($"Legenda: {Caption}");
            }
        }
    }
}
