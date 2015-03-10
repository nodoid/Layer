using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/MessageImpl", DoNotGenerateAcw=true)]
	public partial class MessageImpl : global::Com.Layer.Sdk.Messaging.Message, global::Com.Layer.Sdk.Internal.Messaging.IChangeable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/MessageImpl$Attribute", DoNotGenerateAcw=true)]
		public sealed partial class Attribute : global::Java.Lang.Enum, global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute {


			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='e']"
			[Register ("e")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr f_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='f']"
			[Register ("f")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute F {
				get {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='g']"
			[Register ("g")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr h_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='h']"
			[Register ("h")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute H {
				get {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, h_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, h_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr i_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='i']"
			[Register ("i")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute I {
				get {
					if (i_jfieldId == IntPtr.Zero)
						i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, i_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (i_jfieldId == IntPtr.Zero)
						i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, i_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr j_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/field[@name='j']"
			[Register ("j")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute J {
				get {
					if (j_jfieldId == IntPtr.Zero)
						j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, j_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (j_jfieldId == IntPtr.Zero)
						j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, j_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/MessageImpl$Attribute", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;", "")]
			public global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Z", "")]
			public bool C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_c);
			}

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()[Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute[] D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetStaticMethodID (class_ref, "d", "()[Lcom/layer/sdk/internal/messaging/models/MessageImpl$Attribute;");
				return (global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_d), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl.Attribute));
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl.Attribute']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/MessageImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageImpl); }
		}

		protected MessageImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/constructor[@name='MessageImpl' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Long']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/Long;)V", "")]
		public MessageImpl (global::Android.Net.Uri p0, global::Java.Lang.Long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MessageImpl)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/constructor[@name='MessageImpl' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public MessageImpl (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (MessageImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getConversation;
#pragma warning disable 0169
		static Delegate GetGetConversationHandler ()
		{
			if (cb_getConversation == null)
				cb_getConversation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversation);
			return cb_getConversation;
		}

		static IntPtr n_GetConversation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conversation);
		}
#pragma warning restore 0169

		static IntPtr id_getConversation;
		public override global::Com.Layer.Sdk.Messaging.Conversation Conversation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getConversation' and count(parameter)=0]"
			[Register ("getConversation", "()Lcom/layer/sdk/messaging/Conversation;", "GetGetConversationHandler")]
			get {
				if (id_getConversation == IntPtr.Zero)
					id_getConversation = JNIEnv.GetMethodID (class_ref, "getConversation", "()Lcom/layer/sdk/messaging/Conversation;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_getConversation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversation", "()Lcom/layer/sdk/messaging/Conversation;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndex);
			return cb_getIndex;
		}

		static IntPtr n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Index);
		}
#pragma warning restore 0169

		static IntPtr id_getIndex;
		public override global::Java.Lang.Integer Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()Ljava/lang/Integer;", "GetGetIndexHandler")]
			get {
				if (id_getIndex == IntPtr.Zero)
					id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()Ljava/lang/Integer;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getIndex), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndex", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		static IntPtr id_isDeleted;
		public override bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='isDeleted' and count(parameter)=0]"
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

		static Delegate cb_isSent;
#pragma warning disable 0169
		static Delegate GetIsSentHandler ()
		{
			if (cb_isSent == null)
				cb_isSent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSent);
			return cb_isSent;
		}

		static bool n_IsSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSent;
		}
#pragma warning restore 0169

		static IntPtr id_isSent;
		public override bool IsSent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='isSent' and count(parameter)=0]"
			[Register ("isSent", "()Z", "GetIsSentHandler")]
			get {
				if (id_isSent == IntPtr.Zero)
					id_isSent = JNIEnv.GetMethodID (class_ref, "isSent", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSent", "()Z"));
			}
		}

		static Delegate cb_getMessageParts;
