using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='CancelCallback']"
	[Register ("com/layer/sdk/internal/syncrecon/CancelCallback", "", "Com.Layer.Sdk.Internal.Syncrecon.ICancelCallbackInvoker")]
	public partial interface ICancelCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='CancelCallback']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler:Com.Layer.Sdk.Internal.Syncrecon.ICancelCallbackInvoker, Layer")]
		bool A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='CancelCallback']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler:Com.Layer.Sdk.Internal.Syncrecon.ICancelCallbackInvoker, Layer")]
		void B ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/CancelCallback", DoNotGenerateAcw=true)]
	internal class ICancelCallbackInvoker : global::Java.Lang.Object, ICancelCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/CancelCallback");
		IntPtr class_ref;

		public static ICancelCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancelCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.CancelCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancelCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICancelCallbackInvoker); }
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Syncrecon.ICancelCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.ICancelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		IntPtr id_a;
		public bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_a);
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Syncrecon.ICancelCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.ICancelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		IntPtr id_b;
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod (Handle, id_b);
		}

	}

}
