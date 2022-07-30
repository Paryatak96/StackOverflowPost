using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaPostów = new List<Post>();
            var przycisk = ' ';
            uint IkrementLike2 = 1;
            uint IkrementUnLike2 = 1;
            do
            {
                System.Console.Clear();
                Console.WriteLine("Co chcesz zrobić:");
                Console.WriteLine("1 - Dodaj Post");
                Console.WriteLine("2 - Wyświetl Post");
                Console.WriteLine("3 - Daj Like");
                Console.WriteLine("4 - Daj Unlike");

                przycisk = Console.ReadLine()[0];
                switch (przycisk)
                {
                    case '1':
                        {
                            Console.Write("Podaj tytuł postu: ");
                            var tytuł = Console.ReadLine();
                            Console.WriteLine("Napisz post: ");
                            var opis = Console.ReadLine();
                            var dataDodania = DateTime.Now;
                            var post1 = new Post(tytuł, opis, dataDodania);
                            ListaPostów.Add(post1);
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Który post chcesz wyświetlić?");
                            for (int i = 0; i < ListaPostów.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + "Tytuł posta: {0}. Data dodania: {1}", ListaPostów[i].TytułPostu, 
                                                  ListaPostów[i].DataDodania);
                                Console.Write("Lubię To! {0}", ListaPostów[i].Like);
                                Console.Write("       ");
                                Console.WriteLine("Nie lubię tego! {0}", ListaPostów[i].Unlike);
                                Console.WriteLine();
                            }
                            var wybór = byte.Parse(Console.ReadLine());
                            Console.WriteLine(ListaPostów[wybór - 1].Opis); 
                            Console.ReadLine();
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Któremu chcesz dać 'like'? ");
                            for (int i = 0; i < ListaPostów.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + "Tytuł posta: {0}. Data dodania: {1}", ListaPostów[i].TytułPostu,
                                                  ListaPostów[i].DataDodania);
                            }
                            var wybór2 = byte.Parse(Console.ReadLine());
                            ListaPostów[wybór2 - 1].DajLike(IkrementLike2);
                            break;
                        }

                    case '4':
                        {
                            Console.WriteLine("Któremu chcesz dać 'Unlike'? ");
                            for (int i = 0; i < ListaPostów.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + "Tytuł posta: {0}. Data dodania: {1}", ListaPostów[i].TytułPostu,
                                                  ListaPostów[i].DataDodania);
                            }
                            var wybór3 = byte.Parse(Console.ReadLine());
                            ListaPostów[wybór3 - 1].DajUnlike(IkrementUnLike2);
                            break;
                        }
                    default:
                        break;
                }
            } while (true);
        }
    }
}