#pragma warning disable 0169
		static Delegate GetGetMessagePartsHandler ()
		{
			if (cb_getMessageParts == null)
				cb_getMessageParts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageParts);
			return cb_getMessageParts;
		}

		static IntPtr n_GetMessageParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.ToLocalJniHandle (__this.MessageParts);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageParts;
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> MessageParts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getMessageParts' and count(parameter)=0]"
			[Register ("getMessageParts", "()Ljava/util/List;", "GetGetMessagePartsHandler")]
			get {
				if (id_getMessageParts == IntPtr.Zero)
					id_getMessageParts = JNIEnv.GetMethodID (class_ref, "getMessageParts", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageParts), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageParts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReceivedAt;
#pragma warning disable 0169
		static Delegate GetGetReceivedAtHandler ()
		{
			if (cb_getReceivedAt == null)
				cb_getReceivedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedAt);
			return cb_getReceivedAt;
		}

		static IntPtr n_GetReceivedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReceivedAt);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedAt;
		public override global::Java.Util.Date ReceivedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getReceivedAt' and count(parameter)=0]"
			[Register ("getReceivedAt", "()Ljava/util/Date;", "GetGetReceivedAtHandler")]
			get {
				if (id_getReceivedAt == IntPtr.Zero)
					id_getReceivedAt = JNIEnv.GetMethodID (class_ref, "getReceivedAt", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getReceivedAt), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSentAt;
#pragma warning disable 0169
		static Delegate GetGetSentAtHandler ()
		{
			if (cb_getSentAt == null)
				cb_getSentAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentAt);
			return cb_getSentAt;
		}

		static IntPtr n_GetSentAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SentAt);
		}
#pragma warning restore 0169

		static IntPtr id_getSentAt;
		public override global::Java.Util.Date SentAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getSentAt' and count(parameter)=0]"
			[Register ("getSentAt", "()Ljava/util/Date;", "GetGetSentAtHandler")]
			get {
				if (id_getSentAt == IntPtr.Zero)
					id_getSentAt = JNIEnv.GetMethodID (class_ref, "getSentAt", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getSentAt), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSentByUserId;
#pragma warning disable 0169
		static Delegate GetGetSentByUserIdHandler ()
		{
			if (cb_getSentByUserId == null)
				cb_getSentByUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentByUserId);
			return cb_getSentByUserId;
		}

		static IntPtr n_GetSentByUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentByUserId);
		}
#pragma warning restore 0169

		static IntPtr id_getSentByUserId;
		public override string SentByUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getSentByUserId' and count(parameter)=0]"
			[Register ("getSentByUserId", "()Ljava/lang/String;", "GetGetSentByUserIdHandler")]
			get {
				if (id_getSentByUserId == IntPtr.Zero)
					id_getSentByUserId = JNIEnv.GetMethodID (class_ref, "getSentByUserId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSentByUserId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentByUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/Queue;", "")]
		public global::Java.Util.IQueue A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/Queue;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_Change_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Change;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Conversation;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Integer;)V", "")]
		public void A (global::Java.Lang.Integer p0)
		{
			if (id_a_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)V", "")]
		public void A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.layer.sdk.messaging.Message.RecipientStatus'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V", "")]
		public void A (string p0, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus p1, global::Java.Lang.Integer p2)
		{
			if (id_a_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/layer/sdk/messaging/Message$RecipientStatus;Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Lcom_layer_sdk_messaging_Message_RecipientStatus_Ljava_lang_Integer_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "")]
		public void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)V", "")]
		public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)V", "")]
		public void A (global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_Change_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/Change;)V", "")]
		public void B (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("b", "(Ljava/lang/Integer;)V", "")]
		public void B (global::Java.Lang.Integer p0)
		{
			if (id_b_Ljava_lang_Integer_ == IntPtr.Zero)
				id_b_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("b", "(Ljava/util/Date;)V", "")]
		public void B (global::Java.Util.Date p0)
		{
			if (id_b_Ljava_util_Date_ == IntPtr.Zero)
				id_b_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("c", "(Ljava/lang/Integer;)V", "")]
		public void C (global::Java.Lang.Integer p0)
		{
			if (id_c_Ljava_lang_Integer_ == IntPtr.Zero)
				id_c_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("c", "(Ljava/lang/Long;)V", "")]
		public void C (global::Java.Lang.Long p0)
		{
			if (id_c_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("c", "(Ljava/util/Date;)V", "")]
		public void C (global::Java.Util.Date p0)
		{
			if (id_c_Ljava_util_Date_ == IntPtr.Zero)
				id_c_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("d", "(Ljava/lang/Integer;)V", "")]
		public void D (global::Java.Lang.Integer p0)
		{
			if (id_d_Ljava_lang_Integer_ == IntPtr.Zero)
				id_d_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_d_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("d", "(Ljava/lang/Long;)V", "")]
		public void D (global::Java.Lang.Long p0)
		{
			if (id_d_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_d_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("d", "(Ljava/util/Date;)V", "")]
		public void D (global::Java.Util.Date p0)
		{
			if (id_d_Ljava_util_Date_ == IntPtr.Zero)
				id_d_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_util_Date_, new JValue (p0));
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
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("e", "(Ljava/lang/Integer;)V", "")]
		public void E (global::Java.Lang.Integer p0)
		{
			if (id_e_Ljava_lang_Integer_ == IntPtr.Zero)
				id_e_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_Integer_, new JValue (p0));
		}

		static IntPtr id_e_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("e", "(Ljava/util/Date;)V", "")]
		public void E (global::Java.Util.Date p0)
		{
			if (id_e_Ljava_util_Date_ == IntPtr.Zero)
				id_e_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/util/Set;", "")]
		public global::System.Collections.Generic.ICollection<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_g), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getRecipientStatus;
