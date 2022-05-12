namespace MyApp
{
    public class Program
    {

        static void Metodo(string sString)
        {
            MyApp.ShowMessage smMioMessaggio = new MyApp.ShowMessage();

            Console.WriteLine("ciao");
        }
        static void Main(string[] args)
        {

            Metodo("Ciao");


            //Il tipo DateTime
            /*
             * TimeSpan è un struct, che identifica una struttura dati,
             * composta da giorni, ore, minuti, secondi e millisecondi
             * 
             */
            DateTime dt1 = new DateTime(2022, 12, 20);
            DateTime dt2 = new DateTime(2021, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2022 10:36:10 AM



        }
    }
}