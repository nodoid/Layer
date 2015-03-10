using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Response$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='CONTENT']"
			[Register ("CONTENT")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Content {
				get {
					if (CONTENT_jfieldId == IntPtr.Zero)
						CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONTENT_jfieldId == IntPtr.Zero)
						CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONTENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='EVENT']"
			[Register ("EVENT")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Event {
				get {
					if (EVENT_jfieldId == IntPtr.Zero)
						EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_jfieldId == IntPtr.Zero)
						EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SEQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='SEQ']"
			[Register ("SEQ")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Seq {
				get {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SEQ_jfieldId == IntPtr.Zero)
						SEQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEQ", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SEQ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='STREAM']"
			[Register ("STREAM")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Stream {
				get {
					if (STREAM_jfieldId == IntPtr.Zero)
						STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_jfieldId == IntPtr.Zero)
						STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='STREAMS']"
			[Register ("STREAMS")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields Streams {
				get {
					if (STREAMS_jfieldId == IntPtr.Zero)
						STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAMS", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAMS_jfieldId == IntPtr.Zero)
						STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAMS", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAMS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_METADATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/field[@name='STREAM_METADATA']"
			[Register ("STREAM_METADATA")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields StreamMetadata {
				get {
					if (STREAM_METADATA_jfieldId == IntPtr.Zero)
						STREAM_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_METADATA", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_METADATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_METADATA_jfieldId == IntPtr.Zero)
						STREAM_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_METADATA", "Lcom/layer/transport/thrift/sync/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_METADATA_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Response$_Fields", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Response$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Response._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Response$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Response$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Response$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Response._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/sync/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Response._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/Response$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Sync.Response._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.Response._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/constructor[@name='Response' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Response () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Response)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_a);
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_g);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Response']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "")]
		public void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_h);
		}

	}
}
