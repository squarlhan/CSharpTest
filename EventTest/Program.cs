using System;

namespace EventTest
{
    class Station
    {
        string content;
        public Station(string content) => this.content = content;
        public void broatcast() => Console.WriteLine(content);
    }

    public delegate void listen2RadioEventHandler();
    class Radio
    {
        public event listen2RadioEventHandler listen2Radio;
        public void onListen2Radio()
        {
            listen2Radio();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Station fm1001 = new Station("FM100.1!");
            Station fm880 = new Station("Leftest FM!");

            Radio myradio = new Radio();
            myradio.listen2Radio += fm1001.broatcast;
            myradio.listen2Radio += fm880.broatcast;

            myradio.onListen2Radio();
        }
    }
}
