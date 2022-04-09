using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

// ReSharper disable once CheckNamespace
namespace Com.Scwang.Smartrefresh.Layout
{
    partial class SmartRefreshLayout
    {
        [Register(".ctor", "(Landroid/content/Context;)V", "")]
        public unsafe SmartRefreshLayout(Context context)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "(Landroid/content/Context;)V";

            if (Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
            }

            FixEgg();
        }

        [Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
        public unsafe SmartRefreshLayout(Context context, Android.Util.IAttributeSet attrs)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

            if (Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
                __args[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
            }

            FixEgg();
        }

        protected SmartRefreshLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            FixEgg();
        }

        static readonly Java.Lang.Object tagObj = new Java.Lang.String("close egg");

        /// <summary>
        /// https://github.com/scwang90/SmartRefreshLayout/blob/androidx/refresh-layout/src/main/java/com/scwang/smartrefresh/layout/SmartRefreshLayout.java#L1673
        /// </summary>
        void FixEgg()
        {
            if (Tag == null)
            {
                base.Tag = tagObj;
            }
        }

        public override Java.Lang.Object Tag
        {
            set
            {
                if (value == null) value = tagObj; // no eggs
                base.Tag = value;
            }
        }
    }
}