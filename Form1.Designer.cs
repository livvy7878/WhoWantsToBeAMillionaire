using WhoWantToBeAMillionaire.Properties;

namespace WhoWantToBeAMillionaire
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.играToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.администраторскийРежимToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.EditQuestionsMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.администраторскийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpBox = new System.Windows.Forms.GroupBox();
			this.HelpGuysButton = new System.Windows.Forms.Button();
			this.HelpCallButton = new System.Windows.Forms.Button();
			this.Help50x50Button = new System.Windows.Forms.Button();
			this.QuestionBox = new System.Windows.Forms.TextBox();
			this.ExitApplicationButton = new System.Windows.Forms.Button();
			this.AnswerA = new System.Windows.Forms.Button();
			this.AnswerD = new System.Windows.Forms.Button();
			this.AnswerC = new System.Windows.Forms.Button();
			this.AnswerB = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.MaxGalkinImage = new System.Windows.Forms.PictureBox();
			this.MaxGalkinCorrectLabel = new System.Windows.Forms.Label();
			this.PopupImageCallHelp = new System.Windows.Forms.PictureBox();
			this.PopupLabelCallHelp = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.menuStrip1.SuspendLayout();
			this.HelpBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxGalkinImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupImageCallHelp)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem1,
            this.администраторскийРежимToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// играToolStripMenuItem1
			// 
			this.играToolStripMenuItem1.Name = "играToolStripMenuItem1";
			resources.ApplyResources(this.играToolStripMenuItem1, "играToolStripMenuItem1");
			// 
			// администраторскийРежимToolStripMenuItem1
			// 
			this.администраторскийРежимToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditQuestionsMenuStripItem});
			this.администраторскийРежимToolStripMenuItem1.Name = "администраторскийРежимToolStripMenuItem1";
			resources.ApplyResources(this.администраторскийРежимToolStripMenuItem1, "администраторскийРежимToolStripMenuItem1");
			// 
			// EditQuestionsMenuStripItem
			// 
			this.EditQuestionsMenuStripItem.Name = "EditQuestionsMenuStripItem";
			resources.ApplyResources(this.EditQuestionsMenuStripItem, "EditQuestionsMenuStripItem");
			// 
			// оПрограммеToolStripMenuItem1
			// 
			this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
			resources.ApplyResources(this.оПрограммеToolStripMenuItem1, "оПрограммеToolStripMenuItem1");
			// 
			// играToolStripMenuItem
			// 
			this.играToolStripMenuItem.Name = "играToolStripMenuItem";
			resources.ApplyResources(this.играToolStripMenuItem, "играToolStripMenuItem");
			// 
			// администраторскийРежимToolStripMenuItem
			// 
			this.администраторскийРежимToolStripMenuItem.Name = "администраторскийРежимToolStripMenuItem";
			resources.ApplyResources(this.администраторскийРежимToolStripMenuItem, "администраторскийРежимToolStripMenuItem");
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
			// 
			// HelpBox
			// 
			resources.ApplyResources(this.HelpBox, "HelpBox");
			this.HelpBox.BackColor = System.Drawing.Color.Black;
			this.HelpBox.Controls.Add(this.HelpGuysButton);
			this.HelpBox.Controls.Add(this.HelpCallButton);
			this.HelpBox.Controls.Add(this.Help50x50Button);
			this.HelpBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.HelpBox.Name = "HelpBox";
			this.HelpBox.TabStop = false;
			// 
			// HelpGuysButton
			// 
			resources.ApplyResources(this.HelpGuysButton, "HelpGuysButton");
			this.HelpGuysButton.BackColor = System.Drawing.Color.Black;
			this.HelpGuysButton.FlatAppearance.BorderSize = 0;
			this.HelpGuysButton.Image = global::WhoWantToBeAMillionaire.Properties.Resources.helpGuys;
			this.HelpGuysButton.Name = "HelpGuysButton";
			this.HelpGuysButton.TabStop = false;
			this.HelpGuysButton.UseVisualStyleBackColor = false;
			// 
			// HelpCallButton
			// 
			resources.ApplyResources(this.HelpCallButton, "HelpCallButton");
			this.HelpCallButton.BackColor = System.Drawing.Color.Black;
			this.HelpCallButton.FlatAppearance.BorderSize = 0;
			this.HelpCallButton.Image = global::WhoWantToBeAMillionaire.Properties.Resources.helpCall;
			this.HelpCallButton.Name = "HelpCallButton";
			this.HelpCallButton.TabStop = false;
			this.HelpCallButton.UseVisualStyleBackColor = false;
			// 
			// Help50x50Button
			// 
			resources.ApplyResources(this.Help50x50Button, "Help50x50Button");
			this.Help50x50Button.BackColor = System.Drawing.Color.Black;
			this.Help50x50Button.FlatAppearance.BorderSize = 0;
			this.Help50x50Button.Image = global::WhoWantToBeAMillionaire.Properties.Resources.help50x50;
			this.Help50x50Button.Name = "Help50x50Button";
			this.Help50x50Button.TabStop = false;
			this.Help50x50Button.UseVisualStyleBackColor = false;
			// 
			// QuestionBox
			// 
			this.QuestionBox.BackColor = System.Drawing.Color.Black;
			this.QuestionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QuestionBox.CausesValidation = false;
			resources.ApplyResources(this.QuestionBox, "QuestionBox");
			this.QuestionBox.ForeColor = System.Drawing.Color.White;
			this.QuestionBox.Name = "QuestionBox";
			this.QuestionBox.ReadOnly = true;
			this.QuestionBox.TabStop = false;
			// 
			// ExitApplicationButton
			// 
			resources.ApplyResources(this.ExitApplicationButton, "ExitApplicationButton");
			this.ExitApplicationButton.BackColor = System.Drawing.Color.Black;
			this.ExitApplicationButton.FlatAppearance.BorderSize = 0;
			this.ExitApplicationButton.Image = global::WhoWantToBeAMillionaire.Properties.Resources.exitDoor;
			this.ExitApplicationButton.Name = "ExitApplicationButton";
			this.ExitApplicationButton.TabStop = false;
			this.ExitApplicationButton.UseVisualStyleBackColor = false;
			// 
			// AnswerA
			// 
			this.AnswerA.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.AnswerA, "AnswerA");
			this.AnswerA.ForeColor = System.Drawing.Color.White;
			this.AnswerA.Name = "AnswerA";
			this.AnswerA.UseVisualStyleBackColor = false;
			// 
			// AnswerD
			// 
			this.AnswerD.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.AnswerD, "AnswerD");
			this.AnswerD.ForeColor = System.Drawing.Color.White;
			this.AnswerD.Name = "AnswerD";
			this.AnswerD.UseVisualStyleBackColor = false;
			// 
			// AnswerC
			// 
			this.AnswerC.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.AnswerC, "AnswerC");
			this.AnswerC.ForeColor = System.Drawing.Color.White;
			this.AnswerC.Name = "AnswerC";
			this.AnswerC.UseVisualStyleBackColor = false;
			// 
			// AnswerB
			// 
			this.AnswerB.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.AnswerB, "AnswerB");
			this.AnswerB.ForeColor = System.Drawing.Color.White;
			this.AnswerB.Name = "AnswerB";
			this.AnswerB.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Name = "label4";
			// 
			// MaxGalkinImage
			// 
			this.MaxGalkinImage.Image = global::WhoWantToBeAMillionaire.Properties.Resources.maximGalkin;
			resources.ApplyResources(this.MaxGalkinImage, "MaxGalkinImage");
			this.MaxGalkinImage.Name = "MaxGalkinImage";
			this.MaxGalkinImage.TabStop = false;
			// 
			// MaxGalkinCorrectLabel
			// 
			resources.ApplyResources(this.MaxGalkinCorrectLabel, "MaxGalkinCorrectLabel");
			this.MaxGalkinCorrectLabel.BackColor = System.Drawing.Color.Black;
			this.MaxGalkinCorrectLabel.ForeColor = System.Drawing.Color.White;
			this.MaxGalkinCorrectLabel.Name = "MaxGalkinCorrectLabel";
			// 
			// PopupImageCallHelp
			// 
			this.PopupImageCallHelp.Image = global::WhoWantToBeAMillionaire.Properties.Resources.GnomeInGlasses;
			resources.ApplyResources(this.PopupImageCallHelp, "PopupImageCallHelp");
			this.PopupImageCallHelp.Name = "PopupImageCallHelp";
			this.PopupImageCallHelp.TabStop = false;
			// 
			// PopupLabelCallHelp
			// 
			resources.ApplyResources(this.PopupLabelCallHelp, "PopupLabelCallHelp");
			this.PopupLabelCallHelp.BackColor = System.Drawing.Color.Black;
			this.PopupLabelCallHelp.ForeColor = System.Drawing.Color.White;
			this.PopupLabelCallHelp.Name = "PopupLabelCallHelp";
			// 
			// MainWindow
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WhoWantToBeAMillionaire.Properties.Resources.Khsm_logo_big;
			this.Controls.Add(this.PopupLabelCallHelp);
			this.Controls.Add(this.PopupImageCallHelp);
			this.Controls.Add(this.MaxGalkinCorrectLabel);
			this.Controls.Add(this.MaxGalkinImage);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AnswerB);
			this.Controls.Add(this.AnswerC);
			this.Controls.Add(this.AnswerD);
			this.Controls.Add(this.AnswerA);
			this.Controls.Add(this.ExitApplicationButton);
			this.Controls.Add(this.QuestionBox);
			this.Controls.Add(this.HelpBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.HelpBox.ResumeLayout(false);
			this.HelpBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxGalkinImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupImageCallHelp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.GroupBox HelpBox;
		private System.Windows.Forms.Button Help50x50Button;
		private System.Windows.Forms.Button HelpGuysButton;
		private System.Windows.Forms.Button HelpCallButton;
		private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
		private System.Windows.Forms.TextBox QuestionBox;
		private System.Windows.Forms.Button ExitApplicationButton;
		private System.Windows.Forms.Button AnswerA;
		private System.Windows.Forms.Button AnswerD;
		private System.Windows.Forms.Button AnswerC;
		private System.Windows.Forms.Button AnswerB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox MaxGalkinImage;
		private System.Windows.Forms.Label MaxGalkinCorrectLabel;
		private System.Windows.Forms.PictureBox PopupImageCallHelp;
		private System.Windows.Forms.Label PopupLabelCallHelp;
		private System.Windows.Forms.ToolStripMenuItem EditQuestionsMenuStripItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

