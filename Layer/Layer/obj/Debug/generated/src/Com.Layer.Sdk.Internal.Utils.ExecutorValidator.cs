using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ExecutorValidator']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/ExecutorValidator", DoNotGenerateAcw=true)]
	public partial class ExecutorValidator : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ExecutorValidator.Callback']"
		[Register ("com/layer/sdk/internal/utils/ExecutorValidator$Callback", "", "Com.Layer.Sdk.Internal.Utils.ExecutorValidator/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ExecutorValidator.Callback']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler:Com.Layer.Sdk.Internal.Utils.ExecutorValidator/ICallbackInvoker, Layer")]
			void A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ExecutorValidator.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("a", "(Ljava/lang/Object;)V", "GetA_Ljava_lang_Object_Handler:Com.Layer.Sdk.Internal.Utils.ExecutorValidator/ICallbackInvoker, Layer")]
			void A (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/ExecutorValidator$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/ExecutorValidator$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.ExecutorValidator.Callback"));
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

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			IntPtr id_a;
			public void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				JNIEnv.CallVoidMethod (Handle, id_a);
			}

			static Delegate cb_a_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_Object_Handler ()
			{
				if (cb_a_Ljava_lang_Object_ == null)
					cb_a_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Object_);
				return cb_a_Ljava_lang_Object_;
			}

			static void n_A_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_Object_;
			public void A (global::Java.Lang.Object p0)
			{
				if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
					id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_Object_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ExecutorValidator.ForegroundCallback']"
		[Register ("com/layer/sdk/internal/utils/ExecutorValidator$ForegroundCallback", "", "Com.Layer.Sdk.Internal.Utils.ExecutorValidator/IForegroundCallbackInvoker")]
		public partial interface IForegroundCallback : global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ExecutorValidator.ForegroundCallback']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/Object;", "GetBHandler:Com.Layer.Sdk.Internal.Utils.ExecutorValidator/IForegroundCallbackInvoker, Layer")]
			global::Java.Lang.Object B ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/ExecutorValidator$ForegroundCallback", DoNotGenerateAcw=true)]
		internal class IForegroundCallbackInvoker : global::Java.Lang.Object, IForegroundCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/ExecutorValidator$ForegroundCallback");
			IntPtr class_ref;

			public static IForegroundCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IForegroundCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.ExecutorValidator.ForegroundCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IForegroundCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IForegroundCallbackInvoker); }
			}

			static Delegate cb_b;
#pragma warning disable 0169
			static Delegate GetBHandler ()
			{
				if (cb_b == null)
					cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
				return cb_b;
			}

			static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.B ());
			}
#pragma warning restore 0169

			IntPtr id_b;
			public global::Java.Lang.Object B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			IntPtr id_a;
			public void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				JNIEnv.CallVoidMethod (Handle, id_a);
			}

			static Delegate cb_a_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_Object_Handler ()
			{
				if (cb_a_Ljava_lang_Object_ == null)
					cb_a_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Object_);
				return cb_a_Ljava_lang_Object_;
			}

			static void n_A_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.IForegroundCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_Object_;
			public void A (global::Java.Lang.Object p0)
			{
				if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
					id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_Object_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/ExecutorValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExecutorValidator); }
		}

		protected ExecutorValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_Executor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ExecutorValidator']/constructor[@name='ExecutorValidator' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register (".ctor", "(Ljava/util/concurrent/Executor;)V", "")]
		public ExecutorValidator (global::Java.Util.Concurrent.IExecutor p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ExecutorValidator)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/Executor;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/Executor;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
				id_ctor_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Executor;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Executor_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_Executor_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ExecutorValidator']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.ExecutorValidator.Callback']]"
		[Register ("a", "(Lcom/layer/sdk/internal/utils/ExecutorValidator$Callback;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Utils.ExecutorValidator.ICallback p0)
		{
			if (id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/ExecutorValidator$Callback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_utils_ExecutorValidator_Callback_, new JValue (p0));
		}

	}
}
