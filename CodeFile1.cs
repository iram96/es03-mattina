namespace MyApp
{
    class ShowMessage
    {
        int[] viMioVettore;

        private static string sMiaStringa = "ciao";

        private int sLunghezzaStringa = sMiaStringa.Length;
        public ShowMessage()
        {
            Console.WriteLine("Hi, I am default message");
            //this.viMioVettore = new int[200];
        }

        public ShowMessage(string message)
        {
            Console.WriteLine(message);
        }


        // passo uno stringone che ogni 10 char faccio andare a capo
        public void AppendMessage(string sMiaStringa)
        {
            int pos = 0;
            foreach (char c in sMiaStringa)
                if (pos == 10)
                {
                    Console.WriteLine();
                    pos = 0;
                }
                else
                {
                    Console.WriteLine(c);
                    pos++;

                }
        }

        ~ShowMessage()
        {
            Console.WriteLine("I am destructor and I clean the resources and free up memory as soon as program closed");
            Console.ReadLine();
        }
    }

}