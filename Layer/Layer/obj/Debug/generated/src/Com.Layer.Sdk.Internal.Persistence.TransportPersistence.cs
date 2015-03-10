using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='TransportPersistence']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/TransportPersistence", DoNotGenerateAcw=true)]
	public partial class TransportPersistence : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/TransportPersistence", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransportPersistence); }
		}

		protected TransportPersistence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='TransportPersistence']/constructor[@name='TransportPersistence' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public TransportPersistence (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TransportPersistence)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='TransportPersistence']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()[Ljava/security/PublicKey;", "")]
		public global::Java.Security.IPublicKey[] A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()[Ljava/security/PublicKey;");
			return (global::Java.Security.IPublicKey[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.IPublicKey));
		}

		static IntPtr id_a_Lcom_layer_transport_auth_Authentication_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='TransportPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.transport.auth.Authentication.Session']]"
		[Register ("a", "(Lcom/layer/transport/auth/Authentication$Session;)V", "")]
		public void A (global::Com.Layer.Transport.Auth.Authentication.Session p0)
		{
			if (id_a_Lcom_layer_transport_auth_Authentication_Session_ == IntPtr.Zero)
				id_a_Lcom_layer_transport_auth_Authentication_Session_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/transport/auth/Authentication$Session;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_transport_auth_Authentication_Session_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='TransportPersistence']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/transport/auth/Authentication$Session;", "")]
		public global::Com.Layer.Transport.Auth.Authentication.Session B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/transport/auth/Authentication$Session;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Auth.Authentication.Session> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

	}
}
