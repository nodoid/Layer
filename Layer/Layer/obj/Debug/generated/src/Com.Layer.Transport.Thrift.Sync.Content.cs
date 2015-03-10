using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Content", DoNotGenerateAcw=true)]
	public partial class Content : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']"
		[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/Content$_Fields", DoNotGenerateAcw=true)]
		public sealed partial class _Fields : global::Java.Lang.Enum {


			static IntPtr BODY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/field[@name='BODY']"
			[Register ("BODY")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields Body {
				get {
					if (BODY_jfieldId == IntPtr.Zero)
						BODY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BODY", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BODY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BODY_jfieldId == IntPtr.Zero)
						BODY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BODY", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BODY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXTERNAL_ACCESS_EXPIRATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/field[@name='EXTERNAL_ACCESS_EXPIRATION']"
			[Register ("EXTERNAL_ACCESS_EXPIRATION")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields ExternalAccessExpiration {
				get {
					if (EXTERNAL_ACCESS_EXPIRATION_jfieldId == IntPtr.Zero)
						EXTERNAL_ACCESS_EXPIRATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL_ACCESS_EXPIRATION", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTERNAL_ACCESS_EXPIRATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXTERNAL_ACCESS_EXPIRATION_jfieldId == IntPtr.Zero)
						EXTERNAL_ACCESS_EXPIRATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL_ACCESS_EXPIRATION", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXTERNAL_ACCESS_EXPIRATION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXTERNAL_URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/field[@name='EXTERNAL_URL']"
			[Register ("EXTERNAL_URL")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields ExternalUrl {
				get {
					if (EXTERNAL_URL_jfieldId == IntPtr.Zero)
						EXTERNAL_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL_URL", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTERNAL_URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXTERNAL_URL_jfieldId == IntPtr.Zero)
						EXTERNAL_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTERNAL_URL", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXTERNAL_URL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MEDIA_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/field[@name='MEDIA_TYPE']"
			[Register ("MEDIA_TYPE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields MediaType {
				get {
					if (MEDIA_TYPE_jfieldId == IntPtr.Zero)
						MEDIA_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIA_TYPE", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEDIA_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MEDIA_TYPE_jfieldId == IntPtr.Zero)
						MEDIA_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIA_TYPE", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MEDIA_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SIZE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/field[@name='SIZE']"
			[Register ("SIZE")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields Size {
				get {
					if (SIZE_jfieldId == IntPtr.Zero)
						SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SIZE_jfieldId == IntPtr.Zero)
						SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE", "Lcom/layer/transport/thrift/sync/Content$_Fields;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SIZE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Content$_Fields", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='getFieldName' and count(parameter)=0]"
				[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_getFieldName == IntPtr.Zero)
						id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getThriftFieldId;
			public short ThriftFieldId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='getThriftFieldId' and count(parameter)=0]"
				[Register ("getThriftFieldId", "()S", "GetGetThriftFieldIdHandler")]
				get {
					if (id_getThriftFieldId == IntPtr.Zero)
						id_getThriftFieldId = JNIEnv.GetMethodID (class_ref, "getThriftFieldId", "()S");
					return JNIEnv.CallShortMethod  (Handle, id_getThriftFieldId);
				}
			}

			static IntPtr id_findByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='findByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Content$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields FindByName (string p0)
			{
				if (id_findByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findByName", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Content$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Content._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findByThriftId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='findByThriftId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Content$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields FindByThriftId (int p0)
			{
				if (id_findByThriftId_I == IntPtr.Zero)
					id_findByThriftId_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftId", "(I)Lcom/layer/transport/thrift/sync/Content$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftId_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_findByThriftIdOrThrow_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='findByThriftIdOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Content$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields FindByThriftIdOrThrow (int p0)
			{
				if (id_findByThriftIdOrThrow_I == IntPtr.Zero)
					id_findByThriftIdOrThrow_I = JNIEnv.GetStaticMethodID (class_ref, "findByThriftIdOrThrow", "(I)Lcom/layer/transport/thrift/sync/Content$_Fields;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByThriftIdOrThrow_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Content$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/Content$_Fields;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Transport.Thrift.Sync.Content._Fields __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content._Fields> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content._Fields']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/transport/thrift/sync/Content$_Fields;", "")]
			public static global::Com.Layer.Transport.Thrift.Sync.Content._Fields[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/Content$_Fields;");
				return (global::Com.Layer.Transport.Thrift.Sync.Content._Fields[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.Content._Fields));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/Content", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Content); }
		}

		protected Content (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/constructor[@name='Content' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Content () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Content)) {
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

		static IntPtr id_ctor_Lcom_layer_transport_thrift_sync_Content_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/constructor[@name='Content' and count(parameter)=1 and parameter[1][@type='com.layer.transport.thrift.sync.Content']]"
		[Register (".ctor", "(Lcom/layer/transport/thrift/sync/Content;)V", "")]
		public Content (global::Com.Layer.Transport.Thrift.Sync.Content p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Content)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/transport/thrift/sync/Content;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/transport/thrift/sync/Content;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_transport_thrift_sync_Content_ == IntPtr.Zero)
				id_ctor_Lcom_layer_transport_thrift_sync_Content_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/transport/thrift/sync/Content;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Content_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_transport_thrift_sync_Content_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_a);
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)Lcom/layer/transport/thrift/sync/Content;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Content A (byte[] p0)
		{
			if (id_a_arrayB == IntPtr.Zero)
				id_a_arrayB = JNIEnv.GetMethodID (class_ref, "a", "([B)Lcom/layer/transport/thrift/sync/Content;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Layer.Transport.Thrift.Sync.Content __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content> (JNIEnv.CallObjectMethod  (Handle, id_a_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)Lcom/layer/transport/thrift/sync/Content;", "")]
		public global::Com.Layer.Transport.Thrift.Sync.Content A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)Lcom/layer/transport/thrift/sync/Content;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.Content> (JNIEnv.CallObjectMethod  (Handle, id_a_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "")]
		public void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Z, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()[B", "")]
		public byte[] C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='Content']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		public static void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetStaticMethodID (class_ref, "g", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g);
		}

	}
}
