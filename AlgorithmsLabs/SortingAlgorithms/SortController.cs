using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlgorithmsLabs
{
    class SortController
    {
        public void AddElement(DataGridView dgvArray, string Element)
        {
            int n = dgvArray.ColumnCount;
            DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
            newCol.Width = 40;
            dgvArray.Columns.Add(newCol);
            if (n > 10)
                dgvArray.Size = new Size(dgvArray.Size.Width, 40);
            if (n == 0)
                dgvArray.Rows.Add(Element);
            else dgvArray.Rows[0].Cells[n].Value = Element;
        }

        public void RemoveElement(DataGridView dgvArray)
        {
            int n = dgvArray.ColumnCount;
            if (n > 0)
                dgvArray.Columns.RemoveAt(n - 1);
            if (n < 13)
                dgvArray.Size = new Size(dgvArray.Size.Width, 25);
        }

        public void FillRandom(DataGridView dgvArray, int n)
        {
            Random rand = new Random();
            if (dgvArray.ColumnCount != 0)
                dgvArray.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                newCol.Width = 40;
                dgvArray.Columns.Add(newCol);
                if (i == 0)
                    dgvArray.Rows.Add(rand.Next(1, 100).ToString());
                else dgvArray.Rows[0].Cells[i].Value = rand.Next(1, 100);
            }
            if (n > 11)
                dgvArray.Size = new Size(dgvArray.Size.Width, 40);
            else dgvArray.Size = new Size(dgvArray.Size.Width, 25);
        }

        public string SortArray(DataGridView dgvArray, DataGridView dgvSortedArray, string btnSort)
        {
            Sort.ResetCounters();
            int[] Array = GetArray(dgvArray);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            CallSort(Array, btnSort);
            timer.Stop();
            SetSortedArray(dgvSortedArray, Array);
            return timer.Elapsed.ToString();
        }

        private void CallSort(int[] Array, string SortName)
        {
            if (SortName == "btnSelectionSort")
                Sort.SelectionSort(Array);
            if (SortName == "btnBubbleSort")
                Sort.BubbleSort(Array);
            if (SortName == "btnShakerSort")
                Sort.ShakerSort(Array);
            if (SortName == "btnQuickSort")
                Sort.QuickSort(Array, 0, Array.Length - 1);
        }

        private int[] GetArray(DataGridView dgvArray)
        {
            int n = dgvArray.ColumnCount;
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
                Array[i] = Convert.ToInt32(dgvArray.Rows[0].Cells[i].Value);
            return Array;
        }

        private void SetSortedArray(DataGridView dgvSortedArray, int[] Array)
        {
            if (dgvSortedArray.ColumnCount != 0)
                dgvSortedArray.Columns.Clear();
            for (int i = 0; i < Array.Length; i++)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                newCol.Width = 40;
                dgvSortedArray.Columns.Add(newCol);
                if (i == 0)
                    dgvSortedArray.Rows.Add(Array[i].ToString());
                else dgvSortedArray.Rows[0].Cells[i].Value = Array[i];
            }
            if (Array.Length > 11)
                dgvSortedArray.Size = new Size(dgvSortedArray.Size.Width, 40);
            else dgvSortedArray.Size = new Size(dgvSortedArray.Size.Width, 25);
        }
    }
}
