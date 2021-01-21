using System;
using Xamarin.Forms;

namespace SkiaSharpExamples
{
    public abstract class ContentPageBase : ContentPage
    {
        public ContentPageBase ()
        {
            Build();
        }

        protected abstract void Build ();
    }
}
