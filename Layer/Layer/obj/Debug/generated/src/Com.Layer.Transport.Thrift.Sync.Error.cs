using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Error", DoNotGenerateAcw=true)]
	public partial class Error : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Error$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/field[@name='CODE']"
			[Register ("CODE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields Code {
				get {
					if (CODE_jfieldId == IntPtr.Zero)
						CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CODE_jfieldId == IntPtr.Zero)
						CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CODE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DETAILS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/field[@name='DETAILS']"
			[Register ("DETAILS")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields Details {
				get {
					if (DETAILS_jfieldId == IntPtr.Zero)
						DETAILS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DETAILS", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DETAILS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DETAILS_jfieldId == IntPtr.Zero)
						DETAILS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DETAILS", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DETAILS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXPECTED_VERSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/field[@name='EXPECTED_VERSION']"
			[Register ("EXPECTED_VERSION")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields ExpectedVersion {
				get {
					if (EXPECTED_VERSION_jfieldId == IntPtr.Zero)
						EXPECTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPECTED_VERSION", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPECTED_VERSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXPECTED_VERSION_jfieldId == IntPtr.Zero)
						EXPECTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPECTED_VERSION", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXPECTED_VERSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/transport/thrift/sync/Error$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Error$_Fields", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Error$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Error$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Error._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Error$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Error$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Error$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Error$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Error$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Error$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Error._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Error._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/sync/Error$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Error._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/Error$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Sync.Error._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.Error._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Error", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Error); }
		}

		protected Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/constructor[@name='Error' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Error () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Error)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_a);
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_transport_thrift_sync_Error_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Error']]"
		[Register ("a", "(Lcom/layer/transport/thrift/sync/Error;)Z", "")]
		public bool A (global::Com.Layer.Transport.Thrift.Sync.Error p0)
		{
			if (id_a_Lcom_layer_transport_thrift_sync_Error_ == IntPtr.Zero)
				id_a_Lcom_layer_transport_thrift_sync_Error_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/transport/thrift/sync/Error;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_layer_transport_thrift_sync_Error_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Error']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public static void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetStaticMethodID (class_ref, "e", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e);
		}

	}
}
