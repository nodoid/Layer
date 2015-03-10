using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/EventType", DoNotGenerateAcw=true)]
	public sealed partial class EventType : global::Java.Lang.Enum {


		static IntPtr APPLICATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='APPLICATION']"
		[Register ("APPLICATION")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType Application {
			get {
				if (APPLICATION_jfieldId == IntPtr.Zero)
					APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_jfieldId == IntPtr.Zero)
					APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APPLICATION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EVENT_DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='EVENT_DELETED']"
		[Register ("EVENT_DELETED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType EventDeleted {
			get {
				if (EVENT_DELETED_jfieldId == IntPtr.Zero)
					EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVENT_DELETED_jfieldId == IntPtr.Zero)
					EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EVENT_DELETED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MEMBER_ADDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='MEMBER_ADDED']"
		[Register ("MEMBER_ADDED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MemberAdded {
			get {
				if (MEMBER_ADDED_jfieldId == IntPtr.Zero)
					MEMBER_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ADDED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_ADDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MEMBER_ADDED_jfieldId == IntPtr.Zero)
					MEMBER_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ADDED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MEMBER_ADDED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MEMBER_REMOVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='MEMBER_REMOVED']"
		[Register ("MEMBER_REMOVED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MemberRemoved {
			get {
				if (MEMBER_REMOVED_jfieldId == IntPtr.Zero)
					MEMBER_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_REMOVED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_REMOVED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MEMBER_REMOVED_jfieldId == IntPtr.Zero)
					MEMBER_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_REMOVED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MEMBER_REMOVED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MESSAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType Message {
			get {
				if (MESSAGE_jfieldId == IntPtr.Zero)
					MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MESSAGE_jfieldId == IntPtr.Zero)
					MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MESSAGE_DELIVERED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='MESSAGE_DELIVERED']"
		[Register ("MESSAGE_DELIVERED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MessageDelivered {
			get {
				if (MESSAGE_DELIVERED_jfieldId == IntPtr.Zero)
					MESSAGE_DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELIVERED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MESSAGE_DELIVERED_jfieldId == IntPtr.Zero)
					MESSAGE_DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MESSAGE_DELIVERED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MESSAGE_READ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='MESSAGE_READ']"
		[Register ("MESSAGE_READ")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MessageRead {
			get {
				if (MESSAGE_READ_jfieldId == IntPtr.Zero)
					MESSAGE_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_READ", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_READ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MESSAGE_READ_jfieldId == IntPtr.Zero)
					MESSAGE_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_READ", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MESSAGE_READ_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr METADATA_ADDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='METADATA_ADDED']"
		[Register ("METADATA_ADDED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MetadataAdded {
			get {
				if (METADATA_ADDED_jfieldId == IntPtr.Zero)
					METADATA_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_ADDED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METADATA_ADDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (METADATA_ADDED_jfieldId == IntPtr.Zero)
					METADATA_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_ADDED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, METADATA_ADDED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr METADATA_REMOVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='METADATA_REMOVED']"
		[Register ("METADATA_REMOVED")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType MetadataRemoved {
			get {
				if (METADATA_REMOVED_jfieldId == IntPtr.Zero)
					METADATA_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_REMOVED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METADATA_REMOVED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (METADATA_REMOVED_jfieldId == IntPtr.Zero)
					METADATA_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_REMOVED", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, METADATA_REMOVED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TOMBSTONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/field[@name='TOMBSTONE']"
		[Register ("TOMBSTONE")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType Tombstone {
			get {
				if (TOMBSTONE_jfieldId == IntPtr.Zero)
					TOMBSTONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOMBSTONE", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOMBSTONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TOMBSTONE_jfieldId == IntPtr.Zero)
					TOMBSTONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOMBSTONE", "Lcom/layer/transport/thrift/sync/EventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TOMBSTONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/EventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventType); }
		}

		internal EventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_findByValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/method[@name='findByValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findByValue", "(I)Lcom/layer/transport/thrift/sync/EventType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType FindByValue (int p0)
		{
			if (id_findByValue_I == IntPtr.Zero)
				id_findByValue_I = JNIEnv.GetStaticMethodID (class_ref, "findByValue", "(I)Lcom/layer/transport/thrift/sync/EventType;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByValue_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/EventType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/EventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Transport.Thrift.Sync.EventType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.EventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='EventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/transport/thrift/sync/EventType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.EventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/EventType;");
			return (global::Com.Layer.Transport.Thrift.Sync.EventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.EventType));
		}

	}
}
