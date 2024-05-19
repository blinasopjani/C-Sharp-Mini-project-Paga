using System;

namespace LlogaritPagen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vazhdo = true;

            while (vazhdo)
            {
                Console.WriteLine("Vendos te dhenat e punojesit: ");
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Emri: ");
                string emri = Console.ReadLine();
                Console.Write("Pozita (Admin, Zhvilues, Menaxher): ");
                string pozita = Console.ReadLine();
                Console.Write("Rroga: ");
                double rroga = Convert.ToDouble(Console.ReadLine());

                Employee punonjesi = null;

                if (pozita.ToLower() == "admin")
                {
                    punonjesi = new Admin(id, emri, pozita, rroga);
                }
                else if (pozita.ToLower() == "zhvilues")
                {
                    punonjesi = new Zhvilluesi(id, emri, pozita, rroga);
                }
                else if (pozita.ToLower() == "menaxher")
                {
                    punonjesi = new Menaxheri(id, emri, pozita, rroga);
                }
                else
                {
                    Console.WriteLine("Pozita e dhene nuk egziston.");
                    continue; // loopi vazhdon deri ne nje pozite valide
                }

                if (punonjesi != null)
                {
                    Console.WriteLine($"\nPunonjesi: {punonjesi.Emri}, Pozita: {punonjesi.Pozita}, Rroga: {punonjesi.Rroga}, Bonusi: {punonjesi.LlogaritBonusin(punonjesi.Rroga)}");
                }

                Console.Write("\nDeshironi te shtypni te dhenat e nje punonjesi tjeter? (po/jo): ");
                string pergjigja = Console.ReadLine();

                if (pergjigja.ToLower() != "po")
                {
                    vazhdo = false;
                }
            }
        }
    }
}