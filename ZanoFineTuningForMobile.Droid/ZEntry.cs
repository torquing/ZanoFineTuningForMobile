using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ZanoFineTuningForMobile;
using ZanoFineTuningForMobile.Droid;

[assembly: ExportRenderer(typeof(ZEntry), typeof(ZEntryRenderer))]
namespace ZanoFineTuningForMobile.Droid
{
    class ZEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                //Control.
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}