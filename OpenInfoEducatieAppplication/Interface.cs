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
        int pace = 0;
        List<int> list = new List<int>();
        int id;
        string name;
        private int panX = 0, panY = 0;
        Quiz quiz = new Quiz();
        private string currentFile = null;

        int targetTime = 25 * 60 * 1000;
        int elapsedTime = 0;

        System.Windows.Forms.Timer clock = new System.Windows.Forms.Timer();
        Label pomoLabel = new Label();

        public Interface(int _id, string _name)
        {
            id = _id;
            name = _name;
            InitializeComponent();
            nameLabel.Text = "Hello, " + name + "!";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Login().ShowDialog();
        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            EraseContent();
            nameLabel.Visible = false;
            nameLabel.Enabled = false;
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
            if (ok == false)
                ActualCalc();
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
            SendData(sleep, ent, hmw, grass);

        }

        private void SendData(int sleep, int ent, int work, int outside)
        {
            int sleepTime = sleep;
            int entertainmentTime = ent;
            int workTime = work;
            int outsideTime = outside;

            var url = "https://api.open-infoed.cristimacovei.dev/add-tracker-data";
            var req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            req.Accept = "application/json";
            req.ContentType = "application/json";

            string day = DateTime.Today.ToString();

            string json = "{\"userId\": " + id.ToString() + ", \"day\": \"" + day + "\", \"data\": {\"sleep\": " + sleepTime.ToString() + ", \"entertainment\": " + entertainmentTime.ToString() + ", \"work\": " + workTime.ToString() + ", \"outside\": " + outsideTime.ToString() + "}}";
            
            Console.WriteLine(json);

            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                streamWriter.Write(json);

            }

            var result = "nu";
            var res = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(res.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Console.WriteLine(result);

        }

        public void EraseContent()
        {
            appPanel.Controls.Clear();
            flowLayoutPanel.Controls.Clear();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            //Notification notification = new Notification();
            //notification.ShowAlert("Test");
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = false;
            nameLabel.Enabled = false;
            EraseContent();
            flowLayoutPanel.Visible = true;
            flowLayoutPanel.Enabled = true;
            pace = 0;
            //new Test().ShowDialog();
            appPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.BringToFront();

            GenPanel("Quiz1", "Quiz");

        }

        public void GenPanel(string name, string tg)
        {
            Panel panel = new Panel();
            panel.Width = 250;
            panel.Height = 250;
            panel.BackColor = Color.Navy;
            panel.Location = new Point(panX, panY);
            panX = panel.Location.X;
            panY = panel.Location.Y;

            Button button = new Button();
            button.Location = new Point(panX + 40, panY + 175);
            button.Width = 175;
            button.Height = 50;
            if (tg == "Quiz")
                button.Click += StartQuiz;
            else
            {
                button.Click += StartPdfView;
                button.Tag = tg;
            }
                
            Label label = new Label();
            label.AutoSize = false;
            label.Text = name;
            label.ForeColor = Color.White;
            label.Location = new Point(panX + 50, panY + 50);
            label.Width = 175;
            label.Height = 50;
            //label.TextAlign
            label.TextAlign = ContentAlignment.TopLeft;


            panel.Controls.Add(button);
            panel.Controls.Add(label);
            //appPanel.Controls.Add(panel);
            flowLayoutPanel.Controls.Add(panel);
        }

        public void StartQuiz(object sender, EventArgs e)
        {
            flowLayoutPanel.Enabled = false;
            flowLayoutPanel.Visible = false;
            verifButton.Enabled = true;
            verifButton.Visible = true;

            var url = "https://api.open-infoed.cristimacovei.dev/questions";
            var req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "GET";
            req.Accept = "application/json";
            req.ContentType = "application/json";

            var result = "nu";
            var res = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(res.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            
            Console.WriteLine(result);
            quiz = JsonConvert.DeserializeObject<Quiz>(result);
            Console.WriteLine(quiz.data[0].question.prompt + quiz.data[0].answers[0].prompt);
            Button button = new Button();
            GenQuiz(0);
        }

        public void GenQuiz(int i)
        {
            Label label = new Label();
            label.Text = quiz.data[i].question.prompt;
            label.ForeColor = Color.Black;
            appPanel.Controls.Add(label);

            int dist = 25;
            int pX = label.Location.X;
            int pY = label.Location.Y;
            foreach(Answer answer in quiz.data[i].answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = answer.prompt;
                radioButton.Location = new Point(pX, pY + dist);
                radioButton.AutoSize = false;
                radioButton.Tag = answer.isCorrect;
                radioButton.Width = 450;
                pY += dist;
                appPanel.Controls.Add(radioButton);
            }
        }

        private void articleButton_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel.Controls.Clear();
            //appPanel.Controls.Clear();
            //Console.WriteLine("SSSSS");
            nameLabel.Visible = false;
            nameLabel.Enabled = false;
            EraseContent();
            flowLayoutPanel.Visible = true;
            flowLayoutPanel.Enabled = true;
            flowLayoutPanel.BringToFront();
            appPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.BringToFront();
            List<string> list = new List<string>() { "https://lumenpublishing.com/journals/index.php/po/article/download/2277/pdf/6101", "https://sync.ithra.com/reports/SYNC_Global_digital_well-being_report_EN.pdf" };
            foreach (string article in list)
            {
                GenPanel("Article", article);
            }

        }

        public void NextClick(object sender, EventArgs e)
        {
            if (ValidateAnswer() == true)
                Console.WriteLine("nu mere");
            else
                Console.WriteLine("mere");
            EraseContent();
            if (pace < quiz.data.Count - 1)
            {
                pace++;
                GenQuiz(pace);
            }
            else
            {
                quizButton_Click(sender, e);
                verifButton.Enabled = false;
                verifButton.Visible = false;
            }
            
        }

        private void pomoButton_Click(object sender, EventArgs e)
        {
            EraseContent();
            nameLabel.Visible = false;
            nameLabel.Enabled = false;
            Button startButton = new Button();
            startButton.Location = new Point(150, 350);
            startButton.BackColor = Color.Red;
            startButton.Click += StartTime;
            appPanel.Controls.Add(pomoLabel);
            appPanel.Controls.Add(startButton);

        }

        public bool ValidateAnswer()
        {
            foreach (Control i in appPanel.Controls)
            {
                if (i is RadioButton)
                {
                    var box = (RadioButton)i;
                    if (Convert.ToBoolean(box.Checked) == Convert.ToBoolean(box.Tag) && Convert.ToBoolean(box.Tag) == true)
                        return true;
                }
            }
            return false;
        }

        public void StartPdfView(object sender, EventArgs e)
        {
            currentFile = ((Button)sender).Tag.ToString();
            Console.WriteLine(currentFile);
            
            new PDF(currentFile).ShowDialog();
        }

        private void StartTime(object sender, EventArgs e)
        {
            clock.Tick += new EventHandler(TimerEventProcessor);

            clock.Interval = 1000;
            clock.Start();
        }

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            int minutes = (targetTime - elapsedTime) / 1000 / 60;
            int seconds = ((targetTime - elapsedTime) / 1000) % 60;

            pomoLabel.Text = minutes.ToString() + " : " + seconds.ToString();

            elapsedTime += 1000;

            if (targetTime < elapsedTime + 1000)
            {
                Console.WriteLine("cainele");

                Notification notification = new Notification();
                notification.ShowAlert(targetTime == 5 * 60 * 1000 ? "Get back to work!" : "Take a break!");
                
            }

            if (targetTime < elapsedTime) { 
                elapsedTime = 0;

                targetTime = 60 * 1000 * (targetTime == 5 * 60 * 1000 ? 25 : 5);
            }
               
        }

        private void GetData()
        {
            //TODO Implement this feature
        }

    }
}
