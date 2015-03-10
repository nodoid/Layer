using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/policy/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr POLICY_INTERNAL_SERVER_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/field[@name='POLICY_INTERNAL_SERVER_ERROR']"
		[Register ("POLICY_INTERNAL_SERVER_ERROR")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode PolicyInternalServerError {
			get {
				if (POLICY_INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
					POLICY_INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_INTERNAL_SERVER_ERROR", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLICY_INTERNAL_SERVER_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POLICY_INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
					POLICY_INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_INTERNAL_SERVER_ERROR", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POLICY_INTERNAL_SERVER_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POLICY_REQUEST_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/field[@name='POLICY_REQUEST_TIMEOUT']"
		[Register ("POLICY_REQUEST_TIMEOUT")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode PolicyRequestTimeout {
			get {
				if (POLICY_REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
					POLICY_REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_REQUEST_TIMEOUT", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLICY_REQUEST_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POLICY_REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
					POLICY_REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_REQUEST_TIMEOUT", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POLICY_REQUEST_TIMEOUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POLICY_SERVICE_UNAVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/field[@name='POLICY_SERVICE_UNAVAILABLE']"
		[Register ("POLICY_SERVICE_UNAVAILABLE")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode PolicyServiceUnavailable {
			get {
				if (POLICY_SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
					POLICY_SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_SERVICE_UNAVAILABLE", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLICY_SERVICE_UNAVAILABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POLICY_SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
					POLICY_SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_SERVICE_UNAVAILABLE", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POLICY_SERVICE_UNAVAILABLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POLICY_UNSPECIFIED_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/field[@name='POLICY_UNSPECIFIED_ERROR']"
		[Register ("POLICY_UNSPECIFIED_ERROR")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode PolicyUnspecifiedError {
			get {
				if (POLICY_UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
					POLICY_UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_UNSPECIFIED_ERROR", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLICY_UNSPECIFIED_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POLICY_UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
					POLICY_UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLICY_UNSPECIFIED_ERROR", "Lcom/layer/transport/thrift/policy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POLICY_UNSPECIFIED_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/policy/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_findByValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/method[@name='findByValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findByValue", "(I)Lcom/layer/transport/thrift/policy/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode FindByValue (int p0)
		{
			if (id_findByValue_I == IntPtr.Zero)
				id_findByValue_I = JNIEnv.GetStaticMethodID (class_ref, "findByValue", "(I)Lcom/layer/transport/thrift/policy/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByValue_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/policy/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Transport.Thrift.Policy.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Policy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.policy']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/transport/thrift/policy/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Policy.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/policy/ErrorCode;");
			return (global::Com.Layer.Transport.Thrift.Policy.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Policy.ErrorCode));
		}

	}
}
