using System;
using Microsoft.ML.Runtime.Api;

namespace CarApp
{
    // Result from prediction operation
    public class AcceptabilityPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel;
    }
}
