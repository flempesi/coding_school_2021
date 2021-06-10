using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session8 {
    public partial class FormAddStudent : Form {
        public string NameFull { get; set; }
        public int Age { get; set; }
        public int RegistrationNumber { get; set; }


        public FormAddStudent() {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e) {

        }

        public void add_Student_Click(object sender, EventArgs e) {
            NameFull = textEdit1.Text;
            Age = Convert.ToInt32(spinEdit1.EditValue);
            RegistrationNumber = Convert.ToInt32(textEdit2.Text);
            
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
