namespace WhoWantsToBeAMillionaire
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
			this.QuestionsEditorTabControl = new System.Windows.Forms.TabControl();
			this.FilesTabPage = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LoadToGameButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.EditorTabPage = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EditQuestionStartButton = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.QuestionsFilenameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.QuestionsEditorTabControl.SuspendLayout();
			this.FilesTabPage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.EditorTabPage.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.SaveFileButton.Location = new System.Drawing.Point(153, 54);
			this.SaveFileButton.Name = "SaveFileButton";
			this.SaveFileButton.Size = new System.Drawing.Size(100, 40);
			this.SaveFileButton.TabIndex = 4;
			this.SaveFileButton.Text = "Конвертировать и сохранить";
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
			// QuestionsEditorTabControl
			// 
			this.QuestionsEditorTabControl.Controls.Add(this.FilesTabPage);
			this.QuestionsEditorTabControl.Controls.Add(this.EditorTabPage);
			this.QuestionsEditorTabControl.Controls.Add(this.tabPage1);
			this.QuestionsEditorTabControl.Location = new System.Drawing.Point(0, 0);
			this.QuestionsEditorTabControl.Name = "QuestionsEditorTabControl";
			this.QuestionsEditorTabControl.SelectedIndex = 0;
			this.QuestionsEditorTabControl.Size = new System.Drawing.Size(273, 308);
			this.QuestionsEditorTabControl.TabIndex = 6;
			// 
			// FilesTabPage
			// 
			this.FilesTabPage.Controls.Add(this.groupBox2);
			this.FilesTabPage.Controls.Add(this.groupBox1);
			this.FilesTabPage.Controls.Add(this.SelectedFileTextBox);
			this.FilesTabPage.Controls.Add(this.SelectFileButton);
			this.FilesTabPage.Location = new System.Drawing.Point(4, 22);
			this.FilesTabPage.Name = "FilesTabPage";
			this.FilesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.FilesTabPage.Size = new System.Drawing.Size(265, 282);
			this.FilesTabPage.TabIndex = 0;
			this.FilesTabPage.Text = "Файлы";
			this.FilesTabPage.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.LoadToGameButton);
			this.groupBox2.Location = new System.Drawing.Point(3, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(259, 109);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Загрузка";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 39);
			this.label2.TabIndex = 5;
			this.label2.Text = "Из xml файла позволяет загрузить вопросы \r\nпо указанному пути в игру(если не выбр" +
    "ан - \r\nиспользуется Questions.xml рядом с программой) ";
			// 
			// LoadToGameButton
			// 
			this.LoadToGameButton.Location = new System.Drawing.Point(153, 63);
			this.LoadToGameButton.Name = "LoadToGameButton";
			this.LoadToGameButton.Size = new System.Drawing.Size(100, 40);
			this.LoadToGameButton.TabIndex = 7;
			this.LoadToGameButton.Text = "Загрузить в игру";
			this.LoadToGameButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.SaveFileButton);
			this.groupBox1.Location = new System.Drawing.Point(3, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 100);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Конвертация";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 26);
			this.label1.TabIndex = 5;
			this.label1.Text = "Конвертирует текстовый файл и сохраняет в\r\nxml рядом с программой\r\n";
			// 
			// EditorTabPage
			// 
			this.EditorTabPage.Controls.Add(this.groupBox3);
			this.EditorTabPage.Location = new System.Drawing.Point(4, 22);
			this.EditorTabPage.Name = "EditorTabPage";
			this.EditorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.EditorTabPage.Size = new System.Drawing.Size(265, 282);
			this.EditorTabPage.TabIndex = 1;
			this.EditorTabPage.Text = "Редактировать";
			this.EditorTabPage.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.EditQuestionStartButton);
			this.groupBox3.Location = new System.Drawing.Point(8, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(247, 85);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Изменение";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(241, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Позволяет изменять существующие вопросы";
			// 
			// EditQuestionStartButton
			// 
			this.EditQuestionStartButton.AutoSize = true;
			this.EditQuestionStartButton.Location = new System.Drawing.Point(79, 56);
			this.EditQuestionStartButton.Name = "EditQuestionStartButton";
			this.EditQuestionStartButton.Size = new System.Drawing.Size(162, 23);
			this.EditQuestionStartButton.TabIndex = 1;
			this.EditQuestionStartButton.Text = "Вызвать редактор вопросов";
			this.EditQuestionStartButton.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.QuestionsFilenameTextBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(265, 282);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Настройки";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// QuestionsFilenameTextBox
			// 
			this.QuestionsFilenameTextBox.Location = new System.Drawing.Point(3, 19);
			this.QuestionsFilenameTextBox.Name = "QuestionsFilenameTextBox";
			this.QuestionsFilenameTextBox.Size = new System.Drawing.Size(252, 20);
			this.QuestionsFilenameTextBox.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Имя файла с вопросами";
			// 
			// EditQuestionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(271, 311);
			this.Controls.Add(this.QuestionsEditorTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "EditQuestionsForm";
			this.ShowInTaskbar = false;
			this.Text = "Редактор вопросов";
			this.QuestionsEditorTabControl.ResumeLayout(false);
			this.FilesTabPage.ResumeLayout(false);
			this.FilesTabPage.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.EditorTabPage.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.Button SaveFileButton;
		private System.Windows.Forms.TextBox SelectedFileTextBox;
		private System.Windows.Forms.TabControl QuestionsEditorTabControl;
		private System.Windows.Forms.TabPage FilesTabPage;
		private System.Windows.Forms.TabPage EditorTabPage;
		private System.Windows.Forms.Button LoadToGameButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button EditQuestionStartButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox QuestionsFilenameTextBox;
	}
}