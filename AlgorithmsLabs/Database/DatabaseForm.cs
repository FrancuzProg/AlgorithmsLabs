using System;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class DatabaseForm : Form
    {
        StartForm MainForm;

        public DatabaseForm(StartForm main)
        {
            InitializeComponent();
            MainForm = main;
            DatabaseController.LoadData(dgvSortings);
        }

        private void DatabaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void dgvSortings_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = dgvSortings.SelectedRows.Count != 0;
            if (dgvSortings.SelectedRows.Count != 0)
                DatabaseController.LoadData(dvgIterations, dgvSortings.SelectedRows[0].Index);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сортировку с id - " + dgvSortings.SelectedRows[0].Cells[0].Value + '?', "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DatabaseController.Detete(dgvSortings.SelectedRows[0].Index);
                dgvSortings.Rows.RemoveAt(dgvSortings.SelectedRows[0].Index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvSortings.RowCount != 0)
                if (MessageBox.Show("Вы действительно хотите удалить все сортировки", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DatabaseController.DeteteAll();
                    dgvSortings.Rows.Clear();
                }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
