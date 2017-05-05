using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTime
{
    internal class MultipleChoiceQuestion : Question
    {
        private string[] choices;
        private int correctChoiceIndex;

        private int userResponse;
        public string UserResponse
        {
            get { return choices[userResponse]; }
        }

        public MultipleChoiceQuestion(string prompt, string[] choices, int correctChoiceIndex) : base(prompt)
        {
            this.choices = choices;
            this.correctChoiceIndex = correctChoiceIndex;
        }

        protected override void CollectResponse()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine(i + " - " + choices[i]);
            }
            
            string response = Console.ReadLine();
            int responseIdx = int.Parse(response);

            while (responseIdx >= choices.Length || responseIdx < 0)
            {
                Console.WriteLine("Invalid choices. Try again.");
                response = Console.ReadLine();
                responseIdx = int.Parse(response);
            }

            userResponse = responseIdx;

        }

        protected override bool IsCorrect()
        {
            return userResponse == correctChoiceIndex;
        }
    }
}
