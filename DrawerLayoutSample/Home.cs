using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace DrawerLayoutSample
{
    [Activity(Label = "Home")]
    public class Home : Activity
    {
        Button buttonHome;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            buttonHome = FindViewById<Button>(Resource.Id.ButtonHome);
            buttonHome.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs args)
        {
            MyNotification.GetInstance.SendMyNotification(Application.Context, "Home Notification", "Esta é uma notificação advinda da Home Activity");
            Finish();
        }
    }
}