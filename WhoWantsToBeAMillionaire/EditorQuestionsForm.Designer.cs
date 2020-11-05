namespace WhoWantsToBeAMillionaire
{
	partial class EditorQuestionsForm
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
			this.QuestionLabel = new System.Windows.Forms.Label();
			this.QuestionTextBox = new System.Windows.Forms.TextBox();
			this.AnswerOneTextBox = new System.Windows.Forms.TextBox();
			this.AnswerFirstLabel = new System.Windows.Forms.Label();
			this.AnswerTwoTextBox = new System.Windows.Forms.TextBox();
			this.AnswerSecondLabel = new System.Windows.Forms.Label();
			this.AnswerThreeTextBox = new System.Windows.Forms.TextBox();
			this.AnswerThirdLabel = new System.Windows.Forms.Label();
			this.AnswerFourTextBox = new System.Windows.Forms.TextBox();
			this.AnswerFourthLabel = new System.Windows.Forms.Label();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.PathToSelectedFile = new System.Windows.Forms.TextBox();
			this.SaveFileButton = new System.Windows.Forms.Button();
			this.AllLoadedQuestionsListBox = new System.Windows.Forms.ListBox();
			this.AddQuestionButton = new System.Windows.Forms.Button();
			this.DeleteQuestionButton = new System.Windows.Forms.Button();
			this.QuestionNumberTextBox = new System.Windows.Forms.TextBox();
			this.ChangePlacesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Номер вопроса";
			// 
			// QuestionLabel
			// 
			this.QuestionLabel.AutoSize = true;
			this.QuestionLabel.Location = new System.Drawing.Point(420, 11);
			this.QuestionLabel.Name = "QuestionLabel";
			this.QuestionLabel.Size = new System.Drawing.Size(44, 13);
			this.QuestionLabel.TabIndex = 2;
			this.QuestionLabel.Text = "Вопрос";
			// 
			// QuestionTextBox
			// 
			this.QuestionTextBox.ForeColor = System.Drawing.Color.Black;
			this.QuestionTextBox.Location = new System.Drawing.Point(420, 27);
			this.QuestionTextBox.Multiline = true;
			this.QuestionTextBox.Name = "QuestionTextBox";
			this.QuestionTextBox.Size = new System.Drawing.Size(260, 49);
			this.QuestionTextBox.TabIndex = 3;
			// 
			// AnswerOneTextBox
			// 
			this.AnswerOneTextBox.ForeColor = System.Drawing.Color.Black;
			this.AnswerOneTextBox.Location = new System.Drawing.Point(420, 97);
			this.AnswerOneTextBox.Multiline = true;
			this.AnswerOneTextBox.Name = "AnswerOneTextBox";
			this.AnswerOneTextBox.Size = new System.Drawing.Size(260, 20);
			this.AnswerOneTextBox.TabIndex = 5;
			// 
			// AnswerFirstLabel
			// 
			this.AnswerFirstLabel.AutoSize = true;
			this.AnswerFirstLabel.Location = new System.Drawing.Point(420, 81);
			this.AnswerFirstLabel.Name = "AnswerFirstLabel";
			this.AnswerFirstLabel.Size = new System.Drawing.Size(159, 13);
			this.AnswerFirstLabel.TabIndex = 4;
			this.AnswerFirstLabel.Text = "Первый вариант(правильный)";
			// 
			// AnswerTwoTextBox
			// 
			this.AnswerTwoTextBox.ForeColor = System.Drawing.Color.Black;
			this.AnswerTwoTextBox.Location = new System.Drawing.Point(420, 142);
			this.AnswerTwoTextBox.Multiline = true;
			this.AnswerTwoTextBox.Name = "AnswerTwoTextBox";
			this.AnswerTwoTextBox.Size = new System.Drawing.Size(260, 20);
			this.AnswerTwoTextBox.TabIndex = 7;
			// 
			// AnswerSecondLabel
			// 
			this.AnswerSecondLabel.AutoSize = true;
			this.AnswerSecondLabel.Location = new System.Drawing.Point(420, 126);
			this.AnswerSecondLabel.Name = "AnswerSecondLabel";
			this.AnswerSecondLabel.Size = new System.Drawing.Size(87, 13);
			this.AnswerSecondLabel.TabIndex = 6;
			this.AnswerSecondLabel.Text = "Второй вариант";
			// 
			// AnswerThreeTextBox
			// 
			this.AnswerThreeTextBox.ForeColor = System.Drawing.Color.Black;
			this.AnswerThreeTextBox.Location = new System.Drawing.Point(420, 185);
			this.AnswerThreeTextBox.Multiline = true;
			this.AnswerThreeTextBox.Name = "AnswerThreeTextBox";
			this.AnswerThreeTextBox.Size = new System.Drawing.Size(260, 20);
			this.AnswerThreeTextBox.TabIndex = 9;
			// 
			// AnswerThirdLabel
			// 
			this.AnswerThirdLabel.AutoSize = true;
			this.AnswerThirdLabel.Location = new System.Drawing.Point(420, 169);
			this.AnswerThirdLabel.Name = "AnswerThirdLabel";
			this.AnswerThirdLabel.Size = new System.Drawing.Size(87, 13);
			this.AnswerThirdLabel.TabIndex = 8;
			this.AnswerThirdLabel.Text = "Третий вариант";
			// 
			// AnswerFourTextBox
			// 
			this.AnswerFourTextBox.ForeColor = System.Drawing.Color.Black;
			this.AnswerFourTextBox.Location = new System.Drawing.Point(420, 227);
			this.AnswerFourTextBox.Multiline = true;
			this.AnswerFourTextBox.Name = "AnswerFourTextBox";
			this.AnswerFourTextBox.Size = new System.Drawing.Size(260, 20);
			this.AnswerFourTextBox.TabIndex = 11;
			// 
			// AnswerFourthLabel
			// 
			this.AnswerFourthLabel.AutoSize = true;
			this.AnswerFourthLabel.Location = new System.Drawing.Point(420, 211);
			this.AnswerFourthLabel.Name = "AnswerFourthLabel";
			this.AnswerFourthLabel.Size = new System.Drawing.Size(107, 13);
			this.AnswerFourthLabel.TabIndex = 10;
			this.AnswerFourthLabel.Text = "Четвертый вариант";
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "openFileDialog1";
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(274, 25);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(89, 23);
			this.SelectFileButton.TabIndex = 12;
			this.SelectFileButton.Text = "Выбрать файл";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Редактируемый файл";
			// 
			// PathToSelectedFile
			// 
			this.PathToSelectedFile.Location = new System.Drawing.Point(8, 27);
			this.PathToSelectedFile.Name = "PathToSelectedFile";
			this.PathToSelectedFile.ReadOnly = true;
			this.PathToSelectedFile.Size = new System.Drawing.Size(260, 20);
			this.PathToSelectedFile.TabIndex = 14;
			// 
			// SaveFileButton
			// 
			this.SaveFileButton.Location = new System.Drawing.Point(596, 253);
			this.SaveFileButton.Name = "SaveFileButton";
			this.SaveFileButton.Size = new System.Drawing.Size(84, 23);
			this.SaveFileButton.TabIndex = 15;
			this.SaveFileButton.Text = "Сохранить";
			this.SaveFileButton.UseVisualStyleBackColor = true;
			// 
			// AllLoadedQuestionsListBox
			// 
			this.AllLoadedQuestionsListBox.ForeColor = System.Drawing.Color.Black;
			this.AllLoadedQuestionsListBox.FormattingEnabled = true;
			this.AllLoadedQuestionsListBox.Location = new System.Drawing.Point(8, 77);
			this.AllLoadedQuestionsListBox.Name = "AllLoadedQuestionsListBox";
			this.AllLoadedQuestionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.AllLoadedQuestionsListBox.Size = new System.Drawing.Size(405, 199);
			this.AllLoadedQuestionsListBox.TabIndex = 35;
			// 
			// AddQuestionButton
			// 
			this.AddQuestionButton.Location = new System.Drawing.Point(419, 253);
			this.AddQuestionButton.Name = "AddQuestionButton";
			this.AddQuestionButton.Size = new System.Drawing.Size(84, 23);
			this.AddQuestionButton.TabIndex = 36;
			this.AddQuestionButton.Text = "Добавить";
			this.AddQuestionButton.UseVisualStyleBackColor = true;
			// 
			// DeleteQuestionButton
			// 
			this.DeleteQuestionButton.Location = new System.Drawing.Point(508, 253);
			this.DeleteQuestionButton.Name = "DeleteQuestionButton";
			this.DeleteQuestionButton.Size = new System.Drawing.Size(84, 23);
			this.DeleteQuestionButton.TabIndex = 37;
			this.DeleteQuestionButton.Text = "Удалить";
			this.DeleteQuestionButton.UseVisualStyleBackColor = true;
			// 
			// QuestionNumberTextBox
			// 
			this.QuestionNumberTextBox.Location = new System.Drawing.Point(9, 51);
			this.QuestionNumberTextBox.Name = "QuestionNumberTextBox";
			this.QuestionNumberTextBox.Size = new System.Drawing.Size(29, 20);
			this.QuestionNumberTextBox.TabIndex = 38;
			// 
			// ChangePlacesButton
			// 
			this.ChangePlacesButton.Location = new System.Drawing.Point(299, 53);
			this.ChangePlacesButton.Name = "ChangePlacesButton";
			this.ChangePlacesButton.Size = new System.Drawing.Size(114, 23);
			this.ChangePlacesButton.TabIndex = 39;
			this.ChangePlacesButton.Text = "Поменять местами";
			this.ChangePlacesButton.UseVisualStyleBackColor = true;
			// 
			// EditorQuestionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 297);
			this.Controls.Add(this.ChangePlacesButton);
			this.Controls.Add(this.QuestionNumberTextBox);
			this.Controls.Add(this.DeleteQuestionButton);
			this.Controls.Add(this.AddQuestionButton);
			this.Controls.Add(this.AllLoadedQuestionsListBox);
			this.Controls.Add(this.SaveFileButton);
			this.Controls.Add(this.PathToSelectedFile);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SelectFileButton);
			this.Controls.Add(this.AnswerFourTextBox);
			this.Controls.Add(this.AnswerFourthLabel);
			this.Controls.Add(this.AnswerThreeTextBox);
			this.Controls.Add(this.AnswerThirdLabel);
			this.Controls.Add(this.AnswerTwoTextBox);
			this.Controls.Add(this.AnswerSecondLabel);
			this.Controls.Add(this.AnswerOneTextBox);
			this.Controls.Add(this.AnswerFirstLabel);
			this.Controls.Add(this.QuestionTextBox);
			this.Controls.Add(this.QuestionLabel);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditorQuestionsForm";
			this.Text = "Редактирование вопросов";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label QuestionLabel;
		private System.Windows.Forms.TextBox QuestionTextBox;
		private System.Windows.Forms.TextBox AnswerOneTextBox;
		private System.Windows.Forms.Label AnswerFirstLabel;
		private System.Windows.Forms.TextBox AnswerTwoTextBox;
		private System.Windows.Forms.Label AnswerSecondLabel;
		private System.Windows.Forms.TextBox AnswerThreeTextBox;
		private System.Windows.Forms.Label AnswerThirdLabel;
		private System.Windows.Forms.TextBox AnswerFourTextBox;
		private System.Windows.Forms.Label AnswerFourthLabel;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox PathToSelectedFile;
		private System.Windows.Forms.Button SaveFileButton;
		private System.Windows.Forms.ListBox AllLoadedQuestionsListBox;
		private System.Windows.Forms.Button AddQuestionButton;
		private System.Windows.Forms.Button DeleteQuestionButton;
		private System.Windows.Forms.TextBox QuestionNumberTextBox;
		private System.Windows.Forms.Button ChangePlacesButton;
	}
}