using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantToBeAMillionaire
{
	class QuestionMaker
	{

	}

	struct Question
	{
		public Question(string askedQuestion, List<string> answers, string correctAnswer)
		{
			AskedQuestion = askedQuestion;
			Answers = answers;
			CorrectAnswer = correctAnswer;
		}

		public string AskedQuestion { get; set; }
		public List<string> Answers { get; set; }
		public string CorrectAnswer { get; set; }
	}
}
