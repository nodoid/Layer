using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='DeviceUtils']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/DeviceUtils", DoNotGenerateAcw=true)]
	public partial class DeviceUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/DeviceUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceUtils); }
		}

		protected DeviceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='DeviceUtils']/constructor[@name='DeviceUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceUtils)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='DeviceUtils']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public static string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='DeviceUtils']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='DeviceUtils']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
