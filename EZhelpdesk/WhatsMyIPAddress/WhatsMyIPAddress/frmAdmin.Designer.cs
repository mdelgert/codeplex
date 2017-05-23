namespace Helpdesk
{
    partial class frmAdmin
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCPUNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJavaInstalled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblCPUNumber
            // 
            this.lblCPUNumber.AutoSize = true;
            this.lblCPUNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUNumber.Location = new System.Drawing.Point(31, 9);
            this.lblCPUNumber.Name = "lblCPUNumber";
            this.lblCPUNumber.Size = new System.Drawing.Size(166, 20);
            this.lblCPUNumber.TabIndex = 1;
            this.lblCPUNumber.Text = "Number of Processors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Install Java Version:";
            // 
            // lblJavaInstalled
            // 
            this.lblJavaInstalled.AutoSize = true;
            this.lblJavaInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavaInstalled.Location = new System.Drawing.Point(420, 322);
            this.lblJavaInstalled.Name = "lblJavaInstalled";
            this.lblJavaInstalled.Size = new System.Drawing.Size(125, 13);
            this.lblJavaInstalled.TabIndex = 3;
            this.lblJavaInstalled.Text = "Version of Java Installed:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 445);
            this.Controls.Add(this.lblJavaInstalled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCPUNumber);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCPUNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJavaInstalled;
    }
}