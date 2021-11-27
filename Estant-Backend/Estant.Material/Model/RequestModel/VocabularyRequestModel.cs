using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.RequestModel
{
    public class PronunciationAssessmentRequest
    {
        public string audio_base64 { get; set; }
        public string audio_format { get; set; }
        public string text { get; set; }
    }
}
