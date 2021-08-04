﻿/*********************************************************************************
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
            public int Volumen;
            public bool isActiv;

        }
        static void Main(string[] args)
        {
            //Lokales Array mit der Länge 75:
            Box[] lager = new Box[75];

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
                    Console.Clear();
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

                    

                    switch (selection)
                    {
                        case 1:
                            //Methode Add
                            AddBox(lager);
                            break;
                        case 2:
                            //Methode Delete
                            DeleteBox(lager);
                            break;
                        case 3:
                            //Methode ChangeBox
                            ChangeBox(lager);
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
        //Die Methode zum Ändern der Daten einer Box
        static void ChangeBox(Box[] abox)
        {
            //User informieren:
            Console.WriteLine();
            Console.WriteLine("----------Boxdaten ändern----------");
            //Methodenvariablen:
            int selectedID;
            int index;
            Console.Write("Bitte geben Sie eine Box-Nummer zwischen 1 und 75 ein: ");
            selectedID = Convert.ToInt32(Console.ReadLine());

            //Arraybereich überwachen:
            if(selectedID >=1 && selectedID <= 75)
            {
                index = selectedID - 1;
                if (abox[index].isActiv == true)
                {
                    Console.Write("Bitte geben Sie die neue Länge ein: ");
                    abox[index].Laenge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bitte geben Sie die neue Breite ein: ");
                    abox[index].Breite = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bitte geben Sie die neue Höhe ein: ");
                    abox[index].Hoehe = Convert.ToInt32(Console.ReadLine());
                    //Volumen neu berechnen:
                    abox[index].Volumen = abox[index].Laenge * abox[index].Breite * abox[index].Hoehe;
                    Console.WriteLine();
                    Console.WriteLine($"Die Daten für die Box-ID: {selectedID} wurden erfolgreich geändert.");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Die Box mit der ID: {selectedID} existiert nicht, bitte neu anlegen!");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"Die von Ihnen eingegebene Nummer: {selectedID} befindetet sich ausserhalb des gültigen Bereiches!");
                Console.WriteLine();
                Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                Console.ReadKey();
            }
        }
        //Die Methode zum Löschen einer Box
        static void DeleteBox(Box[] abox)
        {
            //User informieren:
            Console.WriteLine();
            Console.WriteLine("----------Eine Kiste löschen----------");
            //Methodenvariablen:
            int selectedID;
            int index;
            Console.Write("Bitte geben Sie eine Box-Nummer zwischen 1 und 75 ein: ");
            selectedID = Convert.ToInt32(Console.ReadLine());

            //Arraybereich überwachen:
            if(selectedID >=1 && selectedID <= 75)
            {
                index = selectedID - 1;
                if (abox[index].isActiv == true)
                {
                    abox[index].Laenge = 0;
                    abox[index].Breite = 0;
                    abox[index].Hoehe = 0;
                    abox[index].Volumen = 0;
                    abox[index].isActiv = false;
                    Console.WriteLine();
                    Console.WriteLine($"Die Box mit der ID: {selectedID} wurde erfolgreich gelöscht.");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Die Box mit der ID:{selectedID} wurde bereits gelöscht");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"Die von Ihnen eingegebene Nummer: {selectedID} befindetet sich ausserhalb des gültigen Bereiches!");
                Console.WriteLine();
                Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                Console.ReadKey();
            }
        }

        //die Methode zum Einlesen einer neuen Kiste
        static void AddBox(Box[] abox)
        {
            //User informieren:
            Console.WriteLine();
            Console.WriteLine("---------Eine neue Kiste anlegen--------");
            Console.WriteLine();
            int selectedID;
            int index;
            Console.Write("Bitte geben Sie eine Box-Nummer zwischen 1 und 75 ein: ");
            selectedID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Arraybereich überwachen:
            if(selectedID >=1 && selectedID <= 75)
            {
                index = selectedID - 1;
                if (abox[index].isActiv == false)
                {
                    //Daten für die neue Box erfassen:
                    Console.Write("Bitte geben Sie die Länge der Box ein: ");
                    abox[index].Laenge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bitte geben Sie die Breite der Box ein: ");
                    abox[index].Breite = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bitte geben Sie die Höhe der Box ein: ");
                    abox[index].Hoehe = Convert.ToInt32(Console.ReadLine());
                    //Volumen berechnen und Box aktivieren:
                    abox[index].Volumen = abox[index].Laenge * abox[index].Breite * abox[index].Hoehe;
                    abox[index].isActiv = true;

                    //Ergebnis ausgeben:
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Folgende Daten wurden erfasst:");
                    Console.WriteLine($"Länge:   {abox[index].Laenge}");
                    Console.WriteLine($"Breite:  {abox[index].Breite}");
                    Console.WriteLine($"Höhe:    {abox[index].Hoehe}");
                    Console.WriteLine($"Volumen: {abox[index].Volumen}");
                    Console.WriteLine($"Aktiv:   {abox[index].isActiv}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Die Daten für die Box-ID: {selectedID} wurde erfolgreich gespeichert.");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Die von Ihnen eingegebne Box-ID: {selectedID} ist bereits vergeben!");
                    Console.WriteLine();
                    Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Die von Ihnen eingegebene Nummer befindetet sich ausserhalb des gültigen Bereiches!");
                Console.WriteLine();
                Console.WriteLine("Beliebige Taste drücken um fortzufahren...");
                Console.ReadKey();
            }

        }

    }
}
