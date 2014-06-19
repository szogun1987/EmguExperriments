namespace EmguExperiments.Draw
{
    partial class Draw
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillConvexPolygon = new System.Windows.Forms.Button();
            this.circleViaGdi = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thickness = new System.Windows.Forms.NumericUpDown();
            this.color = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.newPicture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fillConvexPolygon);
            this.panel1.Controls.Add(this.circleViaGdi);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.thickness);
            this.panel1.Controls.Add(this.color);
            this.panel1.Controls.Add(this.circle);
            this.panel1.Controls.Add(this.newPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 72);
            this.panel1.TabIndex = 0;
            // 
            // fillConvexPolygon
            // 
            this.fillConvexPolygon.Location = new System.Drawing.Point(435, 33);
            this.fillConvexPolygon.Name = "fillConvexPolygon";
            this.fillConvexPolygon.Size = new System.Drawing.Size(133, 23);
            this.fillConvexPolygon.TabIndex = 8;
            this.fillConvexPolygon.Text = "Powłoka wypukła";
            this.fillConvexPolygon.UseVisualStyleBackColor = true;
            // 
            // circleViaGdi
            // 
            this.circleViaGdi.Location = new System.Drawing.Point(435, 4);
            this.circleViaGdi.Name = "circleViaGdi";
            this.circleViaGdi.Size = new System.Drawing.Size(133, 23);
            this.circleViaGdi.TabIndex = 7;
            this.circleViaGdi.Text = "Okrąg via GDI+";
            this.circleViaGdi.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(296, 4);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(133, 23);
            this.rectangle.TabIndex = 1;
            this.rectangle.Text = "Prostokąt";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grubość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kolor";
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(206, 33);
            this.thickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(84, 20);
            this.thickness.TabIndex = 3;
            this.thickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Location = new System.Drawing.Point(206, 4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(84, 23);
            this.color.TabIndex = 2;
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(296, 33);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(133, 23);
            this.circle.TabIndex = 6;
            this.circle.Text = "Okrąg";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // newPicture
            // 
            this.newPicture.Location = new System.Drawing.Point(4, 4);
            this.newPicture.Name = "newPicture";
            this.newPicture.Size = new System.Drawing.Size(133, 23);
            this.newPicture.TabIndex = 0;
            this.newPicture.Text = "Nowy obraz";
            this.newPicture.UseVisualStyleBackColor = true;
            this.newPicture.Click += new System.EventHandler(this.newPicture_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.imageBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 356);
            this.panel2.TabIndex = 1;
            // 
            // imageBox
            // 
            this.imageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(226, 144);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Draw";
            this.Size = new System.Drawing.Size(833, 428);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newPicture;
        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown thickness;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button circleViaGdi;
        private System.Windows.Forms.Button fillConvexPolygon;
    }
}
