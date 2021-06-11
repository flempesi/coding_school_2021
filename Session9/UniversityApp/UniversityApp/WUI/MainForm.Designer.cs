
namespace UniversityApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlSerialize = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlDeSerialize = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(143, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(467, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "University managment";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(239, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(237, 67);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add Student";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(239, 209);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(237, 67);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Add Course";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(239, 293);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(237, 67);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Add Professor";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(668, 422);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(88, 53);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "EXIT";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlSerialize.Appearance.Options.UseFont = true;
            this.ctrlSerialize.Location = new System.Drawing.Point(52, 422);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(187, 29);
            this.ctrlSerialize.TabIndex = 5;
            this.ctrlSerialize.Text = "Serialize";
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlDeSerialize
            // 
            this.ctrlDeSerialize.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlDeSerialize.Appearance.Options.UseFont = true;
            this.ctrlDeSerialize.Location = new System.Drawing.Point(282, 422);
            this.ctrlDeSerialize.Name = "ctrlDeSerialize";
            this.ctrlDeSerialize.Size = new System.Drawing.Size(205, 29);
            this.ctrlDeSerialize.TabIndex = 6;
            this.ctrlDeSerialize.Text = "Deserialize";
            this.ctrlDeSerialize.Click += new System.EventHandler(this.ctrlDeSerialize_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 501);
            this.Controls.Add(this.ctrlDeSerialize);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton ctrlSerialize;
        private DevExpress.XtraEditors.SimpleButton ctrlDeSerialize;
    }
}

