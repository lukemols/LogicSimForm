using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSimForm
{
    public class Stim: IComparable<Stim>
    {
        public bool V; //valore
        public int Time;
        public int Node; // numero del nodo

        public Stim(bool Vl, int T, int N)
        {
            V = Vl;
            Time = T;
            Node = N;

        }

        public int CompareTo(Stim S)
        {
            return Time.CompareTo(S.Time);
        }
        
    }

    public class wave
    {
        public string Generator;
        public int TimeStep;
        public int Start;
        public List<Stim> WaveForm;

        public wave(string Name, int St, int TS)
        {
            Generator = String.Copy(Name);
            TimeStep = TS;
            Start = St;
            WaveForm = new List<Stim>();
        }
    }
}


