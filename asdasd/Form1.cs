using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdasd
{
    public partial class Form1 : Form
    {
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
           
        }



        

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                btn.Dispose();
                Button button = new Button();
                button.Font = new Font("F", 20, FontStyle.Bold);
                button.AutoSize = true;
                button.Text = "Button";
                button.MouseEnter += button1_MouseEnter;                
                Random random = new Random();
                int W = random.Next(this.Size.Width - 100);
                int H = random.Next(this.Size.Height - 100);
                button.Location = new Point(W, H);
                this.Controls.Add(button);
                Color randomColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256));
                BackColor = randomColor;

            }



        }
    }
}
