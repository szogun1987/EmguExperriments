﻿namespace EmguExperiments.Draw
{
    partial class Multipoint
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
            this.points = new System.Windows.Forms.ListBox();
            this.newPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pointY = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointY)).BeginInit();
            this.SuspendLayout();
            // 
            // points
            // 
            this.points.DisplayMember = "Description";
            this.points.FormattingEnabled = true;
            this.points.Location = new System.Drawing.Point(12, 12);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(120, 160);
            this.points.TabIndex = 0;
            this.points.SelectedIndexChanged += new System.EventHandler(this.points_SelectedIndexChanged);
            // 
            // newPoint
            // 
            this.newPoint.Location = new System.Drawing.Point(138, 94);
            this.newPoint.Name = "newPoint";
            this.newPoint.Size = new System.Drawing.Size(123, 23);
            this.newPoint.TabIndex = 1;
            this.newPoint.Text = "Nowy punkt";
            this.newPoint.UseVisualStyleBackColor = true;
            this.newPoint.Click += new System.EventHandler(this.newPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // pointX
            // 
            this.pointX.Enabled = false;
            this.pointX.Location = new System.Drawing.Point(141, 28);
            this.pointX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(120, 20);
            this.pointX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // pointY
            // 
            this.pointY.Enabled = false;
            this.pointY.Location = new System.Drawing.Point(141, 68);
            this.pointY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(120, 20);
            this.pointY.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(105, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(186, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Anuluj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Multipoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 215);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pointY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPoint);
            this.Controls.Add(this.points);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Multipoint";
            this.Text = "Wprowadź punkty";
            ((System.ComponentModel.ISupportInitialize)(this.pointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox points;
        private System.Windows.Forms.Button newPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pointX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pointY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}