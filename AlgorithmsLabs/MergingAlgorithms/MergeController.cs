using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AlgorithmsLabs
{
    class MergeController
    {
        /// <summary>
        /// Добавляет стартовый руть к файлу Array.txt
        /// </summary>
        /// <param name="tbPath">Строка для записи пути</param>
        public void SetStartPath(TextBox tbPath)
        {
            FileInfo fi = new FileInfo("Array.txt");
            if (fi.Exists)
                tbPath.Text = fi.FullName;
        }

        /// <summary>
        /// Получает путь до файла, открывая пользовательский диалог
        /// </summary>
        /// <param name="tbPath">Строка для записи пути</param>
        public void GetPath(TextBox tbPath)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                tbPath.Text = ofd.FileName;
        }

        /// <summary>
        /// Сортирует массив из файла
        /// </summary>
        /// <param name="FileName">Путь до сортируемого файла</param>
        /// <returns>Время сортировки</returns>
        public string SortArray(string FileName)
        {
            if (new FileInfo(FileName).Exists)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                try
                {
                    MergeSort.NaturalMergeSort(FileName);
                }
                catch
                {
                    MessageBox.Show("Файл заполнен некорректно!", "Ошибка");
                    return "00:00:00";
                }
                timer.Stop();
                MessageBox.Show("Сортировка выполнена!", "Сортировка");
                return timer.Elapsed.ToString();
            }
            else MessageBox.Show("Некорректный путь!", "Ошибка");
            return "00:00:00";
        }

        /// <summary>
        /// Заполняет файл случайными числами и сортирует их
        /// </summary>
        /// <param name="N">колличество случайных чисел</param>
        /// <returns>Время сортировки</returns>
        public string SortRandomArray(int N)
        {
            string FileName = "Array.txt";
            StreamWriter SW = new StreamWriter(FileName);
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                SW.WriteLine(rand.Next(0, 100));
            SW.Close();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            MergeSort.NaturalMergeSort(FileName);
            timer.Stop();
            MessageBox.Show("Файл Array.txt заполнен " + N + " случайными числами и успешно отсортирован!", "Сортировка");
            return timer.Elapsed.ToString();
        }
    }
}
