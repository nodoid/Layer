using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='ConversationOptions']"
	[global::Android.Runtime.Register ("com/layer/sdk/messaging/ConversationOptions", DoNotGenerateAcw=true)]
	public partial class ConversationOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/messaging/ConversationOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationOptions); }
		}

		protected ConversationOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='ConversationOptions']/constructor[@name='ConversationOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ConversationOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConversationOptions)) {
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

		static Delegate cb_isDeliveryReceipts;
#pragma warning disable 0169
		static Delegate GetIsDeliveryReceiptsHandler ()
		{
			if (cb_isDeliveryReceipts == null)
				cb_isDeliveryReceipts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeliveryReceipts);
			return cb_isDeliveryReceipts;
		}

		static bool n_IsDeliveryReceipts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Messaging.ConversationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeliveryReceipts;
		}
#pragma warning restore 0169

		static IntPtr id_isDeliveryReceipts;
		public virtual bool IsDeliveryReceipts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='ConversationOptions']/method[@name='isDeliveryReceipts' and count(parameter)=0]"
			[Register ("isDeliveryReceipts", "()Z", "GetIsDeliveryReceiptsHandler")]
			get {
				if (id_isDeliveryReceipts == IntPtr.Zero)
					id_isDeliveryReceipts = JNIEnv.GetMethodID (class_ref, "isDeliveryReceipts", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDeliveryReceipts);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeliveryReceipts", "()Z"));
			}
		}

		static Delegate cb_deliveryReceipts_Z;
#pragma warning disable 0169
		static Delegate GetDeliveryReceipts_ZHandler ()
		{
			if (cb_deliveryReceipts_Z == null)
				cb_deliveryReceipts_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_DeliveryReceipts_Z);
			return cb_deliveryReceipts_Z;
		}

		static IntPtr n_DeliveryReceipts_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Layer.Sdk.Messaging.ConversationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeliveryReceipts (p0));
		}
#pragma warning restore 0169

		static IntPtr id_deliveryReceipts_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='ConversationOptions']/method[@name='deliveryReceipts' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("deliveryReceipts", "(Z)Lcom/layer/sdk/messaging/ConversationOptions;", "GetDeliveryReceipts_ZHandler")]
		public virtual global::Com.Layer.Sdk.Messaging.ConversationOptions DeliveryReceipts (bool p0)
		{
			if (id_deliveryReceipts_Z == IntPtr.Zero)
				id_deliveryReceipts_Z = JNIEnv.GetMethodID (class_ref, "deliveryReceipts", "(Z)Lcom/layer/sdk/messaging/ConversationOptions;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (JNIEnv.CallObjectMethod  (Handle, id_deliveryReceipts_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryReceipts", "(Z)Lcom/layer/sdk/messaging/ConversationOptions;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
