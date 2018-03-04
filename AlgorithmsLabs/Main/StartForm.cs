using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

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
            int Y = 45;
            List<Unit> Units = DatabaseController.GetUnits();
            foreach (Unit unit in Units)
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
                    Form form = (Form)Activator.CreateInstance(type, this);
                    form.Show();
                };
                Controls.Add(btn);
                Size = new Size(Size.Width, Size.Height + 50);
                Y += 50;
            }
        }
    }

    public struct Unit
    {
        public string form;
        public string name;
        public Unit(string _form, string _name)
        {
            form = _form;
            name = _name;
        }
    }
}
