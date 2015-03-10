using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Alerters {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncableActionAlerter']"
	[Register ("com/layer/sdk/internal/alerters/SyncableActionAlerter", "", "Com.Layer.Sdk.Internal.Alerters.ISyncableActionAlerterInvoker")]
	public partial interface ISyncableActionAlerter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncableActionAlerter']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "GetFHandler:Com.Layer.Sdk.Internal.Alerters.ISyncableActionAlerterInvoker, Layer")]
		void F ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/alerters/SyncableActionAlerter", DoNotGenerateAcw=true)]
	internal class ISyncableActionAlerterInvoker : global::Java.Lang.Object, ISyncableActionAlerter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/alerters/SyncableActionAlerter");
		IntPtr class_ref;

		public static ISyncableActionAlerter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableActionAlerter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.alerters.SyncableActionAlerter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableActionAlerterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableActionAlerterInvoker); }
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static void n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Alerters.ISyncableActionAlerter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Alerters.ISyncableActionAlerter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.F ();
		}
#pragma warning restore 0169

		IntPtr id_f;
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod (Handle, id_f);
		}

	}

}
