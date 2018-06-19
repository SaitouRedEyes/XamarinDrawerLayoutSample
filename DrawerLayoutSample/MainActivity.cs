using Android.App;
using Android.Views;
using Android.OS;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Widget;

namespace DrawerLayoutSample
{
    [Activity(Label = "DrawerLayoutSample", Theme = "@style/Theme.DesignDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity 
    {
        Android.Support.V4.Widget.DrawerLayout drawerLayout;
        Android.Support.Design.Widget.NavigationView navigationView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);

            drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawer_layout);
            navigationView = FindViewById<Android.Support.Design.Widget.NavigationView>(Resource.Id.nav_view);

            navigationView.NavigationItemSelected += NavigationViewItemSelected;
        }

        private void NavigationViewItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch(e.MenuItem.ToString())
            {
                case "Home": StartActivity(typeof(Home)); break;
                case "Messages": StartActivity(typeof(Messages)); break;
                case "About": StartActivity(typeof(About)); break;
                case "FeedBack": StartActivity(typeof(Feedback)); break;
            }

            drawerLayout.CloseDrawers();
            Finish();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}