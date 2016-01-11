using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIVinterEksamen20152016
{
    public class QuizMaster
    {
        public void NewQuestion(QuizView.CurrentQuestion cur, QuestionAnswer que)
        {
            cur.Question = que.Question;
            cur.A = que.A;
            cur.B = que.B;
            cur.C = que.C;
            cur.D = que.D;
            cur.RightAnswer = que.RightAnswer;
        }

        public int localCounter { get; set; }
        public int Counter { get; set; }

        public int HandleAnswer(QuizView.CurrentQuestion question, string answer)
        {
            if (question.RightAnswer == answer)
                return 0;
            if (localCounter == 0)
            {
                localCounter++;
                return 2;
            }
            if (localCounter == 1)
            {
                localCounter++;
                return 2;
            }
            if (localCounter == 2)
            {
                localCounter = 0;
                return 4;
            }
            return 0;
        }

        
    }
}
