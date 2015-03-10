using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerPolicyListener']"
	[Register ("com/layer/sdk/listeners/LayerPolicyListener", "", "Com.Layer.Sdk.Listeners.ILayerPolicyListenerInvoker")]
	public partial interface ILayerPolicyListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerPolicyListener']/method[@name='onPolicyListUpdate' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='java.util.List'] and parameter[3][@type='java.util.List']]"
		[Register ("onPolicyListUpdate", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;Ljava/util/List;)V", "GetOnPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_Handler:Com.Layer.Sdk.Listeners.ILayerPolicyListenerInvoker, Layer")]
		void OnPolicyListUpdate (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p2);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerPolicyListener", DoNotGenerateAcw=true)]
	internal class ILayerPolicyListenerInvoker : global::Java.Lang.Object, ILayerPolicyListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerPolicyListener");
		IntPtr class_ref;

		public static ILayerPolicyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerPolicyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerPolicyListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerPolicyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerPolicyListenerInvoker); }
		}

		static Delegate cb_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_ == null)
				cb_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_);
			return cb_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_;
		}

		static void n_OnPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Layer.Sdk.Listeners.ILayerPolicyListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerPolicyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Layer.Sdk.Policy.Policy> p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Layer.Sdk.Policy.Policy> p2 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPolicyListUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_;
		public void OnPolicyListUpdate (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p2)
		{
			if (id_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPolicyListUpdate", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_onPolicyListUpdate_Lcom_layer_sdk_LayerClient_Ljava_util_List_Ljava_util_List_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class LayerPolicyEventArgs : global::System.EventArgs {

		public LayerPolicyEventArgs (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1;
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p2;
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerPolicyListenerImplementor")]
	internal sealed class ILayerPolicyListenerImplementor : global::Java.Lang.Object, ILayerPolicyListener {

		object sender;

		public ILayerPolicyListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerPolicyListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LayerPolicyEventArgs> Handler;
#pragma warning restore 0649

		public void OnPolicyListUpdate (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LayerPolicyEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ILayerPolicyListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
