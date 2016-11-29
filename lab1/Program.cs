using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab1
{
    public interface Pojazd
    {
        void jedz();
    }
    public class Samochod:Pojazd
    {
        private int licznik;
        protected String nazwa;
        public String Nazwa
        {
            get { return this.nazwa; }
            set { this.nazwa = value; }
        }

        public Samochod(String nazwa)
        {
            this.nazwa = nazwa;
        }

        public void jedz()
        {
            return;
        }
    }

    public class Osobowy : Samochod
    {
        private int liczbaSiedzen; 

        public int LiczbaSiedzen
        {
            get { return this.liczbaSiedzen; }
            set { this.liczbaSiedzen = value; }
        }
        public Osobowy(String nazwa,int liczbaSiedzen) : base(nazwa)
        {
            this.liczbaSiedzen = liczbaSiedzen;
        }
    }

    public class Ciezarowy : Samochod
    {
        private int ciezar;
        
        public int Ciezar
        {
            get { return this.ciezar; }
            set { this.ciezar = value; }
        }
        public Ciezarowy(String nazwa, int ciezar) : base(nazwa)
        {
            this.ciezar = ciezar;
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            Samochod s = new Samochod("Fiat");
            Console.WriteLine("Twoj samochod to: " + s.Nazwa);
            s.Nazwa = "Audi";
            Console.WriteLine("A teraz twoj samochod to: " + s.Nazwa);
            Samochod s1 = new Ciezarowy("BMW", 1500);
            Console.WriteLine("Twoj samochod ciezarowy to: " + s1.Nazwa);
            Samochod s2 = new Osobowy("Toyota", 5);
            Console.WriteLine("Twoj samochod osobowy to: " + s2.Nazwa);
            if(s2 is Osobowy)
            {
                Osobowy tmp = s2 as Osobowy;
                Console.WriteLine(tmp.LiczbaSiedzen);
            }
        }
        */

        static void Main(string[] args)
        {
            User user1 = new User();
            user1.email = "user@user.user";

            Database.getInstance().users.Add(user1);
            Database.getInstance().groups.Add(new Group());

            Console.WriteLine(User.login("user@user.user"));
            User user2 = Database.getInstance().users.First();
            Console.WriteLine(user2.email);
        }
    }
}
