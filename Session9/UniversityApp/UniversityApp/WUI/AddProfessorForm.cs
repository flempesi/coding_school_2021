using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.Impl;

namespace UniversityApp {
    public partial class AddProfessorForm : Form {

        public Professor NewProfessor { get; set; }
        public bool somethingNotInserted;

        public AddProfessorForm() {
            InitializeComponent();
        }

        private void FormAddProfessor_Load(object sender, EventArgs e) {

        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            insertProfessorDetails();
            if (somethingNotInserted == false) {
                //  CLOSE THE FORM
                DialogResult = DialogResult.OK;
                Close();
            }

        }
        public void insertProfessorDetails() {
            somethingNotInserted = false;
            if (ctrlName.EditValue.ToString().Length > 0) {
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);
            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Name!");
            }
            if (Convert.ToInt32(ctrlAge.EditValue) > 0) {
                NewProfessor.Age = Convert.ToInt32(ctrlAge.EditValue);

            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Age!");
            }
            if (ctrlRank.EditValue.ToString().Length > 0) {

                NewProfessor.Rank= Convert.ToString(ctrlRank.EditValue);

            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Rank!");
            }
        }
    }
}
