using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerConnectionListener']"
	[Register ("com/layer/sdk/listeners/LayerConnectionListener", "", "Com.Layer.Sdk.Listeners.ILayerConnectionListenerInvoker")]
	public partial interface ILayerConnectionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerConnectionListener']/method[@name='onConnectionConnected' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient']]"
		[Register ("onConnectionConnected", "(Lcom/layer/sdk/LayerClient;)V", "GetOnConnectionConnected_Lcom_layer_sdk_LayerClient_Handler:Com.Layer.Sdk.Listeners.ILayerConnectionListenerInvoker, Layer")]
		void OnConnectionConnected (global::Com.Layer.Sdk.LayerClient p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerConnectionListener']/method[@name='onConnectionDisconnected' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient']]"
		[Register ("onConnectionDisconnected", "(Lcom/layer/sdk/LayerClient;)V", "GetOnConnectionDisconnected_Lcom_layer_sdk_LayerClient_Handler:Com.Layer.Sdk.Listeners.ILayerConnectionListenerInvoker, Layer")]
		void OnConnectionDisconnected (global::Com.Layer.Sdk.LayerClient p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerConnectionListener']/method[@name='onConnectionError' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='com.layer.sdk.exceptions.LayerException']]"
		[Register ("onConnectionError", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/exceptions/LayerException;)V", "GetOnConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_Handler:Com.Layer.Sdk.Listeners.ILayerConnectionListenerInvoker, Layer")]
		void OnConnectionError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerConnectionListener", DoNotGenerateAcw=true)]
	internal class ILayerConnectionListenerInvoker : global::Java.Lang.Object, ILayerConnectionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerConnectionListener");
		IntPtr class_ref;

		public static ILayerConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerConnectionListenerInvoker); }
		}

		static Delegate cb_onConnectionConnected_Lcom_layer_sdk_LayerClient_;
#pragma warning disable 0169
		static Delegate GetOnConnectionConnected_Lcom_layer_sdk_LayerClient_Handler ()
		{
			if (cb_onConnectionConnected_Lcom_layer_sdk_LayerClient_ == null)
				cb_onConnectionConnected_Lcom_layer_sdk_LayerClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionConnected_Lcom_layer_sdk_LayerClient_);
			return cb_onConnectionConnected_Lcom_layer_sdk_LayerClient_;
		}

		static void n_OnConnectionConnected_Lcom_layer_sdk_LayerClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionConnected_Lcom_layer_sdk_LayerClient_;
		public void OnConnectionConnected (global::Com.Layer.Sdk.LayerClient p0)
		{
			if (id_onConnectionConnected_Lcom_layer_sdk_LayerClient_ == IntPtr.Zero)
				id_onConnectionConnected_Lcom_layer_sdk_LayerClient_ = JNIEnv.GetMethodID (class_ref, "onConnectionConnected", "(Lcom/layer/sdk/LayerClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectionConnected_Lcom_layer_sdk_LayerClient_, new JValue (p0));
		}

		static Delegate cb_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_;
#pragma warning disable 0169
		static Delegate GetOnConnectionDisconnected_Lcom_layer_sdk_LayerClient_Handler ()
		{
			if (cb_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_ == null)
				cb_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionDisconnected_Lcom_layer_sdk_LayerClient_);
			return cb_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_;
		}

		static void n_OnConnectionDisconnected_Lcom_layer_sdk_LayerClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionDisconnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_;
		public void OnConnectionDisconnected (global::Com.Layer.Sdk.LayerClient p0)
		{
			if (id_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_ == IntPtr.Zero)
				id_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_ = JNIEnv.GetMethodID (class_ref, "onConnectionDisconnected", "(Lcom/layer/sdk/LayerClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectionDisconnected_Lcom_layer_sdk_LayerClient_, new JValue (p0));
		}

		static Delegate cb_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
#pragma warning disable 0169
		static Delegate GetOnConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_Handler ()
		{
			if (cb_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ == null)
				cb_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_);
			return cb_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
		}

		static void n_OnConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Exceptions.LayerException p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
		public void OnConnectionError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
		{
			if (id_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ == IntPtr.Zero)
				id_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ = JNIEnv.GetMethodID (class_ref, "onConnectionError", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/exceptions/LayerException;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectionError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class ConnectionConnectedEventArgs : global::System.EventArgs {

		public ConnectionConnectedEventArgs (global::Com.Layer.Sdk.LayerClient p0)
		{
			this.p0 = p0;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}
	}

	public partial class ConnectionDisconnectedEventArgs : global::System.EventArgs {

		public ConnectionDisconnectedEventArgs (global::Com.Layer.Sdk.LayerClient p0)
		{
			this.p0 = p0;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}
	}

	public partial class ConnectionErrorEventArgs : global::System.EventArgs {

		public ConnectionErrorEventArgs (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Exceptions.LayerException p1;
		public global::Com.Layer.Sdk.Exceptions.LayerException P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerConnectionListenerImplementor")]
	internal sealed class ILayerConnectionListenerImplementor : global::Java.Lang.Object, ILayerConnectionListener {

		object sender;

		public ILayerConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectionConnectedEventArgs> OnConnectionConnectedHandler;
#pragma warning restore 0649

		public void OnConnectionConnected (global::Com.Layer.Sdk.LayerClient p0)
		{
			var __h = OnConnectionConnectedHandler;
			if (__h != null)
				__h (sender, new ConnectionConnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ConnectionDisconnectedEventArgs> OnConnectionDisconnectedHandler;
#pragma warning restore 0649

		public void OnConnectionDisconnected (global::Com.Layer.Sdk.LayerClient p0)
		{
			var __h = OnConnectionDisconnectedHandler;
			if (__h != null)
				__h (sender, new ConnectionDisconnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ConnectionErrorEventArgs> OnConnectionErrorHandler;
#pragma warning restore 0649

		public void OnConnectionError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
		{
			var __h = OnConnectionErrorHandler;
			if (__h != null)
				__h (sender, new ConnectionErrorEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ILayerConnectionListenerImplementor value)
		{
			return value.OnConnectionConnectedHandler == null && value.OnConnectionDisconnectedHandler == null && value.OnConnectionErrorHandler == null;
		}
	}

}
