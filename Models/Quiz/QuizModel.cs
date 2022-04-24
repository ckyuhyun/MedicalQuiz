using MedicalQuiz.Data;

namespace MedicalQuiz.Models
{
    public class QuizModel
    {
        public int QuizId { get; set; }
        public QuizType Type { get; set; }
        public ImageInfo SampleImageInfo {get; set;}
        public AudioInfo SampleAudioInfo {get; set;}
        public TestResultType Result { get; set; }
    }

    public class ImageInfo
    {
        public string ImageSample1FileName { get; set; }
        public string ImageSample2FileName { get; set; }
        public int AnswerImageIndex { get; set; }
    }

    public class AudioInfo
    {
        public string AudioFileFile { get; set; }
    }
}
