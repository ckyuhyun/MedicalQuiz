using MedicalQuiz.Data;
using MedicalQuiz.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MedicalQuiz.Services
{
    public class QuizHelper : IQuizHelper
    {   
        int IQuizHelper.GetQuizCount()
        {
            return new QuizContents().GetQuizCount();
        }
        QuizModel IQuizHelper.GetQuiz(int index)
        {
            var quizConents = new QuizContents().Quiz;
            return JsonConvert.DeserializeObject<List<QuizModel>>(quizConents).ElementAt(index) as QuizModel;
        }

    }
}
