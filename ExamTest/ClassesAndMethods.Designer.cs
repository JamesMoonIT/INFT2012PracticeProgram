
namespace ExamTest
{
    partial class frmClassesAndMethods
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
            this.txbxStudentList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbxStudentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbxStudentList
            // 
            this.txbxStudentList.Location = new System.Drawing.Point(29, 30);
            this.txbxStudentList.Multiline = true;
            this.txbxStudentList.Name = "txbxStudentList";
            this.txbxStudentList.Size = new System.Drawing.Size(100, 187);
            this.txbxStudentList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbxStudentName
            // 
            this.txbxStudentName.Location = new System.Drawing.Point(198, 30);
            this.txbxStudentName.Name = "txbxStudentName";
            this.txbxStudentName.Size = new System.Drawing.Size(100, 23);
            this.txbxStudentName.TabIndex = 2;
            // 
            // frmClassesAndMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 282);
            this.Controls.Add(this.txbxStudentName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbxStudentList);
            this.Name = "frmClassesAndMethods";
            this.Text = "Classes And Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxStudentList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbxStudentName;
    }
}