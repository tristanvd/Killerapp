namespace Blackjack
{
	partial class FormMain
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
			this.btnHome = new System.Windows.Forms.Button();
			this.btnCashier = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.btnBlackjack = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnHome
			// 
			this.btnHome.Location = new System.Drawing.Point(0, -1);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(159, 69);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			// 
			// btnCashier
			// 
			this.btnCashier.Location = new System.Drawing.Point(0, 74);
			this.btnCashier.Name = "btnCashier";
			this.btnCashier.Size = new System.Drawing.Size(159, 69);
			this.btnCashier.TabIndex = 0;
			this.btnCashier.Text = "Cashier";
			this.btnCashier.UseVisualStyleBackColor = true;
			// 
			// btnAccount
			// 
			this.btnAccount.Location = new System.Drawing.Point(0, 149);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(159, 69);
			this.btnAccount.TabIndex = 0;
			this.btnAccount.Text = "Mijn account";
			this.btnAccount.UseVisualStyleBackColor = true;
			// 
			// btnBlackjack
			// 
			this.btnBlackjack.Location = new System.Drawing.Point(0, 224);
			this.btnBlackjack.Name = "btnBlackjack";
			this.btnBlackjack.Size = new System.Drawing.Size(159, 69);
			this.btnBlackjack.TabIndex = 0;
			this.btnBlackjack.Text = "Blackjack";
			this.btnBlackjack.UseVisualStyleBackColor = true;
			this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(0, 297);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(159, 69);
			this.button5.TabIndex = 0;
			this.button5.Text = "button1";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 367);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnBlackjack);
			this.Controls.Add(this.btnAccount);
			this.Controls.Add(this.btnCashier);
			this.Controls.Add(this.btnHome);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnCashier;
		private System.Windows.Forms.Button btnAccount;
		private System.Windows.Forms.Button btnBlackjack;
		private System.Windows.Forms.Button button5;
	}
}