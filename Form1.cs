using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WhoWantToBeAMillionaire.Properties;

namespace WhoWantToBeAMillionaire
{
	public partial class MainWindow : Form
	{
		public List<Question> questionsNow { get; set; }
		public int IndexInQuestions { get; set; }
		private List<string> randomizedOrderOfAnswers;

		private bool IsHelp50x50ButtonPressed;
		private bool IsHelpCallButtonPressed;
		private bool IsHelpGuysButtonPressed;

		public MainWindow()
		{
			InitializeComponent();
			questionsNow = QuestionMaker.LoadQuestions();
			IndexInQuestions = -1;
			StepToNextQuestion();
			EditQuestionsMenuStripItem.Click += OpenFileQuestionLoader;
			ExitApplicationButton.Click += ExitApplicationButton_Click;

			AnswerA.Click += UserAnswerEventHandler;
			AnswerB.Click += UserAnswerEventHandler;
			AnswerC.Click += UserAnswerEventHandler;
			AnswerD.Click += UserAnswerEventHandler;

			MaxGalkinImage.Visible = false;
			MaxGalkinCorrectLabel.Visible = false;
			PopupImageCallHelp.Visible = false;
			PopupLabelCallHelp.Visible = false;

			backgroundWorker1.DoWork += (s, ea) =>
			{
				Thread.Sleep(3000);
				backgroundWorker1.ReportProgress(100);
			};
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.WorkerSupportsCancellation = true;

			Help50x50Button.Click += Help50x50Button_Click;
		}

		private void Help50x50Button_Click(object sender, EventArgs e)
		{
			if (IsHelp50x50ButtonPressed)
			{
				return;
			}
			IsHelp50x50ButtonPressed = true;
			Help50x50Button.Image = Resources.help50x50Pressed;

			Random rand = new Random();
			List<Button> buttons = new List<Button> { AnswerA, AnswerB, AnswerC, AnswerD };

			for (int i = 0; i < 4; i++)
			{
				if (buttons[i].Text == questionsNow[IndexInQuestions].CorrectAnswer)
				{
					buttons.RemoveAt(i);
					break;
				}
			}

			buttons.RemoveAt(rand.Next(0, 2));
			buttons[0].Enabled = false;
			buttons[1].Enabled = false;
		}

		private void UserAnswerEventHandler(object sender, EventArgs e)
		{
			Button pressedButton = sender as Button;
			if (pressedButton.Text == questionsNow[IndexInQuestions].CorrectAnswer)
			{
				UserMakeCorrectAnswer();
			}
		}

		private void UserMakeCorrectAnswer()
		{
			ShowMaximGalkin();
			StepToNextQuestion();
		}

		private void ShowMaximGalkin()
		{
			backgroundWorker1.ProgressChanged += (s, ea) =>
			{
				MaxGalkinImage.Visible = false;
				MaxGalkinCorrectLabel.Visible = false;
			};

			MaxGalkinImage.Visible = true;
			MaxGalkinCorrectLabel.Visible = true;

			if (!backgroundWorker1.IsBusy)
			{
				backgroundWorker1.RunWorkerAsync();
			}
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

		private void StepToNextQuestion()
		{
			AnswerA.Enabled = true;
			AnswerB.Enabled = true;
			AnswerC.Enabled = true;
			AnswerD.Enabled = true;
			IndexInQuestions++;
			QuestionBox.Text = questionsNow[IndexInQuestions].AskedQuestion;
			List<string> randomizedAnswers = MakeRandomAnswerOrder(questionsNow[IndexInQuestions].Answers);
			AnswerA.Text = randomizedAnswers[0];
			AnswerB.Text = randomizedAnswers[1];
			AnswerC.Text = randomizedAnswers[2];
			AnswerD.Text = randomizedAnswers[3];
			randomizedOrderOfAnswers = randomizedAnswers;
		}

		private List<string> MakeRandomAnswerOrder(List<string> inThisList)
		{
			Random rand = new Random();
			List<string> randomizedAnswerOrder = new List<string>();
			for (int i = 0; i < 4; i++)
			{
				int indexToAdd = rand.Next(0, 4 - i);
				randomizedAnswerOrder.Add(inThisList[indexToAdd]);
				inThisList.RemoveAt(indexToAdd);
			}
			return randomizedAnswerOrder;
		}

		public void OpenFileQuestionLoader(object sender, EventArgs e)
		{
			EditQuestionsForm addQuestionsFormWindow = new EditQuestionsForm();
			addQuestionsFormWindow.ShowDialog();
		}
	}
}
