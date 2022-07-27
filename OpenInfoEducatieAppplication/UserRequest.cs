using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    class UserRequest
    {
        User _user;
        string _status;

        UserRequest()
        {

        }

        UserRequest(string status, User userData)
        {
            _status = status;
            _user = userData;
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public User data
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
