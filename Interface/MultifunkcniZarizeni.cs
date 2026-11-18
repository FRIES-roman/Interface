namespace Interface
{
    public class MultifunkcniZarizeni : iTiskarna, iSkener, iPripojitelne
    {
        public string Skenuj()
        {
            return "Naskenoval jsem dokument";
        }

        public void Tiskni(string dokument)
        {
           Console.WriteLine("Tisknu dokument: " + dokument);
        }

        public void Pripoj(string adresa)
        {
            Console.WriteLine("Připojrno - IP adresa: " + adresa);
        }
    }
}