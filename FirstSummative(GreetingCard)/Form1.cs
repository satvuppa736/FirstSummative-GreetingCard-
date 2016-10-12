///Created By Satvir Uppal
///On September 20th 2016
///First Summative for Programming Class
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

            //Plays sound when card is initially opened                                                                                   

            player.Play();

            Thread.Sleep(900);

            //makes opening title card invisible

            openButton.Visible = false;
            greetingLabel.Visible = false;
            nameLabel.Visible = false;
            dateLabel.Visible = false;

            //Clears Screen

            formGraphics.Clear(Color.Black);            

            Pen drawPen = new Pen(Color.White, 1);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //Creates Constellation 

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 65, 207, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 101, 194, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 176, 184, 30, 30);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 182, 145, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 204, 102, 20, 20);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            
            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);
            
            Thread.Sleep(500);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 65, 212, 101, 200);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 101, 200, 180, 195);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 187, 195, 188, 150);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 187, 195, 145, 145);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 188, 150, 212, 102);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 216, 102, 232, 78);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 216, 102, 232, 78);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 232, 78, 253, 45);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);

            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            //Plays "twinkle" sound

            SoundPlayer twinkle = new SoundPlayer(Properties.Resources.twinkle);    
            twinkle.Play();

            Thread.Sleep(1600);

            //Color Change

            drawPen  = new Pen(Color.Blue);
            drawBrush = new SolidBrush(Color.Gold);

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);

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
            formGraphics.DrawLine(drawPen, 232, 78, 253, 45);

            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);
            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);
            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);
            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);

            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);
            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(200);

            //Color Change

            drawPen = new Pen(Color.Yellow);
            drawBrush = new SolidBrush(Color.Purple);

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);

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
            formGraphics.DrawLine(drawPen, 232, 78, 253, 45);

            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);
            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);
            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);
            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);

            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);
            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(200);

            //Color Change

            drawPen = new Pen(Color.LimeGreen);
            drawBrush = new SolidBrush(Color.RoyalBlue);

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);

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
            formGraphics.DrawLine(drawPen, 232, 78, 253, 45);

            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);
            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);
            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);
            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);

            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);
            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(200);

            //Color Change

            drawPen = new Pen(Color.Blue);
            drawBrush = new SolidBrush(Color.Gold);

            formGraphics.FillEllipse(drawBrush, 45, 171, 15, 15);

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
            formGraphics.DrawLine(drawPen, 232, 78, 253, 45);

            formGraphics.FillEllipse(drawBrush, 141, 139, 15, 15);
            formGraphics.DrawLine(drawPen, 145, 145, 104, 149);
            formGraphics.DrawLine(drawPen, 145, 145, 182, 91);

            formGraphics.FillEllipse(drawBrush, 177, 91, 12, 12);
            formGraphics.DrawLine(drawPen, 180, 93, 210, 102);

            formGraphics.FillEllipse(drawBrush, 149, 61, 20, 20);
            formGraphics.DrawLine(drawPen, 180, 93, 153, 65);

            formGraphics.FillEllipse(drawBrush, 102, 147, 10, 10);
            formGraphics.DrawLine(drawPen, 105, 150, 50, 175);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);

            formGraphics.FillEllipse(drawBrush, 227, 78, 10, 10);

            Thread.Sleep(200);

            //Plays "Whoop" Sound

            SoundPlayer sounds = new SoundPlayer(Properties.Resources.whoop);  
            sounds.Play();
            
            Graphics fg = this.CreateGraphics();

            Font drawFont = new Font("Courier Serif", 9, FontStyle.Bold);
            SolidBrush fontBrush = new SolidBrush(Color.HotPink);

            //Writes text explain constellation

            fg.DrawString("Virgo is one of the constellations of the zodiac." , drawFont, fontBrush, 5, 350);
            fg.DrawString("It's name is Latin for 'virgin', and its symbol is ♍.", drawFont, fontBrush, 5, 370);
            fg.DrawString("Lying between Leo to the west and Libra to the east,", drawFont, fontBrush, 5, 385);
            fg.DrawString("it is the second largest constellation in the sky.", drawFont, fontBrush, 5, 400);
        }
    }
}
