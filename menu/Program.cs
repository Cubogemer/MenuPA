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

            Console.CursorVisible = true; //Hace invisible el cursor de la consola

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
                    Console.WriteLine("       2: Herramientas de Programación");
                    Thread.Sleep(25);
                    Console.WriteLine("       3: Fisica I");
                    Thread.Sleep(25);
                    Console.WriteLine("       4: Contabilidad I");
                    Thread.Sleep(25);
                    Console.WriteLine("       5: Ingles III");
                    Thread.Sleep(25);
                    Console.WriteLine("       6: Entorno Socioeconomico de México");
                    Thread.Sleep(25);
                    Console.WriteLine("       7: Comunicacion Cientifica");
                    Thread.Sleep(25);
                    Console.WriteLine("       8: Salir del Programa");
                    opcion = int.Parse(Console.ReadLine());

                    //Las distintas opciones
                    //En la parte "Console.Title" figura a que materia pertenece
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
                                
                            }
                            finally
                            {
                                
                                Console.ReadKey();
                                Console.Clear();
                            }
                            
                            break;

                        case 2:
                            Console.Title = "Herramientas de Programacion";
                            Console.Clear ();
                            Console.WriteLine("Para la materia de Herramientas de Programacion se realizo el programa que estas ejecutando ahora mismo");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            Console.Title = "Fisica I";
                            Console.Clear();
                            try
                            {
                                line = File.ReadAllText("fisica.txt");
                                Console.WriteLine(line);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                                
                            }
                            finally
                            {

                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 4:
                            Console.Title = "Contabilidad I";
                            Console.Clear();
                            try
                            {
                                line = File.ReadAllText("conta.txt");
                                Console.WriteLine(line);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                                
                            }
                            finally
                            {

                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 5:
                            Console.Title = "Ingles III";
                            Console.Clear();
                            Console.WriteLine("For English Class we did an 80´s infografy");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 6:
                            Console.Title = "ESM";
                            Console.Clear();
                            try
                            {
                                line = File.ReadAllText("entorno.txt");
                                Console.WriteLine(line);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                                
                            }
                            finally
                            {

                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 7:
                            Console.Title = "Comunicacion Cientifica";
                            Console.Clear();
                            try
                            {
                                line = File.ReadAllText("comunicacion.txt");
                                Console.WriteLine(line);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exeption: " + e.Message);
                               
                                
                            }
                            finally
                            {

                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        //Opcion para salir del programa
                        case 8:
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.WriteLine("Saliendo del programa...");
                            Thread.Sleep(500);
                            endProgram = false;
                            break;

                        //Opcion por si no se escribe un numero del 1 al 8 
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
