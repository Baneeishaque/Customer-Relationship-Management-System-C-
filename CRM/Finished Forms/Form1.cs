using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace CRM
{
    public partial class PrchaseForm : Form
    {
        int xPos = 0;
        int yPos = 0;
        public PrchaseForm()
        {
            InitializeComponent();
        }
        
        
        private void SetValues()
        {
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }
        private void closeTimer_Tick(object sender, EventArgs e)
        {
            
          

        }
        


        private void closeTimer_Tick_1(object sender, EventArgs e)
        {

            

        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginMaster l = new LoginMaster();

            label1.Text = l.txtUserName.Text;
            SetValues();
            closeTimer.Start();
        }

        private void closeTimer_Tick_2(object sender, EventArgs e)
        {
            closeTimer.Interval =0200;
            int curYPos = this.Location.Y;
            if (curYPos < yPos)
            {
                this.Location = new Point(xPos - this.Width, curYPos + 4);
                this.Opacity = this.Opacity - 0.015;
            }
            else
            {
                this.Close();
            }
        }
    }
}

