using System;
using System.IO;

namespace AlgorithmsLabs
{
    static class MergeSort
    {
        /// <summary>
        /// Счетчик сравнений
        /// </summary>
        static private int CompareCount;

        /// <summary>
        /// Счётчик перестановок
        /// </summary>
        static private int SwapCount;

        /// <summary>
        /// Задаёт нулевые значения для счётчиков
        /// </summary>
        static public void ResetCounters()
        {
            CompareCount = 0;
            SwapCount = 0;
        }

        /// <summary>
        /// Возвращает счетчик сравнений
        /// </summary>
        /// <returns>Счетчик сравнений</returns>
        static public int GetCompareCount()
        {
            return CompareCount;
        }

        /// <summary>
        /// Возвращает счетчик перестановок
        /// </summary>
        /// <returns>Счетчик перестановок</returns>
        static public int GetSwapCount()
        {
            return SwapCount;
        }

        /// <summary>
        /// Сортирует числа в файле методом естественного слияния
        /// </summary>
        /// <param name="FileName">Полный путь к сортируемому файлу</param>
        static public string NaturalMergeSort(string FileName)
        {
            int s1, s2, a1, a2, mark;
            StreamReader SR, SR1, SR2;
            StreamWriter SW, SW1, SW2;
            s1 = 1;
            s2 = 1;
            a1 = 0;
            a2 = 0;
            string array;
            while (s1 > 0 && s2 > 0)
            {
                mark = 1;
                s1 = 0;
                s2 = 0;
                array = ToStringArray(new StreamReader(FileName));
                DatabaseController.SetIteration(array);
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
                    CompareCount++;
                    SwapCount++;
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
                {
                    SW2.WriteLine('\'');
                    SwapCount++;
                }  
                if (s1 > 0 && mark == 1)
                {
                    SW1.WriteLine('\'');
                    SwapCount++;
                }   
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
                        CompareCount++;
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
            array = ToStringArray(new StreamReader(FileName));
            DatabaseController.SetIteration(array);
            return array;
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

        /// <summary>
        /// Получает массив из файла в виде строки
        /// </summary>
        /// <param name="SR">Поток чтения файла</param>
        /// <returns>Массив в строковом представлении</returns>
        static private string ToStringArray(StreamReader SR)
        {
            string str = "{ ";
            while(!SR.EndOfStream)
                str += SR.ReadLine() + ", ";
            SR.Close();
            if (str.Length > 2)
                str = str.Substring(0, str.Length - 2);
            str += " }";
            return str;
        }

        /*static public void NaturalMergeSort()
        {
            string query;
            MySqlDataReader reader, reader1, reader2;
            MySqlCommand cmd;
            DatabaseController.conn.Open();
            int s1, s2, a1, a2, mark, i, i1, i2;
            s1 = 1;
            s2 = 1;
            a1 = 0;
            a2 = 0;

            while (s1 > 0 && s2 > 0)
            {
                mark = 1;
                s1 = 0;
                s2 = 0;
                query = "SELECT * FROM array";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                reader = cmd.ExecuteReader();
                query = "DELETE FROM firsttmp";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM secondtmp";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                cmd.ExecuteNonQuery();
                i1 = 0;
                i2 = 0;
                if (reader.Read())
                {
                    a1 = Convert.ToInt32(reader[1]);
                    query = "INSET INTO firsttmp(index, value) VALUES ( '" + i1 + "', '" + a1 + "' )";
                    cmd = new MySqlCommand(query, DatabaseController.conn);
                    cmd.ExecuteNonQuery();
                    i1++;
                }
                while (reader.Read())
                {
                    a2 = Convert.ToInt32(reader[1]);
                    if (a2 < a1)
                        switch (mark)
                        {
                            case 1:
                                query = "INSET INTO firsttmp(value) VALUES ( '" + i1 + "', '\'' )";
                                cmd = new MySqlCommand(query, DatabaseController.conn);
                                cmd.ExecuteNonQuery();
                                i1++;
                                mark = 2;
                                s1++;
                                break;
                            case 2:
                                query = "INSET INTO secondtmp(value) VALUES ( '" + i2 + "', '\'' )";
                                cmd = new MySqlCommand(query, DatabaseController.conn);
                                cmd.ExecuteNonQuery();
                                mark = 1;
                                i2++;
                                s2++;
                                break;
                        }
                    if (mark == 1)
                    {
                        query = "INSET INTO firsttmp(value) VALUES ( '" + i1 + "', '" + a2 + "' )";
                        cmd = new MySqlCommand(query, DatabaseController.conn);
                        cmd.ExecuteNonQuery();
                        i1++;
                        s1++;
                    }
                    else
                    {
                        query = "INSET INTO secondtmp(value) VALUES ( '" + i2 + "', '" + a2 + "' )";
                        cmd = new MySqlCommand(query, DatabaseController.conn);
                        cmd.ExecuteNonQuery();
                        i2++;
                        s2++;
                    }
                    a1 = a2;
                }
                if (s2 > 0 && mark == 2)
                {
                    query = "INSET INTO secondtmp(value) VALUES ( '" + i2 + "', '\'' )";
                    cmd = new MySqlCommand(query, DatabaseController.conn);
                    cmd.ExecuteNonQuery();
                    i2++;
                }
                if (s1 > 0 && mark == 1)
                {
                    query = "INSET INTO firsttmp(value) VALUES ( '" + i1 + "', '\'' )";
                    cmd = new MySqlCommand(query, DatabaseController.conn);
                    cmd.ExecuteNonQuery();
                    i1++;
                }
                reader.Close();

                i = 0;
                query = "DELETE FROM array";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                cmd.ExecuteNonQuery();
                query = "SELECT * FROM firsttmp";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                reader1 = cmd.ExecuteReader();
                query = "SELECT * FROM secondtmp";
                cmd = new MySqlCommand(query, DatabaseController.conn);
                reader2 = cmd.ExecuteReader();
                if (reader1.Read())
                    a1 = Convert.ToInt32(reader1[1]);
                if (reader2.Read())
                    a2 = Convert.ToInt32(reader2[1]);
                bool file1, file2;
                while (reader1.Read() && reader2.Read())
                {
                    file1 = false;
                    file2 = false;
                    while (!file1 && !file2)
                    {
                        if (a1 <= a2)
                        {
                            query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a1 + "' )";
                            cmd = new MySqlCommand(query, DatabaseController.conn);
                            cmd.ExecuteNonQuery();
                            i++;
                            a1 = Convert.ToInt32(reader1[1]);
                            file1 = EndBlock(reader1);
                        }
                        else
                        {
                            query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a1 + "' )";
                            cmd = new MySqlCommand(query, DatabaseController.conn);
                            cmd.ExecuteNonQuery();
                            i++;
                            a2 = Convert.ToInt32(reader2[1]);
                            file2 = EndBlock(reader2);
                        }
                    }
                    while (!file1)
                    {
                        query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a1 + "' )";
                        cmd = new MySqlCommand(query, DatabaseController.conn);
                        cmd.ExecuteNonQuery();
                        i++;
                        a1 = Convert.ToInt32(reader1[1]);
                        file1 = EndBlock(reader1);
                    }
                    while (!file2)
                    {
                        query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a2 + "' )";
                        cmd = new MySqlCommand(query, DatabaseController.conn);
                        cmd.ExecuteNonQuery();
                        i++;
                        a2 = Convert.ToInt32(reader2[1]);
                        file2 = EndBlock(reader2);
                    }
                }
                file1 = false;
                file2 = false;
                while (!file1)
                {
                    query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a1 + "' )";
                    cmd = new MySqlCommand(query, DatabaseController.conn);
                    cmd.ExecuteNonQuery();
                    i++;
                    a1 = Convert.ToInt32(reader1[1]);
                    file1 = EndBlock(reader1);
                }
                while (!file2 && reader2.Read())
                {
                    query = "INSET INTO array(value) VALUES ( '" + i + "', '" + a2 + "' )";
                    cmd = new MySqlCommand(query, DatabaseController.conn);
                    cmd.ExecuteNonQuery();
                    i++;
                    a2 = Convert.ToInt32(reader2[1]);
                    file2 = EndBlock(reader2);
                }
                reader1.Close();
                reader2.Close();
            }
            DatabaseController.conn.Close();
        }*/

        /*static private bool EndBlock(MySqlDataReader reader)
        {
            reader.Read();
            if (reader[1].ToString()[0] == '\'')
            {
                reader.Read();
                return true;
            }
            else return false;
        }*/

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
