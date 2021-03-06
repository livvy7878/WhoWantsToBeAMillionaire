﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	static class QuestionMaker
	{
		public static void MakeFromTextFileXmlQuestions(string pathToTextFile)
		{
			string[] allTextInFile = File.ReadAllLines(pathToTextFile, Encoding.UTF8);
			List<Question> questions = new List<Question>();

			for (int i = 0; i < 15; i++)
			{
				List<string> listWithAllAnswers = new List<string>() {
					allTextInFile[(i*5) + 1],
					allTextInFile[(i*5) + 2],
					allTextInFile[(i*5) + 3],
					allTextInFile[(i*5) + 4]
				};
				Question oneQuestionToAdd = new Question(allTextInFile[i * 5], listWithAllAnswers, listWithAllAnswers[0]);
				questions.Add(oneQuestionToAdd);
			}
			SaveQuestionsInXmlFile(questions);
		}

		public static void SaveQuestionsInXmlFile(List<Question> questions)
		{
			FileStream fileStream = File.Create("Questions.xml");
			XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(fileStream);
			DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(List<Question>));
			dataContractSerializer.WriteObject(writer, questions);
			writer.Close();
			fileStream.Close();
		}

		public static List<Question> LoadQuestions(string fullFilePath)
		{
			FileStream fs;
			try
			{
				fs = new FileStream(fullFilePath, FileMode.Open);
			}
			catch (System.Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter("error.log", true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
				fs = new FileStream(fullFilePath, FileMode.Open);
			}
			XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
			DataContractSerializer serializer = new DataContractSerializer(typeof(List<Question>));

			List<Question> deserializedQuestions = (List<Question>)serializer.ReadObject(reader, true);
			fs.Close();
			return deserializedQuestions;
		}
	}

	[DataContract]
	public struct Question
	{
		public Question(string askedQuestion, List<string> answers, string correctAnswer)
		{
			AskedQuestion = askedQuestion;
			Answers = answers;
			CorrectAnswer = correctAnswer;
		}
		[DataMember]
		public string AskedQuestion { get; set; }
		[DataMember]
		public List<string> Answers { get; set; }
		[DataMember]
		public string CorrectAnswer { get; set; }

		public override string ToString()
		{
			return AskedQuestion;
		}
	}
}
