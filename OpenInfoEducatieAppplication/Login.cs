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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://api.open-infoed.cristimacovei.dev/login";
            var req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            req.Accept = "application/json";
            req.ContentType = "application/json";

            //string email = emailTextBox.Text.Trim();
            //string password = passwordTextBox.Text.Trim();

            string email = "mirel28";
            string password = "cefacecainele";

            LoginData loginData = new LoginData(email, password);

            string data = JsonConvert.SerializeObject(loginData);

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

            Console.WriteLine(result);
            
            UserRequest fin = JsonConvert.DeserializeObject<UserRequest>(result);
            //var final = JsonConvert.DeserializeObject(result); 
            Console.WriteLine(fin.data.id);
            Console.WriteLine(res.StatusCode);

            int id = fin.data.id;

            new Interface(id).ShowDialog();

        }



    }
}
