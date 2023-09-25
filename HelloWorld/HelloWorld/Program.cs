using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tanaan = DateTime.Today;
            string tervehdys;
            string nimi;
            string osoite;
            string postinumero;
            string postitoimipaikka;
            string ikaluokitus;
            int ika = 0;
            string sukupuoli;
            string puhelinnumero;
            string sahkoposti;
            string kysymys;
            Console.WriteLine("Henkilötietosovellus, versio 11.22. Tänään on:" + tanaan.ToString("d", culture));
            Console.Write("Kerro sukupuolesi. (Mies/Nainen.) ");
            sukupuoli = Console.ReadLine();
            if (sukupuoli == "Mies")
            {
                kysymys = "Mitä jäbä duunaa?";
            }
            else 
            {
                kysymys = "Mitä mimmi duunaa?";
            }
            Console.Write("Anna nimesi: ");
            nimi = Console.ReadLine();
            Console.Write("Anna puhelinnumerosi: ");
            puhelinnumero = Console.ReadLine();
            Console.Write("Anna sähköpostiosoitteesi: ");
            sahkoposti = Console.ReadLine();
            Console.Write("Anna osoitteesi: ");
            osoite = Console.ReadLine();
            Console.Write("Anna postinumerosi: ");
            postinumero = Console.ReadLine();
            Console.Write("Anna postitoimipaikkasi: ");
            postitoimipaikka = Console.ReadLine();
            Console.Write("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 1)
            {
                ikaluokitus = "Olet vauva!";
            }
            else if (ika < 7)
            {
                ikaluokitus = "Olet alle kouluikäinen";
            }
            else if (ika < 18)
            {
                ikaluokitus = "Olet alaikäinen";
            }
            else if (ika < 66)
            {
                ikaluokitus = "Olet täysikäinen";
            }
            else
            {
                ikaluokitus = "Olet seniori ja ehkä eläkkeellä";
            }
            tervehdys = "Päivää " + nimi + "!" + "Olet " + ika.ToString() + "-vuotias " + sukupuoli + ". ";
            Console.WriteLine(tervehdys + "" + ikaluokitus);
            Console.WriteLine("Yhteystiedot ovat...");
            Console.WriteLine(osoite);
            Console.WriteLine(postinumero);
            Console.WriteLine(postitoimipaikka);
            Console.WriteLine(puhelinnumero);
            Console.WriteLine(sahkoposti);
            Console.WriteLine(kysymys);
            Console.ReadLine();
        }
    }
}   
        

    
