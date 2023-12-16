using System;
using System.IO;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro variables 
            int opcion;
            bool  endProgram = true;
            string line;

            //Actualizo el nombre y los colores de la terminal
            Console.Title = "Menu";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White ;
            Console.Clear();

            //Escribo la primera linea de texto
            Console.WriteLine("Este es el menu para mostrar los documentos de proyecto aula");
            Console.ReadKey();
            Console.Clear();

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
}﻿using System;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Menu";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("Este es el menu para mostrar los documentos de proyecto aula");
            Console.ReadKey();
            Console.Clear();

             




        }
    }
}
