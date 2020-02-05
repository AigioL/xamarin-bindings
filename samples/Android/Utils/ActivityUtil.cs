using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TestApp.Utils
{
    public static class ActivityUtil
    {
        const string NameSpace = nameof(TestApp) + "." + nameof(Activities);

        const string Activity = "Activity";

        static readonly Type ActivityType = typeof(Activity);

        static ActivityUtil()
        {
            Values = GetActivityType(Assembly.GetExecutingAssembly().GetTypes()).ToArray();
        }

        public static Type[] Values { get; }

        static IEnumerable<Type> GetActivityType(IEnumerable<Type> types)
        {
            foreach (var item in types)
            {
                if (item.Name.EndsWith(Activity) && ActivityType.IsAssignableFrom(item))
                {
                    yield return item;
                }
            }
        }

        public static bool StartActivity(Context context, string activityName)
        {
            var activityType = Values.FirstOrDefault(x => x.Name.Equals(activityName + Activity, StringComparison.OrdinalIgnoreCase));
            if (activityType != null)
            {
                context.StartActivity(new Intent(context, activityType));
                return true;
            }
            return false;
        }
    }
}