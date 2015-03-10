using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Push {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.push']/interface[@name='TestPushAlerter']"
	[Register ("com/layer/sdk/internal/push/TestPushAlerter", "", "Com.Layer.Sdk.Internal.Push.ITestPushAlerterInvoker")]
	public partial interface ITestPushAlerter : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/push/TestPushAlerter", DoNotGenerateAcw=true)]
	internal class ITestPushAlerterInvoker : global::Java.Lang.Object, ITestPushAlerter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/push/TestPushAlerter");
		IntPtr class_ref;

		public static ITestPushAlerter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPushAlerter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.push.TestPushAlerter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPushAlerterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITestPushAlerterInvoker); }
		}

	}

}
