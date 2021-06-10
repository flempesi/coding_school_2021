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
    public partial class FormAddProfessor : Form {
        public string NameFull;
        public int Age { get; set; }

        public string Rank { get; set; }
        

        public FormAddProfessor() {
            InitializeComponent();
        }

        private void FormAddProfessor_Load(object sender, EventArgs e) {

        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            NameFull = textEdit1.Text;
            Age = Convert.ToInt32(spinEdit1.EditValue);
            Rank = textEdit2.Text;
            this.Close();

        }
    }
}
