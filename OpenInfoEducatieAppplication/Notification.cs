using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenInfoEducatieAppplication
{
    public partial class Notification : Form
    {

        public enum enm
        {
            wait, start, close
        }

        public Notification()
        {
            InitializeComponent();
        }

        private Notification.enm action;

        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enm.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enm.wait:
                    timer1.Interval = 5000;
                    action = enm.close;
                    break;
                case enm.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enm.wait;
                        }
                    }
                    break;
                case enm.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void ShowAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for(int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notification notification = (Notification)Application.OpenForms[fname];

                if (notification == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.label1.Text = msg;

            this.Show();
            this.action = enm.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }

    }
}
