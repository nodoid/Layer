using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Alerters {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='ConfigAlerter']"
	[Register ("com/layer/sdk/internal/alerters/ConfigAlerter", "", "Com.Layer.Sdk.Internal.Alerters.IConfigAlerterInvoker")]
	public partial interface IConfigAlerter : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/alerters/ConfigAlerter", DoNotGenerateAcw=true)]
	internal class IConfigAlerterInvoker : global::Java.Lang.Object, IConfigAlerter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/alerters/ConfigAlerter");
		IntPtr class_ref;

		public static IConfigAlerter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigAlerter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.alerters.ConfigAlerter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigAlerterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IConfigAlerterInvoker); }
		}

	}

}
