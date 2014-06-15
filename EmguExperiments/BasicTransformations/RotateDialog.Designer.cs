namespace EmguExperiments.BasicTransformations
{
    partial class RotateDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.centerX = new System.Windows.Forms.NumericUpDown();
            this.centerY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interpolation = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.crop = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Środek X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Środek Y";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(113, 12);
            this.angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(120, 20);
            this.angle.TabIndex = 2;
            // 
            // centerX
            // 
            this.centerX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.centerX.Location = new System.Drawing.Point(113, 38);
            this.centerX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.centerX.Name = "centerX";
            this.centerX.Size = new System.Drawing.Size(120, 20);
            this.centerX.TabIndex = 3;
            // 
            // centerY
            // 
            this.centerY.Location = new System.Drawing.Point(113, 64);
            this.centerY.Name = "centerY";
            this.centerY.Size = new System.Drawing.Size(120, 20);
            this.centerY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kąt obrotu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ interpolacji";
            // 
            // interpolation
            // 
            this.interpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interpolation.FormattingEnabled = true;
            this.interpolation.Location = new System.Drawing.Point(113, 91);
            this.interpolation.Name = "interpolation";
            this.interpolation.Size = new System.Drawing.Size(121, 21);
            this.interpolation.TabIndex = 7;
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Location = new System.Drawing.Point(113, 118);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(120, 23);
            this.color.TabIndex = 8;
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kolor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Obcięcie";
            // 
            // crop
            // 
            this.crop.AutoSize = true;
            this.crop.Location = new System.Drawing.Point(113, 147);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(15, 14);
            this.crop.TabIndex = 11;
            this.crop.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(157, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(76, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RotateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.color);
            this.Controls.Add(this.interpolation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.centerY);
            this.Controls.Add(this.centerX);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RotateDialog";
            this.Text = "Obrót";
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.NumericUpDown centerX;
        private System.Windows.Forms.NumericUpDown centerY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox interpolation;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox crop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}