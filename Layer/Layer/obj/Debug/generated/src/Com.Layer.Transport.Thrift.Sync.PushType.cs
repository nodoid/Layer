using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/PushType", DoNotGenerateAcw=true)]
	public sealed partial class PushType : global::Java.Lang.Enum {


		static IntPtr APNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/field[@name='APNS']"
		[Register ("APNS")]
		public static global::Com.Layer.Transport.Thrift.Sync.PushType Apns {
			get {
				if (APNS_jfieldId == IntPtr.Zero)
					APNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APNS", "Lcom/layer/transport/thrift/sync/PushType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APNS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.PushType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APNS_jfieldId == IntPtr.Zero)
					APNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APNS", "Lcom/layer/transport/thrift/sync/PushType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APNS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GCM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/field[@name='GCM']"
		[Register ("GCM")]
		public static global::Com.Layer.Transport.Thrift.Sync.PushType Gcm {
			get {
				if (GCM_jfieldId == IntPtr.Zero)
					GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/layer/transport/thrift/sync/PushType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GCM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.PushType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GCM_jfieldId == IntPtr.Zero)
					GCM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GCM", "Lcom/layer/transport/thrift/sync/PushType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GCM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/PushType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushType); }
		}

		internal PushType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_findByValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/method[@name='findByValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findByValue", "(I)Lcom/layer/transport/thrift/sync/PushType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.PushType FindByValue (int p0)
		{
			if (id_findByValue_I == IntPtr.Zero)
				id_findByValue_I = JNIEnv.GetStaticMethodID (class_ref, "findByValue", "(I)Lcom/layer/transport/thrift/sync/PushType;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.PushType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByValue_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/PushType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.PushType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/PushType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Transport.Thrift.Sync.PushType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.PushType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='PushType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/transport/thrift/sync/PushType;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.PushType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/PushType;");
			return (global::Com.Layer.Transport.Thrift.Sync.PushType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.PushType));
		}

	}
}
