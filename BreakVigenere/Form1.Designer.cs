namespace BreakVigenere
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtPlain = new System.Windows.Forms.RichTextBox();
			this.lblPlain = new System.Windows.Forms.Label();
			this.lblCelesi = new System.Windows.Forms.Label();
			this.btnCeles = new System.Windows.Forms.Button();
			this.txtcelesi = new System.Windows.Forms.TextBox();
			this.btnDekripto = new System.Windows.Forms.Button();
			this.lblCelsi1 = new System.Windows.Forms.Label();
			this.txtCipher = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(367, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(315, 22);
			this.label2.TabIndex = 26;
			this.label2.Text = "Gjatesia e çelsave dhe çelesat e mundshem:";
			// 
			// txtPlain
			// 
			this.txtPlain.Location = new System.Drawing.Point(688, 37);
			this.txtPlain.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.txtPlain.Name = "txtPlain";
			this.txtPlain.Size = new System.Drawing.Size(349, 329);
			this.txtPlain.TabIndex = 25;
			this.txtPlain.Text = "";
			// 
			// lblPlain
			// 
			this.lblPlain.AutoSize = true;
			this.lblPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlain.Location = new System.Drawing.Point(684, 10);
			this.lblPlain.Name = "lblPlain";
			this.lblPlain.Size = new System.Drawing.Size(108, 24);
			this.lblPlain.TabIndex = 24;
			this.lblPlain.Text = "PlainTexti:";
			// 
			// lblCelesi
			// 
			this.lblCelesi.AutoSize = true;
			this.lblCelesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelesi.Location = new System.Drawing.Point(367, 314);
			this.lblCelesi.Name = "lblCelesi";
			this.lblCelesi.Size = new System.Drawing.Size(193, 16);
			this.lblCelesi.TabIndex = 23;
			this.lblCelesi.Text = "Shkruaj njerin nga Celesat:";
			// 
			// btnCeles
			// 
			this.btnCeles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCeles.Location = new System.Drawing.Point(202, 372);
			this.btnCeles.Name = "btnCeles";
			this.btnCeles.Size = new System.Drawing.Size(159, 35);
			this.btnCeles.TabIndex = 22;
			this.btnCeles.Text = "Gjej celesat e mundshem";
			this.btnCeles.UseVisualStyleBackColor = true;
			this.btnCeles.Click += new System.EventHandler(this.btnCeles_Click);
			// 
			// txtcelesi
			// 
			this.txtcelesi.Location = new System.Drawing.Point(566, 313);
			this.txtcelesi.Name = "txtcelesi";
			this.txtcelesi.Size = new System.Drawing.Size(116, 20);
			this.txtcelesi.TabIndex = 21;
			// 
			// btnDekripto
			// 
			this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDekripto.Location = new System.Drawing.Point(588, 337);
			this.btnDekripto.Name = "btnDekripto";
			this.btnDekripto.Size = new System.Drawing.Size(94, 29);
			this.btnDekripto.TabIndex = 20;
			this.btnDekripto.Text = "Dekripto";
			this.btnDekripto.UseVisualStyleBackColor = true;
			// 
			// lblCelsi1
			// 
			this.lblCelsi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelsi1.Location = new System.Drawing.Point(367, 96);
			this.lblCelsi1.Name = "lblCelsi1";
			this.lblCelsi1.Size = new System.Drawing.Size(315, 175);
			this.lblCelsi1.TabIndex = 19;
			// 
			// txtCipher
			// 
			this.txtCipher.Location = new System.Drawing.Point(12, 37);
			this.txtCipher.Name = "txtCipher";
			this.txtCipher.Size = new System.Drawing.Size(349, 329);
			this.txtCipher.TabIndex = 18;
			this.txtCipher.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "Ciphertexti:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(1053, 425);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPlain);
			this.Controls.Add(this.lblPlain);
			this.Controls.Add(this.lblCelesi);
			this.Controls.Add(this.btnCeles);
			this.Controls.Add(this.txtcelesi);
			this.Controls.Add(this.btnDekripto);
			this.Controls.Add(this.lblCelsi1);
			this.Controls.Add(this.txtCipher);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "BreakVigenere";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtPlain;
		private System.Windows.Forms.Label lblPlain;
		private System.Windows.Forms.Label lblCelesi;
		private System.Windows.Forms.Button btnCeles;
		private System.Windows.Forms.TextBox txtcelesi;
		private System.Windows.Forms.Button btnDekripto;
		private System.Windows.Forms.Label lblCelsi1;
		private System.Windows.Forms.RichTextBox txtCipher;
		private System.Windows.Forms.Label label1;
	}
}

