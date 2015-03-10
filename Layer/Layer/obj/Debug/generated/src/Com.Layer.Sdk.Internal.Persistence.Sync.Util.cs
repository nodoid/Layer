using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Util () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Util)) {
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

		static IntPtr id_a_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Util']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("a", "(Ljava/util/UUID;)Ljava/lang/String;", "")]
		public static string A (global::Java.Util.UUID p0)
		{
			if (id_a_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/UUID;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_UUID_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
