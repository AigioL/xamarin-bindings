using System;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using Binding;
using TestApp.Utils;
using SEnvironment = System.Environment;
using Android.Widget;
using TinyPinyin;

#nullable enable

namespace TestApp.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public sealed class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        internal activity_main? Binding { get; private set; }

        static MainActivity? mInstance;
        public static MainActivity Instance => mInstance ?? throw new ArgumentNullException(nameof(mInstance));

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Binding = new activity_main(this);
            mInstance = this;
            SetSupportActionBar(Binding.toolbar);
            Binding.tvText.Text = string.Join(SEnvironment.NewLine, new[] {
                $"CLR Version: {SEnvironment.Version}",
                MonoVersion,
            }.Concat(Dependencies.Values).Where(x => !string.IsNullOrWhiteSpace(x)));
        }

        static string? MonoVersion
        {
            get
            {
                var value = Dependencies.MonoRuntimeVersion;
                if (string.IsNullOrWhiteSpace(value)) return null;
                return $"Mono Version: {value}";
            }
        }

        public override bool OnCreateOptionsMenu(IMenu? menu)
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

        public void OnClick(View? view)
        {
            if (view == null) return;
            if (view.Id == Resource.Id.btnTinyPinyin)
            {
                Toast.MakeText(this, $"{PinyinHelper.GetPinyin("适用于Java和Android的快速、低内存占用的汉字转拼音库。", string.Empty)}", ToastLength.Long)!.Show();
            }
            else if (view is TextView textView)
            {
                ActivityUtil.StartActivity(this, textView.Text);
            }
        }
    }
}

