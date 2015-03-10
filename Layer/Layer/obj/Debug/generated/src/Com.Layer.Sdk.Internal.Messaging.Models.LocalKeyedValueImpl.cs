using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl", DoNotGenerateAcw=true)]
	public partial class LocalKeyedValueImpl : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.KeyType']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType", DoNotGenerateAcw=true)]
		public sealed partial class KeyType : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.KeyType']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.KeyType']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KeyType); }
			}

			internal KeyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.KeyType']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()I", "")]
			public int A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_a);
			}

			static IntPtr id_a_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.KeyType']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("a", "(I)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType A (int p0)
			{
				if (id_a_I == IntPtr.Zero)
					id_a_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(I)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.ObjectType']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType", DoNotGenerateAcw=true)]
		public sealed partial class ObjectType : global::Java.Lang.Enum {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ObjectType); }
			}

			internal ObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.ObjectType']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;");
				return (global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType));
			}

			static IntPtr id_a_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.ObjectType']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("a", "(Ljava/lang/String;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType A (string p0)
			{
				if (id_a_Ljava_lang_String_ == IntPtr.Zero)
					id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl.ObjectType']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/String;", "")]
			public string B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/LocalKeyedValueImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalKeyedValueImpl); }
		}

		protected LocalKeyedValueImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/constructor[@name='LocalKeyedValueImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LocalKeyedValueImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocalKeyedValueImpl)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.KeyType']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.ObjectType']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "")]
		public void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "")]
		public void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("c", "(Ljava/lang/Long;)V", "")]
		public void C (global::Java.Lang.Long p0)
		{
			if (id_c_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "")]
		public string G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_g), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='LocalKeyedValueImpl']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

	}
}
