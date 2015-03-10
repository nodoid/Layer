using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/ConversationImpl", DoNotGenerateAcw=true)]
	public partial class ConversationImpl : global::Com.Layer.Sdk.Messaging.Conversation, global::Com.Layer.Sdk.Internal.Messaging.IChangeable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/ConversationImpl$Attribute", DoNotGenerateAcw=true)]
		public sealed partial class Attribute : global::Java.Lang.Enum, global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute {


			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/field[@name='e']"
			[Register ("e")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr f_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/field[@name='f']"
			[Register ("f")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute F {
				get {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/field[@name='g']"
			[Register ("g")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr h_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/field[@name='h']"
			[Register ("h")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute H {
				get {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, h_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, h_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/ConversationImpl$Attribute", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attribute); }
			}

			internal Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;", "")]
			public global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Z", "")]
			public bool C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_c);
			}

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()[Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute[] D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetStaticMethodID (class_ref, "d", "()[Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Attribute;");
				return (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_d), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Attribute));
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Attribute']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Config']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/ConversationImpl$Config", DoNotGenerateAcw=true)]
		public sealed partial class Config : global::Java.Lang.Enum {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/ConversationImpl$Config", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Config); }
			}

			internal Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl.Config']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Config;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Config[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/messaging/models/ConversationImpl$Config;");
				return (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Config[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl.Config));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/ConversationImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationImpl); }
		}

		protected ConversationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/constructor[@name='ConversationImpl' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Long']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/Long;)V", "")]
		public ConversationImpl (global::Android.Net.Uri p0, global::Java.Lang.Long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConversationImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_net_Uri_Ljava_lang_Long_ == IntPtr.Zero)
				id_ctor_Landroid_net_Uri_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/lang/Long;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Long_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/constructor[@name='ConversationImpl' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.ConversationOptions'] and parameter[2][@type='java.util.List']]"
		[Register (".ctor", "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)V", "")]
		public ConversationImpl (global::Com.Layer.Sdk.Messaging.ConversationOptions p0, global::System.Collections.Generic.IList<string> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (ConversationImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isDeleted;
#pragma warning disable 0169
		static Delegate GetIsDeletedHandler ()
		{
			if (cb_isDeleted == null)
				cb_isDeleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeleted);
			return cb_isDeleted;
		}

		static bool n_IsDeleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		static IntPtr id_isDeleted;
		public override bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")]
			get {
				if (id_isDeleted == IntPtr.Zero)
					id_isDeleted = JNIEnv.GetMethodID (class_ref, "isDeleted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDeleted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeleted", "()Z"));
			}
		}

		static Delegate cb_isDeliveryReceiptsEnabled;
#pragma warning disable 0169
		static Delegate GetIsDeliveryReceiptsEnabledHandler ()
		{
			if (cb_isDeliveryReceiptsEnabled == null)
				cb_isDeliveryReceiptsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeliveryReceiptsEnabled);
			return cb_isDeliveryReceiptsEnabled;
		}

		static bool n_IsDeliveryReceiptsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeliveryReceiptsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isDeliveryReceiptsEnabled;
		public override bool IsDeliveryReceiptsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='isDeliveryReceiptsEnabled' and count(parameter)=0]"
			[Register ("isDeliveryReceiptsEnabled", "()Z", "GetIsDeliveryReceiptsEnabledHandler")]
			get {
				if (id_isDeliveryReceiptsEnabled == IntPtr.Zero)
					id_isDeliveryReceiptsEnabled = JNIEnv.GetMethodID (class_ref, "isDeliveryReceiptsEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDeliveryReceiptsEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeliveryReceiptsEnabled", "()Z"));
			}
		}

		static Delegate cb_getLastMessage;
#pragma warning disable 0169
		static Delegate GetGetLastMessageHandler ()
		{
			if (cb_getLastMessage == null)
				cb_getLastMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastMessage);
			return cb_getLastMessage;
		}

		static IntPtr n_GetLastMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getLastMessage;
		public override global::Com.Layer.Sdk.Messaging.Message LastMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='getLastMessage' and count(parameter)=0]"
			[Register ("getLastMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetLastMessageHandler")]
			get {
				if (id_getLastMessage == IntPtr.Zero)
					id_getLastMessage = JNIEnv.GetMethodID (class_ref, "getLastMessage", "()Lcom/layer/sdk/messaging/Message;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_getLastMessage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastMessage", "()Lcom/layer/sdk/messaging/Message;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		public override global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParticipants;
#pragma warning disable 0169
		static Delegate GetGetParticipantsHandler ()
		{
			if (cb_getParticipants == null)
				cb_getParticipants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParticipants);
			return cb_getParticipants;
		}

		static IntPtr n_GetParticipants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Participants);
		}
