using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Stream", DoNotGenerateAcw=true)]
	public partial class Stream : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {


		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/field[@name='d']"
		[Register ("d")]
		public int D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "I");
				return JNIEnv.GetIntField (Handle, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "I");
				JNIEnv.SetField (Handle, d_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Stream$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields ClientId {
				get {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONFIG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='CONFIG']"
			[Register ("CONFIG")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields Config {
				get {
					if (CONFIG_jfieldId == IntPtr.Zero)
						CONFIG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFIG", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFIG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONFIG_jfieldId == IntPtr.Zero)
						CONFIG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFIG", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONFIG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MEMBER_IDS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='MEMBER_IDS']"
			[Register ("MEMBER_IDS")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields MemberIds {
				get {
					if (MEMBER_IDS_jfieldId == IntPtr.Zero)
						MEMBER_IDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_IDS", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_IDS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MEMBER_IDS_jfieldId == IntPtr.Zero)
						MEMBER_IDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_IDS", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MEMBER_IDS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr METADATA_TIMESTAMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='METADATA_TIMESTAMP']"
			[Register ("METADATA_TIMESTAMP")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields MetadataTimestamp {
				get {
					if (METADATA_TIMESTAMP_jfieldId == IntPtr.Zero)
						METADATA_TIMESTAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_TIMESTAMP", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METADATA_TIMESTAMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (METADATA_TIMESTAMP_jfieldId == IntPtr.Zero)
						METADATA_TIMESTAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_TIMESTAMP", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, METADATA_TIMESTAMP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='SEQ']"
			[Register ("SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields Seq {
				get {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='STREAM_ID']"
			[Register ("STREAM_ID")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields StreamId {
				get {
					if (STREAM_ID_jfieldId == IntPtr.Zero)
						STREAM_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_ID", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_ID_jfieldId == IntPtr.Zero)
						STREAM_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_ID", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/field[@name='VERSION']"
			[Register ("VERSION")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields Version {
				get {
					if (VERSION_jfieldId == IntPtr.Zero)
						VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERSION_jfieldId == IntPtr.Zero)
						VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Lcom/layer/transport/thrift/sync/Stream$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Stream$_Fields", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Stream$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Stream$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Stream._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Stream$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Stream$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Stream$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Stream$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Stream$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Stream$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Stream._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Stream._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/sync/Stream$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Stream._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/Stream$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Sync.Stream._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.Stream._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Stream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stream); }
		}

		protected Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/constructor[@name='Stream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Stream () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Stream)) {
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

		static IntPtr id_ctor_Lcom_layer_transport_thrift_sync_Stream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/constructor[@name='Stream' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Stream']]"
		[Register (".ctor", "(Lcom/layer/transport/thrift/sync/Stream;)V", "")]
		public Stream (global::Com.Layer.Transport.Thrift.Sync.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Stream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/transport/thrift/sync/Stream;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/transport/thrift/sync/Stream;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_transport_thrift_sync_Stream_ == IntPtr.Zero)
				id_ctor_Lcom_layer_transport_thrift_sync_Stream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/transport/thrift/sync/Stream;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Stream_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Stream_, new JValue (p0));
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_transport_thrift_sync_Stream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Stream']]"
		[Register ("a", "(Lcom/layer/transport/thrift/sync/Stream;)Z", "")]
		public bool A (global::Com.Layer.Transport.Thrift.Sync.Stream p0)
		{
			if (id_a_Lcom_layer_transport_thrift_sync_Stream_ == IntPtr.Zero)
				id_a_Lcom_layer_transport_thrift_sync_Stream_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/transport/thrift/sync/Stream;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_layer_transport_thrift_sync_Stream_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "")]
		public void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Z, new JValue (p0));
		}

		static IntPtr id_c_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='c' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("c", "(Z)V", "")]
		public void C (bool p0)
		{
			if (id_c_Z == IntPtr.Zero)
				id_c_Z = JNIEnv.GetMethodID (class_ref, "c", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Z, new JValue (p0));
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()[B", "")]
		public byte[] E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_g);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Z", "")]
		public bool H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_h);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Z", "")]
		public bool I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_i);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Z", "")]
		public bool J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_j);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Z", "")]
		public bool K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_k);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Z", "")]
		public bool L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_l);
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Stream']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()V", "")]
		public static void M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetStaticMethodID (class_ref, "m", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_m);
		}

	}
}
