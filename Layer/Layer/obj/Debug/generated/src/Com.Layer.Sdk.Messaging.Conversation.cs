using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']"
	[global::Android.Runtime.Register ("com/layer/sdk/messaging/Conversation", DoNotGenerateAcw=true)]
	public abstract partial class Conversation : global::Java.Lang.Object, global::Com.Layer.Sdk.Messaging.ILayerObject, global::Com.Layer.Sdk.Query.IQueryable {


		public static class InterfaceConsts {

			// The following are fields from: com.layer.sdk.query.Queryable

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_EQUALITY']"
			[Register ("BY_EQUALITY")]
			public const int ByEquality = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_INCLUSION']"
			[Register ("BY_INCLUSION")]
			public const int ByInclusion = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_RELATIVE']"
			[Register ("BY_RELATIVE")]
			public const int ByRelative = (int) 4;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']"
		[global::Android.Runtime.Register ("com/layer/sdk/messaging/Conversation$Property", DoNotGenerateAcw=true)]
		public sealed partial class Property : global::Java.Lang.Enum, global::Com.Layer.Sdk.Query.IQueryableProperty {


			static IntPtr CREATED_AT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='CREATED_AT']"
			[Register ("CREATED_AT")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property CreatedAt {
				get {
					if (CREATED_AT_jfieldId == IntPtr.Zero)
						CREATED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_AT", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_AT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CREATED_AT_jfieldId == IntPtr.Zero)
						CREATED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_AT", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CREATED_AT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HAS_UNREAD_MESSAGES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='HAS_UNREAD_MESSAGES']"
			[Register ("HAS_UNREAD_MESSAGES")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property HasUnreadMessages {
				get {
					if (HAS_UNREAD_MESSAGES_jfieldId == IntPtr.Zero)
						HAS_UNREAD_MESSAGES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_UNREAD_MESSAGES", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAS_UNREAD_MESSAGES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HAS_UNREAD_MESSAGES_jfieldId == IntPtr.Zero)
						HAS_UNREAD_MESSAGES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_UNREAD_MESSAGES", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HAS_UNREAD_MESSAGES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='ID']"
			[Register ("ID")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property Id {
				get {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LAST_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='LAST_MESSAGE']"
			[Register ("LAST_MESSAGE")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property LastMessage {
				get {
					if (LAST_MESSAGE_jfieldId == IntPtr.Zero)
						LAST_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_MESSAGE", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAST_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LAST_MESSAGE_jfieldId == IntPtr.Zero)
						LAST_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_MESSAGE", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LAST_MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LAST_MESSAGE_RECEIVED_AT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='LAST_MESSAGE_RECEIVED_AT']"
			[Register ("LAST_MESSAGE_RECEIVED_AT")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property LastMessageReceivedAt {
				get {
					if (LAST_MESSAGE_RECEIVED_AT_jfieldId == IntPtr.Zero)
						LAST_MESSAGE_RECEIVED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_MESSAGE_RECEIVED_AT", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAST_MESSAGE_RECEIVED_AT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LAST_MESSAGE_RECEIVED_AT_jfieldId == IntPtr.Zero)
						LAST_MESSAGE_RECEIVED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_MESSAGE_RECEIVED_AT", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LAST_MESSAGE_RECEIVED_AT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PARTICIPANTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/field[@name='PARTICIPANTS']"
			[Register ("PARTICIPANTS")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property Participants {
				get {
					if (PARTICIPANTS_jfieldId == IntPtr.Zero)
						PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTICIPANTS", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARTICIPANTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PARTICIPANTS_jfieldId == IntPtr.Zero)
						PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTICIPANTS", "Lcom/layer/sdk/messaging/Conversation$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PARTICIPANTS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/messaging/Conversation$Property", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Property); }
			}

			internal Property (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_isEqualityQueryable;
			public bool IsEqualityQueryable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='isEqualityQueryable' and count(parameter)=0]"
				[Register ("isEqualityQueryable", "()Z", "GetIsEqualityQueryableHandler")]
				get {
					if (id_isEqualityQueryable == IntPtr.Zero)
						id_isEqualityQueryable = JNIEnv.GetMethodID (class_ref, "isEqualityQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isEqualityQueryable);
				}
			}

			static IntPtr id_isInclusionQueryable;
			public bool IsInclusionQueryable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='isInclusionQueryable' and count(parameter)=0]"
				[Register ("isInclusionQueryable", "()Z", "GetIsInclusionQueryableHandler")]
				get {
					if (id_isInclusionQueryable == IntPtr.Zero)
						id_isInclusionQueryable = JNIEnv.GetMethodID (class_ref, "isInclusionQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isInclusionQueryable);
				}
			}

			static IntPtr id_isRelativeQueryable;
			public bool IsRelativeQueryable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='isRelativeQueryable' and count(parameter)=0]"
				[Register ("isRelativeQueryable", "()Z", "GetIsRelativeQueryableHandler")]
				get {
					if (id_isRelativeQueryable == IntPtr.Zero)
						id_isRelativeQueryable = JNIEnv.GetMethodID (class_ref, "isRelativeQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isRelativeQueryable);
				}
			}

			static IntPtr id_isSortable;
			public bool IsSortable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='isSortable' and count(parameter)=0]"
				[Register ("isSortable", "()Z", "GetIsSortableHandler")]
				get {
					if (id_isSortable == IntPtr.Zero)
						id_isSortable = JNIEnv.GetMethodID (class_ref, "isSortable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isSortable);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation$Property;", "")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation$Property;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Messaging.Conversation.Property __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation.Property> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation.Property']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/messaging/Conversation$Property;", "")]
			public static global::Com.Layer.Sdk.Messaging.Conversation.Property[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/Conversation$Property;");
				return (global::Com.Layer.Sdk.Messaging.Conversation.Property[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.Conversation.Property));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/messaging/Conversation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Conversation); }
		}

		protected Conversation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/constructor[@name='Conversation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Conversation () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Conversation)) {
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		public abstract bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeliveryReceiptsEnabled;
		}
#pragma warning restore 0169

		public abstract bool IsDeliveryReceiptsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='isDeliveryReceiptsEnabled' and count(parameter)=0]"
			[Register ("isDeliveryReceiptsEnabled", "()Z", "GetIsDeliveryReceiptsEnabledHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastMessage);
		}
#pragma warning restore 0169

		public abstract global::Com.Layer.Sdk.Messaging.Message LastMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getLastMessage' and count(parameter)=0]"
			[Register ("getLastMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetLastMessageHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "GetGetMetadataHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Participants);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<string> Participants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getParticipants' and count(parameter)=0]"
			[Register ("getParticipants", "()Ljava/util/List;", "GetGetParticipantsHandler")] get;
		}

		static Delegate cb_addParticipants_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddParticipants_arrayLjava_lang_String_Handler ()
		{
			if (cb_addParticipants_arrayLjava_lang_String_ == null)
				cb_addParticipants_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddParticipants_arrayLjava_lang_String_);
			return cb_addParticipants_arrayLjava_lang_String_;
		}

		static void n_AddParticipants_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.AddParticipants (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addParticipants_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='addParticipants' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("addParticipants", "([Ljava/lang/String;)V", "GetAddParticipants_arrayLjava_lang_String_Handler")]
		public virtual void AddParticipants (params  string[] p0)
		{
			if (id_addParticipants_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addParticipants_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParticipants", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addParticipants_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParticipants", "([Ljava/lang/String;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddParticipants (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='addParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addParticipants", "(Ljava/util/List;)V", "GetAddParticipants_Ljava_util_List_Handler")]
		public abstract void AddParticipants (global::System.Collections.Generic.IList<string> p0);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public abstract void Delete (global::Com.Layer.Sdk.LayerClient.DeletionMode p0);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadata (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='boolean']]"
		[Register ("putMetadata", "(Ljava/util/Map;Z)V", "GetPutMetadata_Ljava_util_Map_ZHandler")]
		public abstract void PutMetadata (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, bool p1);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadataAtKeyPath (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='putMetadataAtKeyPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void PutMetadataAtKeyPath (string p0, string p1);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMetadataAtKeyPath (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='removeMetadataAtKeyPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMetadataAtKeyPath", "(Ljava/lang/String;)V", "GetRemoveMetadataAtKeyPath_Ljava_lang_String_Handler")]
		public abstract void RemoveMetadataAtKeyPath (string p0);

		static Delegate cb_removeParticipants_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveParticipants_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeParticipants_arrayLjava_lang_String_ == null)
				cb_removeParticipants_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveParticipants_arrayLjava_lang_String_);
			return cb_removeParticipants_arrayLjava_lang_String_;
		}

		static void n_RemoveParticipants_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RemoveParticipants (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeParticipants_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='removeParticipants' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("removeParticipants", "([Ljava/lang/String;)V", "GetRemoveParticipants_arrayLjava_lang_String_Handler")]
		public virtual void RemoveParticipants (params  string[] p0)
		{
			if (id_removeParticipants_arrayLjava_lang_String_ == IntPtr.Zero)
				id_removeParticipants_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeParticipants", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeParticipants_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeParticipants", "([Ljava/lang/String;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParticipants (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='removeParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("removeParticipants", "(Ljava/util/List;)V", "GetRemoveParticipants_Ljava_util_List_Handler")]
		public abstract void RemoveParticipants (global::System.Collections.Generic.IList<string> p0);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetSend_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler")]
		public abstract void Send (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Handler")]
		public abstract void Send (global::Com.Layer.Sdk.Messaging.Message p0);

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
			global::Com.Layer.Sdk.Messaging.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public abstract void Send (global::Com.Layer.Sdk.Messaging.Message p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/messaging/Conversation", DoNotGenerateAcw=true)]
	internal partial class ConversationInvoker : Conversation {

		public ConversationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationInvoker); }
		}

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isDeleted;
		public override bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")]
			get {
				if (id_isDeleted == IntPtr.Zero)
					id_isDeleted = JNIEnv.GetMethodID (class_ref, "isDeleted", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDeleted);
			}
		}

		static IntPtr id_isDeliveryReceiptsEnabled;
		public override bool IsDeliveryReceiptsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='isDeliveryReceiptsEnabled' and count(parameter)=0]"
			[Register ("isDeliveryReceiptsEnabled", "()Z", "GetIsDeliveryReceiptsEnabledHandler")]
			get {
				if (id_isDeliveryReceiptsEnabled == IntPtr.Zero)
					id_isDeliveryReceiptsEnabled = JNIEnv.GetMethodID (class_ref, "isDeliveryReceiptsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDeliveryReceiptsEnabled);
			}
		}

		static IntPtr id_getLastMessage;
		public override global::Com.Layer.Sdk.Messaging.Message LastMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getLastMessage' and count(parameter)=0]"
			[Register ("getLastMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetLastMessageHandler")]
			get {
				if (id_getLastMessage == IntPtr.Zero)
					id_getLastMessage = JNIEnv.GetMethodID (class_ref, "getLastMessage", "()Lcom/layer/sdk/messaging/Message;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_getLastMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMetadata;
		public override global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getParticipants;
		public override global::System.Collections.Generic.IList<string> Participants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='getParticipants' and count(parameter)=0]"
			[Register ("getParticipants", "()Ljava/util/List;", "GetGetParticipantsHandler")]
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addParticipants_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='addParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addParticipants", "(Ljava/util/List;)V", "GetAddParticipants_Ljava_util_List_Handler")]
		public override void AddParticipants (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_addParticipants_Ljava_util_List_ == IntPtr.Zero)
				id_addParticipants_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addParticipants", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_addParticipants_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public override void Delete (global::Com.Layer.Sdk.LayerClient.DeletionMode p0)
		{
			if (id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ == IntPtr.Zero)
				id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_, new JValue (p0));
		}

		static IntPtr id_putMetadata_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='boolean']]"
		[Register ("putMetadata", "(Ljava/util/Map;Z)V", "GetPutMetadata_Ljava_util_Map_ZHandler")]
		public override void PutMetadata (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, bool p1)
		{
			if (id_putMetadata_Ljava_util_Map_Z == IntPtr.Zero)
				id_putMetadata_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "putMetadata", "(Ljava/util/Map;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_putMetadata_Ljava_util_Map_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='putMetadataAtKeyPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void PutMetadataAtKeyPath (string p0, string p1)
		{
			if (id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putMetadataAtKeyPath", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_putMetadataAtKeyPath_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_removeMetadataAtKeyPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='removeMetadataAtKeyPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMetadataAtKeyPath", "(Ljava/lang/String;)V", "GetRemoveMetadataAtKeyPath_Ljava_lang_String_Handler")]
		public override void RemoveMetadataAtKeyPath (string p0)
		{
			if (id_removeMetadataAtKeyPath_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMetadataAtKeyPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMetadataAtKeyPath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_removeMetadataAtKeyPath_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_removeParticipants_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='removeParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("removeParticipants", "(Ljava/util/List;)V", "GetRemoveParticipants_Ljava_util_List_Handler")]
		public override void RemoveParticipants (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_removeParticipants_Ljava_util_List_ == IntPtr.Zero)
				id_removeParticipants_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "removeParticipants", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_removeParticipants_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetSend_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler")]
		public override void Send (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0)
		{
			if (id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0));
		}

		static IntPtr id_send_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Handler")]
		public override void Send (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_send_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Conversation']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetSend_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override void Send (global::Com.Layer.Sdk.Messaging.Message p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
		}

	}

}
