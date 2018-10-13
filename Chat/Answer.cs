using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Chat
{
    class Answer
    {
        List<string> answersList;
        public Answer()
        {
            answersList = new List<string>();
            AddAnswers(@"Z:\StudentsFiles\RPZ\RPZ3\Витвицький\WPF\Chat\Chat\files\answersDiana.txt");
            AddAnswers(@"Z:\StudentsFiles\RPZ\RPZ3\Витвицький\WPF\Chat\Chat\files\answersInna.txt");
            AddAnswers(@"Z:\StudentsFiles\RPZ\RPZ3\Витвицький\WPF\Chat\Chat\files\answersJulia.txt");
            AddAnswers(@"Z:\StudentsFiles\RPZ\RPZ3\Витвицький\WPF\Chat\Chat\files\answersMax.txt");
            AddAnswers(@"Z:\StudentsFiles\RPZ\RPZ3\Витвицький\WPF\Chat\Chat\files\answersOleksandr.txt");
            
            answersList.Add("");
        }

        private void AddAnswers(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    answersList.Add(line.Trim());
                }
            }
        }

        public string GetAnswer()
        {
            Random r = new Random();
            return answersList[r.Next(answersList.Count)];
        }
    }
}
