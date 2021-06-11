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
    public partial class AddCourseForm : Form {

        public Course NewCourse { get; set; }
        public bool somethingNotInserted;
        public AddCourseForm() {
            InitializeComponent();
        }

        private void FormAddCourse_Load(object sender, EventArgs e) {

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
           
            insertCourseDetails();
            if (somethingNotInserted == false) {
                //  CLOSE THE FORM
                DialogResult = DialogResult.OK;
                Close();
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            Close();
        }

        public void insertCourseDetails() {

            somethingNotInserted = false;
            if (ctrlCode.EditValue.ToString().Length > 0) {
                NewCourse.Code = Convert.ToString(ctrlCode.EditValue);
            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Code!");
            }
            
            if (ctrlSubject.EditValue.ToString().Length > 0) {

                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);

            }
            else {
                somethingNotInserted = true;
                MessageBox.Show("Please insert Subject!");
            }
        }
    }
}

