using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Logging", DoNotGenerateAcw=true)]
	public partial class Logging : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Logging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logging); }
		}

		protected Logging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public static void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a);
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public static void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_LayerClient_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.LogLevel']]"
		[Register ("a", "(Lcom/layer/sdk/LayerClient$LogLevel;)V", "")]
		public static void A (global::Com.Layer.Sdk.LayerClient.LogLevel p0)
		{
			if (id_a_Lcom_layer_sdk_LayerClient_LogLevel_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_LayerClient_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/LayerClient$LogLevel;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lcom_layer_sdk_LayerClient_LogLevel_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='android.app.Activity']]"
		[Register ("a", "(Lcom/layer/sdk/LayerClient;Landroid/app/Activity;)V", "")]
		public static void A (global::Com.Layer.Sdk.LayerClient p0, global::Android.App.Activity p1)
		{
			if (id_a_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/LayerClient;Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(ILjava/lang/String;)V", "")]
		public static void A (int p0, string p1)
		{
			if (id_a_ILjava_lang_String_ == IntPtr.Zero)
				id_a_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public static void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static void A (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/Throwable;)V", "")]
		public static void A (global::Java.Lang.Throwable p0)
		{
			if (id_a_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public static void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetStaticMethodID (class_ref, "b", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b);
		}

		static IntPtr id_b_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("b", "(Ljava/lang/Throwable;)V", "")]
		public static void B (global::Java.Lang.Throwable p0)
		{
			if (id_b_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_b_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Logging']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("c", "(Ljava/lang/Throwable;)Z", "")]
		public static bool C (global::Java.Lang.Throwable p0)
		{
			if (id_c_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_c_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/Throwable;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_c_Ljava_lang_Throwable_, new JValue (p0));
			return __ret;
		}

	}
}
