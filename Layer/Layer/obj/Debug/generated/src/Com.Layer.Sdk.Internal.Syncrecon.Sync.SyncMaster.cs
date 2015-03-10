using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Sync
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster']"
    [global::Android.Runtime.Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster", DoNotGenerateAcw = true)]
    public partial class SyncMaster : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.Results']"
        [Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster$Results", "", "Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IResultsInvoker")]
        public partial interface IResults : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.Results']/method[@name='a' and count(parameter)=0]"
            [Register("a", "()Ljava/util/concurrent/atomic/AtomicInteger;", "GetAHandler:Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IResultsInvoker, Layer")]
            global::Java.Util.Concurrent.Atomic.AtomicInteger A();

            // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.Results']/method[@name='b' and count(parameter)=0]"
            [Register("b", "()Ljava/util/concurrent/atomic/AtomicInteger;", "GetBHandler:Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IResultsInvoker, Layer")]
            global::Java.Util.Concurrent.Atomic.AtomicInteger B();

        }

        [global::Android.Runtime.Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster$Results", DoNotGenerateAcw = true)]
        internal class IResultsInvoker : global::Java.Lang.Object, IResults
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/layer/sdk/internal/syncrecon/sync/SyncMaster$Results");
            IntPtr class_ref;

            public static IResults GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IResults>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                            JNIEnv.GetClassNameFromInstance(handle), "com.layer.sdk.internal.syncrecon.sync.SyncMaster.Results"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IResultsInvoker(IntPtr handle, JniHandleOwnership transfer)
                : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override System.Type ThresholdType
            {
                get { return typeof(IResultsInvoker); }
            }

            static Delegate cb_a;
            #pragma warning disable 0169
            static Delegate GetAHandler()
            {
                if (cb_a == null)
                    cb_a = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_A);
                return cb_a;
            }

            static IntPtr n_A(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IResults __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IResults>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.A());
            }
            #pragma warning restore 0169

            IntPtr id_a;

            public global::Java.Util.Concurrent.Atomic.AtomicInteger A()
            {
                if (id_a == IntPtr.Zero)
                    id_a = JNIEnv.GetMethodID(class_ref, "a", "()Ljava/util/concurrent/atomic/AtomicInteger;");
                return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger>(JNIEnv.CallObjectMethod(Handle, id_a), JniHandleOwnership.TransferLocalRef);
            }

            static Delegate cb_b;
            #pragma warning disable 0169
            static Delegate GetBHandler()
            {
                if (cb_b == null)
                    cb_b = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_B);
                return cb_b;
            }

            static IntPtr n_B(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IResults __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IResults>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.B());
            }
            #pragma warning restore 0169

            IntPtr id_b;

            public global::Java.Util.Concurrent.Atomic.AtomicInteger B()
            {
                if (id_b == IntPtr.Zero)
                    id_b = JNIEnv.GetMethodID(class_ref, "b", "()Ljava/util/concurrent/atomic/AtomicInteger;");
                return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger>(JNIEnv.CallObjectMethod(Handle, id_b), JniHandleOwnership.TransferLocalRef);
            }

        }


        // Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']"
        [global::Android.Runtime.Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster$State", DoNotGenerateAcw = true)]
        public sealed partial class State : global::Java.Lang.Enum
        {


            static IntPtr b_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='b']"
            [Register("b")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State B
            {
                get
                {
                    if (b_jfieldId == IntPtr.Zero)
                        b_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, b_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (b_jfieldId == IntPtr.Zero)
                        b_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, b_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr c_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='c']"
            [Register("c")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State C
            {
                get
                {
                    if (c_jfieldId == IntPtr.Zero)
                        c_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, c_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (c_jfieldId == IntPtr.Zero)
                        c_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, c_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr d_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='d']"
            [Register("d")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State D
            {
                get
                {
                    if (d_jfieldId == IntPtr.Zero)
                        d_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "d", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, d_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (d_jfieldId == IntPtr.Zero)
                        d_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "d", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, d_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr e_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='e']"
            [Register("e")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State E
            {
                get
                {
                    if (e_jfieldId == IntPtr.Zero)
                        e_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "e", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, e_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (e_jfieldId == IntPtr.Zero)
                        e_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "e", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, e_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr f_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='f']"
            [Register("f")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State F
            {
                get
                {
                    if (f_jfieldId == IntPtr.Zero)
                        f_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "f", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, f_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (f_jfieldId == IntPtr.Zero)
                        f_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "f", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, f_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr g_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='g']"
            [Register("g")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State G
            {
                get
                {
                    if (g_jfieldId == IntPtr.Zero)
                        g_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "g", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, g_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (g_jfieldId == IntPtr.Zero)
                        g_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "g", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, g_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr h_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='h']"
            [Register("h")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State H
            {
                get
                {
                    if (h_jfieldId == IntPtr.Zero)
                        h_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "h", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, h_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (h_jfieldId == IntPtr.Zero)
                        h_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "h", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, h_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr i_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='i']"
            [Register("i")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State I
            {
                get
                {
                    if (i_jfieldId == IntPtr.Zero)
                        i_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "i", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, i_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (i_jfieldId == IntPtr.Zero)
                        i_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "i", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, i_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr j_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='j']"
            [Register("j")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State J
            {
                get
                {
                    if (j_jfieldId == IntPtr.Zero)
                        j_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "j", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, j_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (j_jfieldId == IntPtr.Zero)
                        j_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "j", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, j_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr k_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='k']"
            [Register("k")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State K
            {
                get
                {
                    if (k_jfieldId == IntPtr.Zero)
                        k_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "k", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, k_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (k_jfieldId == IntPtr.Zero)
                        k_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "k", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, k_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr l_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='l']"
            [Register("l")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State L
            {
                get
                {
                    if (l_jfieldId == IntPtr.Zero)
                        l_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "l", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, l_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (l_jfieldId == IntPtr.Zero)
                        l_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "l", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, l_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr m_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='m']"
            [Register("m")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State M
            {
                get
                {
                    if (m_jfieldId == IntPtr.Zero)
                        m_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "m", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, m_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (m_jfieldId == IntPtr.Zero)
                        m_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "m", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, m_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            static IntPtr n_jfieldId;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/field[@name='n']"
            [Register("n")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State N
            {
                get
                {
                    if (n_jfieldId == IntPtr.Zero)
                        n_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "n", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, n_jfieldId);
                    return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(__ret, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    if (n_jfieldId == IntPtr.Zero)
                        n_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "n", "Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                    IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
                    JNIEnv.SetStaticField(class_ref, n_jfieldId, native_value);
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }

            internal static IntPtr java_class_handle;

            internal static IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/layer/sdk/internal/syncrecon/sync/SyncMaster$State", ref java_class_handle);
                }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(State); }
            }

            internal State(IntPtr javaReference, JniHandleOwnership transfer)
                : base(javaReference, transfer)
            {
            }

            static IntPtr id_a;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster.State']/method[@name='a' and count(parameter)=0]"
            [Register("a", "()[Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;", "")]
            public static global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State[] A()
            {
                if (id_a == IntPtr.Zero)
                    id_a = JNIEnv.GetStaticMethodID(class_ref, "a", "()[Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;");
                return (global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State[])JNIEnv.GetArray(JNIEnv.CallStaticObjectMethod(class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State));
            }

        }

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.StateListener']"
        [Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster$StateListener", "", "Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IStateListenerInvoker")]
        public partial interface IStateListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.StateListener']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.syncrecon.sync.SyncMaster'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.sync.SyncError']]"
            [Register("a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;Lcom/layer/sdk/internal/syncrecon/sync/SyncError;)V", "GetA_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_Handler:Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IStateListenerInvoker, Layer")]
            void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='SyncMaster.StateListener']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.syncrecon.sync.SyncMaster'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.sync.SyncMaster.State']]"
            [Register("a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;)V", "GetA_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_Handler:Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster/IStateListenerInvoker, Layer")]
            void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p1);

        }

        [global::Android.Runtime.Register("com/layer/sdk/internal/syncrecon/sync/SyncMaster$StateListener", DoNotGenerateAcw = true)]
        internal class IStateListenerInvoker : global::Java.Lang.Object, IStateListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/layer/sdk/internal/syncrecon/sync/SyncMaster$StateListener");
            IntPtr class_ref;

            public static IStateListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IStateListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                            JNIEnv.GetClassNameFromInstance(handle), "com.layer.sdk.internal.syncrecon.sync.SyncMaster.StateListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IStateListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
                : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override System.Type ThresholdType
            {
                get { return typeof(IStateListenerInvoker); }
            }

            static Delegate cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_;
            #pragma warning disable 0169
            static Delegate GetA_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_Handler()
            {
                if (cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_ == null)
                    cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_A_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_);
                return cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_;
            }

            static void n_A_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
            {
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IStateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster>(native_p0, JniHandleOwnership.DoNotTransfer);
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError>(native_p1, JniHandleOwnership.DoNotTransfer);
                __this.A(p0, p1);
            }
            #pragma warning restore 0169

            IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_;

            public void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1)
            {
                if (id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_ == IntPtr.Zero)
                    id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_ = JNIEnv.GetMethodID(class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;Lcom/layer/sdk/internal/syncrecon/sync/SyncError;)V");
                JNIEnv.CallVoidMethod(Handle, id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncError_, new JValue(p0), new JValue(p1));
            }

            static Delegate cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_;
            #pragma warning disable 0169
            static Delegate GetA_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_Handler()
            {
                if (cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_ == null)
                    cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_A_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_);
                return cb_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_;
            }

            static void n_A_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
            {
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IStateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster>(native_p0, JniHandleOwnership.DoNotTransfer);
                global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State>(native_p1, JniHandleOwnership.DoNotTransfer);
                __this.A(p0, p1);
            }
            #pragma warning restore 0169

            IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_;

            public void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p1)
            {
                if (id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_ == IntPtr.Zero)
                    id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_ = JNIEnv.GetMethodID(class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$State;)V");
                JNIEnv.CallVoidMethod(Handle, id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_State_, new JValue(p0), new JValue(p1));
            }

        }

        public partial class AEventArgs : global::System.EventArgs
        {

            public AEventArgs(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0;

            public global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster P0
            {
                get { return p0; }
            }

            global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1;

            public global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError P1
            {
                get { return p1; }
            }
        }

        public partial class AEventArgs : global::System.EventArgs
        {

            public AEventArgs(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p1)
            {
                this.p2 = p0;
                this.p3 = p1;
            }

            global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p2;

            public global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster P2
            {
                get { return p2; }
            }

            global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p3;

            public global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State P3
            {
                get { return this.p3; }
            }
        }

        [global::Android.Runtime.Register("mono/com/layer/sdk/internal/syncrecon/sync/SyncMaster_StateListenerImplementor")]
        internal sealed class IStateListenerImplementor : global::Java.Lang.Object, IStateListener
        {

            object sender;

            public IStateListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/layer/sdk/internal/syncrecon/sync/SyncMaster_StateListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(Handle, "()V");
                this.sender = sender;
            }

            #pragma warning disable 0649
            public EventHandler<AEventArgs> AHandler;
            #pragma warning restore 0649

            public void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncError p1)
            {
                var __h = AHandler;
                if (__h != null)
                    __h(sender, new AEventArgs(p0, p1));
            }
            /*#pragma warning disable 0649
			public EventHandler<AEventArgs> AHandler;
#pragma warning restore 0649*/

            public void A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster p0, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.State p1)
            {
                var __h = AHandler;
                if (__h != null)
                    __h(sender, new AEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IStateListenerImplementor value)
            {
                return value.AHandler == null && value.AHandler == null;
            }
        }


        internal static IntPtr java_class_handle;

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/layer/sdk/internal/syncrecon/sync/SyncMaster", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(SyncMaster); }
        }

        protected SyncMaster(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        static IntPtr id_a;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster']/method[@name='a' and count(parameter)=0]"
        [Register("a", "()V", "")]
        public void A()
        {
            if (id_a == IntPtr.Zero)
                id_a = JNIEnv.GetMethodID(class_ref, "a", "()V");
            JNIEnv.CallVoidMethod(Handle, id_a);
        }

        static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_StateListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncMaster']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.sync.SyncMaster.StateListener']]"
        [Register("a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$StateListener;)Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;", "")]
        public global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster A(global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IStateListener p0)
        {
            if (id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_StateListener_ == IntPtr.Zero)
                id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_StateListener_ = JNIEnv.GetMethodID(class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster$StateListener;)Lcom/layer/sdk/internal/syncrecon/sync/SyncMaster;");
            global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster>(JNIEnv.CallObjectMethod(Handle, id_a_Lcom_layer_sdk_internal_syncrecon_sync_SyncMaster_StateListener_, new JValue(p0)), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

    }
}
