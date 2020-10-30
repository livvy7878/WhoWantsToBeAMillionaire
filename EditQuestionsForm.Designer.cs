namespace WhoWantToBeAMillionaire
{
	partial class EditQuestionsForm
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
			this.SaveFileButton = new System.Windows.Forms.Button();
			this.SelectedFileTextBox = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.LoadToGameButton = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(14, 32);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(233, 23);
			this.SelectFileButton.TabIndex = 2;
			this.SelectFileButton.Text = "Выбрать файл";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			// 
			// SaveFileButton
			// 
			this.SaveFileButton.Location = new System.Drawing.Point(14, 61);
			this.SaveFileButton.Name = "SaveFileButton";
			this.SaveFileButton.Size = new System.Drawing.Size(88, 23);
			this.SaveFileButton.TabIndex = 4;
			this.SaveFileButton.Text = "Сохранить";
			this.SaveFileButton.UseVisualStyleBackColor = true;
			// 
			// SelectedFileTextBox
			// 
			this.SelectedFileTextBox.Location = new System.Drawing.Point(14, 6);
			this.SelectedFileTextBox.Name = "SelectedFileTextBox";
			this.SelectedFileTextBox.ReadOnly = true;
			this.SelectedFileTextBox.Size = new System.Drawing.Size(233, 20);
			this.SelectedFileTextBox.TabIndex = 5;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(273, 258);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.LoadToGameButton);
			this.tabPage1.Controls.Add(this.SaveFileButton);
			this.tabPage1.Controls.Add(this.SelectedFileTextBox);
			this.tabPage1.Controls.Add(this.SelectFileButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(265, 232);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Файлы";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(265, 232);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Загрузить";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// LoadToGameButton
			// 
			this.LoadToGameButton.Location = new System.Drawing.Point(159, 61);
			this.LoadToGameButton.Name = "LoadToGameButton";
			this.LoadToGameButton.Size = new System.Drawing.Size(88, 23);
			this.LoadToGameButton.TabIndex = 7;
			this.LoadToGameButton.Text = "Загрузить";
			this.LoadToGameButton.UseVisualStyleBackColor = true;
			// 
			// AddQuestionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 256);
			this.Controls.Add(this.tabControl1);
			this.Name = "AddQuestionsForm";
			this.Text = "Редактор вопросов";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.Button SaveFileButton;
		private System.Windows.Forms.TextBox SelectedFileTextBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button LoadToGameButton;
	}
}