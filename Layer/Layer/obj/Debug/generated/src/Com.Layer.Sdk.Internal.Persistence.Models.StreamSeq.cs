using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/models/StreamSeq", DoNotGenerateAcw=true)]
	public partial class StreamSeq : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/models/StreamSeq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamSeq); }
		}

		protected StreamSeq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_UUID_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/constructor[@name='StreamSeq' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/util/UUID;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V", "")]
		public StreamSeq (global::Java.Util.UUID p0, global::Java.Lang.Long p1, global::Java.Lang.Integer p2, global::Java.Lang.Integer p3, global::Java.Lang.Integer p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StreamSeq)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/UUID;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/UUID;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Ljava_util_UUID_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_ctor_Ljava_util_UUID_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/UUID;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_UUID_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_UUID_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Integer;)V", "")]
		public void A (global::Java.Lang.Integer p0)
		{
			if (id_a_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("b", "(Ljava/lang/Integer;)V", "")]
		public void B (global::Java.Lang.Integer p0)
		{
			if (id_b_Ljava_lang_Integer_ == IntPtr.Zero)
				id_b_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.models']/class[@name='StreamSeq']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

	}
}
