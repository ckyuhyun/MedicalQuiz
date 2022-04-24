using MedicalQuiz.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MedicalQuiz.Data
{
    public class QuizContents
    {
        private static List<QuizModel> QuizData =  new List<QuizModel>();
        public string Quiz
        {
            get
            {
                return GetQuizContents();
            }
        }

        public QuizContents()
        {
            if (!QuizData.Any())
            {
                QuizData.Add(AddImageOnlyQuizContent("ref1.PNG", "ref2.PNG", 0));
                QuizData.Add(AddAudioOnlyQuizContent("heartbeat-01a.mp3"));
            }
        }

        public int GetQuizCount()
        {
            return QuizData.Count();
        }

        public string GetQuizContents()
        {
            return JsonConvert.SerializeObject(QuizData);
        }

        private QuizModel AddImageOnlyQuizContent(string srcImage1FileName, string srcImage2FileName, int answerIndex)
        {
            return new QuizModel
            {
                QuizId = GetQuizId(),
                Type = QuizType.ImageOnly,
                SampleImageInfo =  new ImageInfo
                {
                    ImageSample1FileName    = $"img/{srcImage1FileName}",
                    ImageSample2FileName    = $"img/{srcImage2FileName}",
                    AnswerImageIndex        = answerIndex
                }
            };
        }

        private QuizModel AddAudioOnlyQuizContent(string srcAudioFileName)
        {
            return new QuizModel
            {
                QuizId = GetQuizId(),
                Type = QuizType.AudioOnly,
                SampleAudioInfo = new AudioInfo
                {
                    AudioFileFile = $"../audio/{srcAudioFileName}"
                }
            };
        }
        private int GetQuizId()
        {
            return QuizData.Count();
        }


    }
}
