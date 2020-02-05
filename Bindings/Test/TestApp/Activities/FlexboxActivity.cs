using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Flexbox;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Binding;

namespace TestApp.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class FlexboxActivity : AppCompatActivity
    {
        internal activity_flexbox Binding { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_flexbox);
            Binding = new activity_flexbox(this);
            Binding.flexbox_layout.FlexDirection = FlexDirection.Row;

            var view = Binding.flexbox_layout.GetChildAt(0);
            var lp = view.LayoutParameters.JavaCast<FlexboxLayout.LayoutParams>();
            lp.Order = -1;
            lp.FlexGrow = 2;
            view.LayoutParameters = lp;
        }
    }
}