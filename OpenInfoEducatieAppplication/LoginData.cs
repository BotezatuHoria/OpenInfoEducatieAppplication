using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    class LoginData
    {
        private string _email, _password;

        public LoginData()
        {

        }

        public LoginData(string _email, string _password)
        {
            this._email = _email;
            this._password = _password;
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
