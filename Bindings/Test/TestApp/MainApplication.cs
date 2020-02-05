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

namespace TestApp
{
    [Application]
    public sealed class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
        : base(handle, transer)
        {
        }

        public static MainApplication Instance { get; private set; }

        public override void OnCreate()
        {
            base.OnCreate();
            if (Instance == null) Instance = this;
        }
    }
}