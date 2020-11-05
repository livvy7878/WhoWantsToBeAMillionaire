using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
	public partial class ScrollQuestions : Form
	{
		private Form Opener { get; set; }
		public ScrollQuestions() : this(null) { }
		public ScrollQuestions(Form opener)
		{
			InitializeComponent();
			Opener = opener;
			StartPosition = FormStartPosition.CenterParent;
			ScrollQuestionsTrackBar.Value = (Opener as MainWindow).StatisticsNow.IndexInQuestions;
			KeyDown += ScrollQuestions_KeyDown;
		}

		private void ScrollQuestions_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void ScrollQuestionsTrackBarScrollEventHandler(object sender, EventArgs e)
		{
			MainWindow parent = Opener as MainWindow;
			parent.MoveToQuestion(ScrollQuestionsTrackBar.Value);
		}
	}
}
