using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Newtonsoft.Json;

namespace GUIVinterEksamen20152016
{
    public class FileDeserializer
    {
        public Quiz Deserialize(string filepath)
        {
            string jsonstring = File.ReadAllText(Properties.Settings.Default.FilePath);
            var jsondto = new List<Dto>();
            jsondto = JsonConvert.DeserializeObject<List<Dto>>(jsonstring);
            var quiz = new Quiz();
            foreach (var VARIABLE in jsondto)
            {
                var Question = new QuestionAnswer();
                Question.Question = VARIABLE.Question;
                Question.A = VARIABLE.A;
                Question.B = VARIABLE.B;
                Question.C = VARIABLE.C;
                Question.D = VARIABLE.D;
                Question.RightAnswer = VARIABLE.RightAnswer;
                quiz.Add(Question);
            }
            return quiz;
        }

            public class Dto
            {
                public string Question { get; set; }
                public string A { get; set; }
                public string B { get; set; }
                public string C { get; set; }
                public string D { get; set; }
                public string RightAnswer { get; set; }
            }

    }
}
