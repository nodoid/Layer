using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/MessageRecipientImpl", DoNotGenerateAcw=true)]
	public partial class MessageRecipientImpl : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/MessageRecipientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageRecipientImpl); }
		}

		protected MessageRecipientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/constructor[@name='MessageRecipientImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MessageRecipientImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MessageRecipientImpl)) {
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

		static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/constructor[@name='MessageRecipientImpl' and count(parameter)=5 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.layer.sdk.messaging.Message.RecipientStatus'] and parameter[5][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V", "")]
		public MessageRecipientImpl (global::Java.Lang.Long p0, global::Java.Lang.Long p1, string p2, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus p3, global::Java.Lang.Integer p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (MessageRecipientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Message_RecipientStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message.RecipientStatus']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Message$RecipientStatus;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Message.RecipientStatus p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Message_RecipientStatus_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Message_RecipientStatus_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Message$RecipientStatus;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Message_RecipientStatus_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Integer;)V", "")]
		public void A (global::Java.Lang.Integer p0)
		{
			if (id_a_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/messaging/Message$RecipientStatus;", "")]
		public global::Com.Layer.Sdk.Messaging.Message.RecipientStatus D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/messaging/Message$RecipientStatus;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageRecipientImpl']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

	}
}
