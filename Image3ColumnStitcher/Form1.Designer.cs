using MyShittyControls;
namespace ImageSampler
{
	partial class Form1
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
            this.lblTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnSwitchWH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.previewPanel = new MyShittyControls.CropperPanel();
            this.imageCropperCrapper4 = new MyShittyControls.ImageCropperCrapper();
            this.imageCropperCrapper3 = new MyShittyControls.ImageCropperCrapper();
            this.imageCropperCrapper2 = new MyShittyControls.ImageCropperCrapper();
            this.imageCropperCrapper1 = new MyShittyControls.ImageCropperCrapper();
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(932, 704);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(92, 17);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "debug output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preview:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(471, 707);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(117, 22);
            this.txtWidth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(703, 707);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(117, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // btnSwitchWH
            // 
            this.btnSwitchWH.Location = new System.Drawing.Point(609, 695);
            this.btnSwitchWH.Name = "btnSwitchWH";
            this.btnSwitchWH.Size = new System.Drawing.Size(75, 34);
            this.btnSwitchWH.TabIndex = 6;
            this.btnSwitchWH.Text = "switch";
            this.btnSwitchWH.UseVisualStyleBackColor = true;
            this.btnSwitchWH.Click += new System.EventHandler(this.btnSwitchWH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 687);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "height";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(935, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 83);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE!!!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.CropRect = null;
            this.previewPanel.Image = null;
            this.previewPanel.ImageHeight = 0;
            this.previewPanel.ImageLeft = 0;
            this.previewPanel.ImageTop = 0;
            this.previewPanel.ImageWidth = 0;
            this.previewPanel.Location = new System.Drawing.Point(453, 384);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(410, 296);
            this.previewPanel.TabIndex = 2;
            this.previewPanel.TabStop = false;
            // 
            // imageCropperCrapper4
            // 
            this.imageCropperCrapper4.AllowDrop = true;
            this.imageCropperCrapper4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageCropperCrapper4.CropSpec = null;
            this.imageCropperCrapper4.Location = new System.Drawing.Point(12, 364);
            this.imageCropperCrapper4.Name = "imageCropperCrapper4";
            this.imageCropperCrapper4.Size = new System.Drawing.Size(399, 340);
            this.imageCropperCrapper4.TabIndex = 0;
            // 
            // imageCropperCrapper3
            // 
            this.imageCropperCrapper3.AllowDrop = true;
            this.imageCropperCrapper3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageCropperCrapper3.CropSpec = null;
            this.imageCropperCrapper3.Location = new System.Drawing.Point(817, 12);
            this.imageCropperCrapper3.Name = "imageCropperCrapper3";
            this.imageCropperCrapper3.Size = new System.Drawing.Size(394, 346);
            this.imageCropperCrapper3.TabIndex = 0;
            // 
            // imageCropperCrapper2
            // 
            this.imageCropperCrapper2.AllowDrop = true;
            this.imageCropperCrapper2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageCropperCrapper2.CropSpec = null;
            this.imageCropperCrapper2.Location = new System.Drawing.Point(417, 12);
            this.imageCropperCrapper2.Name = "imageCropperCrapper2";
            this.imageCropperCrapper2.Size = new System.Drawing.Size(394, 346);
            this.imageCropperCrapper2.TabIndex = 0;
            // 
            // imageCropperCrapper1
            // 
            this.imageCropperCrapper1.AllowDrop = true;
            this.imageCropperCrapper1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageCropperCrapper1.CropSpec = null;
            this.imageCropperCrapper1.Location = new System.Drawing.Point(12, 12);
            this.imageCropperCrapper1.Name = "imageCropperCrapper1";
            this.imageCropperCrapper1.Size = new System.Drawing.Size(399, 346);
            this.imageCropperCrapper1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 746);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSwitchWH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.imageCropperCrapper4);
            this.Controls.Add(this.imageCropperCrapper3);
            this.Controls.Add(this.imageCropperCrapper2);
            this.Controls.Add(this.imageCropperCrapper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private MyShittyControls.ImageCropperCrapper imageCropperCrapper1;
        private MyShittyControls.ImageCropperCrapper imageCropperCrapper2;
        private MyShittyControls.ImageCropperCrapper imageCropperCrapper3;
        private MyShittyControls.ImageCropperCrapper imageCropperCrapper4;
        private System.Windows.Forms.Label lblTest;
        private CropperPanel previewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnSwitchWH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;


    }
}

