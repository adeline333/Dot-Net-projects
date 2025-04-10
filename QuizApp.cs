
class QuizProgram
{
    static void Main()
    {    

         //create questions
        string[] questions =
        {
            "what book holds the record for the fastest selling book in history",
            " How old was queen Elisabeth II when she wa first crowned the Quee of England",
             "Which bloodtype is a universal donor?"
        };

        //create Answers
        string[] answers =
        {
            "A.The hunger games \n B.Harry Potter \n C.kjhkhkljhkhkjh\n",
            "A.27 \n  B. 24 \n C. 31\n",
            "A. O negative\n B. B positive \n C. AB\n"
        };
//INDEX OF CORRECT ANSWERS
        int[] correctAnswers = {1, 1,0};
        int playerscore = 0;

        Console.WriteLine("Welcome to the best Quiz App ever");
            for(int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("Question " + (i+1));
            Console.Write(questions[i]);
            Console.WriteLine(answers[i]);
            Console.WriteLine("Please enter your answer ('A', 'B', or'C'): ");
            string playerAnswer = Console.ReadLine();

            //validating answer
            if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && (correctAnswers[i] == 0))
            {
                playerscore++;
            }
            else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && (correctAnswers[i] == 1))
            {
                playerscore++;
            }
            else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && (correctAnswers[i] == 2))
            {
                playerscore++;
            }
        }

        //print out the score to the user

        Console.WriteLine("Quiz Completed!");
        Console.WriteLine("Your score is " + playerscore +"/"+ questions.Length);




  
    }
    }