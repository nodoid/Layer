using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableTransaction", DoNotGenerateAcw=true)]
	public partial class ChangeableTransaction : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableTransaction$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction.Type']/field[@name='a']"
			[Register ("a")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction.Type']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction.Type']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableTransaction$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableTransaction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableTransaction); }
		}

		protected ChangeableTransaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']/constructor[@name='ChangeableTransaction' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction.Type'] and parameter[2][@type='com.layer.sdk.internal.messaging.ChangeEvent.Emitter']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V", "")]
		public ChangeableTransaction (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type p0, global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent.IEmitter p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChangeableTransaction)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		protected void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_Change_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Change;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeEvent.Emitter']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent.IEmitter p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent$Emitter;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_Emitter_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_Changeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableTransaction']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Changeable']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Changeable;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.IChangeable p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Changeable_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Changeable_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Changeable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_Changeable_, new JValue (p0));
		}

	}
}
