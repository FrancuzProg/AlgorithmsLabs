using System;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int result;
            if (cbRegister.Checked)
                result = BouerMoure.Find(rtbText.Text, tbTemplate.Text);
            else result = BouerMoure.Find(rtbText.Text.ToLower(), tbTemplate.Text.ToLower());
            if (result != -1)
            {
                MessageBox.Show("Образ найден", "Поиск");
                rtbText.Focus();
                rtbText.SelectionStart = result;
                rtbText.SelectionLength = tbTemplate.Text.Length;
            } 
            else MessageBox.Show("Образ не найден", "Поиск");

        }

        private void tbTemplate_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = (tbTemplate.Text.Length != 0);
            cbRegister.Enabled = (tbTemplate.Text.Length != 0);
        }

        private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}