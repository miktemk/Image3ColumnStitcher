namespace ImageSampler
{
	partial class Form1 : IProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnHand = new System.Windows.Forms.RadioButton();
            this.btnPoint = new System.Windows.Forms.RadioButton();
            this.btnRect = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(144, 37);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1644, 1323);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(1822, 37);
            this.txtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(700, 1320);
            this.txtBox.TabIndex = 4;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnHand
            // 
            this.btnHand.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnHand.AutoSize = true;
            this.btnHand.Image = global::ImageSampler.Properties.Resources.imgHand;
            this.btnHand.Location = new System.Drawing.Point(24, 37);
            this.btnHand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(54, 54);
            this.btnHand.TabIndex = 6;
            this.btnHand.TabStop = true;
            this.btnHand.UseVisualStyleBackColor = true;
            this.btnHand.CheckedChanged += new System.EventHandler(this.btnHand_CheckedChanged);
            // 
            // btnPoint
            // 
            this.btnPoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPoint.AutoSize = true;
            this.btnPoint.Image = global::ImageSampler.Properties.Resources.imgPoint;
            this.btnPoint.Location = new System.Drawing.Point(24, 186);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(54, 54);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.TabStop = true;
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.CheckedChanged += new System.EventHandler(this.btnPoint_CheckedChanged);
            // 
            // btnRect
            // 
            this.btnRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRect.AutoSize = true;
            this.btnRect.Image = global::ImageSampler.Properties.Resources.imgRect;
            this.btnRect.Location = new System.Drawing.Point(24, 329);
            this.btnRect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(54, 54);
            this.btnRect.TabIndex = 8;
            this.btnRect.TabStop = true;
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.CheckedChanged += new System.EventHandler(this.btnRect_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2550, 1383);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnHand);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.RadioButton btnHand;
		private System.Windows.Forms.RadioButton btnPoint;
		private System.Windows.Forms.RadioButton btnRect;
	}
}

