using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/layer/sdk/messaging/Message", DoNotGenerateAcw=true)]
	public abstract partial class Message : global::Java.Lang.Object, global::Com.Layer.Sdk.Messaging.ILayerObject, global::Com.Layer.Sdk.Query.IQueryable {


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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']"
		[global::Android.Runtime.Register ("com/layer/sdk/messaging/Message$Property", DoNotGenerateAcw=true)]
		public sealed partial class Property : global::Java.Lang.Enum, global::Com.Layer.Sdk.Query.IQueryableProperty {


			static IntPtr CONVERSATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='CONVERSATION']"
			[Register ("CONVERSATION")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property Conversation {
				get {
					if (CONVERSATION_jfieldId == IntPtr.Zero)
						CONVERSATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONVERSATION_jfieldId == IntPtr.Zero)
						CONVERSATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONVERSATION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='ID']"
			[Register ("ID")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property Id {
				get {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INDEX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='INDEX']"
			[Register ("INDEX")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property Index {
				get {
					if (INDEX_jfieldId == IntPtr.Zero)
						INDEX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INDEX", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INDEX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INDEX_jfieldId == IntPtr.Zero)
						INDEX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INDEX", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INDEX_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IS_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='IS_SENT']"
			[Register ("IS_SENT")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property IsSent {
				get {
					if (IS_SENT_jfieldId == IntPtr.Zero)
						IS_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_SENT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IS_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IS_SENT_jfieldId == IntPtr.Zero)
						IS_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_SENT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IS_SENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IS_UNREAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='IS_UNREAD']"
			[Register ("IS_UNREAD")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property IsUnread {
				get {
					if (IS_UNREAD_jfieldId == IntPtr.Zero)
						IS_UNREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_UNREAD", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IS_UNREAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IS_UNREAD_jfieldId == IntPtr.Zero)
						IS_UNREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_UNREAD", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IS_UNREAD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PART_IS_DOWNLOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='PART_IS_DOWNLOADED']"
			[Register ("PART_IS_DOWNLOADED")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property PartIsDownloaded {
				get {
					if (PART_IS_DOWNLOADED_jfieldId == IntPtr.Zero)
						PART_IS_DOWNLOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_IS_DOWNLOADED", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PART_IS_DOWNLOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PART_IS_DOWNLOADED_jfieldId == IntPtr.Zero)
						PART_IS_DOWNLOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_IS_DOWNLOADED", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PART_IS_DOWNLOADED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PART_IS_UPLOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='PART_IS_UPLOADED']"
			[Register ("PART_IS_UPLOADED")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property PartIsUploaded {
				get {
					if (PART_IS_UPLOADED_jfieldId == IntPtr.Zero)
						PART_IS_UPLOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_IS_UPLOADED", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PART_IS_UPLOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PART_IS_UPLOADED_jfieldId == IntPtr.Zero)
						PART_IS_UPLOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_IS_UPLOADED", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PART_IS_UPLOADED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PART_MIME_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='PART_MIME_TYPE']"
			[Register ("PART_MIME_TYPE")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property PartMimeType {
				get {
					if (PART_MIME_TYPE_jfieldId == IntPtr.Zero)
						PART_MIME_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_MIME_TYPE", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PART_MIME_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PART_MIME_TYPE_jfieldId == IntPtr.Zero)
						PART_MIME_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_MIME_TYPE", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PART_MIME_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PART_SIZE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='PART_SIZE']"
			[Register ("PART_SIZE")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property PartSize {
				get {
					if (PART_SIZE_jfieldId == IntPtr.Zero)
						PART_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_SIZE", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PART_SIZE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PART_SIZE_jfieldId == IntPtr.Zero)
						PART_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PART_SIZE", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PART_SIZE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RECEIVED_AT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='RECEIVED_AT']"
			[Register ("RECEIVED_AT")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property ReceivedAt {
				get {
					if (RECEIVED_AT_jfieldId == IntPtr.Zero)
						RECEIVED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECEIVED_AT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECEIVED_AT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RECEIVED_AT_jfieldId == IntPtr.Zero)
						RECEIVED_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECEIVED_AT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RECEIVED_AT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SENT_AT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='SENT_AT']"
			[Register ("SENT_AT")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property SentAt {
				get {
					if (SENT_AT_jfieldId == IntPtr.Zero)
						SENT_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT_AT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENT_AT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SENT_AT_jfieldId == IntPtr.Zero)
						SENT_AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT_AT", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SENT_AT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SENT_BY_USER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/field[@name='SENT_BY_USER_ID']"
			[Register ("SENT_BY_USER_ID")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property SentByUserId {
				get {
					if (SENT_BY_USER_ID_jfieldId == IntPtr.Zero)
						SENT_BY_USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT_BY_USER_ID", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENT_BY_USER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SENT_BY_USER_ID_jfieldId == IntPtr.Zero)
						SENT_BY_USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT_BY_USER_ID", "Lcom/layer/sdk/messaging/Message$Property;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SENT_BY_USER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/messaging/Message$Property", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='isEqualityQueryable' and count(parameter)=0]"
				[Register ("isEqualityQueryable", "()Z", "GetIsEqualityQueryableHandler")]
				get {
					if (id_isEqualityQueryable == IntPtr.Zero)
						id_isEqualityQueryable = JNIEnv.GetMethodID (class_ref, "isEqualityQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isEqualityQueryable);
				}
			}

			static IntPtr id_isInclusionQueryable;
			public bool IsInclusionQueryable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='isInclusionQueryable' and count(parameter)=0]"
				[Register ("isInclusionQueryable", "()Z", "GetIsInclusionQueryableHandler")]
				get {
					if (id_isInclusionQueryable == IntPtr.Zero)
						id_isInclusionQueryable = JNIEnv.GetMethodID (class_ref, "isInclusionQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isInclusionQueryable);
				}
			}

			static IntPtr id_isRelativeQueryable;
			public bool IsRelativeQueryable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='isRelativeQueryable' and count(parameter)=0]"
				[Register ("isRelativeQueryable", "()Z", "GetIsRelativeQueryableHandler")]
				get {
					if (id_isRelativeQueryable == IntPtr.Zero)
						id_isRelativeQueryable = JNIEnv.GetMethodID (class_ref, "isRelativeQueryable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isRelativeQueryable);
				}
			}

			static IntPtr id_isSortable;
			public bool IsSortable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='isSortable' and count(parameter)=0]"
				[Register ("isSortable", "()Z", "GetIsSortableHandler")]
				get {
					if (id_isSortable == IntPtr.Zero)
						id_isSortable = JNIEnv.GetMethodID (class_ref, "isSortable", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isSortable);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$Property;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$Property;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Messaging.Message.Property __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.Property> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.Property']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/messaging/Message$Property;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.Property[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/Message$Property;");
				return (global::Com.Layer.Sdk.Messaging.Message.Property[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.Message.Property));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']"
		[global::Android.Runtime.Register ("com/layer/sdk/messaging/Message$RecipientStatus", DoNotGenerateAcw=true)]
		public sealed partial class RecipientStatus : global::Java.Lang.Enum {


			static IntPtr DELIVERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/field[@name='DELIVERED']"
			[Register ("DELIVERED")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus Delivered {
				get {
					if (DELIVERED_jfieldId == IntPtr.Zero)
						DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELIVERED", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELIVERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DELIVERED_jfieldId == IntPtr.Zero)
						DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELIVERED", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DELIVERED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PENDING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/field[@name='READ']"
			[Register ("READ")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus Read {
				get {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, READ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/field[@name='SENT']"
			[Register ("SENT")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus Sent {
				get {
					if (SENT_jfieldId == IntPtr.Zero)
						SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SENT_jfieldId == IntPtr.Zero)
						SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT", "Lcom/layer/sdk/messaging/Message$RecipientStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/messaging/Message$RecipientStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecipientStatus); }
			}

			internal RecipientStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Messaging.Message.RecipientStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.RecipientStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/messaging/Message$RecipientStatus;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.RecipientStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/Message$RecipientStatus;");
				return (global::Com.Layer.Sdk.Messaging.Message.RecipientStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.Message.RecipientStatus));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']"
		[global::Android.Runtime.Register ("com/layer/sdk/messaging/Message$ReservedMetadataKeys", DoNotGenerateAcw=true)]
		public sealed partial class ReservedMetadataKeys : global::Java.Lang.Enum {


			static IntPtr PushNotificationAlertMessageKey_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/field[@name='PushNotificationAlertMessageKey']"
			[Register ("PushNotificationAlertMessageKey")]
			public static global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys PushNotificationAlertMessageKey {
				get {
					if (PushNotificationAlertMessageKey_jfieldId == IntPtr.Zero)
						PushNotificationAlertMessageKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PushNotificationAlertMessageKey", "Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PushNotificationAlertMessageKey_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PushNotificationAlertMessageKey_jfieldId == IntPtr.Zero)
						PushNotificationAlertMessageKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PushNotificationAlertMessageKey", "Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PushNotificationAlertMessageKey_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PushNotificationSoundNameKey_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/field[@name='PushNotificationSoundNameKey']"
			[Register ("PushNotificationSoundNameKey")]
			public static global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys PushNotificationSoundNameKey {
				get {
					if (PushNotificationSoundNameKey_jfieldId == IntPtr.Zero)
						PushNotificationSoundNameKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PushNotificationSoundNameKey", "Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PushNotificationSoundNameKey_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PushNotificationSoundNameKey_jfieldId == IntPtr.Zero)
						PushNotificationSoundNameKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PushNotificationSoundNameKey", "Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PushNotificationSoundNameKey_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/messaging/Message$ReservedMetadataKeys", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReservedMetadataKeys); }
			}

			internal ReservedMetadataKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getKey;
			public string Key {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/method[@name='getKey' and count(parameter)=0]"
				[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
				get {
					if (id_getKey == IntPtr.Zero)
						id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message.ReservedMetadataKeys']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;", "")]
			public static global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/Message$ReservedMetadataKeys;");
				return (global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.Message.ReservedMetadataKeys));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/messaging/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/constructor[@name='Message' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Message () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Message)) {
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conversation);
		}
#pragma warning restore 0169

		public abstract global::Com.Layer.Sdk.Messaging.Conversation Conversation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getConversation' and count(parameter)=0]"
			[Register ("getConversation", "()Lcom/layer/sdk/messaging/Conversation;", "GetGetConversationHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Index);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Integer Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()Ljava/lang/Integer;", "GetGetIndexHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		public abstract bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSent;
		}
#pragma warning restore 0169

		public abstract bool IsSent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='isSent' and count(parameter)=0]"
			[Register ("isSent", "()Z", "GetIsSentHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.ToLocalJniHandle (__this.MessageParts);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> MessageParts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getMessageParts' and count(parameter)=0]"
			[Register ("getMessageParts", "()Ljava/util/List;", "GetGetMessagePartsHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReceivedAt);
		}
#pragma warning restore 0169

		public abstract global::Java.Util.Date ReceivedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getReceivedAt' and count(parameter)=0]"
			[Register ("getReceivedAt", "()Ljava/util/Date;", "GetGetReceivedAtHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SentAt);
		}
#pragma warning restore 0169

		public abstract global::Java.Util.Date SentAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getSentAt' and count(parameter)=0]"
			[Register ("getSentAt", "()Ljava/util/Date;", "GetGetSentAtHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentByUserId);
		}
#pragma warning restore 0169

		public abstract string SentByUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getSentByUserId' and count(parameter)=0]"
			[Register ("getSentByUserId", "()Ljava/lang/String;", "GetGetSentByUserIdHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public abstract void Delete (global::Com.Layer.Sdk.LayerClient.DeletionMode p0);

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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus>.ToLocalJniHandle (__this.GetRecipientStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getRecipientStatus' and count(parameter)=0]"
		[Register ("getRecipientStatus", "()Ljava/util/Map;", "GetGetRecipientStatusHandler")]
		public abstract global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> GetRecipientStatus ();

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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRecipientStatus (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getRecipientStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;", "GetGetRecipientStatus_Ljava_lang_String_Handler")]
		public abstract global::Com.Layer.Sdk.Messaging.Message.RecipientStatus GetRecipientStatus (string p0);

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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkAsRead ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='markAsRead' and count(parameter)=0]"
		[Register ("markAsRead", "()V", "GetMarkAsReadHandler")]
		public abstract void MarkAsRead ();

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
			global::Com.Layer.Sdk.Messaging.Message __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMetadata (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setMetadata", "(Ljava/util/Map;)V", "GetSetMetadata_Ljava_util_Map_Handler")]
		public abstract void SetMetadata (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/messaging/Message", DoNotGenerateAcw=true)]
	internal partial class MessageInvoker : Message {

		public MessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageInvoker); }
		}

		static IntPtr id_getConversation;
		public override global::Com.Layer.Sdk.Messaging.Conversation Conversation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getConversation' and count(parameter)=0]"
			[Register ("getConversation", "()Lcom/layer/sdk/messaging/Conversation;", "GetGetConversationHandler")]
			get {
				if (id_getConversation == IntPtr.Zero)
					id_getConversation = JNIEnv.GetMethodID (class_ref, "getConversation", "()Lcom/layer/sdk/messaging/Conversation;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_getConversation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIndex;
		public override global::Java.Lang.Integer Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()Ljava/lang/Integer;", "GetGetIndexHandler")]
			get {
				if (id_getIndex == IntPtr.Zero)
					id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getIndex), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isDeleted;
		public override bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")]
			get {
				if (id_isDeleted == IntPtr.Zero)
					id_isDeleted = JNIEnv.GetMethodID (class_ref, "isDeleted", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDeleted);
			}
		}

		static IntPtr id_isSent;
		public override bool IsSent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='isSent' and count(parameter)=0]"
			[Register ("isSent", "()Z", "GetIsSentHandler")]
			get {
				if (id_isSent == IntPtr.Zero)
					id_isSent = JNIEnv.GetMethodID (class_ref, "isSent", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSent);
			}
		}

		static IntPtr id_getMessageParts;
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> MessageParts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getMessageParts' and count(parameter)=0]"
			[Register ("getMessageParts", "()Ljava/util/List;", "GetGetMessagePartsHandler")]
			get {
				if (id_getMessageParts == IntPtr.Zero)
					id_getMessageParts = JNIEnv.GetMethodID (class_ref, "getMessageParts", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageParts), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getReceivedAt;
		public override global::Java.Util.Date ReceivedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getReceivedAt' and count(parameter)=0]"
			[Register ("getReceivedAt", "()Ljava/util/Date;", "GetGetReceivedAtHandler")]
			get {
				if (id_getReceivedAt == IntPtr.Zero)
					id_getReceivedAt = JNIEnv.GetMethodID (class_ref, "getReceivedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getReceivedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSentAt;
		public override global::Java.Util.Date SentAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getSentAt' and count(parameter)=0]"
			[Register ("getSentAt", "()Ljava/util/Date;", "GetGetSentAtHandler")]
			get {
				if (id_getSentAt == IntPtr.Zero)
					id_getSentAt = JNIEnv.GetMethodID (class_ref, "getSentAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getSentAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSentByUserId;
		public override string SentByUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getSentByUserId' and count(parameter)=0]"
			[Register ("getSentByUserId", "()Ljava/lang/String;", "GetGetSentByUserIdHandler")]
			get {
				if (id_getSentByUserId == IntPtr.Zero)
					id_getSentByUserId = JNIEnv.GetMethodID (class_ref, "getSentByUserId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSentByUserId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDelete_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public override void Delete (global::Com.Layer.Sdk.LayerClient.DeletionMode p0)
		{
			if (id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ == IntPtr.Zero)
				id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/layer/sdk/LayerClient$DeletionMode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_delete_Lcom_layer_sdk_LayerClient_DeletionMode_, new JValue (p0));
		}

		static IntPtr id_getRecipientStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getRecipientStatus' and count(parameter)=0]"
		[Register ("getRecipientStatus", "()Ljava/util/Map;", "GetGetRecipientStatusHandler")]
		public override global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> GetRecipientStatus ()
		{
			if (id_getRecipientStatus == IntPtr.Zero)
				id_getRecipientStatus = JNIEnv.GetMethodID (class_ref, "getRecipientStatus", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Messaging.Message.RecipientStatus>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRecipientStatus), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getRecipientStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='getRecipientStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;", "GetGetRecipientStatus_Ljava_lang_String_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Message.RecipientStatus GetRecipientStatus (string p0)
		{
			if (id_getRecipientStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_getRecipientStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRecipientStatus", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/Message$RecipientStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Messaging.Message.RecipientStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message.RecipientStatus> (JNIEnv.CallObjectMethod  (Handle, id_getRecipientStatus_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_markAsRead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='markAsRead' and count(parameter)=0]"
		[Register ("markAsRead", "()V", "GetMarkAsReadHandler")]
		public override void MarkAsRead ()
		{
			if (id_markAsRead == IntPtr.Zero)
				id_markAsRead = JNIEnv.GetMethodID (class_ref, "markAsRead", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_markAsRead);
		}

		static IntPtr id_setMetadata_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='Message']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setMetadata", "(Ljava/util/Map;)V", "GetSetMetadata_Ljava_util_Map_Handler")]
		public override void SetMetadata (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
				id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setMetadata_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
