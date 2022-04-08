using MedicalQuiz.Data;

namespace MedicalQuiz.Models
{
    public class QuizModel
    {
        public int QuizId { get; set; }
        public string Name { get; set; }
        public TestResultType Result { get; set; }
    }
}
