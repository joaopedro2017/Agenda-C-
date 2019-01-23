using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e) {
            lblData.Text = "Data: " + DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
        }
    }
}
