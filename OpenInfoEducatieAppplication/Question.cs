using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    public class Question
    {
        private int _id;
        private string _prompt;
        Question()
        {

        }

        Question(string _prompt)
        {
            //this._id = _id;
            this._prompt = _prompt;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string prompt
        {
            get { return _prompt; }
            set { _prompt = value; }
        }
    }
}
