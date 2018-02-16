using System;
using System.Windows.Forms;

namespace AlgorithmsLabs
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Hide();
            (new FindForm()).Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Hide();
            (new SortForm()).Show();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            Hide();
            (new MergeForm()).Show();
        }

        private void btnTraversal_Click(object sender, EventArgs e)
        {
            Hide();
            (new TraversalForm()).Show();
        }

        private void btnWay_Click(object sender, EventArgs e)
        {
            Hide();
            (new WayForm()).Show();
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            Hide();
            (new TreeForm()).Show();
        }
    }
}
