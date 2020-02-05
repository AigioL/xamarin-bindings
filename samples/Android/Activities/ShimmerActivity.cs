using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Binding;
using Com.Facebook.Shimmer;

namespace TestApp.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class ShimmerActivity : AppCompatActivity, View.IOnClickListener
    {
        internal activity_shimmer Binding { get; private set; }

        Toast toast;
        Button[] presetButtons;
        int currentPreset = -1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_shimmer);
            Binding = new activity_shimmer(this);
            presetButtons = new[] {
                Binding.preset_button0,
                Binding.preset_button1,
                Binding.preset_button2,
                Binding.preset_button3,
                Binding.preset_button4,
                Binding.preset_button5
            };
            Array.ForEach(presetButtons, btn => btn.SetOnClickListener(this));
        }

        public void OnClick(View view)
        {
            SelectPreset(Array.IndexOf(presetButtons, view.JavaCast<Button>()), true);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Binding.shimmer_view_container.StartShimmer();
        }

        protected override void OnPause()
        {
            Binding.shimmer_view_container.StopShimmer();
            base.OnPause();
        }

        void SelectPreset(int preset, bool showToast)
        {
            if (currentPreset == preset) return;

            if (currentPreset >= 0) presetButtons[currentPreset].SetBackgroundResource(Resource.Color.preset_button_background);
            currentPreset = preset;
            presetButtons[currentPreset].SetBackgroundResource(Resource.Color.preset_button_background_selected);

            // If a toast is already showing, hide it
            toast?.Cancel();

            var shimmerBuilder = new Shimmer.AlphaHighlightBuilder();
            switch (preset)
            {
                case 1:
                    // Slow and reverse
                    toast = Toast.MakeText(this, "Slow and reverse", ToastLength.Short);
                    shimmerBuilder.SetDuration(5000L);
                    shimmerBuilder.SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse);
                    break;
                case 2:
                    // Thin, straight and transparent
                    toast = Toast.MakeText(this, "Thin, straight and transparent", ToastLength.Short);
                    shimmerBuilder.SetBaseAlpha(0.1f);
                    shimmerBuilder.SetDropoff(0.1f);
                    shimmerBuilder.SetTilt(0f);
                    break;
                case 3:
                    // Sweep angle 90
                    toast = Toast.MakeText(this, "Sweep angle 90", ToastLength.Short);
                    shimmerBuilder.SetDuration(Shimmer.Direction.TopToBottom);
                    shimmerBuilder.SetTilt(0f);
                    break;
                case 4:
                    // Spotlight
                    toast = Toast.MakeText(this, "Spotlight", ToastLength.Short);
                    shimmerBuilder.SetBaseAlpha(0f);
                    shimmerBuilder.SetDuration(2000L);
                    shimmerBuilder.SetDropoff(0.1f);
                    shimmerBuilder.SetIntensity(0.35f);
                    shimmerBuilder.SetShape(Shimmer.Shape.Radial);
                    break;
                case 5:
                    // Off
                    toast = Toast.MakeText(this, "Off", ToastLength.Short);
                    shimmerBuilder = null;
                    break;
                default:
                    toast = Toast.MakeText(this, "Default", ToastLength.Short);
                    break;
            }
            Binding.shimmer_view_container.SetShimmer(shimmerBuilder?.Build());

            // Show toast describing the chosen preset, if necessary
            if (showToast) toast?.Show();
        }
    }
}