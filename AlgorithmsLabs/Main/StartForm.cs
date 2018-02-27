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

        /*private void LoadButtons()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo info = new DirectoryInfo(path);
            info = info.Parent.Parent;
            DirectoryInfo[] dirs = info.GetDirectories("*Algorithms");
            int Y = 45;
            foreach (DirectoryInfo dir in dirs)
            {
                string name = dir.GetFiles("*Form.cs")[0].Name;
                name = name.Substring(0, name.Length - 3);
                Button btn = new Button();
                btn.Location = new Point(40, Y);
                btn.Name = "AlgorithmsLabs." + name;
                btn.Text = name;
                btn.Size = new Size(140, 40);
                btn.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    string TypeName = (sender as Button).Name;
                    Type type = Type.GetType(TypeName);
                    Form form = (Form)Activator.CreateInstance(type);
                    form.Show();
                };
                Controls.Add(btn);
                Size = new Size(Size.Width, Size.Height + 50);
                Y += 50;
            }
        }*/

        private void LoadButtons()
        {
            int Y = 45;
            foreach (Unit unit in UnitsKeeper.Units)
            {
                Button btn = new Button();
                btn.Location = new Point(40, Y);
                btn.Name = unit.form;
                btn.Text = unit.name;
                btn.Size = new Size(140, 40);
                btn.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    string TypeName = (sender as Button).Name;
                    Type type = Type.GetType(TypeName);
                    Form form = (Form)Activator.CreateInstance(type);
                    form.Show();
                };
                Controls.Add(btn);
                Size = new Size(Size.Width, Size.Height + 50);
                Y += 50;
            }
        }

        /*private void LoadButtons()
        {
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
        }*/
    }
}
