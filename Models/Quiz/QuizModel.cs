using MedicalQuiz.Data;

namespace MedicalQuiz.Models
{
    public class QuizModel
    {
        public int QuizId { get; set; }
        public QuizType Type { get; set; }
        public Images SampleImageInfo {get; set;}
        public AudioInfo SampleAudioInfo {get; set;}
        public TestResultType Result { get; set; }
    }

    public class Images
    {
        public ImageInfo ImageSample1 { get; set; }
        public ImageInfo ImageSample2 { get; set; }
        public int AnswerImageIndex { get; set; }
    }

    public class ImageInfo
    {
        public string FileName { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
    }

    public class AudioInfo
    {
        public string AudioFileFile { get; set; }
    }
}
