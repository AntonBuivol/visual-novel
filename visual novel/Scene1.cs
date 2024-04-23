using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        int textIndex = 0;
        string[] text = {"This is some text to be `typed`...", "Some new text", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" };

        bool stoptyping = false;

        private async void Label_Click(object sender, EventArgs e)
        {
            stoptyping = true;
            await Task.Delay(50);
            stoptyping = false;
            textIndex = (textIndex + 1) % text.Length;
            await TypeWriterEffect(text[textIndex], Label, 50);
        }

        public Task TypeWriterEffect(string txt, Label lbl, int delay)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= txt.Length; i++)
                {
                    if(stoptyping)
                    {
                        break;
                    }
                    lbl.Invoke((MethodInvoker)delegate {
                        lbl.Text = txt.Substring(0, i);
                    });
                    System.Threading.Thread.Sleep(delay); ;
                }
            });
        }

    }
}
