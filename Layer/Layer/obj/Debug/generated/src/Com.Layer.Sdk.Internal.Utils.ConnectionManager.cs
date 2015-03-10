using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/ConnectionManager", DoNotGenerateAcw=true)]
	public partial class ConnectionManager : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ConnectionManager.Callback']"
		[Register ("com/layer/sdk/internal/utils/ConnectionManager$Callback", "", "Com.Layer.Sdk.Internal.Utils.ConnectionManager/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ConnectionManager.Callback']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Z", "GetAHandler:Com.Layer.Sdk.Internal.Utils.ConnectionManager/ICallbackInvoker, Layer")]
			bool A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ConnectionManager.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("a", "(Z)V", "GetA_ZHandler:Com.Layer.Sdk.Internal.Utils.ConnectionManager/ICallbackInvoker, Layer")]
			void A (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ConnectionManager.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.exceptions.LayerException']]"
			[Register ("a", "(Lcom/layer/sdk/exceptions/LayerException;)V", "GetA_Lcom_layer_sdk_exceptions_LayerException_Handler:Com.Layer.Sdk.Internal.Utils.ConnectionManager/ICallbackInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Exceptions.LayerException p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='ConnectionManager.Callback']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()V", "GetBHandler:Com.Layer.Sdk.Internal.Utils.ConnectionManager/ICallbackInvoker, Layer")]
			void B ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/ConnectionManager$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/ConnectionManager$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.ConnectionManager.Callback"));
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
					cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
				return cb_a;
			}

			static bool n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.A ();
			}
#pragma warning restore 0169

			IntPtr id_a;
			public bool A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_a);
			}

			static Delegate cb_a_Z;
#pragma warning disable 0169
			static Delegate GetA_ZHandler ()
			{
				if (cb_a_Z == null)
					cb_a_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_A_Z);
				return cb_a_Z;
			}

			static void n_A_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Z;
			public void A (bool p0)
			{
				if (id_a_Z == IntPtr.Zero)
					id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Z, new JValue (p0));
			}

			static Delegate cb_a_Lcom_layer_sdk_exceptions_LayerException_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_exceptions_LayerException_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_exceptions_LayerException_ == null)
					cb_a_Lcom_layer_sdk_exceptions_LayerException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_exceptions_LayerException_);
				return cb_a_Lcom_layer_sdk_exceptions_LayerException_;
			}

			static void n_A_Lcom_layer_sdk_exceptions_LayerException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Exceptions.LayerException p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_exceptions_LayerException_;
			public void A (global::Com.Layer.Sdk.Exceptions.LayerException p0)
			{
				if (id_a_Lcom_layer_sdk_exceptions_LayerException_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_exceptions_LayerException_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/exceptions/LayerException;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_exceptions_LayerException_, new JValue (p0));
			}

			static Delegate cb_b;
#pragma warning disable 0169
			static Delegate GetBHandler ()
			{
				if (cb_b == null)
					cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
				return cb_b;
			}

			static void n_B (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ConnectionManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.B ();
			}
#pragma warning restore 0169

			IntPtr id_b;
			public void B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
				JNIEnv.CallVoidMethod (Handle, id_b);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/ConnectionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionManager); }
		}

		protected ConnectionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("a", "(Ljava/io/IOException;)V", "")]
		public void A (global::Java.IO.IOException p0)
		{
			if (id_a_Ljava_io_IOException_ == IntPtr.Zero)
				id_a_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/io/IOException;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_io_IOException_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_f);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		public void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_g);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "")]
		public void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_h);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "")]
		public void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_i);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()V", "")]
		public void J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_j);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()V", "")]
		public void K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_k);
		}

		static Delegate cb_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Handler ()
		{
			if (cb_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_ == null)
				cb_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_);
			return cb_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_;
		}

		static void n_OnEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.ConnectionManager __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.ConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='ConnectionManager']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.services.LayerReceiver.ServiceEvent']]"
		[Register ("onEvent", "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent;)V", "GetOnEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Handler")]
		public virtual void OnEvent (global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent p0)
		{
			if (id_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_ == IntPtr.Zero)
				id_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onEvent_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEvent", "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent;)V"), new JValue (p0));
		}

	}
}
