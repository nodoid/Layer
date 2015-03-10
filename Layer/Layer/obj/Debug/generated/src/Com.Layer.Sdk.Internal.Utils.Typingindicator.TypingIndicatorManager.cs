using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Typingindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorManager']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager", DoNotGenerateAcw=true)]
	public partial class TypingIndicatorManager : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Handlers.IEphemeralEventHandler, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorManager.Callback']"
		[Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback", "", "Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorManager.Callback']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
			[Register ("a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetA_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager/ICallbackInvoker, Layer")]
			void A (string p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorManager.Callback']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
			[Register ("b", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetB_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager/ICallbackInvoker, Layer")]
			void B (global::Java.Util.UUID p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.typingindicator.TypingIndicatorManager.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
			{
				if (cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
					cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
				return cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			}

			static void n_A_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			public void A (string p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2)
			{
				if (id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
					id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
			static Delegate GetB_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
			{
				if (cb_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
					cb_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
				return cb_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			}

			static void n_B_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.B (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			public void B (global::Java.Util.UUID p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1)
			{
				if (id_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
					id_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
				JNIEnv.CallVoidMethod (Handle, id_b_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypingIndicatorManager); }
		}

		protected TypingIndicatorManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorManager_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorManager']/constructor[@name='TypingIndicatorManager' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor'] and parameter[2][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorManager.Callback']]"
		[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback;)V", "")]
		public TypingIndicatorManager (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorManager.ICallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TypingIndicatorManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorManager_Callback_ == IntPtr.Zero)
				id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorManager_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorManager$Callback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorManager_Callback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorManager_Callback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer']]"
		[Register ("a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0)
		{
			if (id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorManager']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2)
		{
			if (id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("a", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "")]
		public void A (global::Java.Util.UUID p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1)
		{
			if (id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1));
		}

	}
}
