using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']"
	[Register ("com/layer/sdk/internal/messaging/ChangeableExecutor", "", "Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker")]
	public partial interface IChangeableExecutor : global::Com.Layer.Sdk.Internal.Alerters.ISyncableActionAlerter {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[2][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Lcom/layer/sdk/messaging/Conversation;)V", "GetA_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, global::Com.Layer.Sdk.Messaging.Conversation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.ExecutorValidator.Callback']]"
		[Register ("a", "(Lcom/layer/sdk/internal/utils/ExecutorValidator$Callback;)V", "GetA_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("a", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetA_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void A (global::Java.Util.UUID p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "GetGHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void G ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "GetHHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void H ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableExecutor']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "GetIHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableExecutorInvoker, Layer")]
		void I ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableExecutor", DoNotGenerateAcw=true)]
	internal class IChangeableExecutorInvoker : global::Java.Lang.Object, IChangeableExecutor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableExecutor");
		IntPtr class_ref;

		public static IChangeableExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChangeableExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeableExecutor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChangeableExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IChangeableExecutorInvoker); }
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_);
			return cb_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_;
		}

		static void n_A_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_;
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, global::Com.Layer.Sdk.Messaging.Conversation p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ == null)
				cb_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_);
			return cb_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_;
		}

		static void n_A_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback p0 = (global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_;
		public void A (global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback p0)
		{
			if (id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/ExecutorValidator$Callback;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_, new JValue (p0));
		}

		static Delegate cb_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
		{
			if (cb_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
				cb_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
			return cb_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		}

		static void n_A_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		public void A (global::Java.Util.UUID p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1)
		{
			if (id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_G);
			return cb_g;
		}

		static void n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.G ();
		}
#pragma warning restore 0169

		IntPtr id_g;
		public void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			JNIEnv.CallVoidMethod (Handle, id_g);
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_H);
			return cb_h;
		}

		static void n_H (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.H ();
		}
#pragma warning restore 0169

		IntPtr id_h;
		public void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			JNIEnv.CallVoidMethod (Handle, id_h);
		}

		static Delegate cb_i;
#pragma warning disable 0169
		static Delegate GetIHandler ()
		{
			if (cb_i == null)
				cb_i = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_I);
			return cb_i;
		}

		static void n_I (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.I ();
		}
#pragma warning restore 0169

		IntPtr id_i;
		public void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			JNIEnv.CallVoidMethod (Handle, id_i);
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static void n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.F ();
		}
#pragma warning restore 0169

		IntPtr id_f;
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod (Handle, id_f);
		}

	}

}
