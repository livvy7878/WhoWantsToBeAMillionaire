using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	[DataContract]
	public class GameStatistics
	{
		public GameStatistics()
		{
			QuestionsNow = QuestionMaker.LoadQuestions(Settings.Default.QuestionsFilename);
		}
		[DataMember]
		public List<Question> QuestionsNow { get; set; }
		[DataMember]
		public int IndexInQuestions { get; set; }
		[DataMember]
		public List<string> randomizedOrderOfAnswers { get; set; }
		[DataMember]
		public bool HelpUsedAtThisQuestion { get; set; }
		[DataMember]
		public bool IsHelp50x50ButtonPressed { get; set; }
		[DataMember]
		public bool IsHelpCallButtonPressed { get; set; }
		[DataMember]
		public bool IsHelpGuysButtonPressed { get; set; }
		public static void SaveStatistics(string pathToSave, GameStatistics statistics)
		{
			FileStream fileStream = File.Create(pathToSave);
			XmlWriter writer = XmlDictionaryWriter.CreateTextWriter(fileStream);
			DataContractSerializer serializer = new DataContractSerializer(typeof(GameStatistics));
			serializer.WriteObject(writer, statistics);
			writer.Close();
			fileStream.Close();
		}
		public static GameStatistics LoadStatisticsOrReturnDefault()
		{
			FileStream fileStream;
			GameStatistics createdStatistics;
			try
			{
				fileStream = new FileStream(Settings.Default.UserSaveFilePath + "UserSave.xml", FileMode.Open);

				XmlReader reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
				DataContractSerializer serializer = new DataContractSerializer(typeof(GameStatistics));
				createdStatistics = (GameStatistics)serializer.ReadObject(reader);
				reader.Close();
				fileStream.Close();
			}
			catch (Exception)
			{
				createdStatistics = new GameStatistics();
			}
			return createdStatistics;
		}
		public void ResetStatistics()
		{
			IndexInQuestions = 0;
			IsHelp50x50ButtonPressed = false;
			IsHelpCallButtonPressed = false;
			IsHelpGuysButtonPressed = false;
		}
	}
}
