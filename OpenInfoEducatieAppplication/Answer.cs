using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    public class Answer
    {

        private int _id, _questionId;
        private string _prompt;
        private bool _isCorrect;

        Answer()
        {

        }

        Answer(string prompt, int questionId, bool isCorrect)
        {
            this._prompt = prompt;
            this._questionId = questionId;
            this._isCorrect = isCorrect;
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

        public int questionId
        {
            get { return _questionId; }
            set { _questionId = value; }
        }

        public bool isCorrect
        {
            get { return _isCorrect; }
            set { _isCorrect = value; }
        }

    }
}
