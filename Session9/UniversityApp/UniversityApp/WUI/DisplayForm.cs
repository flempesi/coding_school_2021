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
using UniversityApp;

namespace UniversityApp.WUI {
    public partial class DisplayForm : Form {
        public University UniversityDisplay { get; set; } 
        public DisplayForm(University codingSchool) {
            InitializeComponent();

            UniversityDisplay = codingSchool;
        }

        private void ctrlListDisplay_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void DisplayForm_Load(object sender, EventArgs e) {
            ctrlDisplayList.Items.Clear();
            ctrlDisplayList.Items.Add("STUDENTS \n");
            foreach (Student item in UniversityDisplay.Students) {

                ctrlDisplayList.Items.Add(string.Format("Name: {0} \t Age: {1} \t RegistrationNumber:{2}", item.Name, item.Age, item.RegistrationNumber));
            }
            ctrlDisplayList.Items.Add("PROFESSORS \n");
            foreach (Professor item in UniversityDisplay.Professors) {

                ctrlDisplayList.Items.Add(string.Format("Name: {0} \t Age: {1} \t Rank: {2}", item.Name, item.Age, item.Rank));
            }
            ctrlDisplayList.Items.Add("COURSES \n");
            foreach (Course item in UniversityDisplay.Courses) {

                ctrlDisplayList.Items.Add(string.Format("Subject: {0} \t Code:{1} ", item.Subject, item.Code));
            }

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