#pragma warning restore 0169

		static IntPtr id_getParticipants;
		public override global::System.Collections.Generic.IList<string> Participants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='getParticipants' and count(parameter)=0]"
			[Register ("getParticipants", "()Ljava/util/List;", "GetGetParticipantsHandler")]
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParticipants", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/Queue;", "")]
		public global::Java.Util.IQueue A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/Queue;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_Change_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Change;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Message;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Integer;)V", "")]
		public void A (global::Java.Lang.Integer p0)
		{
			if (id_a_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public global::Java.Lang.Object A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.layer.sdk.internal.utils.Metadata.Value']]"
		[Register ("a", "(Ljava/lang/String;Lcom/layer/sdk/internal/utils/Metadata$Value;)Ljava/lang/Object;", "")]
		public global::Java.Lang.Object A (string p0, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value p1)
		{
			if (id_a_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/layer/sdk/internal/utils/Metadata$Value;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "")]
		public void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)V", "")]
		public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='boolean']]"
		[Register ("a", "(Ljava/util/Map;Z)V", "")]
		public void A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, bool p1)
		{
			if (id_a_Ljava_util_Map_Z == IntPtr.Zero)
				id_a_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)V", "")]
		public void A (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("a", "(Ljava/util/UUID;)V", "")]
		public void A (global::Java.Util.UUID p0)
		{
			if (id_a_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_UUID_, new JValue (p0));
		}

		static Delegate cb_addParticipants_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddParticipants_Ljava_util_List_Handler ()
		{
			if (cb_addParticipants_Ljava_util_List_ == null)
				cb_addParticipants_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddParticipants_Ljava_util_List_);
			return cb_addParticipants_Ljava_util_List_;
		}

		static void n_AddParticipants_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddParticipants (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addParticipants_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='addParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addParticipants", "(Ljava/util/List;)V", "GetAddParticipants_Ljava_util_List_Handler")]
		public override void AddParticipants (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_addParticipants_Ljava_util_List_ == IntPtr.Zero)
				id_addParticipants_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addParticipants", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addParticipants_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParticipants", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_Change_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/Change;)V", "")]
		public void B (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static IntPtr id_b_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("b", "(Lcom/layer/sdk/messaging/Message;)V", "")]
		public void B (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_b_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("b", "(Ljava/util/Date;)V", "")]
		public void B (global::Java.Util.Date p0)
		{
			if (id_b_Ljava_util_Date_ == IntPtr.Zero)
				id_b_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("b", "(Ljava/util/List;)V", "")]
		public void B (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> p0)
		{
			if (id_b_Ljava_util_List_ == IntPtr.Zero)
				id_b_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("b", "(Ljava/util/UUID;)V", "")]
		public void B (global::Java.Util.UUID p0)
		{
			if (id_b_Ljava_util_UUID_ == IntPtr.Zero)
				id_b_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/UUID;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_UUID_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("c", "(Ljava/lang/Long;)V", "")]
		public void C (global::Java.Lang.Long p0)
		{
			if (id_c_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("c", "(Ljava/util/Date;)V", "")]
		public void C (global::Java.Util.Date p0)
		{
			if (id_c_Ljava_util_Date_ == IntPtr.Zero)
				id_c_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("c", "(Ljava/util/List;)Z", "")]
		public bool C (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> p0)
		{
			if (id_c_Ljava_util_List_ == IntPtr.Zero)
				id_c_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_c_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("d", "(Ljava/util/List;)Z", "")]
		public bool D (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> p0)
		{
			if (id_d_Ljava_util_List_ == IntPtr.Zero)
				id_d_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_d_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler ()
		{
			if (cb_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ == null)
				cb_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_layer_sdk_LayerClient_DeletionMode_);
			return cb_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
		}

		static void n_Delete_Lcom_layer_sdk_LayerClient_DeletionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public override void Delete (global::Com.Layer.Sdk.LayerClient.DeletionMode p0)
		{
			if (id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ == IntPtr.Zero)
				id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V"), new JValue (p0));
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/util/Map;", "")]
		public global::System.Collections.Generic.IDictionary<string, string> F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_g), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_i), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Ljava/util/Map;", "")]
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_m), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_n;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()V", "")]
		public void N ()
		{
			if (id_n == IntPtr.Zero)
				id_n = JNIEnv.GetMethodID (class_ref, "n", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_n);
		}

		static Delegate cb_putMetadata_Ljava_util_Map_Z;
