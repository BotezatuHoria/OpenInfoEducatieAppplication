using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace OpenInfoEducatieAppplication
{
    public partial class Interface : Form
    {

        private int lastPosX = 0, lastPosY = 0;
        List<int> list = new List<int>();

        public Interface()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().ShowDialog();
        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            Label question = new Label();
            question.Text = "How many hours did you spend:";
            question.AutoSize = false;
            question.Width = 1000;
            question.Height = 100;
            question.BackColor = Color.Blue;

            lastPosX = question.Location.X;
            lastPosY = question.Location.Y;

            appPanel.Controls.Add(question);
            GenerateNewStat("Entertainment", 150);
            GenerateNewStat("Outside:", 75);
            GenerateNewStat("Sleep", 75);
            GenerateNewStat("Homework", 75);

            Button buttonSend = new Button();
            buttonSend.Location = new Point(lastPosX + 500, lastPosY);
            buttonSend.Click += LazyCalculator;
            buttonSend.Text = "apasa";

            Label result = new Label();
            result.Location = new Point(lastPosX + 400, lastPosY - 200);
            result.AutoSize = false;
            result.BackColor = Color.Green;
            result.Text = "";


            appPanel.Controls.Add(buttonSend);
            appPanel.Controls.Add(result);

        }

        public void GenerateNewStat(string name, int dist)
        {
            Label label = new Label();
            label.Text = name;
            label.AutoSize = false;
            label.Location = new Point(lastPosX, lastPosY + dist);
            label.Width = 200;
            label.Height = 50;
            label.BackColor = Color.Red;
            lastPosX = label.Location.X;
            lastPosY = label.Location.Y;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(label.Location.X + 210, label.Location.Y);
            textBox.Height = 50;
            textBox.Multiline = true;

            appPanel.Controls.Add(label);
            appPanel.Controls.Add(textBox);
        }

        private void LazyCalculator(object sender, EventArgs e)
        {
            
            foreach (Control txt in appPanel.Controls)
            {
                if (txt is TextBox)
                {
                    int rsp;
                    try
                    {
                        rsp = Convert.ToInt32(txt.Text);
                        list.Add(rsp);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Check the fields for errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                }
            }

            int sum = 0;
            bool ok = false;
            for (int i = 0; i < list.Count; ++i)
            {
                sum += list[i];
            }
            if (sum > 24)
            {
                MessageBox.Show("There are only 24 hours in a day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = true;
            }
            if (ok == true)
                ActualCalc();
            for (int i = 0; i < list.Count; ++i)
                Console.WriteLine(list[i]);
        }

        private void ActualCalc()
        {
            Label label = new Label();
            foreach (Control lbl in appPanel.Controls)
            {
                if (lbl is Label && lbl.Text == "")
                {
                    label = (Label)lbl;
                }
                    
            }
            int ent = list[0];
            int grass = list[1];
            int sleep = list[2];
            int hmw = list[3];
            
            if (sleep < 8)
            {
                label.Text = "You need to sleep more!";
            }
            else
            {
                if (grass < 2)
                    label.Text = "You should consider spending more time off screen!";
                else
                {
                    if (hmw < 6)
                        label.Text = "You should consider working more!";
                    else
                        label.Text = "Keep up the good work!!!";
                }
                    
            }

        }
        private void SendData()
        {
            var url = "https://api.open-infoed.cristimacovei.dev/add-tracker-data";
            var req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            req.Accept = "application/json";
            req.ContentType = "application/json";

            /*var data = @"{
                'userId': 
                day: string
                data: {
                sleep: integer
                entertainment: integer
                work: integer
                outside: integer
                }
            }"*/
        }
    }
}
