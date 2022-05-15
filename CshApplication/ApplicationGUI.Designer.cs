
namespace CshApplication
{
	partial class ApplicationGUI
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
			this.Multiply = new System.Windows.Forms.Button();
			this.Number2Text = new System.Windows.Forms.RichTextBox();
			this.Number1Text = new System.Windows.Forms.RichTextBox();
			this.ResultText = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Multiply
			// 
			this.Multiply.Location = new System.Drawing.Point(11, 90);
			this.Multiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Multiply.Name = "Multiply";
			this.Multiply.Size = new System.Drawing.Size(71, 24);
			this.Multiply.TabIndex = 0;
			this.Multiply.Text = "*";
			this.Multiply.UseVisualStyleBackColor = true;
			this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
			// 
			// Number2Text
			// 
			this.Number2Text.Location = new System.Drawing.Point(149, 34);
			this.Number2Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Number2Text.Name = "Number2Text";
			this.Number2Text.Size = new System.Drawing.Size(80, 21);
			this.Number2Text.TabIndex = 3;
			this.Number2Text.Text = "";
			// 
			// Number1Text
			// 
			this.Number1Text.Location = new System.Drawing.Point(25, 34);
			this.Number1Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Number1Text.Name = "Number1Text";
			this.Number1Text.Size = new System.Drawing.Size(90, 21);
			this.Number1Text.TabIndex = 4;
			this.Number1Text.Text = "";
			// 
			// ResultText
			// 
			this.ResultText.Location = new System.Drawing.Point(58, 59);
			this.ResultText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ResultText.Name = "ResultText";
			this.ResultText.ReadOnly = true;
			this.ResultText.Size = new System.Drawing.Size(171, 19);
			this.ResultText.TabIndex = 5;
			this.ResultText.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label1.Location = new System.Drawing.Point(124, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label2.Location = new System.Drawing.Point(28, 58);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 30);
			this.label2.TabIndex = 7;
			this.label2.Text = "=";
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(87, 90);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 8;
			this.Add.Text = "+";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// ApplicationGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 114);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ResultText);
			this.Controls.Add(this.Number1Text);
			this.Controls.Add(this.Number2Text);
			this.Controls.Add(this.Multiply);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ApplicationGUI";
			this.Text = "ApplicationGUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Multiply;
		private System.Windows.Forms.RichTextBox Number2Text;
		private System.Windows.Forms.RichTextBox Number1Text;
		private System.Windows.Forms.RichTextBox ResultText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Add;
	}
}