
namespace ExamTest
{
    partial class frmList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbxList = new System.Windows.Forms.TextBox();
            this.txbxNewValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblListSize = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbxList
            // 
            this.txbxList.Location = new System.Drawing.Point(38, 29);
            this.txbxList.Multiline = true;
            this.txbxList.Name = "txbxList";
            this.txbxList.Size = new System.Drawing.Size(100, 226);
            this.txbxList.TabIndex = 0;
            // 
            // txbxNewValue
            // 
            this.txbxNewValue.Location = new System.Drawing.Point(194, 29);
            this.txbxNewValue.Name = "txbxNewValue";
            this.txbxNewValue.Size = new System.Drawing.Size(148, 23);
            this.txbxNewValue.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add From Textbox";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(194, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove From Textbox";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblListSize
            // 
            this.lblListSize.AutoSize = true;
            this.lblListSize.Location = new System.Drawing.Point(55, 11);
            this.lblListSize.Name = "lblListSize";
            this.lblListSize.Size = new System.Drawing.Size(60, 15);
            this.lblListSize.TabIndex = 4;
            this.lblListSize.Text = "List Size: 0";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(194, 170);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(276, 170);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(66, 23);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 278);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblListSize);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbxNewValue);
            this.Controls.Add(this.txbxList);
            this.Name = "frmList";
            this.Text = "List Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxList;
        private System.Windows.Forms.TextBox txbxNewValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblListSize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
    }
}

