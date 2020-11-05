using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	public partial class EditorQuestionsForm : Form
	{
		private DialogResult dialogResult;
		private List<Question> questions;
		private int QuestionToEditNow;

		public EditorQuestionsForm()
		{
			InitializeComponent();
			IsUiOfEditorLocked(true);

			QuestionTextBox.Tag = 0;
			AnswerOneTextBox.Tag = 1;
			AnswerTwoTextBox.Tag = 2;
			AnswerThreeTextBox.Tag = 3;
			AnswerFourTextBox.Tag = 4;

			ChangePlacesButton.Enabled = false;
			questions = null;
			StartPosition = FormStartPosition.CenterParent;

			SelectFileButton.Click += SelectFileButton_Click;
			SaveFileButton.Click += SaveFileButton_Click;
			AddQuestionButton.Click += AddQuestionButton_Click;
			DeleteQuestionButton.Click += DeleteQuestionButton_Click;
			ChangePlacesButton.Click += ChangePlacesButton_Click;
			QuestionTextBox.LostFocus += TextBoxLostFocusEventHandler;
			AnswerOneTextBox.LostFocus += TextBoxLostFocusEventHandler;
			AnswerTwoTextBox.LostFocus += TextBoxLostFocusEventHandler;
			AnswerThreeTextBox.LostFocus += TextBoxLostFocusEventHandler;
			AnswerFourTextBox.LostFocus += TextBoxLostFocusEventHandler;
			AllLoadedQuestionsListBox.SelectedIndexChanged += AllLoadedQuestionsListBox_SelectedIndexChanged;

			PathToSelectedFile.Text = Application.StartupPath + '\\' + Settings.Default.QuestionsFilename;
			LoadQuestions(PathToSelectedFile.Text);
		}

		private void ChangePlacesButton_Click(object sender, EventArgs e)
		{
			if (AllLoadedQuestionsListBox.SelectedIndices.Count == 2)
			{
				Question temp = questions[AllLoadedQuestionsListBox.SelectedIndices[0]];
				questions[AllLoadedQuestionsListBox.SelectedIndices[0]] = questions[AllLoadedQuestionsListBox.SelectedIndices[1]];
				questions[AllLoadedQuestionsListBox.SelectedIndices[1]] = temp;

				AllLoadedQuestionsListBox.Items[AllLoadedQuestionsListBox.SelectedIndices[0]] = questions[AllLoadedQuestionsListBox.SelectedIndices[0]];
				AllLoadedQuestionsListBox.Items[AllLoadedQuestionsListBox.SelectedIndices[1]] = questions[AllLoadedQuestionsListBox.SelectedIndices[1]];
			}
		}

		private void DeleteQuestionButton_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show($"Удалить вопрос '{questions[QuestionToEditNow]}' ?", "Редактор вопросов", MessageBoxButtons.YesNo);

			if (res == DialogResult.Yes && QuestionToEditNow >= 0 && QuestionToEditNow <= 14)
			{
				Question removeQuestion = questions[QuestionToEditNow];
				AllLoadedQuestionsListBox.Items.Remove(questions[QuestionToEditNow]);
				questions.Remove(removeQuestion);
			}
		}

		private void AddQuestionButton_Click(object sender, EventArgs e)
		{
			if (questions.Count == 15)
			{
				MessageBox.Show("Достигнуто максимальное (15) количество вопросов");
				return;
			}
			questions.Add(new Question("(empty)", new List<string>() { "(empty)", "(empty)", "(empty)", "(empty)" }, ""));
			AllLoadedQuestionsListBox.Items.Add(questions[questions.Count - 1]);
		}

		private void AllLoadedQuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangePlacesButton.Enabled = AllLoadedQuestionsListBox.SelectedIndices.Count == 2;

			QuestionToEditNow = AllLoadedQuestionsListBox.SelectedIndex;
			QuestionNumberTextBox.Text = (AllLoadedQuestionsListBox.SelectedIndex + 1).ToString();
			ChangeQuestion();
		}

		private void TextBoxLostFocusEventHandler(object sender, EventArgs e)
		{
			if (questions == null)
			{
				return;
			}
			TextBox tBox = sender as TextBox;
			Question editedQuestion = questions[QuestionToEditNow];

			if ((int)tBox.Tag == 0)
			{
				editedQuestion.AskedQuestion = tBox.Text;
			}
			else
			{
				editedQuestion.Answers[(int)tBox.Tag - 1] = tBox.Text;
			}
			questions[QuestionToEditNow] = editedQuestion;
		}

		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			QuestionMaker.SaveQuestionsInXmlFile(questions);
		}

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			dialogResult = OpenFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				PathToSelectedFile.Text = OpenFileDialog.FileName;
				try
				{
					LoadQuestions(OpenFileDialog.FileName);
				}
				catch (Exception)
				{
					MessageBox.Show($"Ошибка при загрузке, файл поврежден");
				}
			}
			else
			{
				IsUiOfEditorLocked(true);
			}
		}

		private void LoadQuestions(string pathToFile)
		{
			AllLoadedQuestionsListBox.Items.Clear();
			questions = QuestionMaker.LoadQuestions(pathToFile);
			questions.ForEach((q) => AllLoadedQuestionsListBox.Items.Add(q));
			IsUiOfEditorLocked(false);
			QuestionToEditNow = 1;
			ChangeQuestion();
		}

		private void ChangeQuestion()
		{
			if (QuestionToEditNow == -1)
			{
				return;
			}
			QuestionTextBox.Text = questions[QuestionToEditNow].AskedQuestion;
			AnswerOneTextBox.Text = questions[QuestionToEditNow].Answers[0];
			AnswerTwoTextBox.Text = questions[QuestionToEditNow].Answers[1];
			AnswerThreeTextBox.Text = questions[QuestionToEditNow].Answers[2];
			AnswerFourTextBox.Text = questions[QuestionToEditNow].Answers[3];
		}

		private void IsUiOfEditorLocked(bool newState)
		{
			QuestionTextBox.ReadOnly = newState;
			AnswerOneTextBox.ReadOnly = newState;
			AnswerTwoTextBox.ReadOnly = newState;
			AnswerThreeTextBox.ReadOnly = newState;
			AnswerFourTextBox.ReadOnly = newState;
			SaveFileButton.Enabled = newState ? false : true;
		}
	}
}
