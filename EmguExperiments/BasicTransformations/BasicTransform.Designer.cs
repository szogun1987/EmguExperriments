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
            this.flip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(724, 342);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.openFile);
            this.flowLayoutPanel1.Controls.Add(this.flip);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 342);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 60);
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
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(259, 3);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(250, 23);
            this.flip.TabIndex = 1;
            this.flip.Text = "Odbicie";
            this.flip.UseVisualStyleBackColor = true;
            // 
            // BasicTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BasicTransform";
            this.Size = new System.Drawing.Size(724, 402);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button flip;

    }
}
