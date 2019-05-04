using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QuickStudyGuider
{
    public class Answer
    {
        public string question;
        public string answer;

        public Answer(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
    public class AnswerKey
    {
        public static void ExportKey(AnswerKey key, string filepath)
        {
            List<string> list = new List<string>();
            foreach(Answer answer in key.answers)
            {
                string line = answer.question + key.splitkey + answer.answer;
                list.Add(line);
            }
            string towrite = string.Join(key.newlinesplit, list);
            File.WriteAllText(filepath,towrite);
        }

        public List<Answer> answers = new List<Answer>();
        public string splitkey;
        public string newlinesplit;
        public string filepath;
        public AnswerKey(string filepath,string splitkey,string newlinesplit)
        {
            this.filepath = filepath;
            this.splitkey = splitkey;
            this.newlinesplit = newlinesplit;
            answers.Clear();
            string text = File.ReadAllText(filepath);
            string[] lines = Regex.Split(text, newlinesplit);
            if(newlinesplit.Length == 1)
            {
                lines = text.Split(newlinesplit[0]);
            }
            foreach (string line in lines)
            {
                if(!string.IsNullOrEmpty(line))
                {
                    string[] arguments = Regex.Split(line, splitkey);
                    if(splitkey.Length == 1)
                    {
                        arguments = line.Split(splitkey[0]);
                    }
                    arguments[0] = FormatQuestion(arguments[0]);
                    answers.Add(new Answer(arguments[0], arguments[1]));
                }
            }
        }

        private string FormatQuestion(string question)
        {
            question = question.Replace(" ", "");
            question = question.Replace("-", "");
            question = question.Replace("\"", "");
            question = question.Replace(".", "");
            question = question.Replace(",", "");
            question = question.Replace(";", "");
            question = question.Replace("_", "");
            question = question.Replace("\r\n", "");
            question = question.Replace("\n", "");
            question = question.ToUpper();
            return question;
        }

        public string GetAnswer(string question)
        {
            question = FormatQuestion(question);
            foreach(Answer answer in answers)
            {
                if(answer.question == question)
                {
                    return answer.answer;
                }
            }
            return "That question is not found.";
        }

        public bool AddQuestion(string question, string answer)
        {
            foreach(Answer ans in answers)
            {
                if(ans.question == FormatQuestion(question))
                {
                    return false;
                }
            }
            answers.Add(new Answer(FormatQuestion(question), answer));
            return true;
        }

        public bool DeleteQuestion(string question)
        {
            Answer toremove = null;
            foreach(Answer answer in answers)
            {
                if(answer.question == FormatQuestion(question))
                {
                    toremove = answer;
                }
            }
            return answers.Remove(toremove);
        }

        public string GetKeyProperty(string propertyname)
        {
            if(GetAnswer("prop."+propertyname) == "That question is not found.")
            {
                return "N/A";
            }
            return GetAnswer("prop." + propertyname);
        }

        public void AppendKey(AnswerKey extrakey)
        {
            this.answers.AddRange(extrakey.answers);
        }
    }
}
