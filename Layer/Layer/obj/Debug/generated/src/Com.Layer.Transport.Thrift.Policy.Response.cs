using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/policy/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/policy/Response$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/layer/transport/thrift/policy/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/layer/transport/thrift/policy/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr USER_IDS_WITH_TIMESTAMPS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/field[@name='USER_IDS_WITH_TIMESTAMPS']"
			[Register ("USER_IDS_WITH_TIMESTAMPS")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields UserIdsWithTimestamps {
				get {
					if (USER_IDS_WITH_TIMESTAMPS_jfieldId == IntPtr.Zero)
						USER_IDS_WITH_TIMESTAMPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_IDS_WITH_TIMESTAMPS", "Lcom/layer/transport/thrift/policy/Response$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_IDS_WITH_TIMESTAMPS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (USER_IDS_WITH_TIMESTAMPS_jfieldId == IntPtr.Zero)
						USER_IDS_WITH_TIMESTAMPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_IDS_WITH_TIMESTAMPS", "Lcom/layer/transport/thrift/policy/Response$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, USER_IDS_WITH_TIMESTAMPS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/policy/Response$_Fields", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/Response$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Policy.Response._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/policy/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/policy/Response$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/policy/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/policy/Response$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/Response$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Policy.Response._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.Response._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/policy/Response$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Policy.Response._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/policy/Response$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Policy.Response._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Policy.Response._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/policy/Response", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response']/constructor[@name='Response' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_a);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='Response']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

	}
}
