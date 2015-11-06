using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LogicSimForm
{
    partial class Form1
    {
        int CurrNodenb = 0;

        
        void XMLNetLoad()
        {
            string Name = "";
            string In0 = "";
            string In1 = "";
            string Out = "";

            int OutNode = -1; int In0Node = -1; int In1Node = -1;

            XmlTextReader reader = new XmlTextReader(NetFile);

            reader.Read();

            if (reader.NodeType != XmlNodeType.Element) // The node is not an element.
            {
                Console.WriteLine("The NetList does not begin with \"Net\"");
                if (reader.Name != "net")
                {
                    Console.WriteLine("The NetList does not begin with \"Net\"");
                    return;
                }
            }
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        switch (reader.Name)
                        {
                            case "NOT":
                                while (reader.MoveToNextAttribute())
                                {
                                    switch (reader.Name)
                                    {
                                        case "name":
                                            Name = reader.Value;
                                            break;
                                        case "In":
                                            In0 = reader.Value;
                                            break;
                                        case "Out":
                                            Out = reader.Value;
                                            break;
                                    }
                                }

                                VerExist(Out, ref OutNode);
                                VerExist(In0, ref In0Node);

                                Net.Add(new Node(GateType.NOT, Name, In0Node, OutNode));
                                break;
                            case "NOR2":
                                while (reader.MoveToNextAttribute())
                                {
                                    switch (reader.Name)
                                    {
                                        case "name":
                                            Name = reader.Value;
                                            break;
                                        case "In0":
                                            In0 = reader.Value;
                                            break;
                                        case "In1":
                                            In1 = reader.Value;
                                            break;
                                        case "Out":
                                            Out = reader.Value;
                                            break;
                                    }
                                }
                                VerExist(Out, ref OutNode);
                                VerExist(In0, ref In0Node);
                                VerExist(In1, ref In1Node);
                                Net.Add(new Node(GateType.NOR2, Name, In0Node, In1Node, OutNode));
                                break;
                            case "Stimulus":
                                while (reader.MoveToNextAttribute())
                                {
                                    switch (reader.Name)
                                    {
                                        case "name":
                                            Name = reader.Value;
                                            break;
                                        case "Out":
                                            Out = reader.Value;
                                            break;
                                    }
                                }
                                VerExist(Out, ref OutNode);
                                Net.Add(new Node(GateType.STIM, Name, OutNode));
                                break;
                            default:
                                Console.WriteLine(reader.Name, "unrecognized element");
                                return;
                        }
                        break;
                
                }
            }
        }
        public void VerExist(String S, ref int N)
        {
            if (NodeNet.ContainsKey(S))
            {
                N = NodeNet[S];
            }
            else
            {
                NodeNet.Add(S, CurrNodenb);
                NodeNetRev.Add(S);
                N = CurrNodenb++;
            }
        }

    }
}
