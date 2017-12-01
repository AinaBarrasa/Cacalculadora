using System;

namespace sumar
{
    class Program
    {

        static void Main(string[] args)
        {

            string sprimernombre;
            string ssegonnombre;
            double iprimernombre = 11;
            double isegonnombre = 11;
            bool bucleprimer = false;
            bool buclesegon = false;
            bool bucleoperacio = false;
            double total;


            string soperacio;
            int ioperacio = 11;

            //demanar tipus d'operació
            Console.Clear();
            Console.WriteLine("Seleccioni la operació a realitzar:");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Divisió");
            Console.WriteLine("4: Multiplicació");




            while (!bucleoperacio)
            {
                soperacio = Console.ReadLine();
                if (int.TryParse(soperacio, out ioperacio) && ioperacio <= 4 && ioperacio > 0)
                    bucleoperacio = true;
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("L'operació seleccionada no existeix. Si us plau, indiqui un nombre entre les opcions oferides:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1: Suma");
                    Console.WriteLine("2: Resta");
                    Console.WriteLine("3: Divisió");
                    Console.WriteLine("4: Multiplicació");
                }
            }

            Console.Clear();


            switch (ioperacio)
            {
                case 1:
                    Console.WriteLine("Ha seleccionat l'opció suma");
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionat l'opció resta");
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionat l'opció Divisió");
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionat l'opció multiplicació");
                    break;

                default:
                    break;

            }

            // Demanar es primer nombre

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Introdueix el primer nombre:");



            while (!bucleprimer)
            {
                sprimernombre = Console.ReadLine();
                if (double.TryParse(sprimernombre, out iprimernombre))
                    bucleprimer = true;
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Introdueix el primer nombre:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El numero no es correcte. Torna a intentar-ho:");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // DEMANAR es segonç

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Introdueix el segon nombre:");




            while (!buclesegon)
            {
                ssegonnombre = Console.ReadLine();
                if (double.TryParse(ssegonnombre, out isegonnombre))
                    buclesegon = true;
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Introdueix el segon nombre:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El numero no es correcte. Torna a intentar-ho:");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }



            // Presentar es total
            Console.Clear();

            switch (ioperacio)
            {
                case 1:
                    total = iprimernombre + isegonnombre;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La suma de {0} i {1} es {2}", iprimernombre, isegonnombre, total);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    total = iprimernombre - isegonnombre;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La resta entre {0} i {1} es {2}", iprimernombre, isegonnombre, total);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    total = iprimernombre / isegonnombre;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La divisió entre {0} i {1} es {2}", iprimernombre, isegonnombre, total);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    total = iprimernombre * isegonnombre;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La multiplicació entre {0} i {1} es {2}", iprimernombre, isegonnombre, total);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    break;

            }


        }
    }
}
