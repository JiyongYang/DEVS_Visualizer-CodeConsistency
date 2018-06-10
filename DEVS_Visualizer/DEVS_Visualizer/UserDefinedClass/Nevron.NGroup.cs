using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nevron.Diagram;
using Nevron.Diagram.Shapes;

namespace DEVS_Visualizer
{
    public class UDNGroup : NGroup
    {
        private string uDFullName;
        private string uDUuid;
        private string uDId;
        private List<Port> uDInPorts;
        private List<Port> uDOutPorts;
        private List<Port> uDPorts;

        public string UDFullName
        {
            get { return uDFullName; }
            set { uDFullName = value; }
        }

        public string UDUuid
        {
            get { return uDUuid; }
            set { uDUuid = value; }
        }

        public string UDUdId
        {
            get { return uDId; }
            set { uDId = value; }
        }

        public List<Port> UDPorts
        {
            get { return uDPorts; }
            set { uDPorts = value; }
        }

        public List<Port> UDInPorts
        {
            get { return uDInPorts; }
            set { uDInPorts = value; }
        }

        public List<Port> UDOutPorts
        {
            get { return uDOutPorts; }
            set { uDOutPorts = value; }
        }
    }
}
