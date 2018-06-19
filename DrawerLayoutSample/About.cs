using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace DrawerLayoutSample
{
    [Activity(Label = "About")]
    public class About : Activity
    {
        Button buttonAbout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.About);

            buttonAbout = FindViewById<Button>(Resource.Id.ButtonAbout);
            buttonAbout.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs args)
        {
            MyNotification.GetInstance.SendMyNotification(Application.Context, "About Notification", "Esta é uma notificação advinda da About Activity");
            Finish();
        }
    }
}