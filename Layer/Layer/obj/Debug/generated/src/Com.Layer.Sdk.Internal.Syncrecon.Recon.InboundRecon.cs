using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Recon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.recon']/class[@name='InboundRecon']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/recon/InboundRecon", DoNotGenerateAcw=true)]
	public partial class InboundRecon : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.recon']/interface[@name='InboundRecon.Results']"
		[Register ("com/layer/sdk/internal/syncrecon/recon/InboundRecon$Results", "", "Com.Layer.Sdk.Internal.Syncrecon.Recon.InboundRecon/IResultsInvoker")]
		public partial interface IResults : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.recon']/interface[@name='InboundRecon.Results']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Ljava/util/concurrent/atomic/AtomicInteger;", "GetCHandler:Com.Layer.Sdk.Internal.Syncrecon.Recon.InboundRecon/IResultsInvoker, Layer")]
			global::Java.Util.Concurrent.Atomic.AtomicInteger C ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/recon/InboundRecon$Results", DoNotGenerateAcw=true)]
		internal class IResultsInvoker : global::Java.Lang.Object, IResults {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/recon/InboundRecon$Results");
			IntPtr class_ref;

			public static IResults GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResults> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.recon.InboundRecon.Results"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResultsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IResultsInvoker); }
			}

			static Delegate cb_c;
#pragma warning disable 0169
			static Delegate GetCHandler ()
			{
				if (cb_c == null)
					cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
				return cb_c;
			}

			static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Recon.InboundRecon.IResults __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Recon.InboundRecon.IResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.C ());
			}
#pragma warning restore 0169

			IntPtr id_c;
			public global::Java.Util.Concurrent.Atomic.AtomicInteger C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/concurrent/atomic/AtomicInteger;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (JNIEnv.CallObjectMethod (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/recon/InboundRecon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InboundRecon); }
		}

		protected InboundRecon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.recon']/class[@name='InboundRecon']/constructor[@name='InboundRecon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public InboundRecon () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InboundRecon)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
