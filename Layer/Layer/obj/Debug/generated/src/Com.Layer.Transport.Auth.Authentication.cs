using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']"
	[global::Android.Runtime.Register ("com/layer/transport/auth/Authentication", DoNotGenerateAcw=true)]
	public sealed partial class Authentication : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']"
		[global::Android.Runtime.Register ("com/layer/transport/auth/Authentication$Session", DoNotGenerateAcw=true)]
		public partial class Session : global::Java.Lang.Object, global::Java.IO.ISerializable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/auth/Authentication$Session", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Session); }
			}

			protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_UUID_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']/constructor[@name='Authentication.Session' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date']]"
			[Register (".ctor", "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", "")]
			public Session (global::Java.Util.UUID p0, string p1, string p2, global::Java.Util.Date p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (Session)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Ljava_util_UUID_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
					id_ctor_Ljava_util_UUID_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_UUID_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_UUID_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/util/UUID;", "")]
			public global::Java.Util.UUID A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/UUID;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/String;", "")]
			public string B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Ljava/lang/String;", "")]
			public string C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication.Session']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()Ljava/util/Date;", "")]
			public global::Java.Util.Date D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/auth/Authentication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Authentication); }
		}

		internal Authentication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "")]
		public void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/transport/auth/Authentication$Session;", "")]
		public global::Com.Layer.Transport.Auth.Authentication.Session D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/transport/auth/Authentication$Session;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Auth.Authentication.Session> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.auth']/class[@name='Authentication']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_f);
		}

	}
}
