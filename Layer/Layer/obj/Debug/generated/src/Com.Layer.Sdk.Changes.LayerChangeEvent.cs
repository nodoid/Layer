using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Changes {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChangeEvent']"
	[global::Android.Runtime.Register ("com/layer/sdk/changes/LayerChangeEvent", DoNotGenerateAcw=true)]
	public partial class LayerChangeEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/changes/LayerChangeEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerChangeEvent); }
		}

		protected LayerChangeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_LayerClient_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChangeEvent']/constructor[@name='LayerChangeEvent' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='java.util.List']]"
		[Register (".ctor", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V", "")]
		public LayerChangeEvent (global::Com.Layer.Sdk.LayerClient p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Changes.LayerChange> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Changes.LayerChange>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (LayerChangeEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_LayerClient_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_LayerClient_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/LayerClient;Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_LayerClient_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_LayerClient_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getChanges;
#pragma warning disable 0169
		static Delegate GetGetChangesHandler ()
		{
			if (cb_getChanges == null)
				cb_getChanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChanges);
			return cb_getChanges;
		}

		static IntPtr n_GetChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChangeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChangeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Changes.LayerChange>.ToLocalJniHandle (__this.Changes);
		}
#pragma warning restore 0169

		static IntPtr id_getChanges;
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Changes.LayerChange> Changes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChangeEvent']/method[@name='getChanges' and count(parameter)=0]"
			[Register ("getChanges", "()Ljava/util/List;", "GetGetChangesHandler")]
			get {
				if (id_getChanges == IntPtr.Zero)
					id_getChanges = JNIEnv.GetMethodID (class_ref, "getChanges", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Changes.LayerChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChanges), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Changes.LayerChange>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChanges", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChangeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChangeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual global::Com.Layer.Sdk.LayerClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChangeEvent']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lcom/layer/sdk/LayerClient;", "GetGetClientHandler")]
			get {
				if (id_getClient == IntPtr.Zero)
					id_getClient = JNIEnv.GetMethodID (class_ref, "getClient", "()Lcom/layer/sdk/LayerClient;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_getClient), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClient", "()Lcom/layer/sdk/LayerClient;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
