using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCacheReconciler']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableCacheReconciler", DoNotGenerateAcw=true)]
	public partial class ChangeableCacheReconciler : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.IListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableCacheReconciler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableCacheReconciler); }
		}

		protected ChangeableCacheReconciler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCacheReconciler']/constructor[@name='ChangeableCacheReconciler' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableCache']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/messaging/ChangeableCache;)V", "")]
		public ChangeableCacheReconciler (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChangeableCacheReconciler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/messaging/ChangeableCache;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/messaging/ChangeableCache;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableCache_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/messaging/ChangeableCache;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableCache_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableCache_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCacheReconciler']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeEvent']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_, new JValue (p0));
		}

	}
}