#pragma warning disable 0169
		static Delegate GetPutMetadata_Ljava_util_Map_ZHandler ()
		{
			if (cb_putMetadata_Ljava_util_Map_Z == null)
				cb_putMetadata_Ljava_util_Map_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutMetadata_Ljava_util_Map_Z);
			return cb_putMetadata_Ljava_util_Map_Z;
		}

		static void n_PutMetadata_Ljava_util_Map_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadata (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putMetadata_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='boolean']]"
		[Register ("putMetadata", "(Ljava/util/Map;Z)V", "GetPutMetadata_Ljava_util_Map_ZHandler")]
		public override void PutMetadata (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, bool p1)
		{
			if (id_putMetadata_Ljava_util_Map_Z == IntPtr.Zero)
				id_putMetadata_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "putMetadata", "(Ljava/util/Map;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putMetadata_Ljava_util_Map_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMetadata", "(Ljava/util/Map;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_);
			return cb_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadataAtKeyPath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='putMetadataAtKeyPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void PutMetadataAtKeyPath (string p0, string p1)
		{
			if (id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_removeMetadataAtKeyPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMetadataAtKeyPath_Ljava_lang_String_Handler ()
		{
			if (cb_removeMetadataAtKeyPath_Ljava_lang_String_ == null)
				cb_removeMetadataAtKeyPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMetadataAtKeyPath_Ljava_lang_String_);
			return cb_removeMetadataAtKeyPath_Ljava_lang_String_;
		}

		static void n_RemoveMetadataAtKeyPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMetadataAtKeyPath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeMetadataAtKeyPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='removeMetadataAtKeyPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMetadataAtKeyPath", "(Ljava/lang/String;)V", "GetRemoveMetadataAtKeyPath_Ljava_lang_String_Handler")]
		public override void RemoveMetadataAtKeyPath (string p0)
		{
			if (id_removeMetadataAtKeyPath_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMetadataAtKeyPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMetadataAtKeyPath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeMetadataAtKeyPath_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMetadataAtKeyPath", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeParticipants_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRemoveParticipants_Ljava_util_List_Handler ()
		{
			if (cb_removeParticipants_Ljava_util_List_ == null)
				cb_removeParticipants_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveParticipants_Ljava_util_List_);
			return cb_removeParticipants_Ljava_util_List_;
		}

		static void n_RemoveParticipants_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParticipants (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeParticipants_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='removeParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("removeParticipants", "(Ljava/util/List;)V", "GetRemoveParticipants_Ljava_util_List_Handler")]
		public override void RemoveParticipants (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_removeParticipants_Ljava_util_List_ == IntPtr.Zero)
				id_removeParticipants_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "removeParticipants", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeParticipants_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeParticipants", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
		{
			if (cb_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
				cb_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
			return cb_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		}

		static void n_Send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetSend_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler")]
		public override void Send (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0)
		{
			if (id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V"), new JValue (p0));
		}

		static Delegate cb_send_Lcom_layer_sdk_messaging_Message_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_layer_sdk_messaging_Message_Handler ()
		{
			if (cb_send_Lcom_layer_sdk_messaging_Message_ == null)
				cb_send_Lcom_layer_sdk_messaging_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_layer_sdk_messaging_Message_);
			return cb_send_Lcom_layer_sdk_messaging_Message_;
		}

		static void n_Send_Lcom_layer_sdk_messaging_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Handler")]
		public override void Send (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_send_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/messaging/Message;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/layer/sdk/messaging/Message;)V"), new JValue (p0));
		}

		static Delegate cb_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_Handler ()
		{
			if (cb_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ == null)
				cb_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_);
			return cb_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_;
		}

		static void n_Send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='ConversationImpl']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override void Send (global::Com.Layer.Sdk.Messaging.Message p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
