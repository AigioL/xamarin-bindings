using Android.Flexbox;
using Com.Facebook.Shimmer;
using Com.Scwang.Smartrefresh.Header;
using Com.Scwang.Smartrefresh.Layout;
using TinyPinyin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestApp.Utils
{
    public static class Dependencies
    {
        static readonly Lazy<string[]> _Values = new Lazy<string[]>(() => ReadAssemblyVersion(new[]
        {
            typeof(ShimmerFrameLayout).Assembly,
            typeof(FlexboxLayout).Assembly,
            typeof(SmartRefreshLayout).Assembly,
            typeof(BezierCircleHeader).Assembly,
            typeof(PinyinHelper).Assembly,
        }).ToArray());
        public static string[] Values => _Values.Value;

        static IEnumerable<string> ReadAssemblyVersion(IEnumerable<Assembly> assemblies)
        {
            foreach (var item in assemblies)
            {
                var value = item.GetCustomAttributes<AssemblyFileVersionAttribute>()
                    .FirstOrDefault()?.Version;
                if (value != null) yield return $"{item.GetName().Name}: {value}";
            }
        }
    }
}