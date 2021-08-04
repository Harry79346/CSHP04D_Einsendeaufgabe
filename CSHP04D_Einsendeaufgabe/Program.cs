/*********************************************************************************
 ********Einsendeaufgabe 4 - "Lagerverwaltung"************************************
 ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP04D_Einsendeaufgabe
{
    class Program
    {
        //Datenstruktur 
        public struct Box
        {
            public int BoxID;
            public int Laenge;
            public int Breite;
            public int Hoehe;
            public bool isActiv;

        }
        static void Main(string[] args)
        {
            //Lokales Array mit der Länge 75:
            Box[] lager = new Box[10];

            //Array vorbereiten:
            for (int i = 0; i < lager.Length; i++)
            {
                lager[i].isActiv = false;   //inaktiv setzten
                lager[i].BoxID = i + 1;     //Box-ID von 1 zählen lassen

                //Variable für Usereingabe:
                int selection = 0;

                //Usereingabe verarbeiten:
                while(selection !=6)
                {
                    Console.WriteLine("Hauptmenü");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("\t[1] add a new box");
                    Console.WriteLine("\t[2] delete one box");
                    Console.WriteLine("\t[3] change box data");
                    Console.WriteLine("\t[4] show box by ID");
                    Console.WriteLine("\t[5] show all boxes");
                    Console.WriteLine();
                    Console.Write("Your selection: ");
                    selection = Convert.ToInt32(Console.ReadLine());

                    //Console.Clear();
                    

                    switch (selection)
                    {
                        case 1:
                            //Methode Add
                            Console.WriteLine("Die Methode 'add new Box' kommt bald...versprochen");
                            break;
                        case 2:
                            //Methode Delete
                            break;
                        case 3:
                            //Methode Change
                            break;
                        case 4:
                            //Methode ShowBox
                            break;
                        case 5:
                            //Methode ShowAllBoxes
                            break;
                    }
                    
                }
            }

            
            
        }

    }
}
