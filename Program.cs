using CORE2.Data;
using CORE2.Helper.Enum;
using CORE2.Models;
using System.Runtime.InteropServices;

namespace ConsoleApp17

{
    public class Program
    {

        static void Main(string[] args)
        {
            bool f = false;
            bool f1 = false;
            bool f2 = false;

            do
            {
                Console.WriteLine("1.Olkeler,2.Planetler,0.EXIT");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("1.Olke yarat, 2. Olke gor,3.evvelki menuya qayit,4.GetCountryByRegion,0.EXIT");
                            string operation1 = Console.ReadLine();

                            switch (operation1)
                            {
                                case "1":
                                    Console.WriteLine("Olke adi daxil et");
                                    string Cname = Console.ReadLine();
                                    Console.WriteLine("Olke himni daxil et");
                                    string Canthem = Console.ReadLine();
                                    Console.WriteLine("Olke erazisi daxil edin");
                                    int Carea;
                                    bool t = int.TryParse(Console.ReadLine(), out Carea);
                                    while (!t)
                                    {
                                        Console.WriteLine("erazini duzgun daxil edin.");
                                        t = int.TryParse(Console.ReadLine(), out Carea);
                                    }

                                    Console.WriteLine("olkenin regionunu daxil et");
                                    Region Cregion;
                                    bool k = Region.TryParse(Console.ReadLine(), out Cregion);
                                    do
                                    {
                                        if (k = false)
                                        {
                                            Console.WriteLine(" Duzgun eded daxil edin");
                                        }
                                    } while (k = true);
                                    Country country = new Country()
                                    {

                                        CountryName = Cname,
                                        Anthem = Canthem,
                                        Area = Carea,
                                        Region = Cregion

                                    };
                                    AddDbContext.CreatCountry(country);
                                    Console.Clear();
                                    break;
                                case "2":
                                    AddDbContext.GetAllCountry();
                                    Console.Clear();
                                    break;
                                case "3":
                                    f1 = true;
                                    Console.Clear();
                                    break;
                                    case "4":
                                    Console.WriteLine("Region daxil et");
                                    Region region1 = new Region();
                                    AddDbContext.GetCountryByRegion(region1);
                                    Console.Clear();
                                    break;
                                case "0":
                                    f = true;
                                    break;
                                default:
                                    Console.WriteLine("Duzgun eded daxil edin");
                                    break;
                            }
                        } while (!f1);
                        Console.Clear() ;
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("1.Planet yarat,2.Butun planetleri gor,3.Planet sec ,0.Exit");
                            string operation2 = Console.ReadLine();


                            switch (operation2)
                            {
                                case "1":
                                    Console.WriteLine("planetin adini daxil et:");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Planetin erazisini daxil edin");
                                    int area;
                                begin:
                                    bool l = int.TryParse(Console.ReadLine(), out area);
                                    if (l = false)
                                    {
                                        Console.WriteLine("duzgun eded daxil et");
                                        goto begin;
                                    }
                                    Planet planet = new Planet()
                                    {

                                        PlanetName = name,
                                        Area = area
                                    };
                                    AddDbContext.CreatPlanet(planet);
                                    Console.Clear();
                                    break;
                                case "2":
                                    AddDbContext.GetAllPlanet();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.WriteLine("Ad daxil et:");
                                    string name1 = Console.ReadLine();
                                    AddDbContext.UpdatePlanet(name1);
                                    Console.Clear();
                                    break;
                                case "0":
                                    f = true;
                                    break;
                                default:
                                    Console.WriteLine("duzgun eded daxil edin");
                                    break;

                            }


                        } while (!f2);
                        Console.Clear();
                        break;

                    case "0":
                        f = true;
                        break;
                    default:
                        Console.WriteLine("duzgun eded daxil edin");
                        break;
                }

            } while (!f);
        }
    }
}
