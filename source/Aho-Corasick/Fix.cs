using System;
using System.Linq;
using System.Collections;
using Java.Interop;

// ReSharper disable once CheckNamespace
namespace Org.AhoCorasick.Interval
{
    partial class IntervalableComparatorByPosition : Java.Util.IComparator
    {
        int Java.Util.IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
        {
            return Compare(o1.JavaCast<IIntervalable>(), o2.JavaCast<IIntervalable>());
        }
    }

    partial class IntervalableComparatorBySize : Java.Util.IComparator
    {
        int Java.Util.IComparator.Compare(Java.Lang.Object? o1, Java.Lang.Object? o2)
        {
            return Compare(o1.JavaCast<IIntervalable>(), o2.JavaCast<IIntervalable>());
        }
    }
}

// ReSharper disable once CheckNamespace
namespace Org.AhoCorasick.Trie
{
    partial class Payload : Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object? o1)
        {
            return CompareTo(o1.JavaCast<Payload>());
        }
    }

    partial class PayloadMatchToken
    {
        protected override PayloadEmit? RawEmit => Emit;
    }

    partial class PayloadFragmentToken
    {
        protected override PayloadEmit? RawEmit => Emit;
    }

    partial class PayloadEmit
    {

    }

    partial class PayloadEmit<T> : PayloadEmit
    {
        public PayloadEmit(int start, int end, string? keyword, Java.Lang.Object? payload) : base(start, end, keyword, payload)
        {
        }

        protected PayloadEmit(IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}

// ReSharper disable once CheckNamespace
namespace Org.AhoCorasick.Trie.Handler
{
    partial class AbstractStatefulPayloadEmitHandler
    {
        public abstract bool Emit(PayloadEmit? emit);
    }

    partial class AbstractStatefulPayloadEmitHandlerInvoker
    {
        public override unsafe bool Emit(PayloadEmit? emit)
        {
            const string __id = "emit.(Lorg/ahocorasick/trie/PayloadEmit;)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((emit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)emit).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
                global::System.GC.KeepAlive(emit);
            }
        }
    }

    partial class StatefulPayloadEmitDelegateHandler : IStatefulPayloadEmitHandler
    {
        IList? IStatefulPayloadEmitHandler.Emits
        {
            get
            {
                var value = Emits;
                if (value == null) return null;
                if (value is IList list) return list;
                return value.ToList();
            }
        }
    }

    partial interface IStatefulPayloadEmitHandler
    {

    }
}