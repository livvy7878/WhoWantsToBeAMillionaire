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
	public partial class AddQuestionsForm : Form
	{
		DialogResult dialogRes;
		public AddQuestionsForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;
			SelectFileButton.Click += SelectFileButton_Click;
			LoadFileButton.Click += LoadFileButton_Click;
		}

		private void LoadFileButton_Click(object sender, EventArgs e)
		{
			QuestionMaker.MakeFromTextFileXmlQuestions(SelectedFileTextBox.Text);
			MessageBox.Show("Загружены вопросы из файла");
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
