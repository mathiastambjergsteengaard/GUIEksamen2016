using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GUIVinterEksamen20152016.Annotations;

namespace GUIVinterEksamen20152016
{
    public class QuestionAnswer:INotifyPropertyChanged
    {
        private string _question;

        public string Question
        {
            get { return _question; }
            set
            {
                _question = value;
                OnPropertyChanged();
            }
        }

        private string _a;

        public string A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged();
            }
        }
        private string _b;

        public string B
        {
            get { return _b; }
            set
            {
                _b = value;
                OnPropertyChanged();
            }
        }

        private string _c;

        public string C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged();
            }
        }

        private string _d;

        public string D
        {
            get { return _d; }
            set
            {
                _d = value;
                OnPropertyChanged();
            }
        }

        private string _rightAnswer;

        public string RightAnswer
        {
            get { return _rightAnswer; }
            set
            {
                _rightAnswer = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
