using System;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Markup;
using SkiaSharp.Views.Forms;

namespace SkiaSharpExamples
{
    public class LinearProgressPageCode : ContentPageBase
    {
        LinearProgress _progress1;

        SKCanvasView _canvas;

        protected override void Build ()
        {
            Content =
               new StackLayout
               {
                   Children =
                   {
                        new LinearProgress
                        {
                            StartingPoint = 0,
                            EndingPoint = 100,
                            ProgressColor = Color.Fuchsia,
                        }
                            .TapGesture(x => x.Tapped += (s, e) => UpdateDraw())
                            .Assign(out _progress1),
                        new SKCanvasView
                        {

                        }
                            .Assign(out _canvas),
                   }
               };
        }

        private void UpdateDraw ()
        {
            var rngesus = new Random(Guid.NewGuid().GetHashCode());

            _progress1.StartingPoint = _progress1.EndingPoint = rngesus.Next(0, 100);
            var endingAt1 = rngesus.Next((int)_progress1.StartingPoint + 1, 100);
            _progress1.Animate(nameof(_progress1), x => _progress1.EndingPoint = (float)x, 0, endingAt1, 4, 500, Easing.CubicInOut);

                //Progress2.StartingPoint = Progress2.EndingPoint = rngesus.Next(0, 100);
                //var endingAt2 = rngesus.Next((int)Progress2.StartingPoint + 1, 100);
                //Progress3.Animate(nameof(Progress2), x => Progress2.EndingPoint = (float)x, 0, endingAt2, 4, 500, Easing.SpringOut);

                //Progress3.StartingPoint = Progress3.EndingPoint = rngesus.Next(0, 100);
                //var endingAt3 = rngesus.Next((int)Progress3.StartingPoint + 1, 100);
                //Progress3.Animate(nameof(Progress3), x => Progress3.EndingPoint = (float)x, 0, endingAt3, 4, 500, Easing.BounceOut);
        }
    }
}
