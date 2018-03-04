using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    static class DatabaseController
    {
        /// <summary>
        /// Характеристики подключения
        /// </summary>
        private const string connStr = "server=localhost;user=root;database=sortingalgorithms;password=0000;";

        /// <summary>
        /// Подключение
        /// </summary>
        static public MySqlConnection conn = new MySqlConnection(connStr);

        /// <summary>
        /// Текущий id сортировки
        /// </summary>
        static private int currId;

        /// <summary>
        /// Текущая итерация сортировки
        /// </summary>
        static private int iteration;

        /// <summary>
        /// Получает список достумных модулей приложения для их подключения
        /// </summary>
        /// <returns>Список достумных модулей приложения</returns>
        static public List<Unit> GetUnits()
        {
            List<Unit> Units = new List<Unit>();
            string query = "SELECT * FROM units";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                Units.Add(new Unit(reader[1].ToString(), reader[2].ToString()));
            reader.Close();
            conn.Close();
            return Units;
        }

        /// <summary>
        /// Создаёт таблицу сортировки
        /// </summary>
        static public void CreateTable()
        {
            string query;
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn.Open();
            for (currId = 0; ; currId++)
            {
                query = "SELECT * FROM sortings WHERE id= '" + currId + "'";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                    break;
                reader.Close();
            }
            reader.Close();
            iteration = 0;
            query = "CREATE TABLE `sortingalgorithms`.`sort_iteration_id" + currId + "` (`iteration` INT NOT NULL, `array` TEXT(1000) NOT NULL, PRIMARY KEY(`iteration`));";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Сохраняет итерацию сортировки в БД
        /// </summary>
        /// <param name="array">массив-итерация</param>
        static public void SetIteration(int[] array)
        {
            string query = "INSERT INTO sort_iteration_id" + currId + "(iteration, array) VALUES ( '" + iteration + "', '" + ToStringArray(array) + "' )";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Итерация: " + iteration + "; Массив:");
            Console.WriteLine(ToStringArray(array));
            iteration++;
        }

        /// <summary>
        /// Сохраняет итерацию сортировки в БД
        /// </summary>
        /// <param name="array">массив-итерация</param>
        static public void SetIteration(string array)
        {
            string query = "INSERT INTO sort_iteration_id" + currId + "(iteration, array) VALUES ( '" + iteration + "', '" + array + "' )";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Итерация: " + iteration + "; Массив:");
            Console.WriteLine(array);
            iteration++;
        }

        /// <summary>
        /// Добавляет сортировку в БД
        /// </summary>
        /// <param name="sort_type">тип сортировки</param>
        /// <param name="sort_time">время сортировки</param>
        /// <param name="compares">количество сравнений</param>
        /// <param name="swaps">количество перестановок</param>
        /// <param name="array">массив</param>
        static public void AddSort(string sort_type, string sort_time, int compares, int swaps, int[] array)
        {
            string query = "INSERT INTO sortings(id, sort_type, sort_time, compares, swaps, array) VALUES ( '" + currId + "', '" + sort_type + "', '" + sort_time + "', '" + compares + "', '" + swaps + "', '" + ToStringArray(array) + "' )"; ;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Добавляет сортировку в БД
        /// </summary>
        /// <param name="sort_type">тип сортировки</param>
        /// <param name="sort_time">время сортировки</param>
        /// <param name="compares">количество сравнений</param>
        /// <param name="swaps">количество перестановок</param>
        /// <param name="array">массив</param>
        static public void AddSort(string sort_type, string sort_time, int compares, int swaps, string array)
        {
            string query = "INSERT INTO sortings(id, sort_type, sort_time, compares, swaps, array) VALUES ( '" + currId + "', '" + sort_type + "', '" + sort_time + "', '" + compares + "', '" + swaps + "', '" + array + "' )"; ;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Записывает данные о сортировках из БД в таблицу
        /// </summary>
        /// <param name="dgv">таблица</param>
        static public void LoadData(DataGridView dgv)
        {
            string query = "SELECT * FROM sortings";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            reader.Close();
            conn.Close();
        }

        /// <summary>
        /// Записывает данные об итерациях сортировки из БД в таблицу
        /// </summary>
        /// <param name="dgv">таблица</param>
        /// <param name="id">id сортировки</param>
        static public void LoadData(DataGridView dgv, int id)
        {
            dgv.Rows.Clear();
            string query = "SELECT * FROM sort_iteration_id" + id;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader[1].ToString());
            reader.Close();
            conn.Close();
        }
        
        /// <summary>
        /// Удаляет иформацию о сортировки из БД
        /// </summary>
        /// <param name="index">номер сортировки</param>
        static public void Detete(int index)
        {
            string query = "DELETE FROM sortings WHERE id= '" + index + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            query = "DROP TABLE sort_iteration_id" + index;
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Удаляет иформацию о всех сортировках из БД
        /// </summary>
        static public void DeteteAll()
        {
            string query = "SHOW TABLES";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            List<string> commands = new List<string>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
                if (reader[0].ToString()[4] == '_')
                    commands.Add("DROP TABLE " + reader[0]);
            reader.Close();
            foreach (string command in commands)
            {
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            query = "DELETE FROM sortings";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Получает строковое представление массива
        /// </summary>
        /// <param name="Array">массив</param>
        /// <returns>строковое представление массива</returns>
        static private string ToStringArray(int[] Array)
        {
            string str = "{ ";
            foreach (int i in Array)
                str += i + ", ";
            if (str.Length > 2)
                str = str.Substring(0, str.Length - 2);
            str += " }";
            return str;
        }
    }
}
