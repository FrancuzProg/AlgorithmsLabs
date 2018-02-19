using System;
using System.IO;

namespace AlgorithmsLabs
{
    static class MergeSort
    {
        /// <summary>
        /// Сортирует числа в файле методом естественного слияния
        /// </summary>
        /// <param name="FileName">Полный путь к сортируемому файлу</param>
        static public void NaturalMergeSort(string FileName)
        {
            int s1, s2, a1, a2, mark;
            StreamReader SR, SR1, SR2;
            StreamWriter SW, SW1, SW2;
            s1 = 1;
            s2 = 1;
            a1 = 0;
            a2 = 0;
            while (s1 > 0 && s2 > 0)
            {
                mark = 1;
                s1 = 0;
                s2 = 0;
                SR = new StreamReader(FileName);
                SW1 = new StreamWriter("f1.txt");
                SW2 = new StreamWriter("f2.txt");
                if (!SR.EndOfStream)
                {
                    a1 = Convert.ToInt32(SR.ReadLine());
                    SW1.WriteLine(a1);
                }  
                while (!SR.EndOfStream)
                {
                    a2 = Convert.ToInt32(SR.ReadLine());
                    if (a2 < a1)
                        switch (mark)
                        {
                            case 1:
                                SW1.WriteLine('\'');
                                mark = 2;
                                s1++;
                                break;
                            case 2:
                                SW2.WriteLine('\'');
                                mark = 1;
                                s2++;
                                break;
                        }
                    if (mark == 1)
                    {
                        SW1.WriteLine(a2);
                        s1++;
                    }
                    else
                    {
                        SW2.WriteLine(a2);
                        s2++;
                    }
                    a1 = a2;
                }
                if (s2 > 0 && mark == 2)
                    SW2.WriteLine('\'');
                if (s1 > 0 && mark == 1)
                    SW1.WriteLine('\'');
                SR.Close();
                SW1.Close();
                SW2.Close();

                SW = new StreamWriter(FileName);
                SR1 = new StreamReader("f1.txt");
                SR2 = new StreamReader("f2.txt");
                if (!SR1.EndOfStream)
                    a1 = Convert.ToInt32(SR1.ReadLine());
                if (!SR2.EndOfStream)
                    a2 = Convert.ToInt32(SR2.ReadLine());
                bool file1, file2;
                while (!SR1.EndOfStream && !SR2.EndOfStream)
                {
                    file1 = false;
                    file2 = false;
                    while (!file1 && !file2)
                    {
                        if (a1 <= a2)
                        {
                            SW.WriteLine(a1);
                            file1 = EndBlock(SR1);
                            a1 = Convert.ToInt32(SR1.ReadLine());
                        }
                        else
                        {
                            SW.WriteLine(a2);
                            file2 = EndBlock(SR2);
                            a2 = Convert.ToInt32(SR2.ReadLine());
                        }
                    }
                    while (!file1)
                    {
                        SW.WriteLine(a1);
                        file1 = EndBlock(SR1);
                        a1 = Convert.ToInt32(SR1.ReadLine());
                    }
                    while (!file2)
                    {
                        SW.WriteLine(a2);
                        file2 = EndBlock(SR2);
                        a2 = Convert.ToInt32(SR2.ReadLine());
                    }
                }
                file1 = false;
                file2 = false;
                while (!file1 && !SR1.EndOfStream)
                {
                    SW.WriteLine(a1);
                    file1 = EndBlock(SR1);
                    a1 = Convert.ToInt32(SR1.ReadLine());
                }
                while (!file2 && !SR2.EndOfStream)
                {
                    SW.WriteLine(a2);
                    file2 = EndBlock(SR2);
                    a2 = Convert.ToInt32(SR2.ReadLine());
                }
                SW.Close();
                SR1.Close();
                SR2.Close();
            }
            File.Delete("f1.txt");
            File.Delete("f2.txt");
        }

        /// <summary>
        /// Проверяет на конец блока
        /// </summary>
        /// <param name="SR">Поток чтения файла</param>
        /// <returns>Является ли концом блока</returns>
        static private bool EndBlock(StreamReader SR)
        {
            if ((char)SR.Peek() == '\'')
            {
                SR.ReadLine();
                return true;
            }
            else return false;
        }

        /*static int[] Merge_Sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return Merge(Merge_Sort(massive.Take(mid_point).ToArray()), Merge_Sort(massive.Skip(mid_point).ToArray()));
        }

        static int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                        merged[i] = mass2[b++];
                    else //if int go for
                        merged[i] = mass1[a++];
                else
                  if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }*/
    }
}
