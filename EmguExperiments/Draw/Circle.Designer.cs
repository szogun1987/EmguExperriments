namespace EmguExperiments.Draw
{
    partial class Circle
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
            this.centerX = new System.Windows.Forms.NumericUpDown();
            this.centerY = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.centerX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            this.SuspendLayout();
            // 
            // centerX
            // 
            this.centerX.Location = new System.Drawing.Point(94, 7);
            this.centerX.Name = "centerX";
            this.centerX.Size = new System.Drawing.Size(120, 20);
            this.centerX.TabIndex = 0;
            // 
            // centerY
            // 
            this.centerY.Location = new System.Drawing.Point(94, 33);
            this.centerY.Name = "centerY";
            this.centerY.Size = new System.Drawing.Size(120, 20);
            this.centerY.TabIndex = 1;
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(94, 59);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(120, 20);
            this.radius.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Środek X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Środek Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promień";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(58, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(139, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 119);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.centerY);
            this.Controls.Add(this.centerX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Circle";
            this.Text = "Okrąg";
            ((System.ComponentModel.ISupportInitialize)(this.centerX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown centerX;
        private System.Windows.Forms.NumericUpDown centerY;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}