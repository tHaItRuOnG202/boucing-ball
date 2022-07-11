using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BongNay
{
    public partial class Form1 : Form
    {
        int dx = 5; // Độ dời theo phương ngang
        int dy = 7; // Độ dời theo phương dọc

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Nếu quả bóng đụng biên ngang --> đổi chiều
            if (picBall.Left <= 0 || picBall.Right >= ClientRectangle.Width)
                dx = -dx;
            // Nếu quả bóng đụng biên trên và dưới --> đổi chiều
            if (picBall.Top <= 0 || picBall.Bottom >= ClientRectangle.Height)
                dy = -dy;
            // Di chuyển quả bóng theo dx, dy
            picBall.Left += dx;
            picBall.Top += dy;
        }
    }
}
