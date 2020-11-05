using System;
using System.IO;
using System.Windows.Forms;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	public partial class EditQuestionsForm : Form
	{
		DialogResult dialogRes;
		public EditQuestionsForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;
			SelectFileButton.Click += SelectFileButton_Click;
			SaveFileButton.Click += SaveFileButton_Click;
			LoadToGameButton.Click += LoadToGameButton_Click;
			KeyDown += EditQuestionsForm_KeyDown;
			EditQuestionStartButton.Click += QuestionEditorStartButtonEventHandler;
			QuestionsFilenameTextBox.TextChanged += QuestionsFilenameTextChangedEventHandler;

			QuestionsFilenameTextBox.Text = Settings.Default.QuestionsFilename;
			SelectedFileTextBox.Text = Application.StartupPath + '\\' + Settings.Default.QuestionsFilename;
		}

		private void QuestionsFilenameTextChangedEventHandler(object sender, EventArgs e)
		{
			Settings.Default.QuestionsFilename = QuestionsFilenameTextBox.Text;
		}

		private void QuestionEditorStartButtonEventHandler(object sender, EventArgs e)
		{
			Form editorQuestionsForm = new EditorQuestionsForm();
			editorQuestionsForm.ShowDialog();
		}

		private void EditQuestionsForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			if (SelectedFileTextBox.Text.Length == 0)
			{
				MessageBox.Show("Выбран файл questions.txt рядом с программой");
			}
			try
			{
				QuestionMaker.MakeFromTextFileXmlQuestions(SelectedFileTextBox.Text.Length == 0 ? "questions.txt" : SelectedFileTextBox.Text);
				MessageBox.Show("Конвертированы в xml и сохранены вопросы из файла");
			}
			catch (Exception)
			{
				MessageBox.Show("Нет файла questions.txt рядом с программой в правильном формате");
			}
		}

		private void LoadToGameButton_Click(object sender, EventArgs e)
		{
			MainWindow parentWindow = Owner as MainWindow;
			try
			{
				parentWindow.StatisticsNow.QuestionsNow = QuestionMaker.LoadQuestions(SelectedFileTextBox.Text.Length == 0 ? Settings.Default.QuestionsFilename : SelectedFileTextBox.Text);
				parentWindow.ResetGame(); MessageBox.Show("Загружены вопросы в игру");
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter("error.log", true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
				MessageBox.Show("Что-то пошло не так");
				throw;
			}
		}

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			dialogRes = openFileDialog1.ShowDialog();
			if (dialogRes == DialogResult.OK)
			{
				SelectedFileTextBox.Text = openFileDialog1.FileName;
			}
		}
	}
}
