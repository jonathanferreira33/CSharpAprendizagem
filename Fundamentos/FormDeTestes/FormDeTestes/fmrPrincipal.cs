using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDeTestes {
    public partial class fmrPrincipal : Form {
        public fmrPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Form form = new frmAvisoErro();
            form.Show();
            Thread.Sleep(5000);
            form.Close();
        }
    }
}
