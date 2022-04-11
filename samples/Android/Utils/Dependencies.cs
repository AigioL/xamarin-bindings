using Android.Flexbox;
using Com.Facebook.Shimmer;
using Com.Scwang.Smartrefresh.Header;
using Com.Scwang.Smartrefresh.Layout;
using TinyPinyin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#nullable enable

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
                if (value != null) yield return $"{item.GetName().Name.TrimStart("XAB.")}: {value}";
            }
        }

        public static string? MonoRuntimeVersion
        {
            get
            {
#if NET6_0_OR_GREATER
                var typeRuntime = Type.GetType("Mono.Runtime");
                if (typeRuntime != null)
                {
                    var method = typeRuntime.GetMethod("GetDisplayName", BindingFlags.Static | BindingFlags.Public);
                    if (method != null && method.ReturnType == typeof(string))
                    {
                        return (string)method.Invoke(null, null);
                    }
                }
                return null;
#else
                return global::Mono.Runtime.GetDisplayName();
#endif
            }
        }
    }
}