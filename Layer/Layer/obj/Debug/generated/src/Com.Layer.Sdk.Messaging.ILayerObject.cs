using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']"
	[global::Android.Runtime.Register ("com/layer/sdk/messaging/LayerObject$Type", DoNotGenerateAcw=true)]
	public sealed partial class LayerObjectType : global::Java.Lang.Enum {


		static IntPtr CONVERSATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']/field[@name='CONVERSATION']"
		[Register ("CONVERSATION")]
		public static global::Com.Layer.Sdk.Messaging.LayerObjectType Conversation {
			get {
				if (CONVERSATION_jfieldId == IntPtr.Zero)
					CONVERSATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION", "Lcom/layer/sdk/messaging/LayerObject$Type;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONVERSATION_jfieldId == IntPtr.Zero)
					CONVERSATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION", "Lcom/layer/sdk/messaging/LayerObject$Type;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CONVERSATION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MESSAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public static global::Com.Layer.Sdk.Messaging.LayerObjectType Message {
			get {
				if (MESSAGE_jfieldId == IntPtr.Zero)
					MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/sdk/messaging/LayerObject$Type;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MESSAGE_jfieldId == IntPtr.Zero)
					MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/layer/sdk/messaging/LayerObject$Type;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/messaging/LayerObject$Type", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerObjectType); }
		}

		internal LayerObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromObject_Lcom_layer_sdk_messaging_LayerObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']/method[@name='fromObject' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.LayerObject']]"
		[Register ("fromObject", "(Lcom/layer/sdk/messaging/LayerObject;)Lcom/layer/sdk/messaging/LayerObject$Type;", "")]
		public static global::Com.Layer.Sdk.Messaging.LayerObjectType FromObject (global::Com.Layer.Sdk.Messaging.ILayerObject p0)
		{
			if (id_fromObject_Lcom_layer_sdk_messaging_LayerObject_ == IntPtr.Zero)
				id_fromObject_Lcom_layer_sdk_messaging_LayerObject_ = JNIEnv.GetStaticMethodID (class_ref, "fromObject", "(Lcom/layer/sdk/messaging/LayerObject;)Lcom/layer/sdk/messaging/LayerObject$Type;");
			global::Com.Layer.Sdk.Messaging.LayerObjectType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromObject_Lcom_layer_sdk_messaging_LayerObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/LayerObject$Type;", "")]
		public static global::Com.Layer.Sdk.Messaging.LayerObjectType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/LayerObject$Type;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Messaging.LayerObjectType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='LayerObject.Type']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/sdk/messaging/LayerObject$Type;", "")]
		public static global::Com.Layer.Sdk.Messaging.LayerObjectType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/LayerObject$Type;");
			return (global::Com.Layer.Sdk.Messaging.LayerObjectType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.LayerObjectType));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.messaging']/interface[@name='LayerObject']"
	[Register ("com/layer/sdk/messaging/LayerObject", "", "Com.Layer.Sdk.Messaging.ILayerObjectInvoker")]
	public partial interface ILayerObject : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/messaging/LayerObject", DoNotGenerateAcw=true)]
	internal class ILayerObjectInvoker : global::Java.Lang.Object, ILayerObject {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/messaging/LayerObject");
		IntPtr class_ref;

		public static ILayerObject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerObject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.messaging.LayerObject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerObjectInvoker); }
		}

	}

}
