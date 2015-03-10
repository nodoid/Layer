using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableUri", DoNotGenerateAcw=true)]
	public partial class ChangeableUri : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri.UriTemplate']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableUri$UriTemplate", DoNotGenerateAcw=true)]
		public sealed partial class UriTemplate : global::Java.Lang.Enum {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableUri$UriTemplate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UriTemplate); }
			}

			internal UriTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri.UriTemplate']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;");
				return (global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate));
			}

			static IntPtr id_a_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri.UriTemplate']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("a", "(I)Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate A (int p0)
			{
				if (id_a_I == IntPtr.Zero)
					id_a_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(I)Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri.UriTemplate']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/String;", "")]
			public string B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri.UriTemplate']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Lcom/layer/sdk/messaging/LayerObject$Type;", "")]
			public global::Com.Layer.Sdk.Messaging.LayerObjectType C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/messaging/LayerObject$Type;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableUri", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableUri); }
		}

		protected ChangeableUri (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/constructor[@name='ChangeableUri' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ChangeableUri () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChangeableUri)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Landroid/net/Uri;");
			return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/ChangeableUri$UriTemplate;");
			global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableUri.UriTemplate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_net_Uri_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("a", "(Landroid/net/Uri;Ljava/lang/Integer;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri A (global::Android.Net.Uri p0, global::Java.Lang.Integer p1)
		{
			if (id_a_Landroid_net_Uri_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/net/Uri;Ljava/lang/Integer;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_net_Uri_Ljava_lang_Integer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetStaticMethodID (class_ref, "b", "()Landroid/net/Uri;");
			return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableUri']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("b", "(Landroid/net/Uri;)Ljava/util/UUID;", "")]
		public static global::Java.Util.UUID B (global::Android.Net.Uri p0)
		{
			if (id_b_Landroid_net_Uri_ == IntPtr.Zero)
				id_b_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/net/Uri;)Ljava/util/UUID;");
			global::Java.Util.UUID __ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
