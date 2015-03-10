using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Timer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/timer/Repeater", DoNotGenerateAcw=true)]
	public abstract partial class Repeater : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/timer/Repeater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Repeater); }
		}

		protected Repeater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']/constructor[@name='Repeater' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor']]"
		[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;)V", "")]
		public Repeater (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Repeater)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_ == IntPtr.Zero)
				id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "")]
		public void A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_J, new JValue (p0));
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Utils.Timer.Repeater __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Timer.Repeater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public abstract void Run ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/timer/Repeater", DoNotGenerateAcw=true)]
	internal partial class RepeaterInvoker : Repeater {

		public RepeaterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeaterInvoker); }
		}

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.timer']/class[@name='Repeater']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public override void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_run);
		}

	}

}
