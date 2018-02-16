using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlgorithmsLabs
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = dgvArray.ColumnCount;
            DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
            //newCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            newCol.Width = 40;
            //newCol.HeaderText = n.ToString();
            //newCol.Name = "c" + n.ToString();
            dgvArray.Columns.Add(newCol);
            //if (dgvArray.Size.Width < 450)
            //dgvArray.Size = new Size(dgvArray.Size.Width + 40, dgvArray.Size.Height);
            if (n > 10)
                dgvArray.Size = new Size(dgvArray.Size.Width, 40);
            if (n == 0)
                dgvArray.Rows.Add(tbNumber.Text);
            else dgvArray.Rows[0].Cells[n].Value = tbNumber.Text;
            btnRemove.Enabled = true;
        }

        private void SortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int n = dgvArray.ColumnCount;
            if (n < 1)
                btnRemove.Enabled = false;
            else dgvArray.Columns.RemoveAt(n - 1);
            if (n < 13)
                dgvArray.Size = new Size(dgvArray.Size.Width, 25);
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !String.IsNullOrEmpty(tbNumber.Text);
        }

        private void tbRandom_TextChanged(object sender, EventArgs e)
        {
            btnRandom.Enabled = !String.IsNullOrEmpty(tbRandom.Text);
        }

        private void dgvArray_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int value;
            string cellValue = e.FormattedValue.ToString();
            if (!Int32.TryParse(cellValue, out value))
            {
                MessageBox.Show("Некорректное значение элемента массива!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void NumberValidating(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && (l != '\b'))
                e.Handled = true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbRandom.Text);
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
            if (n != 0)
                btnRemove.Enabled = true;
            else btnRemove.Enabled = false;
        }

        private int[] GetArray()
        {
            int n = dgvArray.ColumnCount;
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
                Array[i] = Convert.ToInt32(dgvArray.Rows[0].Cells[i].Value);
            return Array;
        }

        private void SetSortedArray(int[] Array)
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
                dgvSortedArray.Size = new Size(dgvArray.Size.Width, 40);
            else dgvSortedArray.Size = new Size(dgvArray.Size.Width, 25);
        }

        static void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                    if (Array[j] < Array[min])
                        min = j;
                Swap(ref Array[i], ref Array[min]);
            }
        }

        static void BubbleSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
                for (int j = 0; j < Array.Length - i - 1; j++)
                    if (Array[j] > Array[j + 1])
                        Swap(ref Array[j], ref Array[j + 1]);
        }

        static void ShakerSort(int[] Array)
        {
            int Left = 0;
            int Right = Array.Length - 1;
            while (Left <= Right)
            {
                for (int i = Left; i < Right; i++)
                    if (Array[i] > Array[i + 1])
                        Swap(ref Array[i], ref Array[i + 1]);
                Right--;
                for (int i = Right; i > Left; i--)
                    if (Array[i - 1] > Array[i])
                        Swap(ref Array[i - 1], ref Array[i]);
                Left++;
            }
        }

        static void QuickSort(int[] Array, int Start, int End)
        {
            if (Start >= End)
                return;
            int Border = Start;
            int Pivot = (new Random()).Next(Start, End + 1);
            for (int i = Start; i <= End; i++)
                if (Array[i] < Array[Pivot])
                {
                    Swap(ref Array[i], ref Array[Border]);
                    if (Border == Pivot)
                        Pivot = i;
                    Border++;
                }
            Swap(ref Array[Pivot], ref Array[Border]);
            QuickSort(Array, Start, Border - 1);
            QuickSort(Array, Border + 1, End);
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] Array = GetArray();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SelectionSort(Array);
            timer.Stop();
            SetSortedArray(Array);
            lblSortTime.Text = timer.Elapsed.ToString();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] Array = GetArray();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            BubbleSort(Array);
            timer.Stop();
            SetSortedArray(Array);
            lblSortTime.Text = timer.Elapsed.ToString();
        }

        private void btnShakerSort_Click(object sender, EventArgs e)
        {
            int[] Array = GetArray();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ShakerSort(Array);
            timer.Stop();
            SetSortedArray(Array);
            lblSortTime.Text = timer.Elapsed.ToString();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int[] Array = GetArray();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            QuickSort(Array, 0, Array.Length - 1);
            timer.Stop();
            SetSortedArray(Array);
            lblSortTime.Text = timer.Elapsed.ToString();
        }
    }
}
