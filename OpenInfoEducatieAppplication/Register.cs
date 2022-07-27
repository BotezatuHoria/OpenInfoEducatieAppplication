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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var url = "https://api.open-infoed.cristimacovei.dev/signup";
            var req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            req.Accept = "application/json";
            req.ContentType = "application/json";

            string email = emailTextBox.Text.Trim();
            string fname = fNameTextBox.Text.Trim();
            string lname = lNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            User user = new User(email, fname, lname, password);

            string data = JsonConvert.SerializeObject(user);

            Console.WriteLine(data);


            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                streamWriter.Write(data);

            }

            var result = "nu";
            var res = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(res.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            var final = JsonConvert.DeserializeObject(result);
            Console.WriteLine(final);
            Console.WriteLine(res.StatusCode);

        }
    }
}
