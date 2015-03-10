using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='TimeLog']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/TimeLog", DoNotGenerateAcw=true)]
	public partial class TimeLog : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='TimeLog.Entry']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/TimeLog$Entry", DoNotGenerateAcw=true)]
		public partial class Entry : global::Java.Lang.Object {

			protected Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/TimeLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeLog); }
		}

		protected TimeLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='TimeLog']/constructor[@name='TimeLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TimeLog () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TimeLog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
