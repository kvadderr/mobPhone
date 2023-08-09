using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Views;
using MobPhone;
using MobPhone.Custom;
using MobPhone.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomMenuButton), typeof(TouchableFrameRenderer))]
namespace MobPhone.Droid
{
    class TouchableFrameRenderer: ViewRenderer
    {
        public TouchableFrameRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            var touchableRelativeLayout = e.NewElement as CustomMenuButton;

            var thisView = this;
            thisView.Touch += (object sender, TouchEventArgs args) =>
            {
                if (args.Event.Action == MotionEventActions.Down)
                {
                    touchableRelativeLayout.OnPressed();
                }

                else if (args.Event.Action == MotionEventActions.Up || args.Event.Action == MotionEventActions.Move)
                {
                    touchableRelativeLayout.OnReleased();
                }
            };
        }
    }
}