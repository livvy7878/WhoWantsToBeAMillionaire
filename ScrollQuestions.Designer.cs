namespace WhoWantToBeAMillionaire
{
	partial class ScrollQuestions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollQuestions));
			this.ScrollQuestionsTrackBar = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.ScrollQuestionsTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// ScrollQuestionsTrackBar
			// 
			this.ScrollQuestionsTrackBar.AutoSize = false;
			this.ScrollQuestionsTrackBar.LargeChange = 1;
			this.ScrollQuestionsTrackBar.Location = new System.Drawing.Point(28, 12);
			this.ScrollQuestionsTrackBar.Maximum = 14;
			this.ScrollQuestionsTrackBar.Name = "ScrollQuestionsTrackBar";
			this.ScrollQuestionsTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.ScrollQuestionsTrackBar.Size = new System.Drawing.Size(45, 172);
			this.ScrollQuestionsTrackBar.TabIndex = 0;
			this.ScrollQuestionsTrackBar.Scroll += new System.EventHandler(this.ScrollQuestionsTrackBarScrollEventHandler);
			// 
			// ScrollQuestions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(103, 196);
			this.Controls.Add(this.ScrollQuestionsTrackBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "ScrollQuestions";
			this.Text = "ScrollQuestions";
			((System.ComponentModel.ISupportInitialize)(this.ScrollQuestionsTrackBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar ScrollQuestionsTrackBar;
	}
}