using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerProgressListener.Operation']"
	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerProgressListener$Operation", DoNotGenerateAcw=true)]
	public sealed partial class LayerProgressListenerOperation : global::Java.Lang.Enum {


		static IntPtr DOWNLOAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerProgressListener.Operation']/field[@name='DOWNLOAD']"
		[Register ("DOWNLOAD")]
		public static global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation Download {
			get {
				if (DOWNLOAD_jfieldId == IntPtr.Zero)
					DOWNLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD", "Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DOWNLOAD_jfieldId == IntPtr.Zero)
					DOWNLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD", "Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DOWNLOAD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UPLOAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerProgressListener.Operation']/field[@name='UPLOAD']"
		[Register ("UPLOAD")]
		public static global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation Upload {
			get {
				if (UPLOAD_jfieldId == IntPtr.Zero)
					UPLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD", "Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UPLOAD_jfieldId == IntPtr.Zero)
					UPLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD", "Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UPLOAD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/listeners/LayerProgressListener$Operation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerProgressListenerOperation); }
		}

		internal LayerProgressListenerOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerProgressListener.Operation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/listeners/LayerProgressListener$Operation;", "")]
		public static global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerProgressListener.Operation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/sdk/listeners/LayerProgressListener$Operation;", "")]
		public static global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/listeners/LayerProgressListener$Operation;");
			return (global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerProgressListener']"
	[Register ("com/layer/sdk/listeners/LayerProgressListener", "", "Com.Layer.Sdk.Listeners.ILayerProgressListenerInvoker")]
	public partial interface ILayerProgressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerProgressListener']/method[@name='onProgressComplete' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation']]"
		[Register ("onProgressComplete", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V", "GetOnProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Handler:Com.Layer.Sdk.Listeners.ILayerProgressListenerInvoker, Layer")]
		void OnProgressComplete (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerProgressListener']/method[@name='onProgressError' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onProgressError", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;Ljava/lang/Throwable;)V", "GetOnProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_Handler:Com.Layer.Sdk.Listeners.ILayerProgressListenerInvoker, Layer")]
		void OnProgressError (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerProgressListener']/method[@name='onProgressStart' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation']]"
		[Register ("onProgressStart", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V", "GetOnProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Handler:Com.Layer.Sdk.Listeners.ILayerProgressListenerInvoker, Layer")]
		void OnProgressStart (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerProgressListener']/method[@name='onProgressUpdate' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation'] and parameter[3][@type='long']]"
		[Register ("onProgressUpdate", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;J)V", "GetOnProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JHandler:Com.Layer.Sdk.Listeners.ILayerProgressListenerInvoker, Layer")]
		void OnProgressUpdate (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, long p2);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerProgressListener", DoNotGenerateAcw=true)]
	internal class ILayerProgressListenerInvoker : global::Java.Lang.Object, ILayerProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerProgressListener");
		IntPtr class_ref;

		public static ILayerProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerProgressListenerInvoker); }
		}

		static Delegate cb_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
#pragma warning disable 0169
		static Delegate GetOnProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Handler ()
		{
			if (cb_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == null)
				cb_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_);
			return cb_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		}

		static void n_OnProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		public void OnProgressComplete (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			if (id_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == IntPtr.Zero)
				id_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNIEnv.GetMethodID (class_ref, "onProgressComplete", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V");
			JNIEnv.CallVoidMethod (Handle, id_onProgressComplete_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ == null)
				cb_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_);
			return cb_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_;
		}

		static void n_OnProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_;
		public void OnProgressError (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, global::Java.Lang.Throwable p2)
		{
			if (id_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onProgressError", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;Ljava/lang/Throwable;)V");
			JNIEnv.CallVoidMethod (Handle, id_onProgressError_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
#pragma warning disable 0169
		static Delegate GetOnProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Handler ()
		{
			if (cb_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == null)
				cb_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_);
			return cb_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		}

		static void n_OnProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressStart (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		public void OnProgressStart (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			if (id_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == IntPtr.Zero)
				id_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNIEnv.GetMethodID (class_ref, "onProgressStart", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V");
			JNIEnv.CallVoidMethod (Handle, id_onProgressStart_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JHandler ()
		{
			if (cb_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J == null)
				cb_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_OnProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J);
			return cb_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J;
		}

		static void n_OnProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J;
		public void OnProgressUpdate (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, long p2)
		{
			if (id_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J == IntPtr.Zero)
				id_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onProgressUpdate_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_J, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	public partial class ProgressCompleteEventArgs : global::System.EventArgs {

		public ProgressCompleteEventArgs (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.Messaging.MessagePart p0;
		public global::Com.Layer.Sdk.Messaging.MessagePart P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1;
		public global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation P1 {
			get { return p1; }
		}
	}

	public partial class ProgressErrorEventArgs : global::System.EventArgs {

		public ProgressErrorEventArgs (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, global::Java.Lang.Throwable p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Layer.Sdk.Messaging.MessagePart p0;
		public global::Com.Layer.Sdk.Messaging.MessagePart P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1;
		public global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}
	}

	public partial class ProgressStartEventArgs : global::System.EventArgs {

		public ProgressStartEventArgs (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.Messaging.MessagePart p0;
		public global::Com.Layer.Sdk.Messaging.MessagePart P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1;
		public global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation P1 {
			get { return p1; }
		}
	}

	public partial class ProgressUpdateEventArgs : global::System.EventArgs {

		public ProgressUpdateEventArgs (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Layer.Sdk.Messaging.MessagePart p0;
		public global::Com.Layer.Sdk.Messaging.MessagePart P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1;
		public global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation P1 {
			get { return p1; }
		}

		long p2;
		public long P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerProgressListenerImplementor")]
	internal sealed class ILayerProgressListenerImplementor : global::Java.Lang.Object, ILayerProgressListener {

		object sender;

		public ILayerProgressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ProgressCompleteEventArgs> OnProgressCompleteHandler;
#pragma warning restore 0649

		public void OnProgressComplete (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			var __h = OnProgressCompleteHandler;
			if (__h != null)
				__h (sender, new ProgressCompleteEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ProgressErrorEventArgs> OnProgressErrorHandler;
#pragma warning restore 0649

		public void OnProgressError (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, global::Java.Lang.Throwable p2)
		{
			var __h = OnProgressErrorHandler;
			if (__h != null)
				__h (sender, new ProgressErrorEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ProgressStartEventArgs> OnProgressStartHandler;
#pragma warning restore 0649

		public void OnProgressStart (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			var __h = OnProgressStartHandler;
			if (__h != null)
				__h (sender, new ProgressStartEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ProgressUpdateEventArgs> OnProgressUpdateHandler;
#pragma warning restore 0649

		public void OnProgressUpdate (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, long p2)
		{
			var __h = OnProgressUpdateHandler;
			if (__h != null)
				__h (sender, new ProgressUpdateEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ILayerProgressListenerImplementor value)
		{
			return value.OnProgressCompleteHandler == null && value.OnProgressErrorHandler == null && value.OnProgressStartHandler == null && value.OnProgressUpdateHandler == null;
		}
	}

}
