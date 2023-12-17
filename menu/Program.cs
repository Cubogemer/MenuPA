using System;
using System.IO;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int opcion;
            bool endProgram = true;
            string line;

            //Cambio el color y el titulo de la consola
            Console.Title = "Menu";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.CursorVisible = false; //Hace invisible el cursor de la consola

            //Escribe el nombre del programa (Hecho en figlet) y la licencia proporcionada por Github
            try
            {
                StreamReader sr = new StreamReader("licensia.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    Thread.Sleep(10);
                }
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption: " + e.Message);
                Thread.Sleep(350);
                Console.Clear();
            }
            finally
            {
                Thread.Sleep(600);
                Console.Clear();
            }

            while (endProgram)
            {
                try
                {
                    //Muestra el menu, los "Sleep" son mera estetica
                    Console.Title = "Menu";
                    Thread.Sleep(25);
                    Console.WriteLine("Escoge una opción");
                    Thread.Sleep(25);
                    Console.WriteLine("       1: Investigacion general");
                    Thread.Sleep(25);
                    Console.WriteLine("       2: Opcion 2");
                    Thread.Sleep(25);
                    Console.WriteLine("       3: Salir del programa");
                    opcion = int.Parse(Console.ReadLine());

                    //Las distintas opciones
                    switch (opcion)
                    {
                        case 1:
                            Console.Title = "Investigación general";
                            Console.Clear ();
                            try
                            {
                                line = File.ReadAllText("texto_general.txt");
                                Console.WriteLine(line);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                                Console.ReadKey();
                                Console.Clear() ;
                            }
                            finally
                            {
                                Console.ReadKey();
                                Console.Clear();
                            }
                            
                            break;

                        case 2:
                            Console.Clear ();
                            Console.WriteLine("Escogiste la opcion 2");
                            break;

                        case 3:
                            Console.Clear ();
                            Console.WriteLine("Has elegido salir del programa");
                            Thread.Sleep (500);

                            endProgram = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("No escribiste un numero dentro del rango");
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("Exeption: " + e.Message);
                    Thread.Sleep(300);
                    Console.Clear();
                }



            }



        }
    }
}
