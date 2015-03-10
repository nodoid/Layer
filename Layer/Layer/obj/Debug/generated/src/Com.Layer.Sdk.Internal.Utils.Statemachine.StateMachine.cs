using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='StateMachine']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/StateMachine", DoNotGenerateAcw=true)]
	public abstract partial class StateMachine : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/StateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateMachine); }
		}

		protected StateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='StateMachine']/constructor[@name='StateMachine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public StateMachine () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StateMachine)) {
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

		static IntPtr id_a_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='StateMachine']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)Lcom/layer/sdk/internal/utils/statemachine/StateMachine;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)Lcom/layer/sdk/internal/utils/statemachine/StateMachine;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_b_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='StateMachine']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("b", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		protected global::Java.Lang.Object B (global::Java.Lang.Object p0)
		{
			if (id_b_Ljava_lang_Object_ == IntPtr.Zero)
				id_b_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='StateMachine']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Ljava/lang/Object;", "")]
		public global::Java.Lang.Object M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_m), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/StateMachine", DoNotGenerateAcw=true)]
	internal partial class StateMachineInvoker : StateMachine {

		public StateMachineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateMachineInvoker); }
		}

	}

}
