using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace DrawerLayoutSample
{
    class MyNotification
    {
        private static MyNotification myNotification;

        private MyNotification() {}

        public static MyNotification GetInstance
        {
            get
            {
                if (myNotification == null)
                    myNotification = new MyNotification();

                return myNotification;
            }
        }

        public void SendMyNotification(Context c, String title, String text)
        {
            Intent i = new Intent(c, typeof(MainActivity));

            const int pendingIntentID = 0;

            PendingIntent pi = PendingIntent.GetActivity(c, pendingIntentID, i, PendingIntentFlags.OneShot);

            Notification.Builder builder = new Notification.Builder(c)
                .SetContentIntent(pi)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetSmallIcon(Resource.Drawable.ic_notification);
                //.SetLargeIcon(BitmapFactory.DecodeResource(c.Resources, Resource.Drawable.ic_notification));

            Notification notification = builder.Build();
            notification.Flags = NotificationFlags.AutoCancel;

            NotificationManager nm = c.GetSystemService(Context.NotificationService) as NotificationManager;

            const int notificationID = 0;

            nm.Notify(notificationID, notification);
        }
    }
}