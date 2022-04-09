using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

// ReSharper disable once CheckNamespace
namespace Com.Scwang.Smartrefresh.Layout
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']"
    [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout", DoNotGenerateAcw = true)]
    public partial class SmartRefreshLayout : global::Android.Views.ViewGroup, global::AndroidX.Core.View.INestedScrollingParent, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout
    {



        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='animationRunnable']"
        [Register("animationRunnable")]
        protected global::Java.Lang.IRunnable AnimationRunnable
        {
            get
            {
                const string __id = "animationRunnable.Ljava/lang/Runnable;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "animationRunnable.Ljava/lang/Runnable;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mAttachedToWindow']"
        [Register("mAttachedToWindow")]
        protected bool MAttachedToWindow
        {
            get
            {
                const string __id = "mAttachedToWindow.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mAttachedToWindow.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mCurrentVelocity']"
        [Register("mCurrentVelocity")]
        protected int MCurrentVelocity
        {
            get
            {
                const string __id = "mCurrentVelocity.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mCurrentVelocity.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDisableContentWhenLoading']"
        [Register("mDisableContentWhenLoading")]
        protected bool MDisableContentWhenLoading
        {
            get
            {
                const string __id = "mDisableContentWhenLoading.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mDisableContentWhenLoading.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDisableContentWhenRefresh']"
        [Register("mDisableContentWhenRefresh")]
        protected bool MDisableContentWhenRefresh
        {
            get
            {
                const string __id = "mDisableContentWhenRefresh.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mDisableContentWhenRefresh.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDragDirection']"
        [Register("mDragDirection")]
        protected char MDragDirection
        {
            get
            {
                const string __id = "mDragDirection.C";

                var __v = _members.InstanceFields.GetCharValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mDragDirection.C";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDragRate']"
        [Register("mDragRate")]
        protected float MDragRate
        {
            get
            {
                const string __id = "mDragRate.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mDragRate.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableAutoLoadMore']"
        [Register("mEnableAutoLoadMore")]
        protected bool MEnableAutoLoadMore
        {
            get
            {
                const string __id = "mEnableAutoLoadMore.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableAutoLoadMore.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableClipFooterWhenFixedBehind']"
        [Register("mEnableClipFooterWhenFixedBehind")]
        protected bool MEnableClipFooterWhenFixedBehind
        {
            get
            {
                const string __id = "mEnableClipFooterWhenFixedBehind.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableClipFooterWhenFixedBehind.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableClipHeaderWhenFixedBehind']"
        [Register("mEnableClipHeaderWhenFixedBehind")]
        protected bool MEnableClipHeaderWhenFixedBehind
        {
            get
            {
                const string __id = "mEnableClipHeaderWhenFixedBehind.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableClipHeaderWhenFixedBehind.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableFooterFollowWhenNoMoreData']"
        [Register("mEnableFooterFollowWhenNoMoreData")]
        protected bool MEnableFooterFollowWhenNoMoreData
        {
            get
            {
                const string __id = "mEnableFooterFollowWhenNoMoreData.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableFooterFollowWhenNoMoreData.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableFooterTranslationContent']"
        [Register("mEnableFooterTranslationContent")]
        protected bool MEnableFooterTranslationContent
        {
            get
            {
                const string __id = "mEnableFooterTranslationContent.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableFooterTranslationContent.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableHeaderTranslationContent']"
        [Register("mEnableHeaderTranslationContent")]
        protected bool MEnableHeaderTranslationContent
        {
            get
            {
                const string __id = "mEnableHeaderTranslationContent.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableHeaderTranslationContent.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableLoadMore']"
        [Register("mEnableLoadMore")]
        protected bool MEnableLoadMore
        {
            get
            {
                const string __id = "mEnableLoadMore.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableLoadMore.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableLoadMoreWhenContentNotFull']"
        [Register("mEnableLoadMoreWhenContentNotFull")]
        protected bool MEnableLoadMoreWhenContentNotFull
        {
            get
            {
                const string __id = "mEnableLoadMoreWhenContentNotFull.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableLoadMoreWhenContentNotFull.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableNestedScrolling']"
        [Register("mEnableNestedScrolling")]
        protected bool MEnableNestedScrolling
        {
            get
            {
                const string __id = "mEnableNestedScrolling.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableNestedScrolling.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableOverScrollBounce']"
        [Register("mEnableOverScrollBounce")]
        protected bool MEnableOverScrollBounce
        {
            get
            {
                const string __id = "mEnableOverScrollBounce.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableOverScrollBounce.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableOverScrollDrag']"
        [Register("mEnableOverScrollDrag")]
        protected bool MEnableOverScrollDrag
        {
            get
            {
                const string __id = "mEnableOverScrollDrag.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableOverScrollDrag.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnablePreviewInEditMode']"
        [Register("mEnablePreviewInEditMode")]
        protected bool MEnablePreviewInEditMode
        {
            get
            {
                const string __id = "mEnablePreviewInEditMode.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnablePreviewInEditMode.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnablePureScrollMode']"
        [Register("mEnablePureScrollMode")]
        protected bool MEnablePureScrollMode
        {
            get
            {
                const string __id = "mEnablePureScrollMode.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnablePureScrollMode.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableRefresh']"
        [Register("mEnableRefresh")]
        protected bool MEnableRefresh
        {
            get
            {
                const string __id = "mEnableRefresh.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableRefresh.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableScrollContentWhenLoaded']"
        [Register("mEnableScrollContentWhenLoaded")]
        protected bool MEnableScrollContentWhenLoaded
        {
            get
            {
                const string __id = "mEnableScrollContentWhenLoaded.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableScrollContentWhenLoaded.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableScrollContentWhenRefreshed']"
        [Register("mEnableScrollContentWhenRefreshed")]
        protected bool MEnableScrollContentWhenRefreshed
        {
            get
            {
                const string __id = "mEnableScrollContentWhenRefreshed.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mEnableScrollContentWhenRefreshed.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFalsifyEvent']"
        [Register("mFalsifyEvent")]
        protected global::Android.Views.MotionEvent MFalsifyEvent
        {
            get
            {
                const string __id = "mFalsifyEvent.Landroid/view/MotionEvent;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mFalsifyEvent.Landroid/view/MotionEvent;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedFooterViewId']"
        [Register("mFixedFooterViewId")]
        protected int MFixedFooterViewId
        {
            get
            {
                const string __id = "mFixedFooterViewId.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFixedFooterViewId.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedHeaderViewId']"
        [Register("mFixedHeaderViewId")]
        protected int MFixedHeaderViewId
        {
            get
            {
                const string __id = "mFixedHeaderViewId.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFixedHeaderViewId.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFloorDuration']"
        [Register("mFloorDuration")]
        protected int MFloorDuration
        {
            get
            {
                const string __id = "mFloorDuration.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFloorDuration.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterBackgroundColor']"
        [Register("mFooterBackgroundColor")]
        protected int MFooterBackgroundColor
        {
            get
            {
                const string __id = "mFooterBackgroundColor.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterBackgroundColor.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterHeight']"
        [Register("mFooterHeight")]
        protected int MFooterHeight
        {
            get
            {
                const string __id = "mFooterHeight.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterHeight.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterHeightStatus']"
        [Register("mFooterHeightStatus")]
        protected global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus MFooterHeightStatus
        {
            get
            {
                const string __id = "mFooterHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mFooterHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterInsetStart']"
        [Register("mFooterInsetStart")]
        protected int MFooterInsetStart
        {
            get
            {
                const string __id = "mFooterInsetStart.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterInsetStart.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterLocked']"
        [Register("mFooterLocked")]
        protected bool MFooterLocked
        {
            get
            {
                const string __id = "mFooterLocked.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterLocked.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterMaxDragRate']"
        [Register("mFooterMaxDragRate")]
        protected float MFooterMaxDragRate
        {
            get
            {
                const string __id = "mFooterMaxDragRate.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterMaxDragRate.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterNeedTouchEventWhenLoading']"
        [Register("mFooterNeedTouchEventWhenLoading")]
        protected bool MFooterNeedTouchEventWhenLoading
        {
            get
            {
                const string __id = "mFooterNeedTouchEventWhenLoading.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterNeedTouchEventWhenLoading.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterNoMoreData']"
        [Register("mFooterNoMoreData")]
        protected bool MFooterNoMoreData
        {
            get
            {
                const string __id = "mFooterNoMoreData.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterNoMoreData.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterNoMoreDataEffective']"
        [Register("mFooterNoMoreDataEffective")]
        protected bool MFooterNoMoreDataEffective
        {
            get
            {
                const string __id = "mFooterNoMoreDataEffective.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterNoMoreDataEffective.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterTranslationViewId']"
        [Register("mFooterTranslationViewId")]
        protected int MFooterTranslationViewId
        {
            get
            {
                const string __id = "mFooterTranslationViewId.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterTranslationViewId.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterTriggerRate']"
        [Register("mFooterTriggerRate")]
        protected float MFooterTriggerRate
        {
            get
            {
                const string __id = "mFooterTriggerRate.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mFooterTriggerRate.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHandler']"
        [Register("mHandler")]
        protected global::Android.OS.Handler MHandler
        {
            get
            {
                const string __id = "mHandler.Landroid/os/Handler;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.OS.Handler>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mHandler.Landroid/os/Handler;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderBackgroundColor']"
        [Register("mHeaderBackgroundColor")]
        protected int MHeaderBackgroundColor
        {
            get
            {
                const string __id = "mHeaderBackgroundColor.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderBackgroundColor.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderHeight']"
        [Register("mHeaderHeight")]
        protected int MHeaderHeight
        {
            get
            {
                const string __id = "mHeaderHeight.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderHeight.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderHeightStatus']"
        [Register("mHeaderHeightStatus")]
        protected global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus MHeaderHeightStatus
        {
            get
            {
                const string __id = "mHeaderHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mHeaderHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderInsetStart']"
        [Register("mHeaderInsetStart")]
        protected int MHeaderInsetStart
        {
            get
            {
                const string __id = "mHeaderInsetStart.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderInsetStart.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderMaxDragRate']"
        [Register("mHeaderMaxDragRate")]
        protected float MHeaderMaxDragRate
        {
            get
            {
                const string __id = "mHeaderMaxDragRate.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderMaxDragRate.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderNeedTouchEventWhenRefreshing']"
        [Register("mHeaderNeedTouchEventWhenRefreshing")]
        protected bool MHeaderNeedTouchEventWhenRefreshing
        {
            get
            {
                const string __id = "mHeaderNeedTouchEventWhenRefreshing.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderNeedTouchEventWhenRefreshing.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderTranslationViewId']"
        [Register("mHeaderTranslationViewId")]
        protected int MHeaderTranslationViewId
        {
            get
            {
                const string __id = "mHeaderTranslationViewId.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderTranslationViewId.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderTriggerRate']"
        [Register("mHeaderTriggerRate")]
        protected float MHeaderTriggerRate
        {
            get
            {
                const string __id = "mHeaderTriggerRate.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mHeaderTriggerRate.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mIsBeingDragged']"
        [Register("mIsBeingDragged")]
        protected bool MIsBeingDragged
        {
            get
            {
                const string __id = "mIsBeingDragged.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mIsBeingDragged.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mKernel']"
        [Register("mKernel")]
        protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MKernel
        {
            get
            {
                const string __id = "mKernel.Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mKernel.Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastOpenTime']"
        [Register("mLastOpenTime")]
        protected long MLastOpenTime
        {
            get
            {
                const string __id = "mLastOpenTime.J";

                var __v = _members.InstanceFields.GetInt64Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mLastOpenTime.J";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastSpinner']"
        [Register("mLastSpinner")]
        protected int MLastSpinner
        {
            get
            {
                const string __id = "mLastSpinner.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mLastSpinner.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastTouchX']"
        [Register("mLastTouchX")]
        protected float MLastTouchX
        {
            get
            {
                const string __id = "mLastTouchX.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mLastTouchX.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastTouchY']"
        [Register("mLastTouchY")]
        protected float MLastTouchY
        {
            get
            {
                const string __id = "mLastTouchY.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mLastTouchY.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLoadMoreListener']"
        [Register("mLoadMoreListener")]
        protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener MLoadMoreListener
        {
            get
            {
                const string __id = "mLoadMoreListener.Lcom/scwang/smartrefresh/layout/listener/OnLoadMoreListener;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mLoadMoreListener.Lcom/scwang/smartrefresh/layout/listener/OnLoadMoreListener;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mManualFooterTranslationContent']"
        [Register("mManualFooterTranslationContent")]
        protected bool MManualFooterTranslationContent
        {
            get
            {
                const string __id = "mManualFooterTranslationContent.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mManualFooterTranslationContent.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mManualHeaderTranslationContent']"
        [Register("mManualHeaderTranslationContent")]
        protected bool MManualHeaderTranslationContent
        {
            get
            {
                const string __id = "mManualHeaderTranslationContent.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mManualHeaderTranslationContent.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mManualLoadMore']"
        [Register("mManualLoadMore")]
        protected bool MManualLoadMore
        {
            get
            {
                const string __id = "mManualLoadMore.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mManualLoadMore.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mMaximumVelocity']"
        [Register("mMaximumVelocity")]
        protected int MMaximumVelocity
        {
            get
            {
                const string __id = "mMaximumVelocity.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mMaximumVelocity.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mMinimumVelocity']"
        [Register("mMinimumVelocity")]
        protected int MMinimumVelocity
        {
            get
            {
                const string __id = "mMinimumVelocity.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mMinimumVelocity.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedChild']"
        [Register("mNestedChild")]
        protected global::AndroidX.Core.View.NestedScrollingChildHelper MNestedChild
        {
            get
            {
                const string __id = "mNestedChild.Landroidx/core/view/NestedScrollingChildHelper;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.NestedScrollingChildHelper>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mNestedChild.Landroidx/core/view/NestedScrollingChildHelper;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedInProgress']"
        [Register("mNestedInProgress")]
        protected bool MNestedInProgress
        {
            get
            {
                const string __id = "mNestedInProgress.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mNestedInProgress.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedParent']"
        [Register("mNestedParent")]
        protected global::AndroidX.Core.View.NestedScrollingParentHelper MNestedParent
        {
            get
            {
                const string __id = "mNestedParent.Landroidx/core/view/NestedScrollingParentHelper;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.NestedScrollingParentHelper>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mNestedParent.Landroidx/core/view/NestedScrollingParentHelper;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mOnMultiPurposeListener']"
        [Register("mOnMultiPurposeListener")]
        protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener MOnMultiPurposeListener
        {
            get
            {
                const string __id = "mOnMultiPurposeListener.Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mOnMultiPurposeListener.Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mPaint']"
        [Register("mPaint")]
        protected global::Android.Graphics.Paint MPaint
        {
            get
            {
                const string __id = "mPaint.Landroid/graphics/Paint;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mPaint.Landroid/graphics/Paint;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mParentOffsetInWindow']"
        [Register("mParentOffsetInWindow")]
        protected IList<int> MParentOffsetInWindow
        {
            get
            {
                const string __id = "mParentOffsetInWindow.[I";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Android.Runtime.JavaArray<int>.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mParentOffsetInWindow.[I";

                IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mPrimaryColors']"
        [Register("mPrimaryColors")]
        protected IList<int> MPrimaryColors
        {
            get
            {
                const string __id = "mPrimaryColors.[I";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Android.Runtime.JavaArray<int>.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mPrimaryColors.[I";

                IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mReboundDuration']"
        [Register("mReboundDuration")]
        protected int MReboundDuration
        {
            get
            {
                const string __id = "mReboundDuration.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mReboundDuration.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mReboundInterpolator']"
        [Register("mReboundInterpolator")]
        protected global::Android.Views.Animations.IInterpolator MReboundInterpolator
        {
            get
            {
                const string __id = "mReboundInterpolator.Landroid/view/animation/Interpolator;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mReboundInterpolator.Landroid/view/animation/Interpolator;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshContent']"
        [Register("mRefreshContent")]
        protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent MRefreshContent
        {
            get
            {
                const string __id = "mRefreshContent.Lcom/scwang/smartrefresh/layout/api/RefreshContent;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mRefreshContent.Lcom/scwang/smartrefresh/layout/api/RefreshContent;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshFooter']"
        [Register("mRefreshFooter")]
        protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal MRefreshFooter
        {
            get
            {
                const string __id = "mRefreshFooter.Lcom/scwang/smartrefresh/layout/api/RefreshInternal;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mRefreshFooter.Lcom/scwang/smartrefresh/layout/api/RefreshInternal;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshHeader']"
        [Register("mRefreshHeader")]
        protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal MRefreshHeader
        {
            get
            {
                const string __id = "mRefreshHeader.Lcom/scwang/smartrefresh/layout/api/RefreshInternal;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mRefreshHeader.Lcom/scwang/smartrefresh/layout/api/RefreshInternal;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshListener']"
        [Register("mRefreshListener")]
        protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener MRefreshListener
        {
            get
            {
                const string __id = "mRefreshListener.Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mRefreshListener.Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mScreenHeightPixels']"
        [Register("mScreenHeightPixels")]
        protected int MScreenHeightPixels
        {
            get
            {
                const string __id = "mScreenHeightPixels.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mScreenHeightPixels.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mScrollBoundaryDecider']"
        [Register("mScrollBoundaryDecider")]
        protected global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider MScrollBoundaryDecider
        {
            get
            {
                const string __id = "mScrollBoundaryDecider.Lcom/scwang/smartrefresh/layout/api/ScrollBoundaryDecider;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mScrollBoundaryDecider.Lcom/scwang/smartrefresh/layout/api/ScrollBoundaryDecider;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mScroller']"
        [Register("mScroller")]
        protected global::Android.Widget.Scroller MScroller
        {
            get
            {
                const string __id = "mScroller.Landroid/widget/Scroller;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mScroller.Landroid/widget/Scroller;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mSpinner']"
        [Register("mSpinner")]
        protected int MSpinner
        {
            get
            {
                const string __id = "mSpinner.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mSpinner.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mState']"
        [Register("mState")]
        protected global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState MState
        {
            get
            {
                const string __id = "mState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mSuperDispatchTouchEvent']"
        [Register("mSuperDispatchTouchEvent")]
        protected bool MSuperDispatchTouchEvent
        {
            get
            {
                const string __id = "mSuperDispatchTouchEvent.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mSuperDispatchTouchEvent.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTotalUnconsumed']"
        [Register("mTotalUnconsumed")]
        protected int MTotalUnconsumed
        {
            get
            {
                const string __id = "mTotalUnconsumed.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mTotalUnconsumed.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchSlop']"
        [Register("mTouchSlop")]
        protected int MTouchSlop
        {
            get
            {
                const string __id = "mTouchSlop.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mTouchSlop.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchSpinner']"
        [Register("mTouchSpinner")]
        protected int MTouchSpinner
        {
            get
            {
                const string __id = "mTouchSpinner.I";

                var __v = _members.InstanceFields.GetInt32Value(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mTouchSpinner.I";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchX']"
        [Register("mTouchX")]
        protected float MTouchX
        {
            get
            {
                const string __id = "mTouchX.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mTouchX.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchY']"
        [Register("mTouchY")]
        protected float MTouchY
        {
            get
            {
                const string __id = "mTouchY.F";

                var __v = _members.InstanceFields.GetSingleValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mTouchY.F";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mVelocityTracker']"
        [Register("mVelocityTracker")]
        protected global::Android.Views.VelocityTracker MVelocityTracker
        {
            get
            {
                const string __id = "mVelocityTracker.Landroid/view/VelocityTracker;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Views.VelocityTracker>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mVelocityTracker.Landroid/view/VelocityTracker;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mVerticalPermit']"
        [Register("mVerticalPermit")]
        protected bool MVerticalPermit
        {
            get
            {
                const string __id = "mVerticalPermit.Z";

                var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                return __v;
            }
            set
            {
                const string __id = "mVerticalPermit.Z";

                try
                {
                    _members.InstanceFields.SetValue(__id, this, value);
                }
                finally
                {
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mViceState']"
        [Register("mViceState")]
        protected global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState MViceState
        {
            get
            {
                const string __id = "mViceState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "mViceState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='reboundAnimator']"
        [Register("reboundAnimator")]
        protected global::Android.Animation.ValueAnimator ReboundAnimator
        {
            get
            {
                const string __id = "reboundAnimator.Landroid/animation/ValueAnimator;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "reboundAnimator.Landroid/animation/ValueAnimator;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='sDefaultMarginLP']"
        [Register("sDefaultMarginLP")]
        protected static global::Android.Views.ViewGroup.MarginLayoutParams SDefaultMarginLP
        {
            get
            {
                const string __id = "sDefaultMarginLP.Landroid/view/ViewGroup$MarginLayoutParams;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.MarginLayoutParams>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "sDefaultMarginLP.Landroid/view/ViewGroup$MarginLayoutParams;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.StaticFields.SetValue(__id, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='sFooterCreator']"
        [Register("sFooterCreator")]
        protected static global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreator SFooterCreator
        {
            get
            {
                const string __id = "sFooterCreator.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreator;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreator>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "sFooterCreator.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreator;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.StaticFields.SetValue(__id, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='sHeaderCreator']"
        [Register("sHeaderCreator")]
        protected static global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreator SHeaderCreator
        {
            get
            {
                const string __id = "sHeaderCreator.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreator;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreator>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "sHeaderCreator.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreator;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.StaticFields.SetValue(__id, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='sRefreshInitializer']"
        [Register("sRefreshInitializer")]
        protected static global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshInitializer SRefreshInitializer
        {
            get
            {
                const string __id = "sRefreshInitializer.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshInitializer;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshInitializer>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "sRefreshInitializer.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshInitializer;";

                IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                try
                {
                    _members.StaticFields.SetValue(__id, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }
        // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.10']"
        [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout$10", DoNotGenerateAcw = true)]
        public partial class _10 : global::Java.Lang.Object
        {

            internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout$10", typeof(_10));
            internal static new IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected _10(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        }

        // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.BounceRunnable']"
        [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout$BounceRunnable", DoNotGenerateAcw = true)]
        protected internal partial class BounceRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable
        {

            internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout$BounceRunnable", typeof(BounceRunnable));
            internal static new IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected BounceRunnable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static Delegate cb_run;
#pragma warning disable 0169
            static Delegate GetRunHandler()
            {
                if (cb_run == null)
                    cb_run = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_Run);
                return cb_run;
            }

            static void n_Run(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.BounceRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.BounceRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.Run();
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.BounceRunnable']/method[@name='run' and count(parameter)=0]"
            [Register("run", "()V", "GetRunHandler")]
            public virtual unsafe void Run()
            {
                const string __id = "run.()V";
                try
                {
                    _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
                }
                finally
                {
                }
            }

        }

        // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.FlingRunnable']"
        [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout$FlingRunnable", DoNotGenerateAcw = true)]
        protected internal partial class FlingRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable
        {

            internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout$FlingRunnable", typeof(FlingRunnable));
            internal static new IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected FlingRunnable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static Delegate cb_run;
#pragma warning disable 0169
            static Delegate GetRunHandler()
            {
                if (cb_run == null)
                    cb_run = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_Run);
                return cb_run;
            }

            static void n_Run(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.FlingRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.FlingRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.Run();
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.FlingRunnable']/method[@name='run' and count(parameter)=0]"
            [Register("run", "()V", "GetRunHandler")]
            public virtual unsafe void Run()
            {
                const string __id = "run.()V";
                try
                {
                    _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
                }
                finally
                {
                }
            }

            static Delegate cb_start;
#pragma warning disable 0169
            static Delegate GetStartHandler()
            {
                if (cb_start == null)
                    cb_start = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_Start);
                return cb_start;
            }

            static IntPtr n_Start(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.FlingRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.FlingRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.Start());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.FlingRunnable']/method[@name='start' and count(parameter)=0]"
            [Register("start", "()Ljava/lang/Runnable;", "GetStartHandler")]
            public virtual unsafe global::Java.Lang.IRunnable Start()
            {
                const string __id = "start.()Ljava/lang/Runnable;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

        }

        // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']"
        [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout$LayoutParams", DoNotGenerateAcw = true)]
        public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
        {



            // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/field[@name='backgroundColor']"
            [Register("backgroundColor")]
            public int BackgroundColor
            {
                get
                {
                    const string __id = "backgroundColor.I";

                    var __v = _members.InstanceFields.GetInt32Value(__id, this);
                    return __v;
                }
                set
                {
                    const string __id = "backgroundColor.I";

                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, value);
                    }
                    finally
                    {
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/field[@name='spinnerStyle']"
            [Register("spinnerStyle")]
            public global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle SpinnerStyle
            {
                get
                {
                    const string __id = "spinnerStyle.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle>(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "spinnerStyle.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

                    IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }
            internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout$LayoutParams", typeof(LayoutParams));
            internal static new IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
            [Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
            public unsafe LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                    __args[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object)attrs).Handle);
                    var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                    SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                    _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
                }
                finally
                {
                }
            }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
            [Register(".ctor", "(II)V", "")]
            public unsafe LayoutParams(int width, int height)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                const string __id = "(II)V";

                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue(width);
                    __args[1] = new JniArgumentValue(height);
                    var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                    SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                    _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
                }
                finally
                {
                }
            }

        }

        // Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']"
        [global::Android.Runtime.Register("com/scwang/smartrefresh/layout/SmartRefreshLayout$RefreshKernelImpl", DoNotGenerateAcw = true)]
        public partial class RefreshKernelImpl : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel
        {

            internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout$RefreshKernelImpl", typeof(RefreshKernelImpl));
            internal static new IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected RefreshKernelImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/constructor[@name='SmartRefreshLayout.RefreshKernelImpl' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.SmartRefreshLayout']]"
            [Register(".ctor", "(Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;)V", "")]
            public unsafe RefreshKernelImpl(global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __self)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName(GetType().DeclaringType) + ";)V";

                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object)__self).Handle);
                    var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                    SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                    _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
                }
                finally
                {
                }
            }

            static Delegate cb_getRefreshContent;
#pragma warning disable 0169
            static Delegate GetGetRefreshContentHandler()
            {
                if (cb_getRefreshContent == null)
                    cb_getRefreshContent = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetRefreshContent);
                return cb_getRefreshContent;
            }

            static IntPtr n_GetRefreshContent(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.RefreshContent);
            }
#pragma warning restore 0169

            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent RefreshContent
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='getRefreshContent' and count(parameter)=0]"
                [Register("getRefreshContent", "()Lcom/scwang/smartrefresh/layout/api/RefreshContent;", "GetGetRefreshContentHandler")]
                get
                {
                    const string __id = "getRefreshContent.()Lcom/scwang/smartrefresh/layout/api/RefreshContent;";
                    try
                    {
                        var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                        return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                    }
                    finally
                    {
                    }
                }
            }

            static Delegate cb_getRefreshLayout;
#pragma warning disable 0169
            static Delegate GetGetRefreshLayoutHandler()
            {
                if (cb_getRefreshLayout == null)
                    cb_getRefreshLayout = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetRefreshLayout);
                return cb_getRefreshLayout;
            }

            static IntPtr n_GetRefreshLayout(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.RefreshLayout);
            }
#pragma warning restore 0169

            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout RefreshLayout
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='getRefreshLayout' and count(parameter)=0]"
                [Register("getRefreshLayout", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetGetRefreshLayoutHandler")]
                get
                {
                    const string __id = "getRefreshLayout.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
                    try
                    {
                        var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                        return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                    }
                    finally
                    {
                    }
                }
            }

            static Delegate cb_animSpinner_I;
#pragma warning disable 0169
            static Delegate GetAnimSpinner_IHandler()
            {
                if (cb_animSpinner_I == null)
                    cb_animSpinner_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_AnimSpinner_I);
                return cb_animSpinner_I;
            }

            static IntPtr n_AnimSpinner_I(IntPtr jnienv, IntPtr native__this, int endSpinner)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.AnimSpinner(endSpinner));
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='animSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("animSpinner", "(I)Landroid/animation/ValueAnimator;", "GetAnimSpinner_IHandler")]
            public virtual unsafe global::Android.Animation.ValueAnimator AnimSpinner(int endSpinner)
            {
                const string __id = "animSpinner.(I)Landroid/animation/ValueAnimator;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(endSpinner);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_finishTwoLevel;
#pragma warning disable 0169
            static Delegate GetFinishTwoLevelHandler()
            {
                if (cb_finishTwoLevel == null)
                    cb_finishTwoLevel = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_FinishTwoLevel);
                return cb_finishTwoLevel;
            }

            static IntPtr n_FinishTwoLevel(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.FinishTwoLevel());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='finishTwoLevel' and count(parameter)=0]"
            [Register("finishTwoLevel", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetFinishTwoLevelHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel FinishTwoLevel()
            {
                const string __id = "finishTwoLevel.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_moveSpinner_IZ;
#pragma warning disable 0169
            static Delegate GetMoveSpinner_IZHandler()
            {
                if (cb_moveSpinner_IZ == null)
                    cb_moveSpinner_IZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool, IntPtr>)n_MoveSpinner_IZ);
                return cb_moveSpinner_IZ;
            }

            static IntPtr n_MoveSpinner_IZ(IntPtr jnienv, IntPtr native__this, int spinner, bool isDragging)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.MoveSpinner(spinner, isDragging));
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='moveSpinner' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
            [Register("moveSpinner", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetMoveSpinner_IZHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinner(int spinner, bool isDragging)
            {
                const string __id = "moveSpinner.(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue(spinner);
                    __args[1] = new JniArgumentValue(isDragging);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_requestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z;
#pragma warning disable 0169
            static Delegate GetRequestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ZHandler()
            {
                if (cb_requestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z == null)
                    cb_requestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>)n_RequestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z);
                return cb_requestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z;
            }

            static IntPtr n_RequestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z(IntPtr jnienv, IntPtr native__this, IntPtr native__internal, bool translation)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(native__internal, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestDefaultTranslationContentFor(@internal, translation));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestDefaultTranslationContentFor' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshInternal'] and parameter[2][@type='boolean']]"
            [Register("requestDefaultTranslationContentFor", "(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDefaultTranslationContentFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ZHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDefaultTranslationContentFor(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal, bool translation)
            {
                const string __id = "requestDefaultTranslationContentFor.(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue((@internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@internal).Handle);
                    __args[1] = new JniArgumentValue(translation);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_requestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I;
#pragma warning disable 0169
            static Delegate GetRequestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_IHandler()
            {
                if (cb_requestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I == null)
                    cb_requestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>)n_RequestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I);
                return cb_requestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I;
            }

            static IntPtr n_RequestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_I(IntPtr jnienv, IntPtr native__this, IntPtr native__internal, int backgroundColor)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(native__internal, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestDrawBackgroundFor(@internal, backgroundColor));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestDrawBackgroundFor' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshInternal'] and parameter[2][@type='int']]"
            [Register("requestDrawBackgroundFor", "(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDrawBackgroundFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_IHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgroundFor(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal, int backgroundColor)
            {
                const string __id = "requestDrawBackgroundFor.(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue((@internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@internal).Handle);
                    __args[1] = new JniArgumentValue(backgroundColor);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_requestFloorDuration_I;
#pragma warning disable 0169
            static Delegate GetRequestFloorDuration_IHandler()
            {
                if (cb_requestFloorDuration_I == null)
                    cb_requestFloorDuration_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_RequestFloorDuration_I);
                return cb_requestFloorDuration_I;
            }

            static IntPtr n_RequestFloorDuration_I(IntPtr jnienv, IntPtr native__this, int duration)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.RequestFloorDuration(duration));
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestFloorDuration' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("requestFloorDuration", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestFloorDuration_IHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestFloorDuration(int duration)
            {
                const string __id = "requestFloorDuration.(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(duration);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_requestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z;
#pragma warning disable 0169
            static Delegate GetRequestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ZHandler()
            {
                if (cb_requestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z == null)
                    cb_requestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>)n_RequestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z);
                return cb_requestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z;
            }

            static IntPtr n_RequestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Z(IntPtr jnienv, IntPtr native__this, IntPtr native__internal, bool request)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(native__internal, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestNeedTouchEventFor(@internal, request));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestNeedTouchEventFor' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshInternal'] and parameter[2][@type='boolean']]"
            [Register("requestNeedTouchEventFor", "(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestNeedTouchEventFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ZHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestNeedTouchEventFor(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal, bool request)
            {
                const string __id = "requestNeedTouchEventFor.(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue((@internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@internal).Handle);
                    __args[1] = new JniArgumentValue(request);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_requestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_;
#pragma warning disable 0169
            static Delegate GetRequestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Handler()
            {
                if (cb_requestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ == null)
                    cb_requestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_RequestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_);
                return cb_requestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_;
            }

            static IntPtr n_RequestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_(IntPtr jnienv, IntPtr native__this, IntPtr native__internal)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(native__internal, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestRemeasureHeightFor(@internal));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestRemeasureHeightFor' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshInternal']]"
            [Register("requestRemeasureHeightFor", "(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestRemeasureHeightFor_Lcom_scwang_smartrefresh_layout_api_RefreshInternal_Handler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestRemeasureHeightFor(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal)
            {
                const string __id = "requestRemeasureHeightFor.(Lcom/scwang/smartrefresh/layout/api/RefreshInternal;)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((@internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@internal).Handle);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_setState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
            static Delegate GetSetState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler()
            {
                if (cb_setState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
                    cb_setState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
                return cb_setState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
            }

            static IntPtr n_SetState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(native_state, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetState(state));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
            [Register("setState", "(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetState(global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state)
            {
                const string __id = "setState.(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object)state).Handle);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            static Delegate cb_startTwoLevel_Z;
#pragma warning disable 0169
            static Delegate GetStartTwoLevel_ZHandler()
            {
                if (cb_startTwoLevel_Z == null)
                    cb_startTwoLevel_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_StartTwoLevel_Z);
                return cb_startTwoLevel_Z;
            }

            static IntPtr n_StartTwoLevel_Z(IntPtr jnienv, IntPtr native__this, bool open)
            {
                global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.StartTwoLevel(open));
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='startTwoLevel' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("startTwoLevel", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetStartTwoLevel_ZHandler")]
            public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel StartTwoLevel(bool open)
            {
                const string __id = "startTwoLevel.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(open);
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

        }

        internal static new readonly JniPeerMembers _members = new XAPeerMembers("com/scwang/smartrefresh/layout/SmartRefreshLayout", typeof(SmartRefreshLayout));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        //protected SmartRefreshLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

        //// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        //[Register (".ctor", "(Landroid/content/Context;)V", "")]
        //public unsafe SmartRefreshLayout (global::Android.Content.Context context)
        //	: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        //{
        //	const string __id = "(Landroid/content/Context;)V";

        //	if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
        //		return;

        //	try {
        //		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
        //		__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
        //		var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
        //		SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
        //		_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
        //	} finally {
        //	}
        //}

        //// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
        //[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
        //public unsafe SmartRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
        //	: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        //{
        //	const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

        //	if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
        //		return;

        //	try {
        //		JniArgumentValue* __args = stackalloc JniArgumentValue [2];
        //		__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
        //		__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
        //		var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
        //		SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
        //		_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
        //	} finally {
        //	}
        //}

        static Delegate cb_getLayout;
#pragma warning disable 0169
        static Delegate GetGetLayoutHandler()
        {
            if (cb_getLayout == null)
                cb_getLayout = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetLayout);
            return cb_getLayout;
        }

        static IntPtr n_GetLayout(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Layout);
        }
#pragma warning restore 0169

        public virtual unsafe global::Android.Views.ViewGroup Layout
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getLayout' and count(parameter)=0]"
            [Register("getLayout", "()Landroid/view/ViewGroup;", "GetGetLayoutHandler")]
            get
            {
                const string __id = "getLayout.()Landroid/view/ViewGroup;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getRefreshFooter;
#pragma warning disable 0169
        static Delegate GetGetRefreshFooterHandler()
        {
            if (cb_getRefreshFooter == null)
                cb_getRefreshFooter = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetRefreshFooter);
            return cb_getRefreshFooter;
        }

        static IntPtr n_GetRefreshFooter(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.RefreshFooter);
        }
#pragma warning restore 0169

        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter RefreshFooter
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getRefreshFooter' and count(parameter)=0]"
            [Register("getRefreshFooter", "()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;", "GetGetRefreshFooterHandler")]
            get
            {
                const string __id = "getRefreshFooter.()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getRefreshHeader;
#pragma warning disable 0169
        static Delegate GetGetRefreshHeaderHandler()
        {
            if (cb_getRefreshHeader == null)
                cb_getRefreshHeader = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetRefreshHeader);
            return cb_getRefreshHeader;
        }

        static IntPtr n_GetRefreshHeader(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.RefreshHeader);
        }
#pragma warning restore 0169

        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader RefreshHeader
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getRefreshHeader' and count(parameter)=0]"
            [Register("getRefreshHeader", "()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;", "GetGetRefreshHeaderHandler")]
            get
            {
                const string __id = "getRefreshHeader.()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getState;
#pragma warning disable 0169
        static Delegate GetGetStateHandler()
        {
            if (cb_getState == null)
                cb_getState = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetState);
            return cb_getState;
        }

        static IntPtr n_GetState(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.State);
        }
#pragma warning restore 0169

        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState State
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getState' and count(parameter)=0]"
            [Register("getState", "()Lcom/scwang/smartrefresh/layout/constant/RefreshState;", "GetGetStateHandler")]
            get
            {
                const string __id = "getState.()Lcom/scwang/smartrefresh/layout/constant/RefreshState;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_animSpinner_IILandroid_view_animation_Interpolator_I;
#pragma warning disable 0169
        static Delegate GetAnimSpinner_IILandroid_view_animation_Interpolator_IHandler()
        {
            if (cb_animSpinner_IILandroid_view_animation_Interpolator_I == null)
                cb_animSpinner_IILandroid_view_animation_Interpolator_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>)n_AnimSpinner_IILandroid_view_animation_Interpolator_I);
            return cb_animSpinner_IILandroid_view_animation_Interpolator_I;
        }

        static IntPtr n_AnimSpinner_IILandroid_view_animation_Interpolator_I(IntPtr jnienv, IntPtr native__this, int endSpinner, int startDelay, IntPtr native_interpolator, int duration)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.Animations.IInterpolator interpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.AnimSpinner(endSpinner, startDelay, interpolator, duration));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinner' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Interpolator'] and parameter[4][@type='int']]"
        [Register("animSpinner", "(IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator;", "GetAnimSpinner_IILandroid_view_animation_Interpolator_IHandler")]
        protected virtual unsafe global::Android.Animation.ValueAnimator AnimSpinner(int endSpinner, int startDelay, global::Android.Views.Animations.IInterpolator interpolator, int duration)
        {
            const string __id = "animSpinner.(IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(endSpinner);
                __args[1] = new JniArgumentValue(startDelay);
                __args[2] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object)interpolator).Handle);
                __args[3] = new JniArgumentValue(duration);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_animSpinnerBounce_F;
#pragma warning disable 0169
        static Delegate GetAnimSpinnerBounce_FHandler()
        {
            if (cb_animSpinnerBounce_F == null)
                cb_animSpinnerBounce_F = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, float>)n_AnimSpinnerBounce_F);
            return cb_animSpinnerBounce_F;
        }

        static void n_AnimSpinnerBounce_F(IntPtr jnienv, IntPtr native__this, float velocity)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.AnimSpinnerBounce(velocity);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinnerBounce' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("animSpinnerBounce", "(F)V", "GetAnimSpinnerBounce_FHandler")]
        protected virtual unsafe void AnimSpinnerBounce(float velocity)
        {
            const string __id = "animSpinnerBounce.(F)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(velocity);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_autoLoadMore;
#pragma warning disable 0169
        static Delegate GetAutoLoadMoreHandler()
        {
            if (cb_autoLoadMore == null)
                cb_autoLoadMore = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_AutoLoadMore);
            return cb_autoLoadMore;
        }

        static bool n_AutoLoadMore(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoLoadMore();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadMore' and count(parameter)=0]"
        [Register("autoLoadMore", "()Z", "GetAutoLoadMoreHandler")]
        public virtual unsafe bool AutoLoadMore()
        {
            const string __id = "autoLoadMore.()Z";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoLoadMore_IIFZ;
#pragma warning disable 0169
        static Delegate GetAutoLoadMore_IIFZHandler()
        {
            if (cb_autoLoadMore_IIFZ == null)
                cb_autoLoadMore_IIFZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, float, bool, bool>)n_AutoLoadMore_IIFZ);
            return cb_autoLoadMore_IIFZ;
        }

        static bool n_AutoLoadMore_IIFZ(IntPtr jnienv, IntPtr native__this, int delayed, int duration, float dragRate, bool animationOnly)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoLoadMore(delayed, duration, dragRate, animationOnly);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadMore' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
        [Register("autoLoadMore", "(IIFZ)Z", "GetAutoLoadMore_IIFZHandler")]
        public virtual unsafe bool AutoLoadMore(int delayed, int duration, float dragRate, bool animationOnly)
        {
            const string __id = "autoLoadMore.(IIFZ)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(delayed);
                __args[1] = new JniArgumentValue(duration);
                __args[2] = new JniArgumentValue(dragRate);
                __args[3] = new JniArgumentValue(animationOnly);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoLoadMoreAnimationOnly;
#pragma warning disable 0169
        static Delegate GetAutoLoadMoreAnimationOnlyHandler()
        {
            if (cb_autoLoadMoreAnimationOnly == null)
                cb_autoLoadMoreAnimationOnly = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_AutoLoadMoreAnimationOnly);
            return cb_autoLoadMoreAnimationOnly;
        }

        static bool n_AutoLoadMoreAnimationOnly(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoLoadMoreAnimationOnly();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadMoreAnimationOnly' and count(parameter)=0]"
        [Register("autoLoadMoreAnimationOnly", "()Z", "GetAutoLoadMoreAnimationOnlyHandler")]
        public virtual unsafe bool AutoLoadMoreAnimationOnly()
        {
            const string __id = "autoLoadMoreAnimationOnly.()Z";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoRefresh;
#pragma warning disable 0169
        static Delegate GetAutoRefreshHandler()
        {
            if (cb_autoRefresh == null)
                cb_autoRefresh = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_AutoRefresh);
            return cb_autoRefresh;
        }

        static bool n_AutoRefresh(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoRefresh();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=0]"
        [Register("autoRefresh", "()Z", "GetAutoRefreshHandler")]
        public virtual unsafe bool AutoRefresh()
        {
            const string __id = "autoRefresh.()Z";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoRefresh_I;
#pragma warning disable 0169
        [Obsolete]
        static Delegate GetAutoRefresh_IHandler()
        {
            if (cb_autoRefresh_I == null)
                cb_autoRefresh_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool>)n_AutoRefresh_I);
            return cb_autoRefresh_I;
        }

        [Obsolete]
        static bool n_AutoRefresh_I(IntPtr jnienv, IntPtr native__this, int delayed)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoRefresh(delayed);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
        [Obsolete(@"deprecated")]
        [Register("autoRefresh", "(I)Z", "GetAutoRefresh_IHandler")]
        public virtual unsafe bool AutoRefresh(int delayed)
        {
            const string __id = "autoRefresh.(I)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(delayed);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoRefresh_IIFZ;
#pragma warning disable 0169
        static Delegate GetAutoRefresh_IIFZHandler()
        {
            if (cb_autoRefresh_IIFZ == null)
                cb_autoRefresh_IIFZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, float, bool, bool>)n_AutoRefresh_IIFZ);
            return cb_autoRefresh_IIFZ;
        }

        static bool n_AutoRefresh_IIFZ(IntPtr jnienv, IntPtr native__this, int delayed, int duration, float dragRate, bool animationOnly)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoRefresh(delayed, duration, dragRate, animationOnly);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
        [Register("autoRefresh", "(IIFZ)Z", "GetAutoRefresh_IIFZHandler")]
        public virtual unsafe bool AutoRefresh(int delayed, int duration, float dragRate, bool animationOnly)
        {
            const string __id = "autoRefresh.(IIFZ)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(delayed);
                __args[1] = new JniArgumentValue(duration);
                __args[2] = new JniArgumentValue(dragRate);
                __args[3] = new JniArgumentValue(animationOnly);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_autoRefreshAnimationOnly;
#pragma warning disable 0169
        static Delegate GetAutoRefreshAnimationOnlyHandler()
        {
            if (cb_autoRefreshAnimationOnly == null)
                cb_autoRefreshAnimationOnly = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_AutoRefreshAnimationOnly);
            return cb_autoRefreshAnimationOnly;
        }

        static bool n_AutoRefreshAnimationOnly(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.AutoRefreshAnimationOnly();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefreshAnimationOnly' and count(parameter)=0]"
        [Register("autoRefreshAnimationOnly", "()Z", "GetAutoRefreshAnimationOnlyHandler")]
        public virtual unsafe bool AutoRefreshAnimationOnly()
        {
            const string __id = "autoRefreshAnimationOnly.()Z";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_closeHeaderOrFooter;
#pragma warning disable 0169
        static Delegate GetCloseHeaderOrFooterHandler()
        {
            if (cb_closeHeaderOrFooter == null)
                cb_closeHeaderOrFooter = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_CloseHeaderOrFooter);
            return cb_closeHeaderOrFooter;
        }

        static IntPtr n_CloseHeaderOrFooter(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.CloseHeaderOrFooter());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='closeHeaderOrFooter' and count(parameter)=0]"
        [Register("closeHeaderOrFooter", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetCloseHeaderOrFooterHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout CloseHeaderOrFooter()
        {
            const string __id = "closeHeaderOrFooter.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMore;
#pragma warning disable 0169
        static Delegate GetFinishLoadMoreHandler()
        {
            if (cb_finishLoadMore == null)
                cb_finishLoadMore = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_FinishLoadMore);
            return cb_finishLoadMore;
        }

        static IntPtr n_FinishLoadMore(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishLoadMore());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadMore' and count(parameter)=0]"
        [Register("finishLoadMore", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadMoreHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadMore()
        {
            const string __id = "finishLoadMore.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMore_Z;
#pragma warning disable 0169
        static Delegate GetFinishLoadMore_ZHandler()
        {
            if (cb_finishLoadMore_Z == null)
                cb_finishLoadMore_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_FinishLoadMore_Z);
            return cb_finishLoadMore_Z;
        }

        static IntPtr n_FinishLoadMore_Z(IntPtr jnienv, IntPtr native__this, bool success)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishLoadMore(success));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("finishLoadMore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadMore_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadMore(bool success)
        {
            const string __id = "finishLoadMore.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(success);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMore_I;
#pragma warning disable 0169
        static Delegate GetFinishLoadMore_IHandler()
        {
            if (cb_finishLoadMore_I == null)
                cb_finishLoadMore_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_FinishLoadMore_I);
            return cb_finishLoadMore_I;
        }

        static IntPtr n_FinishLoadMore_I(IntPtr jnienv, IntPtr native__this, int delayed)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishLoadMore(delayed));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadMore' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("finishLoadMore", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadMore_IHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadMore(int delayed)
        {
            const string __id = "finishLoadMore.(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(delayed);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMore_IZZ;
#pragma warning disable 0169
        static Delegate GetFinishLoadMore_IZZHandler()
        {
            if (cb_finishLoadMore_IZZ == null)
                cb_finishLoadMore_IZZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool, bool, IntPtr>)n_FinishLoadMore_IZZ);
            return cb_finishLoadMore_IZZ;
        }

        static IntPtr n_FinishLoadMore_IZZ(IntPtr jnienv, IntPtr native__this, int delayed, bool success, bool noMoreData)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishLoadMore(delayed, success, noMoreData));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadMore' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
        [Register("finishLoadMore", "(IZZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadMore_IZZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadMore(int delayed, bool success, bool noMoreData)
        {
            const string __id = "finishLoadMore.(IZZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(delayed);
                __args[1] = new JniArgumentValue(success);
                __args[2] = new JniArgumentValue(noMoreData);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMoreWithNoMoreData;
#pragma warning disable 0169
        static Delegate GetFinishLoadMoreWithNoMoreDataHandler()
        {
            if (cb_finishLoadMoreWithNoMoreData == null)
                cb_finishLoadMoreWithNoMoreData = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_FinishLoadMoreWithNoMoreData);
            return cb_finishLoadMoreWithNoMoreData;
        }

        static IntPtr n_FinishLoadMoreWithNoMoreData(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishLoadMoreWithNoMoreData());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadMoreWithNoMoreData' and count(parameter)=0]"
        [Register("finishLoadMoreWithNoMoreData", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadMoreWithNoMoreDataHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadMoreWithNoMoreData()
        {
            const string __id = "finishLoadMoreWithNoMoreData.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishRefresh;
#pragma warning disable 0169
        static Delegate GetFinishRefreshHandler()
        {
            if (cb_finishRefresh == null)
                cb_finishRefresh = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_FinishRefresh);
            return cb_finishRefresh;
        }

        static IntPtr n_FinishRefresh(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishRefresh());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=0]"
        [Register("finishRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefreshHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh()
        {
            const string __id = "finishRefresh.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishRefresh_Z;
#pragma warning disable 0169
        static Delegate GetFinishRefresh_ZHandler()
        {
            if (cb_finishRefresh_Z == null)
                cb_finishRefresh_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_FinishRefresh_Z);
            return cb_finishRefresh_Z;
        }

        static IntPtr n_FinishRefresh_Z(IntPtr jnienv, IntPtr native__this, bool success)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishRefresh(success));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("finishRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh(bool success)
        {
            const string __id = "finishRefresh.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(success);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishRefresh_I;
#pragma warning disable 0169
        static Delegate GetFinishRefresh_IHandler()
        {
            if (cb_finishRefresh_I == null)
                cb_finishRefresh_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_FinishRefresh_I);
            return cb_finishRefresh_I;
        }

        static IntPtr n_FinishRefresh_I(IntPtr jnienv, IntPtr native__this, int delayed)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishRefresh(delayed));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("finishRefresh", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_IHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh(int delayed)
        {
            const string __id = "finishRefresh.(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(delayed);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishRefresh_IZLjava_lang_Boolean_;
#pragma warning disable 0169
        static Delegate GetFinishRefresh_IZLjava_lang_Boolean_Handler()
        {
            if (cb_finishRefresh_IZLjava_lang_Boolean_ == null)
                cb_finishRefresh_IZLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool, IntPtr, IntPtr>)n_FinishRefresh_IZLjava_lang_Boolean_);
            return cb_finishRefresh_IZLjava_lang_Boolean_;
        }

        static IntPtr n_FinishRefresh_IZLjava_lang_Boolean_(IntPtr jnienv, IntPtr native__this, int delayed, bool success, IntPtr native_noMoreData)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Boolean noMoreData = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean>(native_noMoreData, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.FinishRefresh(delayed, success, noMoreData));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.Boolean']]"
        [Register("finishRefresh", "(IZLjava/lang/Boolean;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_IZLjava_lang_Boolean_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh(int delayed, bool success, global::Java.Lang.Boolean noMoreData)
        {
            const string __id = "finishRefresh.(IZLjava/lang/Boolean;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(delayed);
                __args[1] = new JniArgumentValue(success);
                __args[2] = new JniArgumentValue((noMoreData == null) ? IntPtr.Zero : ((global::Java.Lang.Object)noMoreData).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_finishRefreshWithNoMoreData;
#pragma warning disable 0169
        static Delegate GetFinishRefreshWithNoMoreDataHandler()
        {
            if (cb_finishRefreshWithNoMoreData == null)
                cb_finishRefreshWithNoMoreData = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_FinishRefreshWithNoMoreData);
            return cb_finishRefreshWithNoMoreData;
        }

        static IntPtr n_FinishRefreshWithNoMoreData(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.FinishRefreshWithNoMoreData());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefreshWithNoMoreData' and count(parameter)=0]"
        [Register("finishRefreshWithNoMoreData", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefreshWithNoMoreDataHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefreshWithNoMoreData()
        {
            const string __id = "finishRefreshWithNoMoreData.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_interceptAnimatorByAction_I;
#pragma warning disable 0169
        static Delegate GetInterceptAnimatorByAction_IHandler()
        {
            if (cb_interceptAnimatorByAction_I == null)
                cb_interceptAnimatorByAction_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool>)n_InterceptAnimatorByAction_I);
            return cb_interceptAnimatorByAction_I;
        }

        static bool n_InterceptAnimatorByAction_I(IntPtr jnienv, IntPtr native__this, int action)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.InterceptAnimatorByAction(action);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='interceptAnimatorByAction' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("interceptAnimatorByAction", "(I)Z", "GetInterceptAnimatorByAction_IHandler")]
        protected virtual unsafe bool InterceptAnimatorByAction(int action)
        {
            const string __id = "interceptAnimatorByAction.(I)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(action);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_isEnableRefreshOrLoadMore_Z;
#pragma warning disable 0169
        static Delegate GetIsEnableRefreshOrLoadMore_ZHandler()
        {
            if (cb_isEnableRefreshOrLoadMore_Z == null)
                cb_isEnableRefreshOrLoadMore_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, bool>)n_IsEnableRefreshOrLoadMore_Z);
            return cb_isEnableRefreshOrLoadMore_Z;
        }

        static bool n_IsEnableRefreshOrLoadMore_Z(IntPtr jnienv, IntPtr native__this, bool enable)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.IsEnableRefreshOrLoadMore(enable);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableRefreshOrLoadMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("isEnableRefreshOrLoadMore", "(Z)Z", "GetIsEnableRefreshOrLoadMore_ZHandler")]
        protected virtual unsafe bool IsEnableRefreshOrLoadMore(bool enable)
        {
            const string __id = "isEnableRefreshOrLoadMore.(Z)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enable);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_isEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_;
#pragma warning disable 0169
        static Delegate GetIsEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_Handler()
        {
            if (cb_isEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_ == null)
                cb_isEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr, bool>)n_IsEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_);
            return cb_isEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_;
        }

        static bool n_IsEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_(IntPtr jnienv, IntPtr native__this, bool enable, IntPtr native__internal)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal>(native__internal, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.IsEnableTranslationContent(enable, @internal);
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableTranslationContent' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.scwang.smartrefresh.layout.api.RefreshInternal']]"
        [Register("isEnableTranslationContent", "(ZLcom/scwang/smartrefresh/layout/api/RefreshInternal;)Z", "GetIsEnableTranslationContent_ZLcom_scwang_smartrefresh_layout_api_RefreshInternal_Handler")]
        protected virtual unsafe bool IsEnableTranslationContent(bool enable, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal @internal)
        {
            const string __id = "isEnableTranslationContent.(ZLcom/scwang/smartrefresh/layout/api/RefreshInternal;)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(enable);
                __args[1] = new JniArgumentValue((@internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@internal).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_moveSpinnerInfinitely_F;
#pragma warning disable 0169
        static Delegate GetMoveSpinnerInfinitely_FHandler()
        {
            if (cb_moveSpinnerInfinitely_F == null)
                cb_moveSpinnerInfinitely_F = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, float>)n_MoveSpinnerInfinitely_F);
            return cb_moveSpinnerInfinitely_F;
        }

        static void n_MoveSpinnerInfinitely_F(IntPtr jnienv, IntPtr native__this, float spinner)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.MoveSpinnerInfinitely(spinner);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='moveSpinnerInfinitely' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("moveSpinnerInfinitely", "(F)V", "GetMoveSpinnerInfinitely_FHandler")]
        protected virtual unsafe void MoveSpinnerInfinitely(float spinner)
        {
            const string __id = "moveSpinnerInfinitely.(F)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(spinner);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
        static Delegate GetNotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler()
        {
            if (cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
                cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_NotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
            return cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
        }

        static void n_NotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(native_state, JniHandleOwnership.DoNotTransfer);
            __this.NotifyStateChanged(state);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='notifyStateChanged' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
        [Register("notifyStateChanged", "(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetNotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
        protected virtual unsafe void NotifyStateChanged(global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state)
        {
            const string __id = "notifyStateChanged.(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object)state).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onFinishInflate;
#pragma warning disable 0169
        static Delegate GetOnFinishInflateHandler()
        {
            if (cb_onFinishInflate == null)
                cb_onFinishInflate = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OnFinishInflate);
            return cb_onFinishInflate;
        }

        static void n_OnFinishInflate(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OnFinishInflate();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='onFinishInflate' and count(parameter)=0]"
        [Register("onFinishInflate", "()V", "GetOnFinishInflateHandler")]
        public virtual unsafe void OnFinishInflate()
        {
            const string __id = "onFinishInflate.()V";
            try
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
            }
            finally
            {
            }
        }

        static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
        static Delegate GetOnLayout_ZIIIIHandler()
        {
            if (cb_onLayout_ZIIII == null)
                cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, bool, int, int, int, int>)n_OnLayout_ZIIII);
            return cb_onLayout_ZIIII;
        }

        static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OnLayout(changed, l, t, r, b);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
        [Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
        protected override unsafe void OnLayout(bool changed, int l, int t, int r, int b)
        {
            const string __id = "onLayout.(ZIIII)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[5];
                __args[0] = new JniArgumentValue(changed);
                __args[1] = new JniArgumentValue(l);
                __args[2] = new JniArgumentValue(t);
                __args[3] = new JniArgumentValue(r);
                __args[4] = new JniArgumentValue(b);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_overSpinner;
#pragma warning disable 0169
        static Delegate GetOverSpinnerHandler()
        {
            if (cb_overSpinner == null)
                cb_overSpinner = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OverSpinner);
            return cb_overSpinner;
        }

        static void n_OverSpinner(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OverSpinner();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='overSpinner' and count(parameter)=0]"
        [Register("overSpinner", "()V", "GetOverSpinnerHandler")]
        protected virtual unsafe void OverSpinner()
        {
            const string __id = "overSpinner.()V";
            try
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
            }
            finally
            {
            }
        }

        static Delegate cb_resetNoMoreData;
#pragma warning disable 0169
        static Delegate GetResetNoMoreDataHandler()
        {
            if (cb_resetNoMoreData == null)
                cb_resetNoMoreData = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_ResetNoMoreData);
            return cb_resetNoMoreData;
        }

        static IntPtr n_ResetNoMoreData(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.ResetNoMoreData());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='resetNoMoreData' and count(parameter)=0]"
        [Register("resetNoMoreData", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetResetNoMoreDataHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout ResetNoMoreData()
        {
            const string __id = "resetNoMoreData.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDefaultRefreshFooterCreator' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.DefaultRefreshFooterCreator']]"
        [Register("setDefaultRefreshFooterCreator", "(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreator;)V", "")]
        public static unsafe void SetDefaultRefreshFooterCreator(global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreator creator)
        {
            const string __id = "setDefaultRefreshFooterCreator.(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreator;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((creator == null) ? IntPtr.Zero : ((global::Java.Lang.Object)creator).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDefaultRefreshHeaderCreator' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.DefaultRefreshHeaderCreator']]"
        [Register("setDefaultRefreshHeaderCreator", "(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreator;)V", "")]
        public static unsafe void SetDefaultRefreshHeaderCreator(global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreator creator)
        {
            const string __id = "setDefaultRefreshHeaderCreator.(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreator;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((creator == null) ? IntPtr.Zero : ((global::Java.Lang.Object)creator).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDefaultRefreshInitializer' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.DefaultRefreshInitializer']]"
        [Register("setDefaultRefreshInitializer", "(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshInitializer;)V", "")]
        public static unsafe void SetDefaultRefreshInitializer(global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshInitializer initializer)
        {
            const string __id = "setDefaultRefreshInitializer.(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshInitializer;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((initializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)initializer).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setDisableContentWhenLoading_Z;
#pragma warning disable 0169
        static Delegate GetSetDisableContentWhenLoading_ZHandler()
        {
            if (cb_setDisableContentWhenLoading_Z == null)
                cb_setDisableContentWhenLoading_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetDisableContentWhenLoading_Z);
            return cb_setDisableContentWhenLoading_Z;
        }

        static IntPtr n_SetDisableContentWhenLoading_Z(IntPtr jnienv, IntPtr native__this, bool disable)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetDisableContentWhenLoading(disable));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDisableContentWhenLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setDisableContentWhenLoading", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDisableContentWhenLoading_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenLoading(bool disable)
        {
            const string __id = "setDisableContentWhenLoading.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(disable);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setDisableContentWhenRefresh_Z;
#pragma warning disable 0169
        static Delegate GetSetDisableContentWhenRefresh_ZHandler()
        {
            if (cb_setDisableContentWhenRefresh_Z == null)
                cb_setDisableContentWhenRefresh_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetDisableContentWhenRefresh_Z);
            return cb_setDisableContentWhenRefresh_Z;
        }

        static IntPtr n_SetDisableContentWhenRefresh_Z(IntPtr jnienv, IntPtr native__this, bool disable)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetDisableContentWhenRefresh(disable));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDisableContentWhenRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setDisableContentWhenRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDisableContentWhenRefresh_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenRefresh(bool disable)
        {
            const string __id = "setDisableContentWhenRefresh.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(disable);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setDragRate_F;
#pragma warning disable 0169
        static Delegate GetSetDragRate_FHandler()
        {
            if (cb_setDragRate_F == null)
                cb_setDragRate_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetDragRate_F);
            return cb_setDragRate_F;
        }

        static IntPtr n_SetDragRate_F(IntPtr jnienv, IntPtr native__this, float rate)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetDragRate(rate));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDragRate_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDragRate(float rate)
        {
            const string __id = "setDragRate.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(rate);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableAutoLoadMore_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableAutoLoadMore_ZHandler()
        {
            if (cb_setEnableAutoLoadMore_Z == null)
                cb_setEnableAutoLoadMore_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableAutoLoadMore_Z);
            return cb_setEnableAutoLoadMore_Z;
        }

        static IntPtr n_SetEnableAutoLoadMore_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableAutoLoadMore(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableAutoLoadMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableAutoLoadMore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableAutoLoadMore_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableAutoLoadMore(bool enabled)
        {
            const string __id = "setEnableAutoLoadMore.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableClipFooterWhenFixedBehind_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableClipFooterWhenFixedBehind_ZHandler()
        {
            if (cb_setEnableClipFooterWhenFixedBehind_Z == null)
                cb_setEnableClipFooterWhenFixedBehind_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableClipFooterWhenFixedBehind_Z);
            return cb_setEnableClipFooterWhenFixedBehind_Z;
        }

        static IntPtr n_SetEnableClipFooterWhenFixedBehind_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableClipFooterWhenFixedBehind(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableClipFooterWhenFixedBehind' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableClipFooterWhenFixedBehind", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableClipFooterWhenFixedBehind_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableClipFooterWhenFixedBehind(bool enabled)
        {
            const string __id = "setEnableClipFooterWhenFixedBehind.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableClipHeaderWhenFixedBehind_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableClipHeaderWhenFixedBehind_ZHandler()
        {
            if (cb_setEnableClipHeaderWhenFixedBehind_Z == null)
                cb_setEnableClipHeaderWhenFixedBehind_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableClipHeaderWhenFixedBehind_Z);
            return cb_setEnableClipHeaderWhenFixedBehind_Z;
        }

        static IntPtr n_SetEnableClipHeaderWhenFixedBehind_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableClipHeaderWhenFixedBehind(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableClipHeaderWhenFixedBehind' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableClipHeaderWhenFixedBehind", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableClipHeaderWhenFixedBehind_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableClipHeaderWhenFixedBehind(bool enabled)
        {
            const string __id = "setEnableClipHeaderWhenFixedBehind.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableFooterFollowWhenLoadFinished_Z;
#pragma warning disable 0169
        [Obsolete]
        static Delegate GetSetEnableFooterFollowWhenLoadFinished_ZHandler()
        {
            if (cb_setEnableFooterFollowWhenLoadFinished_Z == null)
                cb_setEnableFooterFollowWhenLoadFinished_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableFooterFollowWhenLoadFinished_Z);
            return cb_setEnableFooterFollowWhenLoadFinished_Z;
        }

        [Obsolete]
        static IntPtr n_SetEnableFooterFollowWhenLoadFinished_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableFooterFollowWhenLoadFinished(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableFooterFollowWhenLoadFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Obsolete(@"deprecated")]
        [Register("setEnableFooterFollowWhenLoadFinished", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableFooterFollowWhenLoadFinished_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterFollowWhenLoadFinished(bool enabled)
        {
            const string __id = "setEnableFooterFollowWhenLoadFinished.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableFooterFollowWhenNoMoreData_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableFooterFollowWhenNoMoreData_ZHandler()
        {
            if (cb_setEnableFooterFollowWhenNoMoreData_Z == null)
                cb_setEnableFooterFollowWhenNoMoreData_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableFooterFollowWhenNoMoreData_Z);
            return cb_setEnableFooterFollowWhenNoMoreData_Z;
        }

        static IntPtr n_SetEnableFooterFollowWhenNoMoreData_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableFooterFollowWhenNoMoreData(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableFooterFollowWhenNoMoreData' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableFooterFollowWhenNoMoreData", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableFooterFollowWhenNoMoreData_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterFollowWhenNoMoreData(bool enabled)
        {
            const string __id = "setEnableFooterFollowWhenNoMoreData.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableFooterTranslationContent_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableFooterTranslationContent_ZHandler()
        {
            if (cb_setEnableFooterTranslationContent_Z == null)
                cb_setEnableFooterTranslationContent_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableFooterTranslationContent_Z);
            return cb_setEnableFooterTranslationContent_Z;
        }

        static IntPtr n_SetEnableFooterTranslationContent_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableFooterTranslationContent(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableFooterTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableFooterTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableFooterTranslationContent_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterTranslationContent(bool enabled)
        {
            const string __id = "setEnableFooterTranslationContent.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableHeaderTranslationContent_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableHeaderTranslationContent_ZHandler()
        {
            if (cb_setEnableHeaderTranslationContent_Z == null)
                cb_setEnableHeaderTranslationContent_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableHeaderTranslationContent_Z);
            return cb_setEnableHeaderTranslationContent_Z;
        }

        static IntPtr n_SetEnableHeaderTranslationContent_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableHeaderTranslationContent(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableHeaderTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableHeaderTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableHeaderTranslationContent_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableHeaderTranslationContent(bool enabled)
        {
            const string __id = "setEnableHeaderTranslationContent.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableLoadMore_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableLoadMore_ZHandler()
        {
            if (cb_setEnableLoadMore_Z == null)
                cb_setEnableLoadMore_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableLoadMore_Z);
            return cb_setEnableLoadMore_Z;
        }

        static IntPtr n_SetEnableLoadMore_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableLoadMore(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableLoadMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableLoadMore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableLoadMore_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableLoadMore(bool enabled)
        {
            const string __id = "setEnableLoadMore.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableLoadMoreWhenContentNotFull_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableLoadMoreWhenContentNotFull_ZHandler()
        {
            if (cb_setEnableLoadMoreWhenContentNotFull_Z == null)
                cb_setEnableLoadMoreWhenContentNotFull_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableLoadMoreWhenContentNotFull_Z);
            return cb_setEnableLoadMoreWhenContentNotFull_Z;
        }

        static IntPtr n_SetEnableLoadMoreWhenContentNotFull_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableLoadMoreWhenContentNotFull(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableLoadMoreWhenContentNotFull' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableLoadMoreWhenContentNotFull", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableLoadMoreWhenContentNotFull_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableLoadMoreWhenContentNotFull(bool enabled)
        {
            const string __id = "setEnableLoadMoreWhenContentNotFull.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableNestedScroll_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableNestedScroll_ZHandler()
        {
            if (cb_setEnableNestedScroll_Z == null)
                cb_setEnableNestedScroll_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableNestedScroll_Z);
            return cb_setEnableNestedScroll_Z;
        }

        static IntPtr n_SetEnableNestedScroll_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableNestedScroll(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableNestedScroll' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableNestedScroll", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableNestedScroll_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableNestedScroll(bool enabled)
        {
            const string __id = "setEnableNestedScroll.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableOverScrollBounce_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableOverScrollBounce_ZHandler()
        {
            if (cb_setEnableOverScrollBounce_Z == null)
                cb_setEnableOverScrollBounce_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableOverScrollBounce_Z);
            return cb_setEnableOverScrollBounce_Z;
        }

        static IntPtr n_SetEnableOverScrollBounce_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableOverScrollBounce(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableOverScrollBounce' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableOverScrollBounce", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableOverScrollBounce_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableOverScrollBounce(bool enabled)
        {
            const string __id = "setEnableOverScrollBounce.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableOverScrollDrag_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableOverScrollDrag_ZHandler()
        {
            if (cb_setEnableOverScrollDrag_Z == null)
                cb_setEnableOverScrollDrag_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableOverScrollDrag_Z);
            return cb_setEnableOverScrollDrag_Z;
        }

        static IntPtr n_SetEnableOverScrollDrag_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableOverScrollDrag(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableOverScrollDrag' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableOverScrollDrag", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableOverScrollDrag_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableOverScrollDrag(bool enabled)
        {
            const string __id = "setEnableOverScrollDrag.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnablePureScrollMode_Z;
#pragma warning disable 0169
        static Delegate GetSetEnablePureScrollMode_ZHandler()
        {
            if (cb_setEnablePureScrollMode_Z == null)
                cb_setEnablePureScrollMode_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnablePureScrollMode_Z);
            return cb_setEnablePureScrollMode_Z;
        }

        static IntPtr n_SetEnablePureScrollMode_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnablePureScrollMode(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnablePureScrollMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnablePureScrollMode", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnablePureScrollMode_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnablePureScrollMode(bool enabled)
        {
            const string __id = "setEnablePureScrollMode.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableRefresh_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableRefresh_ZHandler()
        {
            if (cb_setEnableRefresh_Z == null)
                cb_setEnableRefresh_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableRefresh_Z);
            return cb_setEnableRefresh_Z;
        }

        static IntPtr n_SetEnableRefresh_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableRefresh(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableRefresh_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableRefresh(bool enabled)
        {
            const string __id = "setEnableRefresh.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableScrollContentWhenLoaded_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableScrollContentWhenLoaded_ZHandler()
        {
            if (cb_setEnableScrollContentWhenLoaded_Z == null)
                cb_setEnableScrollContentWhenLoaded_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableScrollContentWhenLoaded_Z);
            return cb_setEnableScrollContentWhenLoaded_Z;
        }

        static IntPtr n_SetEnableScrollContentWhenLoaded_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableScrollContentWhenLoaded(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableScrollContentWhenLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableScrollContentWhenLoaded", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableScrollContentWhenLoaded_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableScrollContentWhenLoaded(bool enabled)
        {
            const string __id = "setEnableScrollContentWhenLoaded.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setEnableScrollContentWhenRefreshed_Z;
#pragma warning disable 0169
        static Delegate GetSetEnableScrollContentWhenRefreshed_ZHandler()
        {
            if (cb_setEnableScrollContentWhenRefreshed_Z == null)
                cb_setEnableScrollContentWhenRefreshed_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetEnableScrollContentWhenRefreshed_Z);
            return cb_setEnableScrollContentWhenRefreshed_Z;
        }

        static IntPtr n_SetEnableScrollContentWhenRefreshed_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetEnableScrollContentWhenRefreshed(enabled));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableScrollContentWhenRefreshed' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setEnableScrollContentWhenRefreshed", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableScrollContentWhenRefreshed_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableScrollContentWhenRefreshed(bool enabled)
        {
            const string __id = "setEnableScrollContentWhenRefreshed.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(enabled);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setFooterHeight_F;
#pragma warning disable 0169
        static Delegate GetSetFooterHeight_FHandler()
        {
            if (cb_setFooterHeight_F == null)
                cb_setFooterHeight_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetFooterHeight_F);
            return cb_setFooterHeight_F;
        }

        static IntPtr n_SetFooterHeight_F(IntPtr jnienv, IntPtr native__this, float heightDp)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetFooterHeight(heightDp));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterHeight' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setFooterHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterHeight_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeight(float heightDp)
        {
            const string __id = "setFooterHeight.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(heightDp);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setFooterInsetStart_F;
#pragma warning disable 0169
        static Delegate GetSetFooterInsetStart_FHandler()
        {
            if (cb_setFooterInsetStart_F == null)
                cb_setFooterInsetStart_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetFooterInsetStart_F);
            return cb_setFooterInsetStart_F;
        }

        static IntPtr n_SetFooterInsetStart_F(IntPtr jnienv, IntPtr native__this, float insetDp)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetFooterInsetStart(insetDp));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterInsetStart' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setFooterInsetStart", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterInsetStart_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterInsetStart(float insetDp)
        {
            const string __id = "setFooterInsetStart.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(insetDp);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setFooterMaxDragRate_F;
#pragma warning disable 0169
        static Delegate GetSetFooterMaxDragRate_FHandler()
        {
            if (cb_setFooterMaxDragRate_F == null)
                cb_setFooterMaxDragRate_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetFooterMaxDragRate_F);
            return cb_setFooterMaxDragRate_F;
        }

        static IntPtr n_SetFooterMaxDragRate_F(IntPtr jnienv, IntPtr native__this, float rate)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetFooterMaxDragRate(rate));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setFooterMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterMaxDragRate_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterMaxDragRate(float rate)
        {
            const string __id = "setFooterMaxDragRate.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(rate);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setFooterTriggerRate_F;
#pragma warning disable 0169
        static Delegate GetSetFooterTriggerRate_FHandler()
        {
            if (cb_setFooterTriggerRate_F == null)
                cb_setFooterTriggerRate_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetFooterTriggerRate_F);
            return cb_setFooterTriggerRate_F;
        }

        static IntPtr n_SetFooterTriggerRate_F(IntPtr jnienv, IntPtr native__this, float rate)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetFooterTriggerRate(rate));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterTriggerRate' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setFooterTriggerRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterTriggerRate_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterTriggerRate(float rate)
        {
            const string __id = "setFooterTriggerRate.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(rate);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setHeaderHeight_F;
#pragma warning disable 0169
        static Delegate GetSetHeaderHeight_FHandler()
        {
            if (cb_setHeaderHeight_F == null)
                cb_setHeaderHeight_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetHeaderHeight_F);
            return cb_setHeaderHeight_F;
        }

        static IntPtr n_SetHeaderHeight_F(IntPtr jnienv, IntPtr native__this, float heightDp)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetHeaderHeight(heightDp));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderHeight' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setHeaderHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderHeight_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeight(float heightDp)
        {
            const string __id = "setHeaderHeight.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(heightDp);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setHeaderInsetStart_F;
#pragma warning disable 0169
        static Delegate GetSetHeaderInsetStart_FHandler()
        {
            if (cb_setHeaderInsetStart_F == null)
                cb_setHeaderInsetStart_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetHeaderInsetStart_F);
            return cb_setHeaderInsetStart_F;
        }

        static IntPtr n_SetHeaderInsetStart_F(IntPtr jnienv, IntPtr native__this, float insetDp)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetHeaderInsetStart(insetDp));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderInsetStart' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setHeaderInsetStart", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderInsetStart_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderInsetStart(float insetDp)
        {
            const string __id = "setHeaderInsetStart.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(insetDp);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setHeaderMaxDragRate_F;
#pragma warning disable 0169
        static Delegate GetSetHeaderMaxDragRate_FHandler()
        {
            if (cb_setHeaderMaxDragRate_F == null)
                cb_setHeaderMaxDragRate_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetHeaderMaxDragRate_F);
            return cb_setHeaderMaxDragRate_F;
        }

        static IntPtr n_SetHeaderMaxDragRate_F(IntPtr jnienv, IntPtr native__this, float rate)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetHeaderMaxDragRate(rate));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setHeaderMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderMaxDragRate_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderMaxDragRate(float rate)
        {
            const string __id = "setHeaderMaxDragRate.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(rate);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setHeaderTriggerRate_F;
#pragma warning disable 0169
        static Delegate GetSetHeaderTriggerRate_FHandler()
        {
            if (cb_setHeaderTriggerRate_F == null)
                cb_setHeaderTriggerRate_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, IntPtr>)n_SetHeaderTriggerRate_F);
            return cb_setHeaderTriggerRate_F;
        }

        static IntPtr n_SetHeaderTriggerRate_F(IntPtr jnienv, IntPtr native__this, float rate)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetHeaderTriggerRate(rate));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderTriggerRate' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setHeaderTriggerRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderTriggerRate_FHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderTriggerRate(float rate)
        {
            const string __id = "setHeaderTriggerRate.(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(rate);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setNoMoreData_Z;
#pragma warning disable 0169
        static Delegate GetSetNoMoreData_ZHandler()
        {
            if (cb_setNoMoreData_Z == null)
                cb_setNoMoreData_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>)n_SetNoMoreData_Z);
            return cb_setNoMoreData_Z;
        }

        static IntPtr n_SetNoMoreData_Z(IntPtr jnienv, IntPtr native__this, bool noMoreData)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetNoMoreData(noMoreData));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setNoMoreData' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setNoMoreData", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetNoMoreData_ZHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetNoMoreData(bool noMoreData)
        {
            const string __id = "setNoMoreData.(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(noMoreData);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_;
#pragma warning disable 0169
        static Delegate GetSetOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_Handler()
        {
            if (cb_setOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_ == null)
                cb_setOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_);
            return cb_setOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_;
        }

        static IntPtr n_SetOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnLoadMoreListener(listener));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnLoadMoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnLoadMoreListener']]"
        [Register("setOnLoadMoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnLoadMoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadMoreListener_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnLoadMoreListener(global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadMoreListener listener)
        {
            const string __id = "setOnLoadMoreListener.(Lcom/scwang/smartrefresh/layout/listener/OnLoadMoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
#pragma warning disable 0169
        static Delegate GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler()
        {
            if (cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ == null)
                cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_);
            return cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
        }

        static IntPtr n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnMultiPurposeListener(listener));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnMultiPurposeListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnMultiPurposeListener']]"
        [Register("setOnMultiPurposeListener", "(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnMultiPurposeListener(global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener listener)
        {
            const string __id = "setOnMultiPurposeListener.(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
#pragma warning disable 0169
        static Delegate GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler()
        {
            if (cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ == null)
                cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_);
            return cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
        }

        static IntPtr n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnRefreshListener(listener));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnRefreshListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshListener']]"
        [Register("setOnRefreshListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshListener(global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener listener)
        {
            const string __id = "setOnRefreshListener.(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_;
#pragma warning disable 0169
        static Delegate GetSetOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_Handler()
        {
            if (cb_setOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_ == null)
                cb_setOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_);
            return cb_setOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_;
        }

        static IntPtr n_SetOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadMoreListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadMoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadMoreListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnRefreshLoadMoreListener(listener));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnRefreshLoadMoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshLoadMoreListener']]"
        [Register("setOnRefreshLoadMoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadMoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnRefreshLoadMoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadMoreListener_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshLoadMoreListener(global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadMoreListener listener)
        {
            const string __id = "setOnRefreshLoadMoreListener.(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadMoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
        static Delegate GetSetPrimaryColors_arrayIHandler()
        {
            if (cb_setPrimaryColors_arrayI == null)
                cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetPrimaryColors_arrayI);
            return cb_setPrimaryColors_arrayI;
        }

        static IntPtr n_SetPrimaryColors_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_primaryColors)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            int[] primaryColors = (int[])JNIEnv.GetArray(native_primaryColors, JniHandleOwnership.DoNotTransfer, typeof(int));
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetPrimaryColors(primaryColors));
            if (primaryColors != null)
                JNIEnv.CopyArray(primaryColors, native_primaryColors);
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setPrimaryColors' and count(parameter)=1 and parameter[1][@type='int...']]"
        [Register("setPrimaryColors", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetPrimaryColors_arrayIHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColors(params int[] primaryColors)
        {
            const string __id = "setPrimaryColors.([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            IntPtr native_primaryColors = JNIEnv.NewArray(primaryColors);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_primaryColors);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                if (primaryColors != null)
                {
                    JNIEnv.CopyArray(native_primaryColors, primaryColors);
                    JNIEnv.DeleteLocalRef(native_primaryColors);
                }
            }
        }

        static Delegate cb_setPrimaryColorsId_arrayI;
#pragma warning disable 0169
        static Delegate GetSetPrimaryColorsId_arrayIHandler()
        {
            if (cb_setPrimaryColorsId_arrayI == null)
                cb_setPrimaryColorsId_arrayI = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetPrimaryColorsId_arrayI);
            return cb_setPrimaryColorsId_arrayI;
        }

        static IntPtr n_SetPrimaryColorsId_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_primaryColorId)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            int[] primaryColorId = (int[])JNIEnv.GetArray(native_primaryColorId, JniHandleOwnership.DoNotTransfer, typeof(int));
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetPrimaryColorsId(primaryColorId));
            if (primaryColorId != null)
                JNIEnv.CopyArray(primaryColorId, native_primaryColorId);
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setPrimaryColorsId' and count(parameter)=1 and parameter[1][@type='int...']]"
        [Register("setPrimaryColorsId", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetPrimaryColorsId_arrayIHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColorsId(params int[] primaryColorId)
        {
            const string __id = "setPrimaryColorsId.([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            IntPtr native_primaryColorId = JNIEnv.NewArray(primaryColorId);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_primaryColorId);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                if (primaryColorId != null)
                {
                    JNIEnv.CopyArray(native_primaryColorId, primaryColorId);
                    JNIEnv.DeleteLocalRef(native_primaryColorId);
                }
            }
        }

        static Delegate cb_setReboundDuration_I;
#pragma warning disable 0169
        static Delegate GetSetReboundDuration_IHandler()
        {
            if (cb_setReboundDuration_I == null)
                cb_setReboundDuration_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_SetReboundDuration_I);
            return cb_setReboundDuration_I;
        }

        static IntPtr n_SetReboundDuration_I(IntPtr jnienv, IntPtr native__this, int duration)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SetReboundDuration(duration));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setReboundDuration' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("setReboundDuration", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetReboundDuration_IHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundDuration(int duration)
        {
            const string __id = "setReboundDuration.(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(duration);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
        static Delegate GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler()
        {
            if (cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ == null)
                cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetReboundInterpolator_Landroid_view_animation_Interpolator_);
            return cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
        }

        static IntPtr n_SetReboundInterpolator_Landroid_view_animation_Interpolator_(IntPtr jnienv, IntPtr native__this, IntPtr native_interpolator)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.Animations.IInterpolator interpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetReboundInterpolator(interpolator));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setReboundInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
        [Register("setReboundInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundInterpolator(global::Android.Views.Animations.IInterpolator interpolator)
        {
            const string __id = "setReboundInterpolator.(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object)interpolator).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshContent_Landroid_view_View_;
#pragma warning disable 0169
        static Delegate GetSetRefreshContent_Landroid_view_View_Handler()
        {
            if (cb_setRefreshContent_Landroid_view_View_ == null)
                cb_setRefreshContent_Landroid_view_View_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetRefreshContent_Landroid_view_View_);
            return cb_setRefreshContent_Landroid_view_View_;
        }

        static IntPtr n_SetRefreshContent_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_content)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.View content = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_content, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshContent(content));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshContent' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
        [Register("setRefreshContent", "(Landroid/view/View;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshContent_Landroid_view_View_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshContent(global::Android.Views.View content)
        {
            const string __id = "setRefreshContent.(Landroid/view/View;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((content == null) ? IntPtr.Zero : ((global::Java.Lang.Object)content).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshContent_Landroid_view_View_II;
#pragma warning disable 0169
        static Delegate GetSetRefreshContent_Landroid_view_View_IIHandler()
        {
            if (cb_setRefreshContent_Landroid_view_View_II == null)
                cb_setRefreshContent_Landroid_view_View_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>)n_SetRefreshContent_Landroid_view_View_II);
            return cb_setRefreshContent_Landroid_view_View_II;
        }

        static IntPtr n_SetRefreshContent_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_content, int width, int height)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.View content = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_content, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshContent(content, width, height));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshContent' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
        [Register("setRefreshContent", "(Landroid/view/View;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshContent_Landroid_view_View_IIHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshContent(global::Android.Views.View content, int width, int height)
        {
            const string __id = "setRefreshContent.(Landroid/view/View;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((content == null) ? IntPtr.Zero : ((global::Java.Lang.Object)content).Handle);
                __args[1] = new JniArgumentValue(width);
                __args[2] = new JniArgumentValue(height);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
#pragma warning disable 0169
        static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler()
        {
            if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ == null)
                cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_);
            return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
        }

        static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_(IntPtr jnienv, IntPtr native__this, IntPtr native_footer)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter>(native_footer, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshFooter(footer));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter']]"
        [Register("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer)
        {
            const string __id = "setRefreshFooter.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)footer).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
#pragma warning disable 0169
        static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler()
        {
            if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == null)
                cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>)n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II);
            return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
        }

        static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II(IntPtr jnienv, IntPtr native__this, IntPtr native_footer, int width, int height)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter>(native_footer, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshFooter(footer, width, height));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
        [Register("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, int width, int height)
        {
            const string __id = "setRefreshFooter.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)footer).Handle);
                __args[1] = new JniArgumentValue(width);
                __args[2] = new JniArgumentValue(height);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
#pragma warning disable 0169
        static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler()
        {
            if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ == null)
                cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_);
            return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
        }

        static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_(IntPtr jnienv, IntPtr native__this, IntPtr native_header)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader>(native_header, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshHeader(header));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader']]"
        [Register("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header)
        {
            const string __id = "setRefreshHeader.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object)header).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
#pragma warning disable 0169
        static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler()
        {
            if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == null)
                cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>)n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II);
            return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
        }

        static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II(IntPtr jnienv, IntPtr native__this, IntPtr native_header, int width, int height)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader>(native_header, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetRefreshHeader(header, width, height));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
        [Register("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader(global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, int width, int height)
        {
            const string __id = "setRefreshHeader.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object)header).Handle);
                __args[1] = new JniArgumentValue(width);
                __args[2] = new JniArgumentValue(height);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_;
#pragma warning disable 0169
        static Delegate GetSetScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_Handler()
        {
            if (cb_setScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_ == null)
                cb_setScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_SetScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_);
            return cb_setScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_;
        }

        static IntPtr n_SetScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_(IntPtr jnienv, IntPtr native__this, IntPtr native_boundary)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider boundary = (global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider>(native_boundary, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetScrollBoundaryDecider(boundary));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setScrollBoundaryDecider' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.ScrollBoundaryDecider']]"
        [Register("setScrollBoundaryDecider", "(Lcom/scwang/smartrefresh/layout/api/ScrollBoundaryDecider;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetScrollBoundaryDecider_Lcom_scwang_smartrefresh_layout_api_ScrollBoundaryDecider_Handler")]
        public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetScrollBoundaryDecider(global::Com.Scwang.Smartrefresh.Layout.Api.IScrollBoundaryDecider boundary)
        {
            const string __id = "setScrollBoundaryDecider.(Lcom/scwang/smartrefresh/layout/api/ScrollBoundaryDecider;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((boundary == null) ? IntPtr.Zero : ((global::Java.Lang.Object)boundary).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_setStateDirectLoading_Z;
#pragma warning disable 0169
        static Delegate GetSetStateDirectLoading_ZHandler()
        {
            if (cb_setStateDirectLoading_Z == null)
                cb_setStateDirectLoading_Z = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, bool>)n_SetStateDirectLoading_Z);
            return cb_setStateDirectLoading_Z;
        }

        static void n_SetStateDirectLoading_Z(IntPtr jnienv, IntPtr native__this, bool triggerLoadMoreEvent)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetStateDirectLoading(triggerLoadMoreEvent);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateDirectLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setStateDirectLoading", "(Z)V", "GetSetStateDirectLoading_ZHandler")]
        protected virtual unsafe void SetStateDirectLoading(bool triggerLoadMoreEvent)
        {
            const string __id = "setStateDirectLoading.(Z)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(triggerLoadMoreEvent);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setStateLoading_Z;
#pragma warning disable 0169
        static Delegate GetSetStateLoading_ZHandler()
        {
            if (cb_setStateLoading_Z == null)
                cb_setStateLoading_Z = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, bool>)n_SetStateLoading_Z);
            return cb_setStateLoading_Z;
        }

        static void n_SetStateLoading_Z(IntPtr jnienv, IntPtr native__this, bool notify)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetStateLoading(notify);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setStateLoading", "(Z)V", "GetSetStateLoading_ZHandler")]
        protected virtual unsafe void SetStateLoading(bool notify)
        {
            const string __id = "setStateLoading.(Z)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(notify);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setStateRefreshing_Z;
#pragma warning disable 0169
        static Delegate GetSetStateRefreshing_ZHandler()
        {
            if (cb_setStateRefreshing_Z == null)
                cb_setStateRefreshing_Z = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, bool>)n_SetStateRefreshing_Z);
            return cb_setStateRefreshing_Z;
        }

        static void n_SetStateRefreshing_Z(IntPtr jnienv, IntPtr native__this, bool notify)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetStateRefreshing(notify);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateRefreshing' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setStateRefreshing", "(Z)V", "GetSetStateRefreshing_ZHandler")]
        protected virtual unsafe void SetStateRefreshing(bool notify)
        {
            const string __id = "setStateRefreshing.(Z)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(notify);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
        static Delegate GetSetViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler()
        {
            if (cb_setViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
                cb_setViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
            return cb_setViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
        }

        static void n_SetViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState>(native_state, JniHandleOwnership.DoNotTransfer);
            __this.SetViceState(state);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setViceState' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
        [Register("setViceState", "(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetSetViceState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
        protected virtual unsafe void SetViceState(global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state)
        {
            const string __id = "setViceState.(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object)state).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_startFlingIfNeed_F;
#pragma warning disable 0169
        static Delegate GetStartFlingIfNeed_FHandler()
        {
            if (cb_startFlingIfNeed_F == null)
                cb_startFlingIfNeed_F = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, float, bool>)n_StartFlingIfNeed_F);
            return cb_startFlingIfNeed_F;
        }

        static bool n_StartFlingIfNeed_F(IntPtr jnienv, IntPtr native__this, float flingVelocity)
        {
            global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.StartFlingIfNeed(flingVelocity);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='startFlingIfNeed' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("startFlingIfNeed", "(F)Z", "GetStartFlingIfNeed_FHandler")]
        protected virtual unsafe bool StartFlingIfNeed(float flingVelocity)
        {
            const string __id = "startFlingIfNeed.(F)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(flingVelocity);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

    }
}
