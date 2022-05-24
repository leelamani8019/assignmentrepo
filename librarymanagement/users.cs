using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace librarymanagement
{
    public class users
    {
        String issueDate;
        public void StoreBorrowerDetails(String borrowerName, int borrowerId, string bookName)
        {
            FileStream fileStreamObj = new FileStream(@"E:\laxman\librarymanagement\borrowerDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            streamWriterObj.Write(borrowerName + ",");

            streamWriterObj.Write(borrowerId + ",");

            streamWriterObj.Write(bookName);

            issueDate = DateTime.Now.ToShortDateString();
            streamWriterObj.WriteLine(issueDate);

            streamWriterObj.Close();
            fileStreamObj.Close();

        }
        public void UpdateBooksDetailFile(string bookName)
        {
            FileStream fileStreamObj = new FileStream(@"E:\laxman\librarymanagement\bookls.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            FileStream fileStreamWObj = new FileStream(@"E:\laxman\librarymanagement\NewBookDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamWObj);

            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] bookDataArr = line.Split(',');
                if (line.Contains(bookName))
                {
                    continue;

                }
                else
                {
                    for (int i = 0; i < bookDataArr.Length; i++)
                        streamWriterObj.Write(bookDataArr[i] + ",");
                }
                streamWriterObj.Write("\n");
            }
            streamWriterObj.Close();
            streamReaderObj.Close();
            fileStreamWObj.Close();

            File.Delete(@"E:\laxman\librarymanagement\bookls.txt");
            File.Move(@"E:\laxman\librarymanagement\NewBookDetails.txt", @"E:\laxman\librarymanagement\bookls.txt");

        }
    }
}
