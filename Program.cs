using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stampa un nuovo array 
            //static void StampaArray(int[] array)
            //{
            //    Console.Write("(");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(array[i]);
            //        if (i < array.Length - 1)
            //            Console.Write(", ");
            //    }
            //    Console.Write(")");
            //}
            //Versione generica 

            static void StampaArray<T>(T[] array, int n = 0)
            {
                if (n == 0)
                {
                    Console.Write("(");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < array.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }
                else
                {
                    Console.Write("(");
                    for (int i = 0; i < n && i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < n - 1 && i < array.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }
            }

            // Restituisce il quadrato di un numero 
            static int Quadrato(int numero)
            {
                int numeroQuadrato = numero * numero;
                return numeroQuadrato;
            }
            int[] copiaArray = new int[] { };

            //Funzione per QUADRATARE! gli array 
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                // Copio l'array in modo da non modificare l'originale
                int[] copiaArray = (int[])array.Clone();

                int[] arrayAlQuadrato = new int[copiaArray.Length];

                // Calcolo i quadrati e li salvo nel nuovo array
                for (int i = 0; i < copiaArray.Length; i++)
                {
                    arrayAlQuadrato[i] = Quadrato(copiaArray[i]);
                }

                // Restituisco l'array con i valori al quadrato
                return arrayAlQuadrato;
            }


            int sommaElementiArray(int[] array)
            {
                // Copio l'array
                int[] arrayCopia = (int[])array.Clone();

                // Inizializzo la variabile somma al di fuori del ciclo
                int somma = 0;

                for (int i = 0; i < arrayCopia.Length; i++)
                {
                    // Aggiungo l'elemento corrente all'accumulatore somma
                    somma += arrayCopia[i];
                }
                //Console.WriteLine(somma);
                // Restituisco la somma
                return somma;
                
            }


            int[] arraydinumeriinteri = new int[] { 2, 6, 7, 5, 3, 9 };

            int sommastandard = sommaElementiArray(arraydinumeriinteri);

            int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arraydinumeriinteri);

            int sommaAlQuadrato = sommaElementiArray(arrayAlQuadrato);

            Console.WriteLine("Inserisci il numero di elementi che conterrà l'array");

            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());

            int [] array = new int[n];     

            Console.WriteLine("Stampare l’array di numeri fornito a video (arraydinumeriinteri):");

            StampaArray(arraydinumeriinteri);

            Console.WriteLine();

            Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato: ");

            ElevaArrayAlQuadrato(arraydinumeriinteri);
            StampaArray(arrayAlQuadrato);
            Console.WriteLine();    
            Console.WriteLine("Verifico che l'array originale sia rimasto intatto: ");

            StampaArray(arraydinumeriinteri);


            Console.WriteLine() ;
            Console.WriteLine("Ora sommo i vari elementi dell'array e stampo la somma di tutti i numeri: ");

            sommaElementiArray(arraydinumeriinteri);
            Console.WriteLine(sommastandard) ;
            Console.WriteLine();

            Console.WriteLine("Ora sommo i vari elementi dell'array al QUADRATO e stampo la somma: ");

            sommaElementiArray(arrayAlQuadrato);
            Console.WriteLine(sommaAlQuadrato);   







        }



    }



    //** BONUS:** Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi** di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di...e così via.
    //A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.Rieseguire il programma con l’input preso esternamente dall’utente.


}   
