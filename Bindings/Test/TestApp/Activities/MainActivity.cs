using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using Java.Interop;
using Binding;
using TestApp.Utils;
using SEnvironment = System.Environment;
using Android.Widget;

namespace TestApp.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public sealed class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        internal activity_main Binding { get; private set; }

        public static MainActivity Instance { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Binding = new activity_main(this);
            Instance = this;
            SetSupportActionBar(Binding.toolbar);
            Binding.tvDependencies.Text = string.Join(SEnvironment.NewLine, Dependencies.Values);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public void OnClick(View view)
        {
            if (view is TextView textView)
            {
                ActivityUtil.StartActivity(this, textView.Text);
            }
        }
    }
}

