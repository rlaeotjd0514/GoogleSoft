using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOOGLESOFT.ComputeClass;
using Google.Apis.Compute.v1;

namespace GOOGLESOFT
{
    public partial class ComputeApiForm : Form
    {
        public ComputeApiForm(AuthResponse ATT)
        {
            InitializeComponent();
            this.ATT = ATT;
        }

        private AuthResponse ATT;

        private void ComputeApiForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateInstanceButton_Click(object sender, EventArgs e)
        {
            var Server = new ComputeServiceInstance("youtube-gui-225813", "YOUTUBE GUI", ATT);
            Server.TestCreateInstance("kimjjang-31", "asia-east1-a", "zones/asia-east1-a/machineTypes/n1-standard-1", "debian-9", "debian-cloud", 100);
        }
    }
}
