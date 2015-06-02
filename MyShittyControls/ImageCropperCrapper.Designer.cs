namespace MyShittyControls
{
    partial class ImageCropperCrapper
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
            this.pictureBox = new MyShittyControls.CropperPanel();
            this.btnTillTop = new System.Windows.Forms.Button();
            this.btnTillBottom = new System.Windows.Forms.Button();
            this.btnTillLeft = new System.Windows.Forms.Button();
            this.btnTillRight = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.CropRect = null;
            this.pictureBox.Image = null;
            this.pictureBox.ImageHeight = 0;
            this.pictureBox.ImageLeft = 0;
            this.pictureBox.ImageTop = 0;
            this.pictureBox.ImageWidth = 0;
            this.pictureBox.Location = new System.Drawing.Point(17, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 224);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnTillTop
            // 
            this.btnTillTop.Location = new System.Drawing.Point(104, 248);
            this.btnTillTop.Name = "btnTillTop";
            this.btnTillTop.Size = new System.Drawing.Size(62, 33);
            this.btnTillTop.TabIndex = 1;
            this.btnTillTop.Text = "till top";
            this.btnTillTop.UseVisualStyleBackColor = true;
            this.btnTillTop.Click += new System.EventHandler(this.btnTillTop_Click);
            // 
            // btnTillBottom
            // 
            this.btnTillBottom.Location = new System.Drawing.Point(91, 297);
            this.btnTillBottom.Name = "btnTillBottom";
            this.btnTillBottom.Size = new System.Drawing.Size(87, 33);
            this.btnTillBottom.TabIndex = 1;
            this.btnTillBottom.Text = "till bottom";
            this.btnTillBottom.UseVisualStyleBackColor = true;
            this.btnTillBottom.Click += new System.EventHandler(this.btnTillBottom_Click);
            // 
            // btnTillLeft
            // 
            this.btnTillLeft.Location = new System.Drawing.Point(17, 274);
            this.btnTillLeft.Name = "btnTillLeft";
            this.btnTillLeft.Size = new System.Drawing.Size(68, 33);
            this.btnTillLeft.TabIndex = 1;
            this.btnTillLeft.Text = "<-- left";
            this.btnTillLeft.UseVisualStyleBackColor = true;
            this.btnTillLeft.Click += new System.EventHandler(this.btnTillLeft_Click);
            // 
            // btnTillRight
            // 
            this.btnTillRight.Location = new System.Drawing.Point(184, 274);
            this.btnTillRight.Name = "btnTillRight";
            this.btnTillRight.Size = new System.Drawing.Size(83, 33);
            this.btnTillRight.TabIndex = 1;
            this.btnTillRight.Text = "right -->";
            this.btnTillRight.UseVisualStyleBackColor = true;
            this.btnTillRight.Click += new System.EventHandler(this.btnTillRight_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(282, 274);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(96, 33);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "FULL!!!";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ImageCropperCrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTillRight);
            this.Controls.Add(this.btnTillLeft);
            this.Controls.Add(this.btnTillBottom);
            this.Controls.Add(this.btnTillTop);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImageCropperCrapper";
            this.Size = new System.Drawing.Size(396, 340);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyShittyControls.CropperPanel pictureBox;
        private System.Windows.Forms.Button btnTillTop;
        private System.Windows.Forms.Button btnTillBottom;
        private System.Windows.Forms.Button btnTillLeft;
        private System.Windows.Forms.Button btnTillRight;
        private System.Windows.Forms.Button btnAll;
    }
}
