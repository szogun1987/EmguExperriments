namespace EmguExperiments.BasicTransformations
{
    partial class BasicTransform
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
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFile = new System.Windows.Forms.Button();
            this.flipHorizontal = new System.Windows.Forms.Button();
            this.flipVertical = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(75, 23);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.openFile);
            this.flowLayoutPanel1.Controls.Add(this.flipHorizontal);
            this.flowLayoutPanel1.Controls.Add(this.flipVertical);
            this.flowLayoutPanel1.Controls.Add(this.rotate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 342);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 60);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(3, 3);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(250, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Otwórz plik";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // flipHorizontal
            // 
            this.flipHorizontal.Location = new System.Drawing.Point(259, 3);
            this.flipHorizontal.Name = "flipHorizontal";
            this.flipHorizontal.Size = new System.Drawing.Size(250, 23);
            this.flipHorizontal.TabIndex = 1;
            this.flipHorizontal.Text = "Odbicie w poziomie";
            this.flipHorizontal.UseVisualStyleBackColor = true;
            this.flipHorizontal.Click += new System.EventHandler(this.flip_Click);
            // 
            // flipVertical
            // 
            this.flipVertical.Location = new System.Drawing.Point(515, 3);
            this.flipVertical.Name = "flipVertical";
            this.flipVertical.Size = new System.Drawing.Size(250, 23);
            this.flipVertical.TabIndex = 2;
            this.flipVertical.Text = "Odbicie w pionie";
            this.flipVertical.UseVisualStyleBackColor = true;
            this.flipVertical.Click += new System.EventHandler(this.flipVertical_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 342);
            this.panel1.TabIndex = 4;
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(3, 32);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(250, 23);
            this.rotate.TabIndex = 3;
            this.rotate.Text = "Obrót";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // BasicTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BasicTransform";
            this.Size = new System.Drawing.Size(776, 402);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button flipHorizontal;
        private System.Windows.Forms.Button flipVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rotate;

    }
}
