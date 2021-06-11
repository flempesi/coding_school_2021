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
    public partial class AddStudentForm : Form {
        
        public Student NewStudent { get; set; }
        public bool somethingNotInserted;

        public AddStudentForm() {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e) {

        }

        public void add_Student_Click(object sender, EventArgs e) {

            insertStudentDetails();
            if (somethingNotInserted == false) {
                //  CLOSE THE FORM
                DialogResult = DialogResult.OK;
                Close();
            }


        }
        public void insertStudentDetails() {
            somethingNotInserted = false;
            if (Convert.ToString(ctrlName.EditValue).Length > 0) {
                NewStudent.Name = Convert.ToString(ctrlName.EditValue);
            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Name!");
            }
            if (Convert.ToInt32(ctrlAge.EditValue) > 0) {
                NewStudent.Age = Convert.ToInt32(ctrlAge.EditValue);

            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Age!");
            }
            if (Convert.ToInt32(ctrlRegistrationNumber.EditValue) > 0) {

                NewStudent.RegistrationNumber = Convert.ToInt32(ctrlRegistrationNumber.EditValue);

            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert RegistrationNumber!");
            }
        }
        private void cancel_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;
            Close();
            
        }

        private void AddStudentForm_Load(object sender, EventArgs e) {

        }
    }
}
