using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerAuthenticationListener']"
	[Register ("com/layer/sdk/listeners/LayerAuthenticationListener", "", "Com.Layer.Sdk.Listeners.ILayerAuthenticationListenerInvoker")]
	public partial interface ILayerAuthenticationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerAuthenticationListener']/method[@name='onAuthenticated' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAuthenticated", "(Lcom/layer/sdk/LayerClient;Ljava/lang/String;)V", "GetOnAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_Handler:Com.Layer.Sdk.Listeners.ILayerAuthenticationListenerInvoker, Layer")]
		void OnAuthenticated (global::Com.Layer.Sdk.LayerClient p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerAuthenticationListener']/method[@name='onAuthenticationChallenge' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAuthenticationChallenge", "(Lcom/layer/sdk/LayerClient;Ljava/lang/String;)V", "GetOnAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_Handler:Com.Layer.Sdk.Listeners.ILayerAuthenticationListenerInvoker, Layer")]
		void OnAuthenticationChallenge (global::Com.Layer.Sdk.LayerClient p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerAuthenticationListener']/method[@name='onAuthenticationError' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='com.layer.sdk.exceptions.LayerException']]"
		[Register ("onAuthenticationError", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/exceptions/LayerException;)V", "GetOnAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_Handler:Com.Layer.Sdk.Listeners.ILayerAuthenticationListenerInvoker, Layer")]
		void OnAuthenticationError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerAuthenticationListener']/method[@name='onDeauthenticated' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient']]"
		[Register ("onDeauthenticated", "(Lcom/layer/sdk/LayerClient;)V", "GetOnDeauthenticated_Lcom_layer_sdk_LayerClient_Handler:Com.Layer.Sdk.Listeners.ILayerAuthenticationListenerInvoker, Layer")]
		void OnDeauthenticated (global::Com.Layer.Sdk.LayerClient p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerAuthenticationListener", DoNotGenerateAcw=true)]
	internal class ILayerAuthenticationListenerInvoker : global::Java.Lang.Object, ILayerAuthenticationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerAuthenticationListener");
		IntPtr class_ref;

		public static ILayerAuthenticationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerAuthenticationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerAuthenticationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerAuthenticationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerAuthenticationListenerInvoker); }
		}

		static Delegate cb_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_Handler ()
		{
			if (cb_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ == null)
				cb_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_);
			return cb_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
		}

		static void n_OnAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthenticated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
		public void OnAuthenticated (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			if (id_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ == IntPtr.Zero)
				id_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthenticated", "(Lcom/layer/sdk/LayerClient;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAuthenticated_Lcom_layer_sdk_LayerClient_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_Handler ()
		{
			if (cb_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ == null)
				cb_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_);
			return cb_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
		}

		static void n_OnAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthenticationChallenge (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_;
		public void OnAuthenticationChallenge (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			if (id_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ == IntPtr.Zero)
				id_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthenticationChallenge", "(Lcom/layer/sdk/LayerClient;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAuthenticationChallenge_Lcom_layer_sdk_LayerClient_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
#pragma warning disable 0169
		static Delegate GetOnAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_Handler ()
		{
			if (cb_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ == null)
				cb_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_);
			return cb_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
		}

		static void n_OnAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Exceptions.LayerException p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthenticationError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_;
		public void OnAuthenticationError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
		{
			if (id_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ == IntPtr.Zero)
				id_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_ = JNIEnv.GetMethodID (class_ref, "onAuthenticationError", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/exceptions/LayerException;)V");
			JNIEnv.CallVoidMethod (Handle, id_onAuthenticationError_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_exceptions_LayerException_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onDeauthenticated_Lcom_layer_sdk_LayerClient_;
#pragma warning disable 0169
		static Delegate GetOnDeauthenticated_Lcom_layer_sdk_LayerClient_Handler ()
		{
			if (cb_onDeauthenticated_Lcom_layer_sdk_LayerClient_ == null)
				cb_onDeauthenticated_Lcom_layer_sdk_LayerClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeauthenticated_Lcom_layer_sdk_LayerClient_);
			return cb_onDeauthenticated_Lcom_layer_sdk_LayerClient_;
		}

		static void n_OnDeauthenticated_Lcom_layer_sdk_LayerClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeauthenticated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDeauthenticated_Lcom_layer_sdk_LayerClient_;
		public void OnDeauthenticated (global::Com.Layer.Sdk.LayerClient p0)
		{
			if (id_onDeauthenticated_Lcom_layer_sdk_LayerClient_ == IntPtr.Zero)
				id_onDeauthenticated_Lcom_layer_sdk_LayerClient_ = JNIEnv.GetMethodID (class_ref, "onDeauthenticated", "(Lcom/layer/sdk/LayerClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onDeauthenticated_Lcom_layer_sdk_LayerClient_, new JValue (p0));
		}

	}

	public partial class AuthenticatedEventArgs : global::System.EventArgs {

		public AuthenticatedEventArgs (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class AuthenticationChallengeEventArgs : global::System.EventArgs {

		public AuthenticationChallengeEventArgs (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class AuthenticationErrorEventArgs : global::System.EventArgs {

		public AuthenticationErrorEventArgs (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
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

	public partial class DeauthenticatedEventArgs : global::System.EventArgs {

		public DeauthenticatedEventArgs (global::Com.Layer.Sdk.LayerClient p0)
		{
			this.p0 = p0;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerAuthenticationListenerImplementor")]
	internal sealed class ILayerAuthenticationListenerImplementor : global::Java.Lang.Object, ILayerAuthenticationListener {

		object sender;

		public ILayerAuthenticationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerAuthenticationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthenticatedEventArgs> OnAuthenticatedHandler;
#pragma warning restore 0649

		public void OnAuthenticated (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			var __h = OnAuthenticatedHandler;
			if (__h != null)
				__h (sender, new AuthenticatedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AuthenticationChallengeEventArgs> OnAuthenticationChallengeHandler;
#pragma warning restore 0649

		public void OnAuthenticationChallenge (global::Com.Layer.Sdk.LayerClient p0, string p1)
		{
			var __h = OnAuthenticationChallengeHandler;
			if (__h != null)
				__h (sender, new AuthenticationChallengeEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AuthenticationErrorEventArgs> OnAuthenticationErrorHandler;
#pragma warning restore 0649

		public void OnAuthenticationError (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Exceptions.LayerException p1)
		{
			var __h = OnAuthenticationErrorHandler;
			if (__h != null)
				__h (sender, new AuthenticationErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<DeauthenticatedEventArgs> OnDeauthenticatedHandler;
#pragma warning restore 0649

		public void OnDeauthenticated (global::Com.Layer.Sdk.LayerClient p0)
		{
			var __h = OnDeauthenticatedHandler;
			if (__h != null)
				__h (sender, new DeauthenticatedEventArgs (p0));
		}

		internal static bool __IsEmpty (ILayerAuthenticationListenerImplementor value)
		{
			return value.OnAuthenticatedHandler == null && value.OnAuthenticationChallengeHandler == null && value.OnAuthenticationErrorHandler == null && value.OnDeauthenticatedHandler == null;
		}
	}

}
