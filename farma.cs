namespace ConsoleApp4
{
    class Krava
    {
        public string jmeno;
        public double vaha;
        public int id;
        public string typ_chovu;
        
        public Krava(string Jmeno, double Vaha, int ID, string Typ_chovu) 
        {
            jmeno = Jmeno;
            vaha = Vaha;
            id = ID;
            typ_chovu = Typ_chovu;
        }
        public void zvuk()
        {
            Console.WriteLine("Kráva dělá BUUuu");
        }
        public void vypis_vlastnosti()
        {
            Console.WriteLine("Jméno: "+ jmeno + " váha: "+ vaha + " ID: "+ id + " Typ chovu: " + typ_chovu);
        }
        public void prejmenovani()
        {
            Console.WriteLine("napiste nove jmeno");
            string a = Console.ReadLine();
            jmeno = a;
            Console.WriteLine("Nové jméno je: "+a);
        }
    }
    class Prase
    {
        public string jmeno;
        public double vaha;
        public int id;
        public string typ_chovu;

        public Prase(string Jmeno, double Vaha, int ID, string Typ_chovu)
        {
            jmeno = Jmeno;
            vaha = Vaha;
            id = ID;
            typ_chovu = Typ_chovu;

        }
        public void zvuk()
        {
            Console.WriteLine("Prase dělá Qvíííí");
        }
        public void vypis_vlastnosti()
        {
            Console.WriteLine("Jméno: " + jmeno + " váha: " + vaha + " ID: " + id + " Typ chovu: " + typ_chovu);
        }
        public void prejmenovani()
        {
            Console.WriteLine("napiste nove jmeno");
            string a = Console.ReadLine();
            jmeno = a;
            Console.WriteLine("Nové jméno je: " + a);
        }
    }
    class Ovce
    {
        public string jmeno;
        public double vaha;
        public int id;
        public string typ_chovu;

        public Ovce(string Jmeno, double Vaha, int ID, string Typ_chovu)
        {
            jmeno = Jmeno;
            vaha = Vaha;
            id = ID;
            typ_chovu = Typ_chovu;
        }
        public void zvuk()
        {
            Console.WriteLine("Ovce dělá BEEeeee");
        }
        public void vypis_vlastnosti()
        {
            Console.WriteLine("Jméno: " + jmeno + " váha: " + vaha + " ID: " + id + " Typ chovu: " + typ_chovu);
        }
        public void prejmenovani()
        {
            Console.WriteLine("napiste nove jmeno");
            string a = Console.ReadLine();
            jmeno = a;
            Console.WriteLine("Nové jméno je: "+a);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Krava venca = new Krava("Venca",1166.6666, 1, "Maso");
            venca.zvuk();
            venca.vypis_vlastnosti();
            venca.prejmenovani();

            Krava marka = new Krava("Marka", 460, 4, "Mléko");
            Krava honza = new Krava("Honza",1250.4 , 3, "Maso");

            Prase pepa = new Prase("Pepa", 250, 1, "Maso");
            pepa.zvuk();
            pepa.vypis_vlastnosti();
            pepa.prejmenovani();
            
            Prase pepa2 = new Prase("Gabča", 60, 2, "Maso");
            Prase pepa3 = new Prase("Vilém", 178, 3, "Maso");

            Ovce arnost = new Ovce("Arnošt", 179.9, 1, "Vlna");
            arnost.zvuk();
            arnost.vypis_vlastnosti();
            arnost.prejmenovani();
            
            Ovce arnost2 = new Ovce("Jana", 300, 2, "Maso");
            Ovce arnost3 = new Ovce("Kuba", 25, 3, "Vlna");
        }
    }
}
