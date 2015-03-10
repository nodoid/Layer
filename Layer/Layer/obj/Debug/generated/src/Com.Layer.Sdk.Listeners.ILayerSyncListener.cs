using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerSyncListener']"
	[Register ("com/layer/sdk/listeners/LayerSyncListener", "", "Com.Layer.Sdk.Listeners.ILayerSyncListenerInvoker")]
	public partial interface ILayerSyncListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerSyncListener']/method[@name='onAfterSync' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient']]"
		[Register ("onAfterSync", "(Lcom/layer/sdk/LayerClient;)V", "GetOnAfterSync_Lcom_layer_sdk_LayerClient_Handler:Com.Layer.Sdk.Listeners.ILayerSyncListenerInvoker, Layer")]
		void OnAfterSync (global::Com.Layer.Sdk.LayerClient p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerSyncListener']/method[@name='onBeforeSync' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient']]"
		[Register ("onBeforeSync", "(Lcom/layer/sdk/LayerClient;)V", "GetOnBeforeSync_Lcom_layer_sdk_LayerClient_Handler:Com.Layer.Sdk.Listeners.ILayerSyncListenerInvoker, Layer")]
		void OnBeforeSync (global::Com.Layer.Sdk.LayerClient p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerSyncListener']/method[@name='onSyncError' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='java.util.List']]"
		[Register ("onSyncError", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V", "GetOnSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_Handler:Com.Layer.Sdk.Listeners.ILayerSyncListenerInvoker, Layer")]
		void OnSyncError (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p1);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerSyncListener", DoNotGenerateAcw=true)]
	internal class ILayerSyncListenerInvoker : global::Java.Lang.Object, ILayerSyncListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerSyncListener");
		IntPtr class_ref;

		public static ILayerSyncListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerSyncListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerSyncListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerSyncListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerSyncListenerInvoker); }
		}

		static Delegate cb_onAfterSync_Lcom_layer_sdk_LayerClient_;
#pragma warning disable 0169
		static Delegate GetOnAfterSync_Lcom_layer_sdk_LayerClient_Handler ()
		{
			if (cb_onAfterSync_Lcom_layer_sdk_LayerClient_ == null)
				cb_onAfterSync_Lcom_layer_sdk_LayerClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAfterSync_Lcom_layer_sdk_LayerClient_);
			return cb_onAfterSync_Lcom_layer_sdk_LayerClient_;
		}

		static void n_OnAfterSync_Lcom_layer_sdk_LayerClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerSyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerSyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterSync (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAfterSync_Lcom_layer_sdk_LayerClient_;
		public void OnAfterSync (global::Com.Layer.Sdk.LayerClient p0)
		{
			if (id_onAfterSync_Lcom_layer_sdk_LayerClient_ == IntPtr.Zero)
				id_onAfterSync_Lcom_layer_sdk_LayerClient_ = JNIEnv.GetMethodID (class_ref, "onAfterSync", "(Lcom/layer/sdk/LayerClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onAfterSync_Lcom_layer_sdk_LayerClient_, new JValue (p0));
		}

		static Delegate cb_onBeforeSync_Lcom_layer_sdk_LayerClient_;
#pragma warning disable 0169
		static Delegate GetOnBeforeSync_Lcom_layer_sdk_LayerClient_Handler ()
		{
			if (cb_onBeforeSync_Lcom_layer_sdk_LayerClient_ == null)
				cb_onBeforeSync_Lcom_layer_sdk_LayerClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBeforeSync_Lcom_layer_sdk_LayerClient_);
			return cb_onBeforeSync_Lcom_layer_sdk_LayerClient_;
		}

		static void n_OnBeforeSync_Lcom_layer_sdk_LayerClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerSyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerSyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeSync (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBeforeSync_Lcom_layer_sdk_LayerClient_;
		public void OnBeforeSync (global::Com.Layer.Sdk.LayerClient p0)
		{
			if (id_onBeforeSync_Lcom_layer_sdk_LayerClient_ == IntPtr.Zero)
				id_onBeforeSync_Lcom_layer_sdk_LayerClient_ = JNIEnv.GetMethodID (class_ref, "onBeforeSync", "(Lcom/layer/sdk/LayerClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onBeforeSync_Lcom_layer_sdk_LayerClient_, new JValue (p0));
		}

		static Delegate cb_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_Handler ()
		{
			if (cb_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_ == null)
				cb_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_);
			return cb_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_;
		}

		static void n_OnSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Listeners.ILayerSyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerSyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Layer.Sdk.Exceptions.LayerException> p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Exceptions.LayerException>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSyncError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_;
		public void OnSyncError (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p1)
		{
			if (id_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_ == IntPtr.Zero)
				id_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onSyncError", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Exceptions.LayerException>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onSyncError_Lcom_layer_sdk_LayerClient_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class AfterSyncEventArgs : global::System.EventArgs {

		public AfterSyncEventArgs (global::Com.Layer.Sdk.LayerClient p0)
		{
			this.p0 = p0;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}
	}

	public partial class BeforeSyncEventArgs : global::System.EventArgs {

		public BeforeSyncEventArgs (global::Com.Layer.Sdk.LayerClient p0)
		{
			this.p0 = p0;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}
	}

	public partial class SyncErrorEventArgs : global::System.EventArgs {

		public SyncErrorEventArgs (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p1;
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerSyncListenerImplementor")]
	internal sealed class ILayerSyncListenerImplementor : global::Java.Lang.Object, ILayerSyncListener {

		object sender;

		public ILayerSyncListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerSyncListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AfterSyncEventArgs> OnAfterSyncHandler;
#pragma warning restore 0649

		public void OnAfterSync (global::Com.Layer.Sdk.LayerClient p0)
		{
			var __h = OnAfterSyncHandler;
			if (__h != null)
				__h (sender, new AfterSyncEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<BeforeSyncEventArgs> OnBeforeSyncHandler;
#pragma warning restore 0649

		public void OnBeforeSync (global::Com.Layer.Sdk.LayerClient p0)
		{
			var __h = OnBeforeSyncHandler;
			if (__h != null)
				__h (sender, new BeforeSyncEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SyncErrorEventArgs> OnSyncErrorHandler;
#pragma warning restore 0649

		public void OnSyncError (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p1)
		{
			var __h = OnSyncErrorHandler;
			if (__h != null)
				__h (sender, new SyncErrorEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ILayerSyncListenerImplementor value)
		{
			return value.OnAfterSyncHandler == null && value.OnBeforeSyncHandler == null && value.OnSyncErrorHandler == null;
		}
	}

}
