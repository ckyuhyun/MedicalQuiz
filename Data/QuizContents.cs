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
                QuizData.Add(AddImageComparisonQuizContent("ref1.PNG", "ref2.PNG", 0));
                QuizData.Add(AddAudioOnlyQuizContent("heartbeat-01a.mp3"));
                QuizData.Add(AddImagePositionPickQuizContent("ref1_ref.PNG", 452,261, 548,380));
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

        private QuizModel AddImageComparisonQuizContent(string srcImage1FileName, string srcImage2FileName, int answerIndex)
        {
            return new QuizModel
            {
                QuizId = GetQuizId(),
                Type = QuizType.ImageComparison,
                SampleImageInfo =  new Images
                {
                    ImageSample1        = GetImageInfo($"img/{srcImage1FileName}"),
                    ImageSample2        = GetImageInfo($"img/{srcImage2FileName}"),
                    AnswerImageIndex    = answerIndex
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

        private QuizModel AddImagePositionPickQuizContent(string srcImage1FileName, int startX, int startY, int endX, int endY)
        {
            return new QuizModel
            {
                QuizId = GetQuizId(),
                Type = QuizType.ImagePosSelection,
                SampleImageInfo = new Images
                {
                    ImageSample1 = GetImageInfo($"img/{srcImage1FileName}", startX, startY, endX, endY)
                }
            };
        }

        private ImageInfo GetImageInfo(string fileName, int startX = 0, int startY = 0, int endX = 0, int endY = 0)
        {
            return new ImageInfo
            {
                FileName = fileName,
                StartX = startX,
                StartY = startY,
                EndX = endX,
                EndY = endY
            };
        }

        private int GetQuizId()
        {
            return QuizData.Count();
        }


    }
}
