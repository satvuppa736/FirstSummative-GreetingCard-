///Created By Satvir Uppal
///On September 20th 2016
///First Summative for Programming Class
///Follow me on Insta & Twitter @SatvirUppal
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FirstSummative_GreetingCard_
{
    public partial class greetingCard : Form
    {
        public greetingCard()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {


            Graphics formGraphics = this.CreateGraphics();

            SoundPlayer player = new SoundPlayer(Properties.Resources.dingSound);

            player.Play();

            Thread.Sleep(900);

            openButton.Visible = false;
            greetingLabel.Visible = false;
            nameLabel.Visible = false;
            dateLabel.Visible = false;

            formGraphics.Clear(Color.Black);

            Pen drawPen = new Pen(Color.White, 1);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            formGraphics.FillEllipse(drawBrush, 65, 207, 10, 10);
            formGraphics.DrawLine(drawPen, 65, 212, 101, 200);

            formGraphics.FillEllipse(drawBrush, 101, 194, 10, 10);
            formGraphics.DrawLine(drawPen, 101, 200, 180, 195);

            formGraphics.FillEllipse(drawBrush, 176, 184, 30, 30);
            formGraphics.DrawLine(drawPen, 187, 195, 188, 150);
            formGraphics.DrawLine(drawPen, 187, 195, 145, 145);

            formGraphics.FillEllipse(drawBrush, 182, 145, 10, 10);
            formGraphics.DrawLine(drawPen, 188, 150, 212, 102);
            formGraphics.FillEllipse(drawBrush, 204, 102, 20, 20);
            formGraphics.DrawLine(drawPen, 216, 102, 232, 78);
            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);
            formGraphics.DrawLine(drawPen, 216, 102, 232, 78);
            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);


            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);
            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);
            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            
            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);
            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);
                
            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);
            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);


            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);



           
            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);


        }
    }
}
