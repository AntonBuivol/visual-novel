using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_novel
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            Scene1 scene1 = new Scene1();
            scene1.Show();
            this.Hide();
        }
    }
}
