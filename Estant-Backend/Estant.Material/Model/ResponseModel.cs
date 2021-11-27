using Estant.Material.Model.EnumModel;
using System;
using System.Collections.Generic;
using System.Text;
using Estant.Material.Utilities;

namespace Estant.Material.Model
{
    public class ResponseModel<T>
    {
        /// <summary>
        /// 0 => Success
        /// </summary>
        public int code { get; set; }

        public T data { get; set; }

        public string message { get; set; }

        public void SetResponseError(ResponseError responseError)
        {
            if (this != null)
            {
                if (responseError.HasError())
                {
                    this.code = (int)responseError;
                    this.message = responseError.ToDescription();
                }
            }
        }
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
