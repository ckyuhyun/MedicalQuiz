using MedicalQuiz.Models;

namespace MedicalQuiz.Services
{
    public interface IQuizHelper
    {
        int GetQuizCount();
        QuizModel GetQuiz(int index);
    }
}
