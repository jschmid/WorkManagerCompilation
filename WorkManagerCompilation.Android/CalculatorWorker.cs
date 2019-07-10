using System;
using Android.Content;
using AndroidX.Work;

namespace WorkManagerCompilation.Droid
{
    public class CalculatorWorker : Worker
    {
        public CalculatorWorker(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {

        }
        public override Result DoWork()
        {
            var taxReturn = CalculateTaxes();
            Android.Util.Log.Debug("CalculatorWorker", $"Your Tax Return is: {taxReturn}");
            return Result.InvokeSuccess();
        }

        public double CalculateTaxes()
        {
            return 2000;
        }
    }
}
