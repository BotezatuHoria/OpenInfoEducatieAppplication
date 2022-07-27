using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{

    public class QandA
    {
        private Question _question;
        private List<Answer> _answers;

        QandA()
        {
            
        }

        QandA(Question _question, List<Answer> _answers)
        {
            this._question = _question;
            this._answers = _answers;
        }
        
        public Question question
        {
            get { return _question; }
            set { _question = value; }
        }

        public List<Answer> answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

    }
}
