using System;
using System.Windows.Forms;

namespace HelloGuiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text;
            MessageBox.Show("Hello, " + userName + "!", "Greeting");
        }
    }
}
