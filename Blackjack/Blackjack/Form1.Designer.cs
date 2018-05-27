namespace Blackjack
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblDealerGetal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSpeler1Getal = new System.Windows.Forms.Label();
			this.btnHit1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblSpeler2Getal = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSpeler3Getal = new System.Windows.Forms.Label();
			this.btnHit2 = new System.Windows.Forms.Button();
			this.btnHit3 = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop1 = new System.Windows.Forms.Button();
			this.btnStop2 = new System.Windows.Forms.Button();
			this.btnStop3 = new System.Windows.Forms.Button();
			this.lblInzetSpeler3 = new System.Windows.Forms.Label();
			this.lblInzetSpeler2 = new System.Windows.Forms.Label();
			this.lblInzetSpeler1 = new System.Windows.Forms.Label();
			this.lblInzet1Euro = new System.Windows.Forms.Label();
			this.lblInzet5Euro = new System.Windows.Forms.Label();
			this.lblInzet25Euro = new System.Windows.Forms.Label();
			this.btnReady = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(285, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dealer";
			// 
			// lblDealerGetal
			// 
			this.lblDealerGetal.AutoSize = true;
			this.lblDealerGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDealerGetal.Location = new System.Drawing.Point(283, 67);
			this.lblDealerGetal.Name = "lblDealerGetal";
			this.lblDealerGetal.Size = new System.Drawing.Size(26, 29);
			this.lblDealerGetal.TabIndex = 0;
			this.lblDealerGetal.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(486, 227);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Speler 1";
			// 
			// lblSpeler1Getal
			// 
			this.lblSpeler1Getal.AutoSize = true;
			this.lblSpeler1Getal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeler1Getal.Location = new System.Drawing.Point(484, 257);
			this.lblSpeler1Getal.Name = "lblSpeler1Getal";
			this.lblSpeler1Getal.Size = new System.Drawing.Size(66, 29);
			this.lblSpeler1Getal.TabIndex = 0;
			this.lblSpeler1Getal.Text = "getal";
			// 
			// btnHit1
			// 
			this.btnHit1.Location = new System.Drawing.Point(475, 192);
			this.btnHit1.Name = "btnHit1";
			this.btnHit1.Size = new System.Drawing.Size(34, 32);
			this.btnHit1.TabIndex = 1;
			this.btnHit1.Text = "Hit";
			this.btnHit1.UseVisualStyleBackColor = true;
			this.btnHit1.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(-1, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 212);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// lblSpeler2Getal
			// 
			this.lblSpeler2Getal.AutoSize = true;
			this.lblSpeler2Getal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeler2Getal.Location = new System.Drawing.Point(325, 257);
			this.lblSpeler2Getal.Name = "lblSpeler2Getal";
			this.lblSpeler2Getal.Size = new System.Drawing.Size(66, 29);
			this.lblSpeler2Getal.TabIndex = 3;
			this.lblSpeler2Getal.Text = "getal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(327, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Speler 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(186, 227);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Speler 3";
			// 
			// lblSpeler3Getal
			// 
			this.lblSpeler3Getal.AutoSize = true;
			this.lblSpeler3Getal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeler3Getal.Location = new System.Drawing.Point(184, 257);
			this.lblSpeler3Getal.Name = "lblSpeler3Getal";
			this.lblSpeler3Getal.Size = new System.Drawing.Size(66, 29);
			this.lblSpeler3Getal.TabIndex = 3;
			this.lblSpeler3Getal.Text = "getal";
			// 
			// btnHit2
			// 
			this.btnHit2.Enabled = false;
			this.btnHit2.Location = new System.Drawing.Point(316, 192);
			this.btnHit2.Name = "btnHit2";
			this.btnHit2.Size = new System.Drawing.Size(33, 32);
			this.btnHit2.TabIndex = 1;
			this.btnHit2.Text = "Hit";
			this.btnHit2.UseVisualStyleBackColor = true;
			this.btnHit2.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnHit3
			// 
			this.btnHit3.Enabled = false;
			this.btnHit3.Location = new System.Drawing.Point(175, 192);
			this.btnHit3.Name = "btnHit3";
			this.btnHit3.Size = new System.Drawing.Size(35, 32);
			this.btnHit3.TabIndex = 1;
			this.btnHit3.Text = "Hit";
			this.btnHit3.UseVisualStyleBackColor = true;
			this.btnHit3.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(515, 16);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(133, 59);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop1
			// 
			this.btnStop1.Location = new System.Drawing.Point(515, 192);
			this.btnStop1.Name = "btnStop1";
			this.btnStop1.Size = new System.Drawing.Size(34, 32);
			this.btnStop1.TabIndex = 1;
			this.btnStop1.Text = "S";
			this.btnStop1.UseVisualStyleBackColor = true;
			this.btnStop1.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStop2
			// 
			this.btnStop2.Enabled = false;
			this.btnStop2.Location = new System.Drawing.Point(355, 192);
			this.btnStop2.Name = "btnStop2";
			this.btnStop2.Size = new System.Drawing.Size(33, 32);
			this.btnStop2.TabIndex = 1;
			this.btnStop2.Text = "S";
			this.btnStop2.UseVisualStyleBackColor = true;
			this.btnStop2.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStop3
			// 
			this.btnStop3.Enabled = false;
			this.btnStop3.Location = new System.Drawing.Point(216, 192);
			this.btnStop3.Name = "btnStop3";
			this.btnStop3.Size = new System.Drawing.Size(35, 32);
			this.btnStop3.TabIndex = 1;
			this.btnStop3.Text = "S";
			this.btnStop3.UseVisualStyleBackColor = true;
			this.btnStop3.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblInzetSpeler3
			// 
			this.lblInzetSpeler3.AutoSize = true;
			this.lblInzetSpeler3.Location = new System.Drawing.Point(213, 332);
			this.lblInzetSpeler3.Name = "lblInzetSpeler3";
			this.lblInzetSpeler3.Size = new System.Drawing.Size(16, 17);
			this.lblInzetSpeler3.TabIndex = 7;
			this.lblInzetSpeler3.Text = "0";
			this.lblInzetSpeler3.Click += new System.EventHandler(this.lblInzetSpeler3_Click);
			// 
			// lblInzetSpeler2
			// 
			this.lblInzetSpeler2.AutoSize = true;
			this.lblInzetSpeler2.Location = new System.Drawing.Point(342, 332);
			this.lblInzetSpeler2.Name = "lblInzetSpeler2";
			this.lblInzetSpeler2.Size = new System.Drawing.Size(16, 17);
			this.lblInzetSpeler2.TabIndex = 7;
			this.lblInzetSpeler2.Text = "0";
			this.lblInzetSpeler2.Click += new System.EventHandler(this.lblInzetSpeler2_Click);
			// 
			// lblInzetSpeler1
			// 
			this.lblInzetSpeler1.AutoSize = true;
			this.lblInzetSpeler1.Location = new System.Drawing.Point(486, 332);
			this.lblInzetSpeler1.Name = "lblInzetSpeler1";
			this.lblInzetSpeler1.Size = new System.Drawing.Size(16, 17);
			this.lblInzetSpeler1.TabIndex = 7;
			this.lblInzetSpeler1.Text = "0";
			this.lblInzetSpeler1.Click += new System.EventHandler(this.lblInzetSpeler1_Click);
			// 
			// lblInzet1Euro
			// 
			this.lblInzet1Euro.AutoSize = true;
			this.lblInzet1Euro.Location = new System.Drawing.Point(41, 332);
			this.lblInzet1Euro.Name = "lblInzet1Euro";
			this.lblInzet1Euro.Size = new System.Drawing.Size(16, 17);
			this.lblInzet1Euro.TabIndex = 7;
			this.lblInzet1Euro.Text = "1";
			this.lblInzet1Euro.Click += new System.EventHandler(this.lblInzet1Euro_Click);
			// 
			// lblInzet5Euro
			// 
			this.lblInzet5Euro.AutoSize = true;
			this.lblInzet5Euro.Location = new System.Drawing.Point(41, 362);
			this.lblInzet5Euro.Name = "lblInzet5Euro";
			this.lblInzet5Euro.Size = new System.Drawing.Size(16, 17);
			this.lblInzet5Euro.TabIndex = 7;
			this.lblInzet5Euro.Text = "5";
			this.lblInzet5Euro.Click += new System.EventHandler(this.lblInzet5Euro_Click);
			// 
			// lblInzet25Euro
			// 
			this.lblInzet25Euro.AutoSize = true;
			this.lblInzet25Euro.Location = new System.Drawing.Point(41, 396);
			this.lblInzet25Euro.Name = "lblInzet25Euro";
			this.lblInzet25Euro.Size = new System.Drawing.Size(24, 17);
			this.lblInzet25Euro.TabIndex = 7;
			this.lblInzet25Euro.Text = "25";
			this.lblInzet25Euro.Click += new System.EventHandler(this.lblInzet25Euro_Click);
			// 
			// btnReady
			// 
			this.btnReady.Location = new System.Drawing.Point(515, 100);
			this.btnReady.Name = "btnReady";
			this.btnReady.Size = new System.Drawing.Size(133, 53);
			this.btnReady.TabIndex = 8;
			this.btnReady.Text = "Klaar";
			this.btnReady.UseVisualStyleBackColor = true;
			this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 455);
			this.Controls.Add(this.btnReady);
			this.Controls.Add(this.lblInzetSpeler1);
			this.Controls.Add(this.lblInzetSpeler2);
			this.Controls.Add(this.lblInzet25Euro);
			this.Controls.Add(this.lblInzet5Euro);
			this.Controls.Add(this.lblInzet1Euro);
			this.Controls.Add(this.lblInzetSpeler3);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblSpeler3Getal);
			this.Controls.Add(this.lblSpeler2Getal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnStop3);
			this.Controls.Add(this.btnHit3);
			this.Controls.Add(this.btnStop2);
			this.Controls.Add(this.btnHit2);
			this.Controls.Add(this.btnStop1);
			this.Controls.Add(this.btnHit1);
			this.Controls.Add(this.lblSpeler1Getal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDealerGetal);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDealerGetal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSpeler1Getal;
		private System.Windows.Forms.Button btnHit1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblSpeler2Getal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSpeler3Getal;
		private System.Windows.Forms.Button btnHit2;
		private System.Windows.Forms.Button btnHit3;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop1;
		private System.Windows.Forms.Button btnStop2;
		private System.Windows.Forms.Button btnStop3;
		private System.Windows.Forms.Label lblInzetSpeler3;
		private System.Windows.Forms.Label lblInzetSpeler2;
		private System.Windows.Forms.Label lblInzetSpeler1;
		private System.Windows.Forms.Label lblInzet1Euro;
		private System.Windows.Forms.Label lblInzet5Euro;
		private System.Windows.Forms.Label lblInzet25Euro;
		private System.Windows.Forms.Button btnReady;
	}
}

