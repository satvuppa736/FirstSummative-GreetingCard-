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

            openButton.Visible = false;
            greetingLabel.Visible = false;
            nameLabel.Visible = false;
            dateLabel.Visible = false;

            formGraphics.Clear(Color.Black);

            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            formGraphics.FillEllipse(drawBrush, 251, 41, 10, 10);
            formGraphics.FillEllipse(drawBrush, 55, 207, 10, 10);

        }
    }
}
