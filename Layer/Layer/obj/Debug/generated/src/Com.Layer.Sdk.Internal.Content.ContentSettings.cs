using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentSettings", DoNotGenerateAcw=true)]
	public partial class ContentSettings : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Content.ISettings {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentSettings); }
		}

		protected ContentSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/constructor[@name='ContentSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ContentSettings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContentSettings)) {
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

		static IntPtr id_a_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_a_Ljava_util_Collection_ == IntPtr.Zero)
				id_a_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Internal.Content.ISettings __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_a_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='b' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("b", "(J)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings B (long p0)
		{
			if (id_b_J == IntPtr.Zero)
				id_b_J = JNIEnv.GetMethodID (class_ref, "b", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_b_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Set;", "")]
		public global::System.Collections.Generic.ICollection<string> C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()J", "")]
		public long D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentSettings']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()J", "")]
		public long E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_e);
		}

	}
}
