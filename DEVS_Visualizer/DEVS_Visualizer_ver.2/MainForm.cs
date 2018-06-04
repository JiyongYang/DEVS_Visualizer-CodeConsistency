using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DEVS_Visualizer_ver._2
{
    public partial class MainForm : Form
    {
        
        public Model OutmostModel;
        public Dictionary<string, Model> ModulePool;
        public Dictionary<string, BaseModel> BaseModels;

        private string OutmostModelName;

        List<UDNGroup> inPortList;
        List<UDNGroup> outPortList;
        List<UDNGroup> instanceList;
        MultiKeyDictionary<string, string, UDNGroup> objMDict;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
