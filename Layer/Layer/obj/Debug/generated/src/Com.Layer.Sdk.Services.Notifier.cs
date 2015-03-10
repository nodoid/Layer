using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier']"
	[global::Android.Runtime.Register ("com/layer/sdk/services/Notifier", DoNotGenerateAcw=true)]
	public abstract partial class Notifier : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']"
		[global::Android.Runtime.Register ("com/layer/sdk/services/Notifier$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Enum {


			static IntPtr CONVERSATION_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='CONVERSATION_ID']"
			[Register ("CONVERSATION_ID")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key ConversationId {
				get {
					if (CONVERSATION_ID_jfieldId == IntPtr.Zero)
						CONVERSATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONVERSATION_ID_jfieldId == IntPtr.Zero)
						CONVERSATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONVERSATION_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='MESSAGE_ID']"
			[Register ("MESSAGE_ID")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key MessageId {
				get {
					if (MESSAGE_ID_jfieldId == IntPtr.Zero)
						MESSAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_ID_jfieldId == IntPtr.Zero)
						MESSAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='SOUND']"
			[Register ("SOUND")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key Sound {
				get {
					if (SOUND_jfieldId == IntPtr.Zero)
						SOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOUND", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SOUND_jfieldId == IntPtr.Zero)
						SOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOUND", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SOURCE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='SOURCE']"
			[Register ("SOURCE")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key Source {
				get {
					if (SOURCE_jfieldId == IntPtr.Zero)
						SOURCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOURCE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SOURCE_jfieldId == IntPtr.Zero)
						SOURCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SOURCE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr USER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/field[@name='USER_ID']"
			[Register ("USER_ID")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key UserId {
				get {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/layer/sdk/services/Notifier$Key;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, USER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/services/Notifier$Key", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Key); }
			}

			internal Key (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/Notifier$Key;", "")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/Notifier$Key;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Services.Notifier.Key __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Key> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Key']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/services/Notifier$Key;", "")]
			public static global::Com.Layer.Sdk.Services.Notifier.Key[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/services/Notifier$Key;");
				return (global::Com.Layer.Sdk.Services.Notifier.Key[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Services.Notifier.Key));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']"
		[global::Android.Runtime.Register ("com/layer/sdk/services/Notifier$Origin", DoNotGenerateAcw=true)]
		public sealed partial class Origin : global::Java.Lang.Enum {


			static IntPtr GCM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/field[@name='GCM']"
			[Register ("GCM")]
			public static global::Com.Layer.Sdk.Services.Notifier.Origin Gcm {
				get {
					if (GCM_jfieldId == IntPtr.Zero)
						GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/layer/sdk/services/Notifier$Origin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GCM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GCM_jfieldId == IntPtr.Zero)
						GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/layer/sdk/services/Notifier$Origin;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GCM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LAYER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/field[@name='LAYER']"
			[Register ("LAYER")]
			public static global::Com.Layer.Sdk.Services.Notifier.Origin Layer {
				get {
					if (LAYER_jfieldId == IntPtr.Zero)
						LAYER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAYER", "Lcom/layer/sdk/services/Notifier$Origin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAYER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LAYER_jfieldId == IntPtr.Zero)
						LAYER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAYER", "Lcom/layer/sdk/services/Notifier$Origin;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LAYER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/services/Notifier$Origin", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Origin); }
			}

			internal Origin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/Notifier$Origin;", "")]
			public static global::Com.Layer.Sdk.Services.Notifier.Origin ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/Notifier$Origin;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Services.Notifier.Origin __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.Notifier.Origin> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier.Origin']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/services/Notifier$Origin;", "")]
			public static global::Com.Layer.Sdk.Services.Notifier.Origin[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/services/Notifier$Origin;");
				return (global::Com.Layer.Sdk.Services.Notifier.Origin[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Services.Notifier.Origin));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/services/Notifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Notifier); }
		}

		protected Notifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_broadcastPush_Landroid_content_Context_Ljava_util_UUID_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Lcom_layer_sdk_services_Notifier_Origin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='Notifier']/method[@name='broadcastPush' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='android.net.Uri'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.layer.sdk.services.Notifier.Origin']]"
		[Register ("broadcastPush", "(Landroid/content/Context;Ljava/util/UUID;Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Lcom/layer/sdk/services/Notifier$Origin;)V", "")]
		public static void BroadcastPush (global::Android.Content.Context p0, global::Java.Util.UUID p1, global::Android.Net.Uri p2, global::Android.Net.Uri p3, string p4, string p5, global::Com.Layer.Sdk.Services.Notifier.Origin p6)
		{
			if (id_broadcastPush_Landroid_content_Context_Ljava_util_UUID_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Lcom_layer_sdk_services_Notifier_Origin_ == IntPtr.Zero)
				id_broadcastPush_Landroid_content_Context_Ljava_util_UUID_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Lcom_layer_sdk_services_Notifier_Origin_ = JNIEnv.GetStaticMethodID (class_ref, "broadcastPush", "(Landroid/content/Context;Ljava/util/UUID;Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Lcom/layer/sdk/services/Notifier$Origin;)V");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_broadcastPush_Landroid_content_Context_Ljava_util_UUID_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Lcom_layer_sdk_services_Notifier_Origin_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6));
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}

	[global::Android.Runtime.Register ("com/layer/sdk/services/Notifier", DoNotGenerateAcw=true)]
	internal partial class NotifierInvoker : Notifier {

		public NotifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotifierInvoker); }
		}

	}

}
