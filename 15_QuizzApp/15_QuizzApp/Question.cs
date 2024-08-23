﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_QuizzApp
{
    internal class Question
    {
        // PROPERTIES
        public string QuestionText { get; set; }
        public string[] Answers {  get; set; }
        public int CorrectAnswerIndex { get; set; }

        // CONSTRUCTORS
        public Question(string questionText, string[] answers, int correctAnswerIndex) 
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;

        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }

    }
}
