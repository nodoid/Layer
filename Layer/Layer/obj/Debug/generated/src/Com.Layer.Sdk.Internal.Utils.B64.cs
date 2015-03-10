using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='B64']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/B64", DoNotGenerateAcw=true)]
	public partial class B64 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/B64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (B64); }
		}

		protected B64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='B64']/constructor[@name='B64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public B64 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (B64)) {
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

		static IntPtr id_a_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='B64']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)Ljava/lang/String;", "")]
		public static string A (byte[] p0)
		{
			if (id_a_arrayB == IntPtr.Zero)
				id_a_arrayB = JNIEnv.GetStaticMethodID (class_ref, "a", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='B64']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)[B", "")]
		public static byte[] A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
