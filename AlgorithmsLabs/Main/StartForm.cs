using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            LoadButtons();
        }

        private void LoadButtons()
        {
            /*StreamWriter SW = new StreamWriter("Units.txt");
            SW.WriteLine(typeof(FindForm).FullName);
            SW.WriteLine("Поиск");
            SW.WriteLine(typeof(SortForm).FullName);
            SW.WriteLine("Сортировка");
            SW.WriteLine(typeof(MergeForm).FullName);
            SW.WriteLine("Слияние");
            SW.Close();*/
            StreamReader SR = new StreamReader("Units.txt");
            int Y = 45;
            while(!SR.EndOfStream)
            {
                Button btn = new Button();
                btn.Location = new Point(40, Y);
                btn.Name = SR.ReadLine();
                btn.Size = new Size(140, 40);
                try
                {
                    btn.Text = SR.ReadLine();
                } catch
                {
                    MessageBox.Show("База модулей заполнена некоректно!", "Ошибка");
                    return;
                }
                try
                {
                    btn.Click += (object sender, EventArgs e) =>
                    {
                        Hide();
                        string TypeName = (sender as Button).Name;
                        Type type = Type.GetType(TypeName);
                        Form form = (Form)Activator.CreateInstance(type);
                        form.Show();
                    };
                } catch
                {
                    MessageBox.Show("Не найден указанный модуль!", "Ошибка");
                    continue;
                }
                Controls.Add(btn);
                Size = new Size(Size.Width, Size.Height + 50);
                Y += 50;
            }
            SR.Close();
        }
    }
}
