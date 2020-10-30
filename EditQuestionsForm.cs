using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantToBeAMillionaire
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
		}

		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			QuestionMaker.MakeFromTextFileXmlQuestions(SelectedFileTextBox.Text);
			MessageBox.Show("Сохранены вопросы из файла");
		}

		private void LoadToGameButton_Click(object sender, EventArgs e)
		{
			MainWindow parentWindow = Parent as MainWindow;
			parentWindow.questionsNow = QuestionMaker.LoadQuestions();
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
