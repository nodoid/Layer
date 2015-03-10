using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Alerters {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncAlerter']"
	[Register ("com/layer/sdk/internal/alerters/SyncAlerter", "", "Com.Layer.Sdk.Internal.Alerters.ISyncAlerterInvoker")]
	public partial interface ISyncAlerter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncAlerter']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.SyncRecon.Results']]"
		[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/SyncRecon$Results;)V", "GetA_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_Handler:Com.Layer.Sdk.Internal.Alerters.ISyncAlerterInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Results p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncAlerter']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)V", "GetA_Ljava_util_List_Handler:Com.Layer.Sdk.Internal.Alerters.ISyncAlerterInvoker, Layer")]
		void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.alerters']/interface[@name='SyncAlerter']/method[@name='p' and count(parameter)=0]"
		[Register ("p", "()V", "GetPHandler:Com.Layer.Sdk.Internal.Alerters.ISyncAlerterInvoker, Layer")]
		void P ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/alerters/SyncAlerter", DoNotGenerateAcw=true)]
	internal class ISyncAlerterInvoker : global::Java.Lang.Object, ISyncAlerter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/alerters/SyncAlerter");
		IntPtr class_ref;

		public static ISyncAlerter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncAlerter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.alerters.SyncAlerter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncAlerterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncAlerterInvoker); }
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ == null)
				cb_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_);
			return cb_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_;
		}

		static void n_A_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Results p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Results> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_;
		public void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Results p0)
		{
			if (id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/SyncRecon$Results;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_, new JValue (p0));
		}

		static Delegate cb_a_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_List_Handler ()
		{
			if (cb_a_Ljava_util_List_ == null)
				cb_a_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_List_);
			return cb_a_Ljava_util_List_;
		}

		static void n_A_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Layer.Sdk.Exceptions.LayerException> p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Exceptions.LayerException>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_util_List_;
		public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Exceptions.LayerException> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Exceptions.LayerException>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_p;
#pragma warning disable 0169
		static Delegate GetPHandler ()
		{
			if (cb_p == null)
				cb_p = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_P);
			return cb_p;
		}

		static void n_P (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.P ();
		}
#pragma warning restore 0169

		IntPtr id_p;
		public void P ()
		{
			if (id_p == IntPtr.Zero)
				id_p = JNIEnv.GetMethodID (class_ref, "p", "()V");
			JNIEnv.CallVoidMethod (Handle, id_p);
		}

	}

}
