using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/UserAppCache", DoNotGenerateAcw=true)]
	public partial class UserAppCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/UserAppCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserAppCache); }
		}

		protected UserAppCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/constructor[@name='UserAppCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public UserAppCache (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserAppCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("a", "(Ljava/util/UUID;)V", "")]
		public void A (global::Java.Util.UUID p0)
		{
			if (id_a_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_UUID_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_b_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("b", "(Ljava/util/UUID;)V", "")]
		public void B (global::Java.Util.UUID p0)
		{
			if (id_b_Ljava_util_UUID_ == IntPtr.Zero)
				id_b_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/UUID;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_UUID_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='UserAppCache']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

	}
}
