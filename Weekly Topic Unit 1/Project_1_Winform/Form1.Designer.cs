﻿namespace Project_1_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMessagePopup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // btnMessagePopup
            // 
            this.btnMessagePopup.Location = new System.Drawing.Point(814, 595);
            this.btnMessagePopup.Name = "btnMessagePopup";
            this.btnMessagePopup.Size = new System.Drawing.Size(305, 81);
            this.btnMessagePopup.TabIndex = 1;
            this.btnMessagePopup.Text = "Exit The Application";
            this.btnMessagePopup.UseVisualStyleBackColor = true;
            this.btnMessagePopup.Click += new System.EventHandler(this.btn_exit);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(350, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(345, 169);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Message Box Popup";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnMessageBoxPopup);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMessagePopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1155, 706);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMessagePopup);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Project 1 - Kenneth Rodriguez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMessagePopup;
        private System.Windows.Forms.Button btnExit;
    }
}

