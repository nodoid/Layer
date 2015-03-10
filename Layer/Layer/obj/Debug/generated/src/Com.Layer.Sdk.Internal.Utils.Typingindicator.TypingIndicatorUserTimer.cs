using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Typingindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer", DoNotGenerateAcw=true)]
	public partial class TypingIndicatorUserTimer : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorUserTimer.Callback']"
		[Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$Callback", "", "Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorUserTimer.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer']]"
			[Register ("a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;)V", "GetA_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Handler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer/ICallbackInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorUserTimer.Callback']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
			[Register ("a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetA_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer/ICallbackInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer.Callback"));
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

			static Delegate cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ == null)
					cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_);
				return cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_;
			}

			static void n_A_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_;
			public void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0)
			{
				if (id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_, new JValue (p0));
			}

			static Delegate cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
					cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
				return cb_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			}

			static void n_A_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
			public void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p2)
			{
				if (id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer;Ljava/util/UUID;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Ljava_util_UUID_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.HeartbeatTimer']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$HeartbeatTimer", DoNotGenerateAcw=true)]
		public partial class HeartbeatTimer : global::Com.Layer.Sdk.Internal.Utils.Timer.Repeater {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$HeartbeatTimer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeartbeatTimer); }
			}

			protected HeartbeatTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.HeartbeatTimer']/constructor[@name='TypingIndicatorUserTimer.HeartbeatTimer' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor'] and parameter[2][@type='java.util.concurrent.atomic.AtomicBoolean'] and parameter[3][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorStateMachine']]"
			[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", "")]
			public HeartbeatTimer (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0, global::Java.Util.Concurrent.Atomic.AtomicBoolean p1, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (HeartbeatTimer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.HeartbeatTimer __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.HeartbeatTimer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.HeartbeatTimer']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.PausedTimer']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$PausedTimer", DoNotGenerateAcw=true)]
		public partial class PausedTimer : global::Com.Layer.Sdk.Internal.Utils.Timer.Oneshot {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$PausedTimer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PausedTimer); }
			}

			protected PausedTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.PausedTimer']/constructor[@name='TypingIndicatorUserTimer.PausedTimer' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor'] and parameter[2][@type='java.util.concurrent.atomic.AtomicBoolean'] and parameter[3][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorStateMachine']]"
			[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", "")]
			public PausedTimer (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0, global::Java.Util.Concurrent.Atomic.AtomicBoolean p1, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PausedTimer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.PausedTimer __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.PausedTimer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.PausedTimer']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.StartedTimer']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$StartedTimer", DoNotGenerateAcw=true)]
		public partial class StartedTimer : global::Com.Layer.Sdk.Internal.Utils.Timer.Oneshot {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$StartedTimer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StartedTimer); }
			}

			protected StartedTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.StartedTimer']/constructor[@name='TypingIndicatorUserTimer.StartedTimer' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor'] and parameter[2][@type='java.util.concurrent.atomic.AtomicBoolean'] and parameter[3][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorStateMachine']]"
			[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", "")]
			public StartedTimer (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0, global::Java.Util.Concurrent.Atomic.AtomicBoolean p1, global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (StartedTimer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_util_concurrent_atomic_AtomicBoolean_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorStateMachine_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.StartedTimer __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.StartedTimer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer.StartedTimer']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypingIndicatorUserTimer); }
		}

		protected TypingIndicatorUserTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_lang_String_Ljava_util_UUID_JJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/constructor[@name='TypingIndicatorUserTimer' and count(parameter)=6 and parameter[1][@type='java.util.concurrent.ScheduledThreadPoolExecutor'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register (".ctor", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/String;Ljava/util/UUID;JJJ)V", "")]
		public TypingIndicatorUserTimer (global::Java.Util.Concurrent.ScheduledThreadPoolExecutor p0, string p1, global::Java.Util.UUID p2, long p3, long p4, long p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (TypingIndicatorUserTimer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/String;Ljava/util/UUID;JJJ)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/String;Ljava/util/UUID;JJJ)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_lang_String_Ljava_util_UUID_JJJ == IntPtr.Zero)
				id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_lang_String_Ljava_util_UUID_JJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledThreadPoolExecutor;Ljava/lang/String;Ljava/util/UUID;JJJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_lang_String_Ljava_util_UUID_JJJ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledThreadPoolExecutor_Ljava_lang_String_Ljava_util_UUID_JJJ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.typingindicator.TypingIndicatorUserTimer.Callback']]"
		[Register ("a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$Callback;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorUserTimer.ICallback p0)
		{
			if (id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Callback_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Callback_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorUserTimer$Callback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_utils_typingindicator_TypingIndicatorUserTimer_Callback_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("a", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "")]
		public void A (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0)
		{
			if (id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_f);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		public void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_g);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "")]
		public void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_h);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "")]
		protected void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_i);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Z", "")]
		public bool J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_j);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Ljava/lang/String;", "")]
		public string K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorUserTimer']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

	}
}
