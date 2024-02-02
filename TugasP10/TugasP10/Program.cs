using System;

namespace TugasPraktikum10
{
    abstract class Bunga
    {
        public abstract void Voice();
    }

    class Mawar : Bunga
    {
        public override void Voice()
        {
            Console.WriteLine("merah");
        }
    }

    class Melati : Bunga
    {
        public override void Voice()
        {
            Console.WriteLine("putih");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Bunga bunga1 = new Mawar();
            Bunga bunga2 = new Melati();

            bunga1.Voice();
            bunga2.Voice();
        }
    }
}