using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestApp.Utils
{
    [Obsolete]
    public static class Dependencies
    {
        static Dependencies()
        {
            Values = ReadAssemblyMetadata(AppDomain.CurrentDomain.GetAssemblies()).ToArray();
        }

        public static string[] Values { get; }

        static IEnumerable<string> ReadAssemblyMetadata(IEnumerable<Assembly> assemblies)
        {
            foreach (var item in assemblies)
            {
                var value = item.GetCustomAttributes<AssemblyMetadataAttribute>()
                    .FirstOrDefault(x => x.Key == "build.gradle.dependencies")?.Value;
                if (value != null) yield return value;
            }
        }
    }
}