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
                result = Find(rtbText.Text, tbTemplate.Text);
            else result = Find(rtbText.Text.ToLower(), tbTemplate.Text.ToLower());
            if (result != -1)
            {
                MessageBox.Show("Образ найден", "Поиск");
                rtbText.Focus();
                rtbText.SelectionStart = result;
                rtbText.SelectionLength = tbTemplate.Text.Length;
            } 
            else MessageBox.Show("Образ не найден", "Поиск");

        }

        private int[] Getd(string s)
        {
            int[] d = new int[char.MaxValue];
            for (int i = 0; i < d.Length; i++)
                d[i] = s.Length;
            for (int i = 0; i < s.Length; i++)
                d[s[i]] = s.Length - i;
            return d;
        }

        private int Find(string text, string template)
        {
            int[] d = Getd(template);
            for (int i = template.Length; i < text.Length + 1;)
                for (int j = template.Length - 1; j >= 0; j--)
                    if (template[j] == text[i - template.Length + j])
                    {
                        if (j == 0)
                            return (i - template.Length);
                    }
                    else
                    {
                        i += d[text[i]];
                        break;
                    }
            return -1;
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