using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	public partial class MainWindow : Form
	{
		public GameStatistics StatisticsNow { get; set; }
		public MainWindow()
		{
			InitializeComponent();
			Settings.Default.UserSaveFilePath = Application.StartupPath + '\\' + "Saves";

			StatisticsNow = GameStatistics.LoadStatisticsOrReturnDefault();
			InitializeButtonsWithAnswers();
			InitializeUpperButtons();
			MaximizeBox = false;

			QuestionBox.Text = StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].AskedQuestion;
			ApplyToButtonRandomizedAnswerOrder();
			EditQuestionsMenuStripItem.Click += OpenFileQuestionLoader;
			FormClosing += MainWindow_FormClosing;

			UserAnswerPauseBackgroundWorker.DoWork += PauseBeforeAnswerCheck;
			UserAnswerPauseBackgroundWorker.ProgressChanged += HandleUserAnswer;

			MaxGalkinImage.Visible = false;
			MaxGalkinCorrectLabel.Visible = false;
			PopupImageCallHelp.Visible = false;
			PopupLabelCallHelp.Visible = false;
			SelectBarRightPanelImage.Top = 586 - (StatisticsNow.IndexInQuestions * 31);

			PopupMaxGalkinBackgroundWorker.WorkerReportsProgress = true;
			PopupMaxGalkinBackgroundWorker.WorkerSupportsCancellation = true;

			KeyUp += MainWindow_KeyUp;
			ResetGameToolStripMenuItem.Click += ResetGameToolStripMenuItem_Click;
			ChangeQuestionNowToolStripMenuItem.Click += ChangeQuestionNowToolStripMenuItem_Click;
			AboutProgramToolStrip.Click += AboutProgramToolStrip_Click;

			//WindowState = FormWindowState.Minimized;
		}

		private void AboutProgramToolStrip_Click(object sender, EventArgs e)
		{
			MessageBox.Show("2020 year\ngithub livvy7878", "Кто хочет стать миллионером?");
		}

		private void AnswerButton_BackColorChanged(object sender, EventArgs e)
		{
			Button button = sender as Button;
			Label label = button.Tag as Label;
			label.BackColor = button.BackColor;
		}

		private void AnswerButton_ForeColorChanged(object sender, EventArgs e)
		{
			Button button = sender as Button;
			Label label = button.Tag as Label;
			label.ForeColor = button.ForeColor;
		}

		private void RestoreButtonsColor(object sender, EventArgs e)
		{
			AnswerA.BackColor = Color.Black;
			AnswerA.ForeColor = Color.White;
			AnswerB.BackColor = Color.Black;
			AnswerB.ForeColor = Color.White;
			AnswerC.BackColor = Color.Black;
			AnswerC.ForeColor = Color.White;
			AnswerD.BackColor = Color.Black;
			AnswerD.ForeColor = Color.White;
		}

		private void HandleColorChangesAfterPressButton(object sender, EventArgs e)
		{
			Button pressedButton = sender as Button;
			bool isAnswerCorrect = pressedButton.Text == StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer;

			Task colorChange = new Task(() =>
			{
				Thread.Sleep(2000);
				pressedButton.BackColor = isAnswerCorrect ? Color.Green : Color.Red;
				pressedButton.ForeColor = Color.Black;
				if (!isAnswerCorrect)
				{
					Button correctButton = FindButtonWithCorrectAnswer();
					correctButton.BackColor = Color.Green;
				}
			});
			colorChange.Start();

			pressedButton.BackColor = Color.Yellow;
			pressedButton.ForeColor = Color.Black;
		}

		private void ChangeQuestionNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ScrollQuestions scrollQuestions = new ScrollQuestions(this);
			scrollQuestions.ShowDialog();
		}

		private void MainWindow_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.M:
					SoundControlButton_Click(this, new EventArgs());
					break;
				case Keys.R:
					ResetGameToolStripMenuItem_Click(this, new EventArgs());
					break;
				case Keys.F1:
					Form form = new EditorQuestionsForm();
					form.ShowDialog();
					break;
			}
		}

		private void SoundControlButton_Click(object sender, EventArgs e)
		{
			if (Settings.Default.IsSoundEnabled)
			{
				Settings.Default.IsSoundEnabled = false;
				SoundController.StopSoundPlaying();
			}
			else
			{
				Settings.Default.IsSoundEnabled = true;
			}
			Settings.Default.Save();
			SoundControlButton.Image = Settings.Default.IsSoundEnabled ? Resources.soundUp : Resources.soundDown;
		}

		private void ResetGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Перезапустить игру?", "Кто хочет стать миллионером?", MessageBoxButtons.YesNo);

			switch (res)
			{
				case DialogResult.Yes:
					ResetGame();
					break;
				case DialogResult.No:
					UiStateChange(false);
					break;
			}
		}

		public void ResetGame()
		{
			StatisticsNow.ResetStatistics();

			MaxGalkinImage.Visible = false;
			MaxGalkinCorrectLabel.Visible = false;
			ResetUiAfterStep();
			AppWinState(true);
			QuestionBox.Text = StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].AskedQuestion;
			ApplyToButtonRandomizedAnswerOrder();

			GameStatistics.SaveStatistics(@"Saves\UserSave.xml", StatisticsNow);

			ResetHelpImages();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Directory.CreateDirectory(@"Saves\");
			GameStatistics.SaveStatistics(@"Saves\UserSave.xml", StatisticsNow);
		}

		private void HelpGuysButton_Click(object sender, EventArgs e)
		{
			if (StatisticsNow.IsHelpGuysButtonPressed || StatisticsNow.HelpUsedAtThisQuestion)
			{
				return;
			}
			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.helpGuysSound);
			}
			StatisticsNow.IsHelpGuysButtonPressed = true;
			HelpGuysButton.Image = Resources.helpGuysPressed;
			HelpGuysGroup.Visible = true;

			Random rand = new Random();
			List<Label> labelsWithPercent = new List<Label> { HelpGuysPercentLabelA, HelpGuysPercentLabelB, HelpGuysPercentLabelC, HelpGuysPercentLabelD };
			List<Label> labelsWithBars = new List<Label> { GuysHelpBoxLabelBarA, GuysHelpBoxLabelBarB, GuysHelpBoxLabelBarC, GuysHelpBoxLabelBarD };
			int percentLeft = 99;
			for (int i = 0; i < 4; i++)
			{
				int randNum = rand.Next(1, percentLeft);
				labelsWithPercent[i].Text = randNum.ToString();
				percentLeft -= randNum;
				labelsWithBars[i].Size = new Size(randNum * 2, labelsWithBars[i].Size.Height);
			}
			int labelIndex = rand.Next(0, 4);
			int valNow = percentLeft + int.Parse(labelsWithPercent[labelIndex].Text);
			labelsWithPercent[labelIndex].Text = valNow.ToString();

			StatisticsNow.HelpUsedAtThisQuestion = true;
		}

		private void HelpCallButton_Click(object sender, EventArgs e)
		{
			if (StatisticsNow.IsHelpCallButtonPressed || StatisticsNow.HelpUsedAtThisQuestion)
			{
				return;
			}

			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.helpNumberDialedSound);
			}

			StatisticsNow.IsHelpCallButtonPressed = true;
			HelpCallButton.Image = Resources.helpCallPressed;

			Random rand = new Random();
			int randomedNumber = rand.Next(0, 100);
			if (randomedNumber <= 40)
			{
				PopupLabelCallHelp.Text = "Я думаю, что это " + StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer;
			}
			else
			{
				PopupLabelCallHelp.Text = "Я думаю, что это " + StatisticsNow.randomizedOrderOfAnswers[rand.Next(0, 4)];
			}
			PopupLabelCallHelp.Visible = true;
			PopupImageCallHelp.Visible = true;

			StatisticsNow.HelpUsedAtThisQuestion = true;
		}

		private void Help50x50Button_Click(object sender, EventArgs e)
		{
			if (StatisticsNow.IsHelp50x50ButtonPressed || StatisticsNow.HelpUsedAtThisQuestion)
			{
				return;
			}

			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.help50x50Sound);
			}

			StatisticsNow.IsHelp50x50ButtonPressed = true;
			Help50x50Button.Image = Resources.help50x50Pressed;

			Random rand = new Random();
			List<Button> buttons = new List<Button> { AnswerA, AnswerB, AnswerC, AnswerD };

			for (int i = 0; i < 4; i++)
			{
				if (buttons[i].Text == StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer)
				{
					buttons.RemoveAt(i);
					break;
				}
			}

			buttons.RemoveAt(rand.Next(0, 2));
			buttons[0].Enabled = false;
			buttons[1].Enabled = false;

			StatisticsNow.HelpUsedAtThisQuestion = true;
		}

		private void UserAnswerButtonClickEventHandler(object sender, EventArgs e)
		{
			Button pressedButton = sender as Button;

			if (!UserAnswerPauseBackgroundWorker.IsBusy)
			{
				HandleColorChangesAfterPressButton(pressedButton, e);
				if (Settings.Default.IsSoundEnabled)
				{
					SoundController.PlaySound(Resources.buttonPressed);
				}
				UserAnswerPauseBackgroundWorker.RunWorkerAsync(pressedButton);
			}
		}

		private void HandleUserAnswer(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			Button pressedButton = e.UserState as Button;

			if (pressedButton.Text == StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer)
			{
				UserMakeCorrectAnswer();
			}
			else
			{
				UserMakeWrongAnswer();
			}
			RestoreButtonsColor(pressedButton, e);
		}

		private void PauseBeforeAnswerCheck(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Thread.Sleep(3000);
			UserAnswerPauseBackgroundWorker.ReportProgress(100, e.Argument);
		}

		private void UserMakeCorrectAnswer()
		{
			if (StatisticsNow.IndexInQuestions == 14)
			{
				ShowWinMessage();
				return;
			}
			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.correctAnswer);
			}
			ShowMaximGalkin();
			MoveToQuestion(++StatisticsNow.IndexInQuestions);
		}

		private void UserMakeWrongAnswer()
		{
			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.wrongAnswer);
			}
			ResetGameToolStripMenuItem_Click(this, new EventArgs());
		}

		private void ShowWinMessage()
		{
			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.winnerSound);
			}
			StatisticsNow.IndexInQuestions = 0;
			AppWinState(false);
			ResetGameToolStripMenuItem_Click(this, new EventArgs());
		}

		private void AppWinState(bool changeStateTo)
		{
			BackgroundImage = changeStateTo ? Resources.Khsm_logo_big : Resources.winImage;
			UiStateChange(changeStateTo);
		}

		private void UiStateChange(bool changeStateTo)
		{
			SelectBarRightPanelImage.Visible = changeStateTo;
			QuestionBox.Visible = changeStateTo;
			AnswerA.Visible = changeStateTo;
			AnswerB.Visible = changeStateTo;
			AnswerC.Visible = changeStateTo;
			AnswerD.Visible = changeStateTo;
			AnswerALabel.Visible = changeStateTo;
			AnswerBLabel.Visible = changeStateTo;
			AnswerCLabel.Visible = changeStateTo;
			AnswerDLabel.Visible = changeStateTo;
			HelpBox.Visible = changeStateTo;
		}

		private void ShowMaximGalkin()
		{
			PopupMaxGalkinBackgroundWorker.DoWork += (s, ea) =>
			{
				Thread.Sleep(2000);
				PopupMaxGalkinBackgroundWorker.ReportProgress(100);
			};
			PopupMaxGalkinBackgroundWorker.ProgressChanged += (s, ea) =>
			{
				MaxGalkinImage.Visible = false;
				MaxGalkinCorrectLabel.Visible = false;
			};

			MaxGalkinImage.Visible = true;
			MaxGalkinCorrectLabel.Visible = true;

			if (!PopupMaxGalkinBackgroundWorker.IsBusy)
			{
				PopupMaxGalkinBackgroundWorker.RunWorkerAsync();
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

		public void MoveToQuestion(int questionNumber)
		{
			StatisticsNow.HelpUsedAtThisQuestion = false;
			StatisticsNow.IndexInQuestions = questionNumber;
			ResetUiAfterStep();
			QuestionBox.Text = StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].AskedQuestion;
			ApplyToButtonRandomizedAnswerOrder();
		}

		private void ResetUiAfterStep()
		{
			SelectBarRightPanelImage.Top = 586 - (StatisticsNow.IndexInQuestions * 31);
			HelpGuysGroup.Visible = false;
			PopupLabelCallHelp.Visible = false;
			PopupImageCallHelp.Visible = false;
			AnswerA.Enabled = true;
			AnswerB.Enabled = true;
			AnswerC.Enabled = true;
			AnswerD.Enabled = true;
		}

		private void ApplyToButtonRandomizedAnswerOrder()
		{
			List<string> answersToRandomize = StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].Answers;
			StatisticsNow.randomizedOrderOfAnswers = MakeRandomAnswerOrder(answersToRandomize);
			AnswerA.Text = StatisticsNow.randomizedOrderOfAnswers[0];
			AnswerB.Text = StatisticsNow.randomizedOrderOfAnswers[1];
			AnswerC.Text = StatisticsNow.randomizedOrderOfAnswers[2];
			AnswerD.Text = StatisticsNow.randomizedOrderOfAnswers[3];
		}

		private void ResetHelpImages()
		{
			Help50x50Button.Image = Resources.help50x50;
			HelpGuysButton.Image = Resources.helpGuys;
			HelpCallButton.Image = Resources.helpCall;
		}

		private List<string> MakeRandomAnswerOrder(List<string> inThisList)
		{
			Random rand = new Random();
			List<string> randomizedAnswerOrder = new List<string>();
			List<string> notRandomizerAnswers = new List<string>(inThisList);
			for (int i = 0; i < 4; i++)
			{
				int indexToAdd = rand.Next(0, 4 - i);
				randomizedAnswerOrder.Add(notRandomizerAnswers[indexToAdd]);
				notRandomizerAnswers.RemoveAt(indexToAdd);
			}
			return randomizedAnswerOrder;
		}

		public void OpenFileQuestionLoader(object sender, EventArgs e)
		{
			EditQuestionsForm addQuestionsFormWindow = new EditQuestionsForm();
			addQuestionsFormWindow.Owner = this;
			addQuestionsFormWindow.ShowDialog();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			if (Settings.Default.IsSoundEnabled)
			{
				SoundController.PlaySound(Resources.gameBegins);
			}
		}

		private Button FindButtonWithCorrectAnswer()
		{
			if (StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer == AnswerA.Text)
			{
				return AnswerA;
			}
			if (StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer == AnswerB.Text)
			{
				return AnswerB;
			}
			if (StatisticsNow.QuestionsNow[StatisticsNow.IndexInQuestions].CorrectAnswer == AnswerC.Text)
			{
				return AnswerC;
			}
			return AnswerD;
		}

		private void InitializeButtonsWithAnswers()
		{
			AnswerA.Click += UserAnswerButtonClickEventHandler;
			AnswerB.Click += UserAnswerButtonClickEventHandler;
			AnswerC.Click += UserAnswerButtonClickEventHandler;
			AnswerD.Click += UserAnswerButtonClickEventHandler;
			AnswerA.Tag = AnswerALabel;
			AnswerB.Tag = AnswerBLabel;
			AnswerC.Tag = AnswerCLabel;
			AnswerD.Tag = AnswerDLabel;
			AnswerA.BackColorChanged += AnswerButton_BackColorChanged;
			AnswerB.BackColorChanged += AnswerButton_BackColorChanged;
			AnswerC.BackColorChanged += AnswerButton_BackColorChanged;
			AnswerD.BackColorChanged += AnswerButton_BackColorChanged;
			AnswerA.ForeColorChanged += AnswerButton_ForeColorChanged;
			AnswerB.ForeColorChanged += AnswerButton_ForeColorChanged;
			AnswerC.ForeColorChanged += AnswerButton_ForeColorChanged;
			AnswerD.ForeColorChanged += AnswerButton_ForeColorChanged;
		}

		private void InitializeUpperButtons()
		{
			Help50x50Button.Click += Help50x50Button_Click;
			HelpCallButton.Click += HelpCallButton_Click;
			HelpGuysButton.Click += HelpGuysButton_Click;
			SoundControlButton.Click += SoundControlButton_Click;
			ExitApplicationButton.Click += ExitApplicationButton_Click;

			Help50x50Button.Image = StatisticsNow.IsHelp50x50ButtonPressed ? Resources.help50x50Pressed : Resources.help50x50;
			HelpCallButton.Image = StatisticsNow.IsHelpCallButtonPressed ? Resources.helpCallPressed : Resources.helpCall;
			HelpGuysButton.Image = StatisticsNow.IsHelpGuysButtonPressed ? Resources.helpGuysPressed : Resources.helpGuys;
			SoundControlButton.Image = Settings.Default.IsSoundEnabled ? Resources.soundUp : Resources.soundDown;
		}
	}
}
