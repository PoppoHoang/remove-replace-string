using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove
{
    internal class Program
    {
        static void Main(string[] args)
        {// program för att ta bort några bookstäver på en string

            string w3resource = "poppo hoang"; // deklarerar en string 
            string ny = w3resource.Remove(7,2); // ta bort en del av en string. "7" betyder att man räknar från vänster för att ta
                                                // bort en hel string. "2" betyder att man tar bort ytterligare en del av den string,
                                                // räknat efter siffran 7 och tar bort 2 extra bokstäver.
                                                // Sedan skriver koden ut resterande av stringen. Vill man inte ha med resterande kan
                                                // man bara skriva första siffran 7, då ta allt bort efter.
                                                
            //NY PROGRAM REPLACE
            Console.WriteLine(ny); // skriv ut den string som då fått bokstäverna borttagna.

            //byta ut replace string
            string nyString = "poppo hoang"; //skriv en string i original form
            string ny2 = ny.Replace("p", "s"); // kod att byta ut alla bokstäver "p" till "s".

            Console.WriteLine(ny2); // skriv ut den nya string, där man bytt "p" till "s"

            // NY PROGRAM , ta bort delar av en string
            string word = "poppo Hoang"; //deklarerar en string 
            string firstCharacter = word.Substring(3, 5); //kod för att ta bort del av string. "3" är de första stringen man tar bort "5"
                                                          //är string som man tar bort efter. All string mellan 3-5 finns alltså kvar.
            Console.WriteLine(firstCharacter); // skriv ut resterande av string som är kvar

            
            Console.ReadKey(true);
        }
        
    }
}
