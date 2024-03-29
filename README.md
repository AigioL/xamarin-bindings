# xamarin-bindings

Xamarin.Android and ~~Xamarin.iOS~~ binding

## Android Libraries

- **[CircleImageView](https://github.com/hdodenhof/CircleImageView)** 
[![NuGet version (de.hdodenhof.circleimageview)](https://img.shields.io/nuget/v/de.hdodenhof.circleimageview.svg)](https://www.nuget.org/packages/de.hdodenhof.circleimageview/)
[![Maven Central](https://img.shields.io/maven-central/v/de.hdodenhof/circleimageview)](https://search.maven.org/artifact/de.hdodenhof/circleimageview)
    - A fast circular ImageView perfect for profile images. This is based on RoundedImageView from Vince Mi which itself is based on techniques recommended by Romain Guy.
- **[Facebook.Shimmer](https://github.com/facebook/shimmer-android)** 
[![NuGet version (XAB.Facebook.Shimmer)](https://img.shields.io/nuget/v/XAB.Facebook.Shimmer.svg)](https://www.nuget.org/packages/XAB.Facebook.Shimmer/)
[![Maven Central](https://img.shields.io/maven-central/v/com.facebook.shimmer/shimmer)](https://search.maven.org/artifact/com.facebook.shimmer/shimmer)
    - Shimmer is an Android library that provides an easy way to add a shimmer effect to any view in your Android app.
- **[Google.Flexbox](https://github.com/google/flexbox-layout)** 
[![NuGet version (XAB.FlexboxLayout)](https://img.shields.io/nuget/v/XAB.FlexboxLayout.svg)](https://www.nuget.org/packages/XAB.FlexboxLayout/)
[![Release Version](https://img.shields.io/github/v/release/google/flexbox-layout?style=flat-square)](https://github.com/google/flexbox-layout/releases/latest)
    - FlexboxLayout is a library project which brings the similar capabilities of CSS Flexible Box Layout Module to Android.
    - package -> namespace:`com.google.android.flexbox` -> `Android.Flexbox`
- **[SmartRefresh](https://github.com/scwang90/SmartRefreshLayout)**
    - **SmartRefresh.Layout** 
    [![NuGet version (SmartRefresh.Layout)](https://img.shields.io/nuget/v/SmartRefresh.Layout.svg)](https://www.nuget.org/packages/SmartRefresh.Layout/)
    - **SmartRefresh.Header** 
    [![NuGet version (SmartRefresh.Header)](https://img.shields.io/nuget/v/SmartRefresh.Header.svg)](https://www.nuget.org/packages/SmartRefresh.Header/)
    - SmartRefreshLayout's goal is to build a strong, stable and mature pull-down refresh layout framework, and to integrate all kinds of cool, diverse, practical and beautiful Headers and Footers.
- **[FloatingActionButtonSpeedDial](https://github.com/leinardi/FloatingActionButtonSpeedDial)**
[![NuGet version (XAB.FloatingActionButtonSpeedDial)](https://img.shields.io/nuget/v/XAB.FloatingActionButtonSpeedDial.svg)](https://www.nuget.org/packages/XAB.FloatingActionButtonSpeedDial/)
[![Maven Central](https://img.shields.io/maven-central/v/com.leinardi.android/speed-dial)](https://search.maven.org/artifact/com.leinardi.android/speed-dial)
    - Android library providing an implementation of the [Material Design Floating Action Button Speed Dial](https://material.io/guidelines/components/buttons-floating-action-button.html#buttons-floating-action-button-transitions).
- **[Aho-Corasick](https://github.com/robert-bor/aho-corasick)** 
[![NuGet version (XAB.Aho-Corasick)](https://img.shields.io/nuget/v/XAB.Aho-Corasick.svg)](https://www.nuget.org/packages/XAB.Aho-Corasick/)
[![Maven Central](https://img.shields.io/maven-central/v/org.ahocorasick/ahocorasick)](https://search.maven.org/artifact/org.ahocorasick/ahocorasick)
    - Aho CoraSick Algorithm For Efficient String Matching
- **[TinyPinyin](https://github.com/AigioL/TinyPinyin)** 
[![NuGet version (XAB.TinyPinyin)](https://img.shields.io/nuget/v/XAB.TinyPinyin.svg)](https://www.nuget.org/packages/XAB.TinyPinyin/)
[![Maven Central](https://img.shields.io/maven-central/v/io.github.biezhi/TinyPinyin)](https://search.maven.org/artifact/io.github.biezhi/TinyPinyin)
    - Fast, low memory footprint Chinese character to Pinyin library for Android
<!--## iOS Libraries-->

## Publish samples\TestApp.Net6
```dotnet publish "samples\Android.Net6\TestApp.Net6.csproj" -f:net6.0-android -c:Release```
