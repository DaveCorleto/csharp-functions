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
            static void StampaArray(int[] array)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(", ");
                }
                Console.Write(")");
            }

            // Restituisce il quadrato di un numero 
            static int Quadrato(int numero)
            {
                int numeroQuadrato = numero * numero;
                return numeroQuadrato;
            }
            int[] copiaArray = new int[] { };

            //Funzione per QUADRATARE! gli array! 
            int[] ElevaArrayAlQuadrato(int[] array)

            {
                //Copio l'array i modo da non modificare l'originale
                int[] copiaArray = (int[])array.Clone();


                for (int i = 0; i < copiaArray.Length; i++)
                {   
                    //richiamo la funzione Quadrato e gli passo l'arrayclonato'
                    copiaArray[i] = Quadrato(copiaArray[i]);

                    Console.WriteLine(copiaArray[i]);
                }
                return copiaArray;
            }

            //int sommaElementiArray(int[] array)
            //{
            //    //Copio l'array'
            //    int[]arraycopia = (int[])array.Clone();

            //    int somma = 0;

            //    for (int i = 0; i < arraycopia.Length; i++)
            //    {

            //        somma += arraycopia[i];
                    
            //    }
            //    return somma;
            //}

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
                Console.WriteLine(somma);
                // Restituisco la somma
                return somma;
                
            }

            int[] arraydinumeriinteri = new int[] { 2, 6, 7, 5, 3, 9 };

            Console.WriteLine("Stampare l’array di numeri fornito a video (arraydinumeriinteri):");

            StampaArray(arraydinumeriinteri);

            Console.WriteLine();
            Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato: ");
            ElevaArrayAlQuadrato(arraydinumeriinteri);

            Console.WriteLine();    
            Console.WriteLine("Verifico che l'array originale sia rimasto intatto: ");

            StampaArray(arraydinumeriinteri);


            Console.WriteLine() ;
            Console.WriteLine("Ora sommo i vari elementi dell'array e stampo la somma di tutti i numeri: ");

            sommaElementiArray(arraydinumeriinteri);
            Console.WriteLine();
            







        }



    }

    //- ** void StampaArray(int[] array)**: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
    //- ** int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.
    //- **int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
    //- **int sommaElementiArray(int[] array)**: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

    //    Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri[2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
    //- Stampare l’array di numeri fornito a video
    //- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto[2, 6, 7, 5, 3, 9])
    //- Stampare la somma di tutti i numeri
    //- Stampare la somma di tutti i numeri elevati al quadrati
    //** BONUS:** Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi** di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di...e così via.
    //A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.Rieseguire il programma con l’input preso esternamente dall’utente.


}   
