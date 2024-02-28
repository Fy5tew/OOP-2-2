using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02 {
    public partial class OutputForm : Form {
        public OutputForm(string output) {
            InitializeComponent();
            SetOutput(output);
        }

        private void SetOutput(string output) {
            outputTextBox.Text = output;
        }

        private void NoInput(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}
