using System;
using System.IO;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool endProgram = true;
            string line;

            Console.Title = "Menu";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            try
            {
                StreamReader sr = new StreamReader("licensia.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
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
                Console.ReadKey();
                Console.Clear();
            }

            while (endProgram)
            {
                try
                {
                    Console.WriteLine("Escoge una opción");
                    Console.WriteLine("1: Investigacion general");
                    Console.WriteLine("2: Opcion 2");
                    Console.WriteLine("3: Salir del programa");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear ();
                            try
                            {
                                StreamReader sr = new StreamReader("texto_general.txt");
                                line = sr.ReadLine();
                                while (line != null)
                                {
                                    Console.WriteLine(line);
                                    line = sr.ReadLine();
                                }
                                sr.Close();
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                                Thread.Sleep(350);
                                Console.Clear() ;
                            }
                            finally
                            {
                                Console.Clear();
                            }
                            Console.Clear();
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
                            Console.WriteLine("No escribiste un numero dentro del rango");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Exeption: " + e.Message);
                }
               

                
            }



        }
    }
}
