using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Event", DoNotGenerateAcw=true)]
	public partial class Event : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Event$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields ClientId {
				get {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CLIENT_SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='CLIENT_SEQ']"
			[Register ("CLIENT_SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields ClientSeq {
				get {
					if (CLIENT_SEQ_jfieldId == IntPtr.Zero)
						CLIENT_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_SEQ_jfieldId == IntPtr.Zero)
						CLIENT_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='CONTENT']"
			[Register ("CONTENT")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Content {
				get {
					if (CONTENT_jfieldId == IntPtr.Zero)
						CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONTENT_jfieldId == IntPtr.Zero)
						CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONTENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CREATOR_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='CREATOR_ID']"
			[Register ("CREATOR_ID")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields CreatorId {
				get {
					if (CREATOR_ID_jfieldId == IntPtr.Zero)
						CREATOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CREATOR_ID_jfieldId == IntPtr.Zero)
						CREATOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CREATOR_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EPHEMERAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='EPHEMERAL']"
			[Register ("EPHEMERAL")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Ephemeral {
				get {
					if (EPHEMERAL_jfieldId == IntPtr.Zero)
						EPHEMERAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPHEMERAL", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EPHEMERAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EPHEMERAL_jfieldId == IntPtr.Zero)
						EPHEMERAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPHEMERAL", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EPHEMERAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MEMBER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='MEMBER_ID']"
			[Register ("MEMBER_ID")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields MemberId {
				get {
					if (MEMBER_ID_jfieldId == IntPtr.Zero)
						MEMBER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MEMBER_ID_jfieldId == IntPtr.Zero)
						MEMBER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MEMBER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr METADATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='METADATA']"
			[Register ("METADATA")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Metadata {
				get {
					if (METADATA_jfieldId == IntPtr.Zero)
						METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METADATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (METADATA_jfieldId == IntPtr.Zero)
						METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, METADATA_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PRECEDING_SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='PRECEDING_SEQ']"
			[Register ("PRECEDING_SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields PrecedingSeq {
				get {
					if (PRECEDING_SEQ_jfieldId == IntPtr.Zero)
						PRECEDING_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRECEDING_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRECEDING_SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PRECEDING_SEQ_jfieldId == IntPtr.Zero)
						PRECEDING_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRECEDING_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PRECEDING_SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SENDER_ORDER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='SENDER_ORDER']"
			[Register ("SENDER_ORDER")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields SenderOrder {
				get {
					if (SENDER_ORDER_jfieldId == IntPtr.Zero)
						SENDER_ORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENDER_ORDER", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENDER_ORDER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SENDER_ORDER_jfieldId == IntPtr.Zero)
						SENDER_ORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENDER_ORDER", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SENDER_ORDER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SENDER_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='SENDER_TOKEN']"
			[Register ("SENDER_TOKEN")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields SenderToken {
				get {
					if (SENDER_TOKEN_jfieldId == IntPtr.Zero)
						SENDER_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENDER_TOKEN", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENDER_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SENDER_TOKEN_jfieldId == IntPtr.Zero)
						SENDER_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENDER_TOKEN", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SENDER_TOKEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='SEQ']"
			[Register ("SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Seq {
				get {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SUBTYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='SUBTYPE']"
			[Register ("SUBTYPE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Subtype {
				get {
					if (SUBTYPE_jfieldId == IntPtr.Zero)
						SUBTYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBTYPE", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBTYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SUBTYPE_jfieldId == IntPtr.Zero)
						SUBTYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBTYPE", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SUBTYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TARGET_SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='TARGET_SEQ']"
			[Register ("TARGET_SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields TargetSeq {
				get {
					if (TARGET_SEQ_jfieldId == IntPtr.Zero)
						TARGET_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TARGET_SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TARGET_SEQ_jfieldId == IntPtr.Zero)
						TARGET_SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TARGET_SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TIMESTAMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='TIMESTAMP']"
			[Register ("TIMESTAMP")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Timestamp {
				get {
					if (TIMESTAMP_jfieldId == IntPtr.Zero)
						TIMESTAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMESTAMP", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMESTAMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TIMESTAMP_jfieldId == IntPtr.Zero)
						TIMESTAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMESTAMP", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TIMESTAMP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TRANSIENT_METADATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='TRANSIENT_METADATA']"
			[Register ("TRANSIENT_METADATA")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields TransientMetadata {
				get {
					if (TRANSIENT_METADATA_jfieldId == IntPtr.Zero)
						TRANSIENT_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSIENT_METADATA", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSIENT_METADATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TRANSIENT_METADATA_jfieldId == IntPtr.Zero)
						TRANSIENT_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSIENT_METADATA", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TRANSIENT_METADATA_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='TYPE']"
			[Register ("TYPE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Type {
				get {
					if (TYPE_jfieldId == IntPtr.Zero)
						TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TYPE_jfieldId == IntPtr.Zero)
						TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/field[@name='VERSION']"
			[Register ("VERSION")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields Version {
				get {
					if (VERSION_jfieldId == IntPtr.Zero)
						VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERSION_jfieldId == IntPtr.Zero)
						VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Lcom/layer/transport/thrift/sync/Event$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Event$_Fields", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (_Fields); }
			}

			internal _Fields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getFieldName;
			public string FieldName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Event$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Event$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Event._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Event$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Event$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Event$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Event$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Event$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Event$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Event._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/sync/Event$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Event._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/Event$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Sync.Event._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.Event._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Event", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Event); }
		}

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/constructor[@name='Event' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Event () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Event)) {
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

		static IntPtr id_ctor_Lcom_layer_transport_thrift_sync_Event_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/constructor[@name='Event' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Event']]"
		[Register (".ctor", "(Lcom/layer/transport/thrift/sync/Event;)V", "")]
		public Event (global::Com.Layer.Transport.Thrift.Sync.Event p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Event)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/transport/thrift/sync/Event;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/transport/thrift/sync/Event;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_transport_thrift_sync_Event_ == IntPtr.Zero)
				id_ctor_Lcom_layer_transport_thrift_sync_Event_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/transport/thrift/sync/Event;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Event_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Event_, new JValue (p0));
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("a", "(B)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event A (sbyte p0)
		{
			if (id_a_B == IntPtr.Zero)
				id_a_B = JNIEnv.GetMethodID (class_ref, "a", "(B)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_a_B, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_transport_thrift_sync_Event_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Event']]"
		[Register ("a", "(Lcom/layer/transport/thrift/sync/Event;)Z", "")]
		public bool A (global::Com.Layer.Transport.Thrift.Sync.Event p0)
		{
			if (id_a_Lcom_layer_transport_thrift_sync_Event_ == IntPtr.Zero)
				id_a_Lcom_layer_transport_thrift_sync_Event_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/transport/thrift/sync/Event;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_layer_transport_thrift_sync_Event_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_a_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_a_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "")]
		public void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Z, new JValue (p0));
		}

		static IntPtr id_b_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("b", "(I)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event B (int p0)
		{
			if (id_b_I == IntPtr.Zero)
				id_b_I = JNIEnv.GetMethodID (class_ref, "b", "(I)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_b_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='c' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("c", "(Z)V", "")]
		public void C (bool p0)
		{
			if (id_c_Z == IntPtr.Zero)
				id_c_Z = JNIEnv.GetMethodID (class_ref, "c", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Z, new JValue (p0));
		}

		static IntPtr id_c_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='c' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("c", "(I)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event C (int p0)
		{
			if (id_c_I == IntPtr.Zero)
				id_c_I = JNIEnv.GetMethodID (class_ref, "c", "(I)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_c_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static IntPtr id_d_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='d' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("d", "(Z)V", "")]
		public void D (bool p0)
		{
			if (id_d_Z == IntPtr.Zero)
				id_d_Z = JNIEnv.GetMethodID (class_ref, "d", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Z, new JValue (p0));
		}

		static IntPtr id_d_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='d' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("d", "(I)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event D (int p0)
		{
			if (id_d_I == IntPtr.Zero)
				id_d_I = JNIEnv.GetMethodID (class_ref, "d", "(I)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_d_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_e);
		}

		static IntPtr id_e_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='e' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("e", "(Z)V", "")]
		public void E (bool p0)
		{
			if (id_e_Z == IntPtr.Zero)
				id_e_Z = JNIEnv.GetMethodID (class_ref, "e", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_e_Z, new JValue (p0));
		}

		static IntPtr id_e_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='e' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("e", "(I)Lcom/layer/transport/thrift/sync/Event;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Event E (int p0)
		{
			if (id_e_I == IntPtr.Zero)
				id_e_I = JNIEnv.GetMethodID (class_ref, "e", "(I)Lcom/layer/transport/thrift/sync/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Event> (JNIEnv.CallObjectMethod  (Handle, id_e_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

		static IntPtr id_f_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='f' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("f", "(Z)V", "")]
		public void F (bool p0)
		{
			if (id_f_Z == IntPtr.Zero)
				id_f_Z = JNIEnv.GetMethodID (class_ref, "f", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_f_Z, new JValue (p0));
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_g);
		}

		static IntPtr id_g_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='g' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("g", "(Z)V", "")]
		public void G (bool p0)
		{
			if (id_g_Z == IntPtr.Zero)
				id_g_Z = JNIEnv.GetMethodID (class_ref, "g", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_g_Z, new JValue (p0));
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Z", "")]
		public bool H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_h);
		}

		static IntPtr id_h_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='h' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("h", "(Z)V", "")]
		public void H (bool p0)
		{
			if (id_h_Z == IntPtr.Zero)
				id_h_Z = JNIEnv.GetMethodID (class_ref, "h", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_h_Z, new JValue (p0));
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Z", "")]
		public bool I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_i);
		}

		static IntPtr id_i_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='i' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("i", "(Z)V", "")]
		public void I (bool p0)
		{
			if (id_i_Z == IntPtr.Zero)
				id_i_Z = JNIEnv.GetMethodID (class_ref, "i", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_i_Z, new JValue (p0));
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Z", "")]
		public bool J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_j);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Z", "")]
		public bool K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_k);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Z", "")]
		public bool L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_l);
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Z", "")]
		public bool M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_m);
		}

		static IntPtr id_n;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()Z", "")]
		public bool N ()
		{
			if (id_n == IntPtr.Zero)
				id_n = JNIEnv.GetMethodID (class_ref, "n", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_n);
		}

		static IntPtr id_o;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='o' and count(parameter)=0]"
		[Register ("o", "()Z", "")]
		public bool O ()
		{
			if (id_o == IntPtr.Zero)
				id_o = JNIEnv.GetMethodID (class_ref, "o", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_o);
		}

		static IntPtr id_p;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='p' and count(parameter)=0]"
		[Register ("p", "()Z", "")]
		public bool P ()
		{
			if (id_p == IntPtr.Zero)
				id_p = JNIEnv.GetMethodID (class_ref, "p", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_p);
		}

		static IntPtr id_q;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='q' and count(parameter)=0]"
		[Register ("q", "()Z", "")]
		public bool Q ()
		{
			if (id_q == IntPtr.Zero)
				id_q = JNIEnv.GetMethodID (class_ref, "q", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_q);
		}

		static IntPtr id_r;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='r' and count(parameter)=0]"
		[Register ("r", "()Z", "")]
		public bool R ()
		{
			if (id_r == IntPtr.Zero)
				id_r = JNIEnv.GetMethodID (class_ref, "r", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_r);
		}

		static IntPtr id_s;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='s' and count(parameter)=0]"
		[Register ("s", "()Z", "")]
		public bool S ()
		{
			if (id_s == IntPtr.Zero)
				id_s = JNIEnv.GetMethodID (class_ref, "s", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_s);
		}

		static IntPtr id_t;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='t' and count(parameter)=0]"
		[Register ("t", "()Z", "")]
		public bool T ()
		{
			if (id_t == IntPtr.Zero)
				id_t = JNIEnv.GetMethodID (class_ref, "t", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_t);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Event']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()V", "")]
		public void U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_u);
		}

	}
}
