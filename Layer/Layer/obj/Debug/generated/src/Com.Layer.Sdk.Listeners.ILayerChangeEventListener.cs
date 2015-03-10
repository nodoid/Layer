using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerChangeEventListener.BackgroundThread']"
	[Register ("com/layer/sdk/listeners/LayerChangeEventListener$BackgroundThread", "", "Com.Layer.Sdk.Listeners.ILayerChangeEventListenerBackgroundThreadInvoker")]
	public partial interface ILayerChangeEventListenerBackgroundThread : global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerChangeEventListener.BackgroundThread']/method[@name='onEventAsync' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.changes.LayerChangeEvent']]"
		[Register ("onEventAsync", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V", "GetOnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_Handler:Com.Layer.Sdk.Listeners.ILayerChangeEventListenerBackgroundThreadInvoker, Layer")]
		void OnEventAsync (global::Com.Layer.Sdk.Changes.LayerChangeEvent p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerChangeEventListener$BackgroundThread", DoNotGenerateAcw=true)]
	internal class ILayerChangeEventListenerBackgroundThreadInvoker : global::Java.Lang.Object, ILayerChangeEventListenerBackgroundThread {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerChangeEventListener$BackgroundThread");
		IntPtr class_ref;

		public static ILayerChangeEventListenerBackgroundThread GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerChangeEventListenerBackgroundThread> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerChangeEventListener.BackgroundThread"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerChangeEventListenerBackgroundThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerChangeEventListenerBackgroundThreadInvoker); }
		}

		static Delegate cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
#pragma warning disable 0169
		static Delegate GetOnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_Handler ()
		{
			if (cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ == null)
				cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_);
			return cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
		}

		static void n_OnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerChangeEventListenerBackgroundThread __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerChangeEventListenerBackgroundThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Changes.LayerChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEventAsync (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
		public void OnEventAsync (global::Com.Layer.Sdk.Changes.LayerChangeEvent p0)
		{
			if (id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ == IntPtr.Zero)
				id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNIEnv.GetMethodID (class_ref, "onEventAsync", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_, new JValue (p0));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerChangeEventListener.MainThread']"
	[Register ("com/layer/sdk/listeners/LayerChangeEventListener$MainThread", "", "Com.Layer.Sdk.Listeners.ILayerChangeEventListenerMainThreadInvoker")]
	public partial interface ILayerChangeEventListenerMainThread : global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerChangeEventListener.MainThread']/method[@name='onEventMainThread' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.changes.LayerChangeEvent']]"
		[Register ("onEventMainThread", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V", "GetOnEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_Handler:Com.Layer.Sdk.Listeners.ILayerChangeEventListenerMainThreadInvoker, Layer")]
		void OnEventMainThread (global::Com.Layer.Sdk.Changes.LayerChangeEvent p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerChangeEventListener$MainThread", DoNotGenerateAcw=true)]
	internal class ILayerChangeEventListenerMainThreadInvoker : global::Java.Lang.Object, ILayerChangeEventListenerMainThread {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerChangeEventListener$MainThread");
		IntPtr class_ref;

		public static ILayerChangeEventListenerMainThread GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerChangeEventListenerMainThread> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerChangeEventListener.MainThread"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerChangeEventListenerMainThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerChangeEventListenerMainThreadInvoker); }
		}

		static Delegate cb_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_;
#pragma warning disable 0169
		static Delegate GetOnEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_Handler ()
		{
			if (cb_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_ == null)
				cb_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_);
			return cb_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_;
		}

		static void n_OnEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Listeners.ILayerChangeEventListenerMainThread __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerChangeEventListenerMainThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Changes.LayerChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEventMainThread (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_;
		public void OnEventMainThread (global::Com.Layer.Sdk.Changes.LayerChangeEvent p0)
		{
			if (id_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_ == IntPtr.Zero)
				id_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNIEnv.GetMethodID (class_ref, "onEventMainThread", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_onEventMainThread_Lcom_layer_sdk_changes_LayerChangeEvent_, new JValue (p0));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerChangeEventListener']"
	[Register ("com/layer/sdk/listeners/LayerChangeEventListener", "", "Com.Layer.Sdk.Listeners.ILayerChangeEventListenerInvoker")]
	public partial interface ILayerChangeEventListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerChangeEventListener", DoNotGenerateAcw=true)]
	internal class ILayerChangeEventListenerInvoker : global::Java.Lang.Object, ILayerChangeEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerChangeEventListener");
		IntPtr class_ref;

		public static ILayerChangeEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerChangeEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerChangeEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerChangeEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerChangeEventListenerInvoker); }
		}

	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerChangeEventListenerImplementor")]
	internal sealed class ILayerChangeEventListenerImplementor : global::Java.Lang.Object, ILayerChangeEventListener {

		public ILayerChangeEventListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerChangeEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
		}


		internal static bool __IsEmpty (ILayerChangeEventListenerImplementor value)
		{
			return true;
		}
	}

}
