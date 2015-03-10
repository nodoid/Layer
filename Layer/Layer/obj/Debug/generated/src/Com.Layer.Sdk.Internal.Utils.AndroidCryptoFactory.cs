using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/AndroidCryptoFactory", DoNotGenerateAcw=true)]
	public partial class AndroidCryptoFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/AndroidCryptoFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidCryptoFactory); }
		}

		protected AndroidCryptoFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/constructor[@name='AndroidCryptoFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AndroidCryptoFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AndroidCryptoFactory)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/security/KeyFactory;", "")]
		public global::Java.Security.KeyFactory A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/security/KeyFactory;");
			return global::Java.Lang.Object.GetObject<global::Java.Security.KeyFactory> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/security/KeyStore;", "")]
		public global::Java.Security.KeyStore B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/security/KeyStore;");
			return global::Java.Lang.Object.GetObject<global::Java.Security.KeyStore> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljavax/net/ssl/KeyManagerFactory;", "")]
		public global::Javax.Net.Ssl.KeyManagerFactory C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljavax/net/ssl/KeyManagerFactory;");
			return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.KeyManagerFactory> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/security/KeyPairGenerator;", "")]
		public global::Java.Security.KeyPairGenerator D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/security/KeyPairGenerator;");
			return global::Java.Lang.Object.GetObject<global::Java.Security.KeyPairGenerator> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AndroidCryptoFactory']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/security/cert/CertificateFactory;", "")]
		public global::Java.Security.Cert.CertificateFactory E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/security/cert/CertificateFactory;");
			return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.CertificateFactory> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

	}
}
