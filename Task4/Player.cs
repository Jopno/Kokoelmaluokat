using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLiiga
{
    [Serializable]
    class Player
    {
        private string Fname { get; set; }
        private string Lname { get; set; }
        private int Number { get; set; }
        private string Handedness { get; set; }

        public Player(string fname, string lname, int number, string handedness)
        {
            Fname = fname;
            Lname = lname;
            Number = number;
            Handedness = handedness;
        }

        public override string ToString()
        {
            return Fname + " " + Lname + " Number: " + Number + " Handedness: " + Handedness;
        }
    }
}