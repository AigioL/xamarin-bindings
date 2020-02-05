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
using AndroidX.AppCompat.App;
using Binding;

namespace TestApp.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class SmartRefreshActivity : AppCompatActivity
    {
        internal activity_smart_refresh Binding { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_smart_refresh);
            Binding = new activity_smart_refresh(this);
            var tag = Binding.refreshLayout.Tag?.ToString();
            Binding.textView.Text = $"SmartRefreshLayout.Tag: {tag}" + System.Environment.NewLine + Binding.textView.Text;
        }
    }
}