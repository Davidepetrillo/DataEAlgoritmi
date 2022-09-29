using System.Diagnostics;
using System;

namespace DataEAlgoritmi
{
    class TestBubbleSort
    {

        
        public static void Main(string[] args)
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };

            BubbleSortingAlgorithm(scores);
            for(int i =0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }

            SelectSortingAlgorithm(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }

            InsertSortingAlgorithms(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }

            //Ricerca Tabella Lineare
            Console.WriteLine("Pleae enter the value you want to search: ");
            int value = Convert.ToInt32(Console.ReadLine());

            bool isSearch = false;
            for(int i=0; i < scores.Length; i++)
            {
                if(scores[i] == value)
                {
                    isSearch = true;
                    Console.WriteLine("Found value: " + value + " the index is: " + i);
                    break;
                }
            }

            if (!isSearch)
            {
                Console.WriteLine("The value was not found " + value);
            }


            int[] scores2 = { 30, 40, 50, 70, 80, 90, 100 };
            int searchValue = 40;
            int position = BinarySearch(scores2, searchValue);
            Console.WriteLine(searchValue + " position: " + position);
        }

        // Bubble sorting algorithm
        //se arrays[j] > arrays[j+1], vengono scambiati
        public static void BubbleSortingAlgorithm(int[] arrays)
        {
            for(int i = 0; i < arrays.Length-1; i++)
            {
                bool isSwap = false;

                for(int j=0; j<arrays.Length-1; j++)
                {
                    if(arrays[j] > arrays[j + 1])
                    {
                        int flag = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = flag;
                        isSwap = true;
                    }

                }

                if (!isSwap)
                {
                    break;
                }
            }
        }


        // Select Sorting Algorithm
        // Ordina un array trovando ripetutamente l'elemento minimo e mettendoloo all'inizio

        public static void SelectSortingAlgorithm(int[] arrays)
        {
            int len = arrays.Length - 1;
            int minIndex;

            for (int i = 0; i < len; i++)
            {
                minIndex = i;
                int minValue = arrays[minIndex];
                for (int j = i; j < len; j++)
                {
                    if (minValue > arrays[j + 1])
                    {
                        minValue = arrays[j + 1];
                        minIndex = j + 1;
                    }
                }

                if (i != minIndex)
                {
                    int temp = arrays[i];
                    arrays[i] = arrays[minIndex];
                    arrays[minIndex] = temp;
                }
            }


        }

        // Insert Sorting Algorithm
        //Prendi un nuovo elemento non ordinato nell'array, confrontandolo con l'elemnento ordinato prima 
        //se l'elemento è più piccolo dell'elemento ordinato, inserisci il nuovo elemento nella posizione corretta

        public static void InsertSortingAlgorithms(int[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                int insertElement = arrays[i];
                int insertPosition = i;

                for(int j =insertPosition-1; j>0; j--)
                {

                    if(insertElement < arrays[j])
                    {
                        arrays[j + 1] = arrays[j];
                        insertPosition--;
                    }
                }
                arrays[insertPosition] = insertElement;
            }
        }


        // RIcerca dicotomica - Dichotomy Binary Search
        // Trova la posizione dell'indice di un determinato valore da un array già oridnato

        public static int BinarySearch(int[] arrays, int searchValue)
        {
            int low = 0;
            int high = arrays.Length - 1;
            int mid = 0;

            while(low <= high)
            {
                mid = (low + high) / 2;
                if(arrays[mid] == searchValue)
                {
                    return mid;
                }
                else if(arrays[mid] < searchValue)
                {
                    low = mid + 1;
                } 
                else if(arrays[mid] > searchValue)
                {
                    high = mid - 1;
                }
            }

            return -1;
        }


    }


 
}





