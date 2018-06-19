using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace DrawerLayoutSample
{
    [Activity(Label = "Messages")]
    public class Messages : Activity
    {
        Button buttonMessages;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Messages);

            buttonMessages = FindViewById<Button>(Resource.Id.ButtonMessages);
            buttonMessages.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs args)
        {
            MyNotification.GetInstance.SendMyNotification(Application.Context, "Message Notification", "Esta é uma notificação advinda da Message Activity");
            Finish();
        }
    }
}