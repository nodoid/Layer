using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Sync {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='ProgressListener']"
	[Register ("com/layer/sdk/internal/syncrecon/sync/ProgressListener", "", "Com.Layer.Sdk.Internal.Syncrecon.Sync.IProgressListenerInvoker")]
	public partial interface IProgressListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/sync/ProgressListener", DoNotGenerateAcw=true)]
	internal class IProgressListenerInvoker : global::Java.Lang.Object, IProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/sync/ProgressListener");
		IntPtr class_ref;

		public static IProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.sync.ProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IProgressListenerInvoker); }
		}

	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/internal/syncrecon/sync/ProgressListenerImplementor")]
	internal sealed class IProgressListenerImplementor : global::Java.Lang.Object, IProgressListener {

		public IProgressListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/internal/syncrecon/sync/ProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
		}


		internal static bool __IsEmpty (IProgressListenerImplementor value)
		{
			return true;
		}
	}

}
