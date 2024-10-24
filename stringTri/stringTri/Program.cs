using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite niz znakova: ");
            string unos = Console.ReadLine();

            
            string sVelika = unos.ToUpper();
            string sMala = unos.ToLower();
            string sPrvaTri = unos.Length >= 3 ? unos.Substring(0, 3) : unos;
            string sZadnjihPet = unos.Length >= 5 ? unos.Substring(unos.Length - 5) : unos;
            string s8_11 = unos.Length >= 11 ? unos.Substring(7, 4) : "N/A";  // Od 8. do 11. znaka

            
            Console.WriteLine("Niz u velikim slovima: " + sVelika);
            Console.WriteLine("Niz u malim slovima: " + sMala);
            Console.WriteLine("Prva tri znaka niza: " + sPrvaTri);
            Console.WriteLine("Zadnjih pet znakova niza: " + sZadnjihPet);
            Console.WriteLine("Od 8. do 11. znaka niza: " + s8_11);

            Console.ReadLine();
        }
    }
}
