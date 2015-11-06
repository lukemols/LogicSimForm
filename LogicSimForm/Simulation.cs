using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSimForm
{
    partial class Form1
    {
        List<Stim> AllStim;
        List<int> nodeChanged;
        int Time = 0;
        public void Simulate()
        {
            BuildTimeList();
            ///Lista dei nodi che cambiano valore
            nodeChanged = new List<int>();
            
            AllStim.Sort();
            Net.Sort();
            

            int Activity = 0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(OutFile))
            {
                Time = -1;
                do
                {
                    Activity = 0;
                    Time++;
                    while( AllStim.Count != 0  && AllStim[0].Time == Time)
                    {
                        Net[AllStim[0].Node].PS = Net[AllStim[0].Node].NS = AllStim[0].V;
                        nodeChanged.Add(AllStim[0].Node); //aggiungi alla lista dei nodi che cambiano valore
                        AllStim.RemoveAt(0);
                    }
                    file.WriteLine(" ");
                    file.WriteLine("Step: " + Time.ToString());
                    foreach (Node N in Net)
                    {
                        file.WriteLine("Node " + NodeNetRev[N.NodeNb] + "  " + N.NS.ToString());
                        ///Se il nodo è diverso da uno stimolo
                        if (N.GT != GateType.STIM)
                        {
                            //controlla se agli ingressi c'è stato un cambiamento
                            foreach (int i in N.Inputs)
                            {
                                if (nodeChanged.Contains(i))
                                {
                                    EvaluateNode(N);
                                    break;
                                    ///il break c'è per valutare il nodo per una volta sola
                                }
                            }
                        }
                    }
                    
                    foreach (Node N in Net)
                    {
                        if (N.PS != N.NS)
                        {
                            Activity++;
                            ///Se c'è stato un cambiamento aggiungilo alla lista degli stimoli
                            bool b = false;
                            if (N.NS == true)
                                b = true;
                            Stim stim = new Stim(b, Time + 1, N.NodeNb);
                            AllStim.Add(stim);
                            N.PS = N.NS;
                        }
                        
                    }
                    nodeChanged.Clear();
                    AllStim.Sort();
                } while (Activity > 0);
                
            }
        }

        public void BuildTimeList()
        {
            AllStim = new List<Stim>();
            for(int i=0; i < WaveList.Count; i++)
            {
                AllStim.AddRange(WaveList[i].WaveForm);
            }
        }
        public void EvaluateNode(Node N) 
        {
            switch (N.GT)
            {
                case GateType.NOT:
                    N.NS = !Net[N.Inputs[0]].PS;
                    break;
                case GateType.NOR2:
                    N.NS = !(Net[N.Inputs[0]].PS | Net[N.Inputs[1]].PS);
                    break;
                case GateType.NAND2:
                    N.NS = !(Net[N.Inputs[0]].PS & Net[N.Inputs[1]].PS);
                    break;
            }

        }

    }
}
