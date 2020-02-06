using Android.Animation;
using Android.Views;
using AndroidX.Annotations;

#pragma warning disable CS1591

namespace Com.Facebook.Shimmer
{
    /// <summary>
    /// A Shimmer is an object detailing all of the configuration options available for <see cref="ShimmerFrameLayout"/>
    /// </summary>
    partial class Shimmer
    {
        public interface IBuilder<T> where T : Builder, IBuilder<T>
        {
        }

        partial class AlphaHighlightBuilder : IBuilder<AlphaHighlightBuilder>
        {
        }

        partial class ColorHighlightBuilder : IBuilder<ColorHighlightBuilder>
        {
        }

        /// <summary>
        /// Direction of the shimmer's sweep.
        /// </summary>
        public enum Direction
        {
            BOTTOM_TO_TOP = _DirectionConsts.BottomToTop,
            BottomToTop = _DirectionConsts.BottomToTop,

            LEFT_TO_RIGHT = _DirectionConsts.LeftToRight,
            LeftToRight = _DirectionConsts.LeftToRight,

            RIGHT_TO_LEFT = _DirectionConsts.RightToLeft,
            RightToLeft = _DirectionConsts.RightToLeft,

            TOP_TO_BOTTOM = _DirectionConsts.TopToBottom,
            TopToBottom = _DirectionConsts.TopToBottom,
        }

        /// <summary>
        /// The shape of the shimmer's highlight. By default <see cref="LINEAR"/> is used.
        /// </summary>
        public enum Shape
        {
            LINEAR = _ShapeConsts.Linear,
            Linear = _ShapeConsts.Linear,

            RADIA = _ShapeConsts.Radial,
            Radial = _ShapeConsts.Radial,
        }
    }

    /// <summary>
    /// Shimmer is an Android library that provides an easy way to add a shimmer effect to any <see cref="View"/>.
    /// It is useful as an unobtrusive loading indicator, and was originally developed for Facebook Home.
    /// <para>Find more examples and usage instructions over at: facebook.github.io/shimmer-android</para>
    /// </summary>
    partial class ShimmerFrameLayout { }

    public static class ShimmerExtensions
    {
        /// <summary>
        /// Sets the direction of the shimmer's sweep. See <see cref="Shimmer.Direction"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static T SetDirection<T>(this T builder, int direction) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetDirection(direction);
            return builder;
        }

        /// <summary>
        /// Sets the direction of the shimmer's sweep. See <see cref="Shimmer.Direction"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static T SetDirection<T>(this T builder, Shimmer.Direction direction) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetDirection((int)direction);
            return builder;
        }

        /// <summary>
        /// Sets the shape of the shimmer. See <see cref="Shimmer.Shape"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static T SetShape<T>(this T builder, int shape) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetShape(shape);
            return builder;
        }

        /// <summary>
        /// Sets the shape of the shimmer. See <see cref="Shimmer.Shape"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static T SetShape<T>(this T builder, Shimmer.Shape shape) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetShape((int)shape);
            return builder;
        }

        /// <summary>
        /// Sets the fixed width of the shimmer, in pixels.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="fixedWidthPX"></param>
        /// <returns></returns>
        public static T SetFixedWidth<T>(this T builder, [Px] int fixedWidthPX) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetFixedWidth(fixedWidthPX);
            return builder;
        }

        /// <summary>
        /// Sets the fixed height of the shimmer, in pixels.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="fixedHeightPX"></param>
        /// <returns></returns>
        public static T SetFixedHeight<T>(this T builder, [Px] int fixedHeightPX) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetFixedHeight(fixedHeightPX);
            return builder;
        }

        /// <summary>
        /// Sets the width ratio of the shimmer, multiplied against the total width of the layout.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="widthRatio"></param>
        /// <returns></returns>
        public static T SetWidthRatio<T>(this T builder, float widthRatio) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetWidthRatio(widthRatio);
            return builder;
        }

        /// <summary>
        /// Sets the height ratio of the shimmer, multiplied against the total height of the layout.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="heightRatio"></param>
        /// <returns></returns>
        public static T SetHeightRatio<T>(this T builder, float heightRatio) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetHeightRatio(heightRatio);
            return builder;
        }

        /// <summary>
        /// Sets the intensity of the shimmer. A larger value causes the shimmer to be larger.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="intensity"></param>
        /// <returns></returns>
        public static T SetIntensity<T>(this T builder, float intensity) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetIntensity(intensity);
            return builder;
        }

        /// <summary>
        /// Sets how quickly the shimmer's gradient drops-off. A larger value causes a sharper drop-off.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="dropoff"></param>
        /// <returns></returns>
        public static T SetDropoff<T>(this T builder, float dropoff) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetDropoff(dropoff);
            return builder;
        }

        /// <summary>
        /// Sets the tilt angle of the shimmer in degrees.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="tilt"></param>
        /// <returns></returns>
        public static T SetTilt<T>(this T builder, float tilt) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetTilt(tilt);
            return builder;
        }

        /// <summary>
        /// Sets the base alpha, which is the alpha of the underlying children, amount in the range [0,1].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static T SetBaseAlpha<T>(this T builder, [FloatRange(From = 0.0d, To = 1.0d)]float alpha) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetBaseAlpha(alpha);
            return builder;
        }

        /// <summary>
        /// Sets the shimmer alpha amount in the range [0, 1].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static T SetHighlightAlpha<T>(this T builder, [FloatRange(From = 0.0d, To = 1.0d)]float alpha) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetHighlightAlpha(alpha);
            return builder;
        }

        /// <summary>
        /// Sets whether the shimmer will clip to the childrens' contents, or if it will opaquely draw on top of the children.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static T SetClipToChildren<T>(this T builder, bool status) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetClipToChildren(status);
            return builder;
        }

        /// <summary>
        /// Sets whether the shimmering animation will start automatically.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static T SetAutoStart<T>(this T builder, bool status) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetAutoStart(status);
            return builder;
        }

        /// <summary>
        /// Sets how often the shimmering animation will repeat. See <see cref="ValueAnimator.RepeatCount"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="repeatCount"></param>
        /// <returns></returns>
        public static T SetRepeatCount<T>(this T builder, int repeatCount) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetRepeatCount(repeatCount);
            return builder;
        }

        /// <summary>
        /// Sets how the shimmering animation will repeat. See <see cref="ValueAnimator.RepeatMode"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static T SetRepeatMode<T>(this T builder, int mode) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetRepeatMode(mode);
            return builder;
        }

        /// <summary>
        /// Sets how the shimmering animation will repeat. See <see cref="ValueAnimator.RepeatMode"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static T SetRepeatMode<T>(this T builder, ValueAnimatorRepeatMode mode) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetRepeatMode((int)mode);
            return builder;
        }

        /// <summary>
        /// Sets how long to wait in between repeats of the shimmering animation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="millis"></param>
        /// <returns></returns>
        public static T SetRepeatDelay<T>(this T builder, long millis) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetRepeatDelay(millis);
            return builder;
        }

        /// <summary>
        /// Sets how long the shimmering animation takes to do one full sweep.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="millis"></param>
        /// <returns></returns>
        public static T SetDuration<T>(this T builder, long millis) where T : Shimmer.Builder, Shimmer.IBuilder<T>
        {
            builder.SetDuration(millis);
            return builder;
        }
    }
}

#pragma warning restore CS1591