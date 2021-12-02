using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class Topic
    {
        public string title { get; set; }
        public string imageUrl { get; set; }
    }

    public class Vocabulary
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<Meaning> meanings { get; set; }

        public class Meaning
        {
            public string partOfSpeech { get; set; }
            public List<Definition> definitions { get; set; }

            public class Definition
            {
                public string definition { get; set; }
                public string example { get; set; }
                public List<string> synonyms { get; set; }
                public List<string> antonyms { get; set; }
            }
        }
    }

    public class PronunciationAssessmentRequest
    {
        public string audio_base64 { get; set; }
        public string audio_format { get; set; }
        public string text { get; set; }
    }


    public class PronunciationAssessmentResponse
    {
        public int score { get; set; }
        public AccentPredictions accent_predictions { get; set; }
        public ScoreEstimate score_estimates { get; set; }

        public class AccentPredictions
        {
            public int en_US { get; set; }
            public int en_UK { get; set; }
            public int en_AU { get; set; }
        }
        public class ScoreEstimate
        {
            public string ielts { get; set; }
            public string toefl { get; set; }
            public string cefr { get; set; }
            public string pte_general { get; set; }
        }
    }
}
