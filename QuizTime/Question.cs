using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTime
{
    internal abstract class Question
    {
        protected string Prompt { get; set; }

        public Question(string prompt)
        {
            Prompt = prompt;
        }

        protected abstract bool IsCorrect();

        protected abstract void CollectResponse();
    }
}
