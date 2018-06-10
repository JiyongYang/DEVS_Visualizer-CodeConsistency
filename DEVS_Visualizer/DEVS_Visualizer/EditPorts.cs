using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nevron.Diagram;
using Nevron.Diagram.Shapes;

namespace DEVS_Visualizer
{
    public partial class EditPorts : Form
    {
        private UDNGroup ep_shape;

        public EditPorts()
        {
            InitializeComponent();
        }

        public EditPorts(UDNGroup _shape)
        {
            InitializeComponent();
            ep_shape = _shape;
            EditPorts_init();
        }

        private void EditPorts_init()
        {
            
            for (int i = 0; i < ep_shape.UDPorts.Count; i++)
            {
                var tPort = ep_shape.UDPorts[i];

                if (tPort.Type == PortType.IN)
                {
                    lb_InPorts.Items.Add(tPort.Name);
                }
                else
                {
                    lb_OutPorts.Items.Add(tPort.Name);
                }
            }
            
            
        }

        private void btn_input_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_input_del_Click(object sender, EventArgs e)
        {
            if (lb_InPorts.SelectedIndex < 0) return;
        }

        private void btn_output_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_output_del_Click(object sender, EventArgs e)
        {
            if (lb_OutPorts.SelectedIndex < 0) return;
        }
    }
}
