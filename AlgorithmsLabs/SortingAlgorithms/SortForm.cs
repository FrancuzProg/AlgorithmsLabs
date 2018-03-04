using System;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class SortForm : Form
    {
        StartForm MainForm;

        SortController Controller = new SortController();

        public SortForm(StartForm main)
        {
            InitializeComponent();
            MainForm = main;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.AddElement(dgvArray, tbNumber.Text);
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Controller.RemoveElement(dgvArray);
            if (dgvArray.ColumnCount < 1)
                btnRemove.Enabled = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbRandom.Text);
            Controller.FillRandom(dgvArray, n);
            if (n != 0)
                btnRemove.Enabled = true;
            else btnRemove.Enabled = false;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Controller.SortArray(dgvArray, dgvSortedArray, (sender as Button).Name);
            lblCompare.Text = Sort.GetCompareCount().ToString();
            lblSwap.Text = Sort.GetSwapCount().ToString();
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

        private void SortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
