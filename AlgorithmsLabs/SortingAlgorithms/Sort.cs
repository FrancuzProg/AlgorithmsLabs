using System;

namespace AlgorithmsLabs
{
    static class Sort
    {
        static private int CompareCount;

        static private int SwapCount;

        static public void ResetCounters()
        {
            CompareCount = 0;
            SwapCount = 0;
        }

        static public int GetCompareCount()
        {
            return CompareCount;
        }

        static public int GetSwapCount()
        {
            return SwapCount;
        }

        static public void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++, CompareCount++)
                    if (Array[j] < Array[min])
                        min = j;
                DatabaseController.SetIteration(Array);
                Swap(ref Array[i], ref Array[min]);
            }
        }

        static public void BubbleSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
                for (int j = 0; j < Array.Length - i - 1; j++, CompareCount++)
                    if (Array[j] > Array[j + 1])
                    {
                        DatabaseController.SetIteration(Array);
                        Swap(ref Array[j], ref Array[j + 1]);
                    } 
        }

        static public void ShakerSort(int[] Array)
        {
            int Left = 0;
            int Right = Array.Length - 1;
            while (Left <= Right)
            {
                for (int i = Left; i < Right; i++, CompareCount++)
                    if (Array[i] > Array[i + 1])
                    {
                        DatabaseController.SetIteration(Array);
                        Swap(ref Array[i], ref Array[i + 1]);
                    } 
                Right--;
                CompareCount += Right - Left;
                for (int i = Right; i > Left; i--, CompareCount++)
                    if (Array[i - 1] > Array[i])
                    {
                        DatabaseController.SetIteration(Array);
                        Swap(ref Array[i - 1], ref Array[i]);
                    }   
                Left++;
            }
        }

        static public void QuickSort(int[] Array, int Start, int End)
        {
            if (Start >= End)
                return;
            int Border = Start;
            int Pivot = (new Random()).Next(Start, End + 1);
            for (int i = Start; i <= End; i++, CompareCount++)
                if (Array[i] < Array[Pivot])
                {
                    DatabaseController.SetIteration(Array);
                    Swap(ref Array[i], ref Array[Border]);
                    if (Border == Pivot)
                        Pivot = i;
                    Border++;
                }
            DatabaseController.SetIteration(Array);
            Swap(ref Array[Pivot], ref Array[Border]);
            QuickSort(Array, Start, Border - 1);
            QuickSort(Array, Border + 1, End);
        }

        static private void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
            SwapCount++;
            Console.WriteLine("Перестановка элемент " + a + " с элементом " + b + ";");
        }
    }
}
