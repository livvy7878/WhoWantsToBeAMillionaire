namespace WhoWantToBeAMillionaire
{
	partial class AddQuestionsForm
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.LoadFileButton = new System.Windows.Forms.Button();
			this.SelectedFileTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(12, 36);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(88, 23);
			this.SelectFileButton.TabIndex = 2;
			this.SelectFileButton.Text = "Выбрать файл";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			// 
			// LoadFileButton
			// 
			this.LoadFileButton.Location = new System.Drawing.Point(157, 36);
			this.LoadFileButton.Name = "LoadFileButton";
			this.LoadFileButton.Size = new System.Drawing.Size(88, 23);
			this.LoadFileButton.TabIndex = 4;
			this.LoadFileButton.Text = "Загрузить";
			this.LoadFileButton.UseVisualStyleBackColor = true;
			// 
			// SelectedFileTextBox
			// 
			this.SelectedFileTextBox.Location = new System.Drawing.Point(12, 10);
			this.SelectedFileTextBox.Name = "SelectedFileTextBox";
			this.SelectedFileTextBox.ReadOnly = true;
			this.SelectedFileTextBox.Size = new System.Drawing.Size(233, 20);
			this.SelectedFileTextBox.TabIndex = 5;
			// 
			// AddQuestionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 71);
			this.Controls.Add(this.SelectedFileTextBox);
			this.Controls.Add(this.LoadFileButton);
			this.Controls.Add(this.SelectFileButton);
			this.Name = "AddQuestionsForm";
			this.Text = "Добавление вопросов";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.Button LoadFileButton;
		private System.Windows.Forms.TextBox SelectedFileTextBox;
	}
}