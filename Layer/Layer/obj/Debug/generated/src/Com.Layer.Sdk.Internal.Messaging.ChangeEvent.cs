using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeEvent']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeEvent", DoNotGenerateAcw=true)]
	public partial class ChangeEvent : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeEvent.Emitter']"
		[Register ("com/layer/sdk/internal/messaging/ChangeEvent$Emitter", "", "Com.Layer.Sdk.Internal.Messaging.ChangeEvent/IEmitterInvoker")]
		public partial interface IEmitter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeEvent.Emitter']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeEvent']]"
			[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V", "GetA_Lcom_layer_sdk_internal_messaging_ChangeEvent_Handler:Com.Layer.Sdk.Internal.Messaging.ChangeEvent/IEmitterInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeEvent$Emitter", DoNotGenerateAcw=true)]
		internal class IEmitterInvoker : global::Java.Lang.Object, IEmitter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeEvent$Emitter");
			IntPtr class_ref;

			public static IEmitter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEmitter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeEvent.Emitter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEmitterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEmitterInvoker); }
			}

			static Delegate cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_messaging_ChangeEvent_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == null)
					cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_ChangeEvent_);
				return cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
			}

			static void n_A_Lcom_layer_sdk_internal_messaging_ChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent.IEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent.IEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
			public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
			{
				if (id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeEvent); }
		}

		protected ChangeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeEvent']/constructor[@name='ChangeEvent' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public ChangeEvent (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Change> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Change>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ChangeEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeEvent']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Change> A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Change>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

	}
}
