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
    public partial class Scene1 : Form
    {
        public Scene1()
        {
            InitializeComponent();
        }

        private async void Label_Click(object sender, EventArgs e)
        {
            await TypeWriterEffect("This is some text to be `typed`...", Label, 50);
        }

        public Task TypeWriterEffect(string txt, Label lbl, int delay)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= txt.Length; i++)
                {
                    lbl.Invoke((MethodInvoker)delegate {
                        lbl.Text = txt.Substring(0, i);
                    });
                    System.Threading.Thread.Sleep(delay); ;
                }
            });
        }

    }
}
