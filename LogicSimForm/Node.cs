using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSimForm
{
    public enum GateType {NOT, NOR2, NAND2, STIM};
    public class Node: IComparable<Node>
    {

        public GateType GT;
        public int[] Inputs;  	//  Inputs
        public int NodeNb; 	// Node Number
        public string Name;
        public bool? PS, NS;

        public Node(GateType G, String S, int NdNb)
        {
            GT = G;
            Name = S;
            NodeNb = NdNb;
        }
        public Node(GateType G, string S, int In, int NdNb)
        {
            GT = G;
            Name = S;
            Inputs = new int[1];
            NodeNb = NdNb;
            Inputs[0] = In;
        }
        public Node(GateType G, string S, int In0, int In1, int NdNb)
        {
            GT = G;
            Name = S;
            Inputs = new int[2];
            Inputs[0] = In0;
            Inputs[1] = In1;
            NodeNb = NdNb;
            PS = null; ;
        }

        public int CompareTo(Node N)
        {
            return NodeNb.CompareTo(N.NodeNb);
        }




    }
}
