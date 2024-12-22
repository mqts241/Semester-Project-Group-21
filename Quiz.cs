using System.Security.Cryptography;
using System.Xml;

namespace WorldOfZuul;
//QUIZ to be printed after the EndGame Showcase, to measure the awareness impact on players
    public class Question {
        public string Prompt {get; private set; }
        public Question (string prompt) {
            Prompt = prompt;
        }
        public string QuizAnswers() {
            Console.WriteLine(Prompt);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     1- Strongly Disagree");
            Console.WriteLine("     2- Disagree");
            Console.WriteLine("     3- Neutral");
            Console.WriteLine("     4- Agree");
            Console.WriteLine("     5- Strongly Agree\n");
            Console.ResetColor();


            string answer;
            while (true) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your answer is: ");
                Console.ResetColor();
                answer = Console.ReadLine()!;
                if(ValidAnswer(answer)){
                    break; 
                }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter a number between 1 - 5.");
            Console.ResetColor();
            }
            return answer;
        }
        private bool ValidAnswer(string answer) {
            return answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5";
        }
    }

    public class Quiz {
        private List<Question> Questions = new List<Question>();

        public void AddQuestion(Question question) {
            Questions.Add(question);
        }
        public Dictionary<Question, string> RunQuiz() {
            var answers = new Dictionary<Question, string>();

            foreach (var question in Questions) {
                string answer = question.QuizAnswers();
                answers[question] = answer;
            }
            return answers;
        }
    }

    public class QuizFileExporter{ //Turns the questions and answers of the user into a text file that then can be shared to us
        public void ExportAnswers(string fileName, Dictionary<Question, string> answers) {
            //Gets the directory of the game
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Defines the file Path within the same directory
            string filePath = Path.Combine(desktopPath, fileName);

            using(var writer = new StreamWriter(filePath)) {
                writer.WriteLine("Quiz Results:");
                foreach(var entry in answers) {
                    writer.WriteLine($"{entry.Key.Prompt}: {AnswerFormat(entry.Value)}");
                }
            }
        }
        private string AnswerFormat(string answer) {
            return answer switch{
                "1" => "Strongly Disagree",
                "2" => "Disagree",
                "3" => "Neutral",
                "4" => "Agree",
                "5" => "Strongly Agree",
                 _  => "Unknown"
            };
        }
    }