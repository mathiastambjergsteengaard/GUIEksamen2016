using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIVinterEksamen20152016
{
    public class Player
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _studyNumber;

        public int StudyNumber
        {
            get { return _studyNumber; }
            set { _studyNumber = value; }
        }

        private int _points;

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

    }
}
