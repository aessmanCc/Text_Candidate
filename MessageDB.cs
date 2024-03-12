using System.Collections.Generic;
using System.IO;

namespace Email_Canidates
{
    class MessageDB
    {
		//Relative file path.
		private const string dir = @"..\..\";
		private const string path = dir + "History.txt";

		public static void SaveStudents(List<Message> messages)
		{
			// create the output stream for a text file
			StreamWriter textOut =
				new StreamWriter(
				new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each student
			foreach (Message message in messages)
			{

				textOut.Write(message.StoreNumber + ",");
				textOut.Write(message.DateOccur + ",");
				textOut.Write(message.TimeStamp + ",");
				textOut.WriteLine(message.MessageContent);

			}

			// write the end of the document
			textOut.Close();
		}

		// Get all students from the text file. 
		public static List<Message> GetMessages()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a text file
			StreamReader textIn =
				new StreamReader(
					new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list for customers
			List<Message> messages = new List<Message>();

			// read the data from the file and store it in the ArrayList
			while (textIn.Peek() != -1)
			{

				string row = textIn.ReadLine();
				string[] columns = row.Split(',');
				Message message = new Message();
				message.StoreNumber = columns[0];
				message.DateOccur = System.DateTime.Parse(columns[1]);
				message.TimeStamp = columns[2];
				message.MessageContent = columns[3];
				messages.Add(message);
			}

			textIn.Close();
			return messages;
		}
	}
}
