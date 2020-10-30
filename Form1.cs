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
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			LoadQuestionsFromFileMenuStripItem.Click += OpenFileQuestionLoader;
			ExitApplicationButton.Click += ExitApplicationButton_Click;
		}

		private void ExitApplicationButton_Click(object sender, EventArgs e)
		{
			DialogResult userAnswer = MessageBox.Show("Закрыть приложение?", "Кто хочет стать миллионером?", MessageBoxButtons.YesNo);
			switch (userAnswer)
			{
				case DialogResult.Yes:
					Close();
					break;
				case DialogResult.No:
					break;
			}
		}

		public void OpenFileQuestionLoader(object sender, EventArgs e)
		{
			AddQuestionsForm addQuestionsFormWindow = new AddQuestionsForm();
			addQuestionsFormWindow.ShowDialog();
		}
	}
}
