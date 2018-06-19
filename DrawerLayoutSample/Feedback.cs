using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace DrawerLayoutSample
{
    [Activity(Label = "Feedback")]
    public class Feedback : Activity
    {
        Button buttonFeedback;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Feedback);

            buttonFeedback = FindViewById<Button>(Resource.Id.ButtonFeedback);
            buttonFeedback.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs args)
        {
            MyNotification.GetInstance.SendMyNotification(Application.Context, "Feedback Notification", "Esta é uma notificação advinda da Feedback Activity");
            Finish();
        }
    }
}