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
    public partial class FormAddCourse : Form {

        public string Code { get; set; }
        public string Subject { get; set; }
        public FormAddCourse() {
            InitializeComponent();
        }

        private void FormAddCourse_Load(object sender, EventArgs e) {

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Code = textEdit1.Text;
            Subject = textEdit2.Text;
           
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
