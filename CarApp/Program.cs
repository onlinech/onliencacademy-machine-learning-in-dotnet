using System;
using System.Diagnostics;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Transforms;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // createPipeline

            // prepareTrainingDataForPipeline

            // selectAlgorithmForPipeline

            // convertLabelFromVectorBackToOriginalText

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // trainModelForPipeline

            // prepareInputModel

            stopwatch.Stop();
            var timeSpan = stopwatch.Elapsed;
            var elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
                timeSpan.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            // writePrediction
        }
    }
}
