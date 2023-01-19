namespace AutoClicker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.txtSeconds = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkLeft = new System.Windows.Forms.CheckBox();
			this.chkRight = new System.Windows.Forms.CheckBox();
			this.richTxt1 = new System.Windows.Forms.RichTextBox();
			this.lblRunning = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "How fast should I click?";
			// 
			// txtSeconds
			// 
			this.txtSeconds.Location = new System.Drawing.Point(11, 63);
			this.txtSeconds.Name = "txtSeconds";
			this.txtSeconds.Size = new System.Drawing.Size(34, 20);
			this.txtSeconds.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "milliseconds.";
			// 
			// chkLeft
			// 
			this.chkLeft.AutoSize = true;
			this.chkLeft.Location = new System.Drawing.Point(11, 12);
			this.chkLeft.Name = "chkLeft";
			this.chkLeft.Size = new System.Drawing.Size(69, 17);
			this.chkLeft.TabIndex = 7;
			this.chkLeft.Text = "Left-click";
			this.chkLeft.UseVisualStyleBackColor = true;
			this.chkLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkLeft_MouseClick);
			// 
			// chkRight
			// 
			this.chkRight.AutoSize = true;
			this.chkRight.Location = new System.Drawing.Point(11, 28);
			this.chkRight.Name = "chkRight";
			this.chkRight.Size = new System.Drawing.Size(76, 17);
			this.chkRight.TabIndex = 8;
			this.chkRight.Text = "Right-click";
			this.chkRight.UseVisualStyleBackColor = true;
			this.chkRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkRight_MouseClick);
			// 
			// richTxt1
			// 
			this.richTxt1.BackColor = System.Drawing.Color.White;
			this.richTxt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTxt1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTxt1.Location = new System.Drawing.Point(12, 89);
			this.richTxt1.Name = "richTxt1";
			this.richTxt1.ReadOnly = true;
			this.richTxt1.Size = new System.Drawing.Size(198, 33);
			this.richTxt1.TabIndex = 9;
			this.richTxt1.TabStop = false;
			this.richTxt1.Text = "TIP: Go into the game and CTRL+left-click anywhere to start/stop the autoclicking" +
    ".";
			this.richTxt1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTxt1_MouseClick);
			// 
			// lblRunning
			// 
			this.lblRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRunning.AutoSize = true;
			this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRunning.Location = new System.Drawing.Point(138, 9);
			this.lblRunning.Name = "lblRunning";
			this.lblRunning.Size = new System.Drawing.Size(66, 13);
			this.lblRunning.TabIndex = 10;
			this.lblRunning.Text = "(not running)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(216, 122);
			this.Controls.Add(this.lblRunning);
			this.Controls.Add(this.richTxt1);
			this.Controls.Add(this.chkRight);
			this.Controls.Add(this.chkLeft);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSeconds);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "AutoClicker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSeconds;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkLeft;
		private System.Windows.Forms.CheckBox chkRight;
		private System.Windows.Forms.RichTextBox richTxt1;
		private System.Windows.Forms.Label lblRunning;
	}
}

