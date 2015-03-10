using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='ProgressOutputStream']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream", DoNotGenerateAcw=true)]
	public partial class ProgressOutputStream : global::Java.IO.OutputStream {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='ProgressOutputStream.Listener']"
		[Register ("com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener", "", "Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/interface[@name='ProgressOutputStream.Listener']/method[@name='a' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register ("a", "(JJJ)V", "GetA_JJJHandler:Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream/IListenerInvoker, Layer")]
			void A (long p0, long p1, long p2);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.sync.ProgressOutputStream.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_a_JJJ;
#pragma warning disable 0169
			static Delegate GetA_JJJHandler ()
			{
				if (cb_a_JJJ == null)
					cb_a_JJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, long>) n_A_JJJ);
				return cb_a_JJJ;
			}

			static void n_A_JJJ (IntPtr jnienv, IntPtr native__this, long p0, long p1, long p2)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_a_JJJ;
			public void A (long p0, long p1, long p2)
			{
				if (id_a_JJJ == IntPtr.Zero)
					id_a_JJJ = JNIEnv.GetMethodID (class_ref, "a", "(JJJ)V");
				JNIEnv.CallVoidMethod (Handle, id_a_JJJ, new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (long p0, long p1, long p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			long p0;
			public long P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}

			long p2;
			public long P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream_ListenerImplementor")]
		internal sealed class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void A (long p0, long p1, long p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/sync/ProgressOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProgressOutputStream); }
		}

		protected ProgressOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_JJLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='ProgressOutputStream']/constructor[@name='ProgressOutputStream' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='com.layer.sdk.internal.syncrecon.sync.ProgressOutputStream.Listener']]"
		[Register (".ctor", "(Ljava/io/OutputStream;JJLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", "")]
		public ProgressOutputStream (global::System.IO.Stream p0, long p1, long p2, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream.IListener p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ProgressOutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;JJLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;JJLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_OutputStream_JJLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_ == IntPtr.Zero)
				id_ctor_Ljava_io_OutputStream_JJLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;JJLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_JJLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_JJLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='ProgressOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override void Write (int p0)
		{
			if (id_write_I == IntPtr.Zero)
				id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_write_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(I)V"), new JValue (p0));
		}

	}
}