#pragma warning disable 0169
		static Delegate GetGetRecipientStatusHandler ()
		{
			if (cb_getRecipientStatus == null)
				cb_getRecipientStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecipientStatus);
			return cb_getRecipientStatus;
		}

		static IntPtr n_GetRecipientStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus>.ToLocalJniHandle (__this.GetRecipientStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecipientStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getRecipientStatus' and count(parameter)=0]"
		[Register ("getRecipientStatus", "()Ljava/util/Map;", "GetGetRecipientStatusHandler")]
		public override global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> GetRecipientStatus ()
		{
			if (id_getRecipientStatus == IntPtr.Zero)
				id_getRecipientStatus = JNIEnv.GetMethodID (class_ref, "getRecipientStatus", "()Ljava/util/Map;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRecipientStatus), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecipientStatus", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getRecipientStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRecipientStatus_Ljava_lang_String_Handler ()
		{
			if (cb_getRecipientStatus_Ljava_lang_String_ == null)
				cb_getRecipientStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRecipientStatus_Ljava_lang_String_);
			return cb_getRecipientStatus_Ljava_lang_String_;
		}

		static IntPtr n_GetRecipientStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRecipientStatus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRecipientStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='getRecipientStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;", "GetGetRecipientStatus_Ljava_lang_String_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Message.RecipientStatus GetRecipientStatus (string p0)
		{
			if (id_getRecipientStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_getRecipientStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Layer.Sdk.Messaging.Message.RecipientStatus __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (JNIEnv.CallObjectMethod  (Handle, id_getRecipientStatus_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/util/Map;", "")]
		public global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_i), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()V", "")]
		public void L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_l);
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Z", "")]
		public bool M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_m);
		}

		static Delegate cb_markAsRead;
#pragma warning disable 0169
		static Delegate GetMarkAsReadHandler ()
		{
			if (cb_markAsRead == null)
				cb_markAsRead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkAsRead);
			return cb_markAsRead;
		}

		static void n_MarkAsRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkAsRead ();
		}
#pragma warning restore 0169

		static IntPtr id_markAsRead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='markAsRead' and count(parameter)=0]"
		[Register ("markAsRead", "()V", "GetMarkAsReadHandler")]
		public override void MarkAsRead ()
		{
			if (id_markAsRead == IntPtr.Zero)
				id_markAsRead = JNIEnv.GetMethodID (class_ref, "markAsRead", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markAsRead);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markAsRead", "()V"));
		}

		static Delegate cb_setMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Ljava_util_Map_ == null)
				cb_setMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Ljava_util_Map_);
			return cb_setMetadata_Ljava_util_Map_;
		}

		static void n_SetMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMetadata (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMetadata_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessageImpl']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setMetadata", "(Ljava/util/Map;)V", "GetSetMetadata_Ljava_util_Map_Handler")]
		public override void SetMetadata (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
				id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMetadata_Ljava_util_Map_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadata", "(Ljava/util/Map;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
