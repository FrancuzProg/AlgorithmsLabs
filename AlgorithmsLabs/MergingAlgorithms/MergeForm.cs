using System;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class MergeForm : Form
    {
        StartForm MainForm;

        MergeController Controller = new MergeController();

        public MergeForm(StartForm main)
        {
            InitializeComponent();
            MainForm = main;
            Controller.SetStartPath(tbPath);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            Controller.GetPath(tbPath);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string FileName = tbPath.Text;
            lblSortTime.Text = Controller.SortArray(FileName);
        }

        private void btnRandomSort_Click(object sender, EventArgs e)
        {
            lblSortTime.Text = Controller.SortRandomArray(Convert.ToInt32(tbN.Text));
        }

        private void tbN_TextChanged(object sender, EventArgs e)
        {
            btnRandomSort.Enabled = !String.IsNullOrEmpty(tbN.Text);
        }

        private void NumberValidating(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && (l != '\b'))
                e.Handled = true;
        }

        private void MergeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}