﻿namespace Metro
{
    partial class TestForm
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
            this.metroButton1 = new Metro.Controls.MetroButton();
            this.metroButtonToggle1 = new Metro.Controls.MetroButtonToggle();
            this.metroCheckBox1 = new Metro.Controls.MetroCheckBox();
            this.metroCheckBox2 = new Metro.Controls.MetroCheckBox();
            this.metroButton2 = new Metro.Controls.MetroButton();
            this.metroButtonToggle2 = new Metro.Controls.MetroButtonToggle();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "MetroButton";
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonToggle1
            // 
            this.metroButtonToggle1.Location = new System.Drawing.Point(120, 41);
            this.metroButtonToggle1.Name = "metroButtonToggle1";
            this.metroButtonToggle1.Size = new System.Drawing.Size(102, 23);
            this.metroButtonToggle1.TabIndex = 2;
            this.metroButtonToggle1.Text = "MetroButtonToggle";
            this.metroButtonToggle1.UseVisualStyleBackColor = true;
            this.metroButtonToggle1.Value = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.Location = new System.Drawing.Point(12, 99);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(102, 17);
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "MetroCheckBox";
            this.metroCheckBox1.UseVisualStyleBackColor = false;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox2.Checked = true;
            this.metroCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox2.Enabled = false;
            this.metroCheckBox2.Location = new System.Drawing.Point(12, 122);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(67, 17);
            this.metroCheckBox2.TabIndex = 4;
            this.metroCheckBox2.Text = "Disabled";
            this.metroCheckBox2.UseVisualStyleBackColor = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(12, 70);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Disabled";
            this.metroButton2.UseVisualStyleBackColor = true;
            // 
            // metroButtonToggle2
            // 
            this.metroButtonToggle2.Enabled = false;
            this.metroButtonToggle2.Location = new System.Drawing.Point(120, 70);
            this.metroButtonToggle2.Name = "metroButtonToggle2";
            this.metroButtonToggle2.Size = new System.Drawing.Size(102, 23);
            this.metroButtonToggle2.TabIndex = 6;
            this.metroButtonToggle2.Text = "Disabled";
            this.metroButtonToggle2.UseVisualStyleBackColor = true;
            this.metroButtonToggle2.Value = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 253);
            this.Controls.Add(this.metroButtonToggle2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroButtonToggle1);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.Text = "Test form with long title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MetroButton metroButton1;
        private Controls.MetroButtonToggle metroButtonToggle1;
        private Controls.MetroCheckBox metroCheckBox1;
        private Controls.MetroCheckBox metroCheckBox2;
        private Controls.MetroButton metroButton2;
        private Controls.MetroButtonToggle metroButtonToggle2;


    }
}

