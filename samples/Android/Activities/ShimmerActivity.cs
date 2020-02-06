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
    /// <summary>
    /// https://github.com/facebook/shimmer-android/blob/0.5.0/sample/src/main/java/com/facebook/shimmer/sample/MainActivity.kt
    /// </summary>
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

            (var _toast, var shimmerBuilder) = preset switch
            {
                1 => (
                    // Slow and reverse
                    Toast.MakeText(this, "Slow and reverse", ToastLength.Short),
                    new Shimmer.AlphaHighlightBuilder().SetDuration(5000L).SetRepeatMode(ValueAnimatorRepeatMode.Reverse)
                    ),
                2 => (
                    // Thin, straight and transparent
                    Toast.MakeText(this, "Thin, straight and transparent", ToastLength.Short),
                    new Shimmer.AlphaHighlightBuilder().SetBaseAlpha(0.1f).SetDropoff(0.1f).SetTilt(0f)
                    ),
                3 => (
                    // Sweep angle 90
                    Toast.MakeText(this, "Sweep angle 90", ToastLength.Short),
                    new Shimmer.AlphaHighlightBuilder().SetDirection(Shimmer.Direction.TOP_TO_BOTTOM).SetTilt(0f)
                    ),
                4 => (
                    // Spotlight
                    Toast.MakeText(this, "Spotlight", ToastLength.Short),
                    new Shimmer.AlphaHighlightBuilder().SetBaseAlpha(0f)
                            .SetDuration(2000L)
                            .SetDropoff(0.1f)
                            .SetIntensity(0.35f)
                            .SetShape(Shimmer.Shape.RADIA)
                    ),
                5 => (
                    // Off
                    Toast.MakeText(this, "Off", ToastLength.Short),
                    null
                    ),
                _ => (
                    Toast.MakeText(this, "Default", ToastLength.Short),
                    new Shimmer.AlphaHighlightBuilder()
                    ),
            };
            toast = _toast;
            Binding.shimmer_view_container.SetShimmer(shimmerBuilder?.Build());

            // Show toast describing the chosen preset, if necessary
            if (showToast) toast?.Show();
        }
    }
}