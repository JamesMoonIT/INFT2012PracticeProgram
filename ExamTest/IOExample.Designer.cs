
namespace ExamTest
{
    partial class frmIO
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
            this.btnImport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCypher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(55, 161);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(99, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Textfile";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 143);
            this.textBox1.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(363, 161);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Textfile";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 143);
            this.textBox2.TabIndex = 3;
            // 
            // btnCypher
            // 
            this.btnCypher.Location = new System.Drawing.Point(220, 80);
            this.btnCypher.Name = "btnCypher";
            this.btnCypher.Size = new System.Drawing.Size(75, 23);
            this.btnCypher.TabIndex = 4;
            this.btnCypher.Text = "Convert";
            this.btnCypher.UseVisualStyleBackColor = true;
            this.btnCypher.Click += new System.EventHandler(this.btnCypher_Click);
            // 
            // frmIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 244);
            this.Controls.Add(this.btnCypher);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnImport);
            this.Name = "frmIO";
            this.Text = "IOExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCypher;
    }
}