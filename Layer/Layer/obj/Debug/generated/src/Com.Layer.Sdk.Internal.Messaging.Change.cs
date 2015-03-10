using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/Change", DoNotGenerateAcw=true)]
	public partial class Change : global::Com.Layer.Sdk.Changes.LayerChange {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/Change", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Change); }
		}

		protected Change (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_internal_messaging_Changeable_Lcom_layer_sdk_internal_messaging_ChangeableAttribute_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/constructor[@name='Change' and count(parameter)=5 and parameter[1][@type='com.layer.sdk.changes.LayerChange.Type'] and parameter[2][@type='com.layer.sdk.internal.messaging.Changeable'] and parameter[3][@type='com.layer.sdk.internal.messaging.ChangeableAttribute'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/internal/messaging/Changeable;Lcom/layer/sdk/internal/messaging/ChangeableAttribute;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public Change (global::Com.Layer.Sdk.Changes.LayerChange.Type p0, global::Com.Layer.Sdk.Internal.Messaging.IChangeable p1, global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Change)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/internal/messaging/Changeable;Lcom/layer/sdk/internal/messaging/ChangeableAttribute;Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/internal/messaging/Changeable;Lcom/layer/sdk/internal/messaging/ChangeableAttribute;Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_internal_messaging_Changeable_Lcom_layer_sdk_internal_messaging_ChangeableAttribute_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_internal_messaging_Changeable_Lcom_layer_sdk_internal_messaging_ChangeableAttribute_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/internal/messaging/Changeable;Lcom/layer/sdk/internal/messaging/ChangeableAttribute;Ljava/lang/Object;Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_internal_messaging_Changeable_Lcom_layer_sdk_internal_messaging_ChangeableAttribute_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_internal_messaging_Changeable_Lcom_layer_sdk_internal_messaging_ChangeableAttribute_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/layer/sdk/internal/messaging/Changeable;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeable A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/messaging/Changeable;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)V", "")]
		public void A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_a_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/messaging/ChangeableAttribute;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/messaging/ChangeableAttribute;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("b", "(Ljava/lang/Object;)V", "")]
		public void B (global::Java.Lang.Object p0)
		{
			if (id_b_Ljava_lang_Object_ == IntPtr.Zero)
				id_b_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='Change']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/changes/LayerChange;", "")]
		public global::Com.Layer.Sdk.Changes.LayerChange C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/changes/LayerChange;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

	}
}
