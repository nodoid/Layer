using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal']/interface[@name='MainThreadRunner']"
	[Register ("com/layer/sdk/internal/MainThreadRunner", "", "Com.Layer.Sdk.Internal.IMainThreadRunnerInvoker")]
	public partial interface IMainThreadRunner : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/interface[@name='MainThreadRunner']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("a", "(Ljava/lang/Runnable;)V", "GetA_Ljava_lang_Runnable_Handler:Com.Layer.Sdk.Internal.IMainThreadRunnerInvoker, Layer")]
		void A (global::Java.Lang.IRunnable p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/MainThreadRunner", DoNotGenerateAcw=true)]
	internal class IMainThreadRunnerInvoker : global::Java.Lang.Object, IMainThreadRunner {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/MainThreadRunner");
		IntPtr class_ref;

		public static IMainThreadRunner GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMainThreadRunner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.MainThreadRunner"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMainThreadRunnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMainThreadRunnerInvoker); }
		}

		static Delegate cb_a_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Runnable_Handler ()
		{
			if (cb_a_Ljava_lang_Runnable_ == null)
				cb_a_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Runnable_);
			return cb_a_Ljava_lang_Runnable_;
		}

		static void n_A_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.IMainThreadRunner __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.IMainThreadRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_Runnable_;
		public void A (global::Java.Lang.IRunnable p0)
		{
			if (id_a_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_a_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Runnable;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_Runnable_, new JValue (p0));
		}

	}

}
