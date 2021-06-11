
namespace UniversityApp.WUI {
    partial class DisplayForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlDisplayList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDisplayList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDisplayList
            // 
            this.ctrlDisplayList.Location = new System.Drawing.Point(25, 12);
            this.ctrlDisplayList.Name = "ctrlDisplayList";
            this.ctrlDisplayList.Size = new System.Drawing.Size(750, 380);
            this.ctrlDisplayList.TabIndex = 0;
            this.ctrlDisplayList.SelectedIndexChanged += new System.EventHandler(this.ctrlListDisplay_SelectedIndexChanged);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlCancel.Appearance.Options.UseFont = true;
            this.ctrlCancel.Location = new System.Drawing.Point(673, 409);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(94, 29);
            this.ctrlCancel.TabIndex = 1;
            this.ctrlCancel.Text = "Close";
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlDisplayList);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDisplayList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl ctrlDisplayList;
        private DevExpress.XtraEditors.SimpleButton ctrlCancel;
    }
}