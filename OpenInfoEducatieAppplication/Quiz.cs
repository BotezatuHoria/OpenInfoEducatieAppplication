using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    public class Quiz
    {
        private string _status;
        private List<QandA> _qanda;
        
        public Quiz()
        {

        }

        public Quiz(string _status, List<QandA> _qanda)
        {
            this._status = _status;
            this._qanda = _qanda;
        }

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        public List<QandA> data
        {
            get { return _qanda; }
            set { _qanda = value; }
        }

    }
}
