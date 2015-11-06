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
        void XMLStimLoad()
        {
            string Name = "";
            int TS=-1;
            int St=-1;
            int WaveNode = -1;

            bool StimVal = true;
            int Tm = -1;

            WaveList = new List<wave>();
            XmlTextReader reader = new XmlTextReader(StimFile);

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Element) // The node is not an element.
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.EndElement)
                            break;
                        if (reader.NodeType == XmlNodeType.Element) // The node is not an element.
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                switch (reader.Name)
                                {
                                    case "comp":
                                        Name = reader.Value;
                                        break;
                                    case "TimeStep":
                                        TS = Convert.ToInt32(reader.Value);
                                        break;
                                    case "Start":
                                        St = Convert.ToInt32(reader.Value);
                                        break;
                                }
                            }
                            foreach(Node N in Net)
                            {
                                if(String.Compare(Name, N.Name) == 0)
                                {
                                    WaveNode = N.NodeNb;
                                }
                            }
                            if(WaveNode == -1)
                            {
                                Console.WriteLine("The Waveform is not associated to a valid component");
                                Environment.Exit(1);
                            }
                            wave CurrWave = new wave(Name, St, TS);
                            bool StartState = true;
                            if (St == 0)
                                StartState = false;
                            
                            WaveList.Add(CurrWave);
                            CurrWave.WaveForm.Add(new Stim(StartState, 0, WaveNode));
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.EndElement)
                                    break;
                                if (reader.NodeType != XmlNodeType.Element)
                                    continue;
                                while (reader.MoveToNextAttribute())
                                {
                                    switch (reader.Name)
                                    {
                                        case "type":
                                            if(String.Compare(reader.Value, "1") == 0)
                                                StimVal = true;
                                            else
                                                StimVal = false;
                                            break;
                                        case "time":
                                            Tm = Convert.ToInt32(reader.Value);
                                            break;
                                    }
                                }
                                CurrWave.WaveForm.Add(new Stim(StimVal, Tm, WaveNode));
                            }
                        }
                    }
                }
            }
            Tm = -1;
        }
    }
}
