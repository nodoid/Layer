using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='FileUtils.LockedRunnable']"
		[Register ("com/layer/sdk/internal/utils/FileUtils$LockedRunnable", "", "Com.Layer.Sdk.Internal.Utils.FileUtils/ILockedRunnableInvoker")]
		public partial interface ILockedRunnable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='FileUtils.LockedRunnable']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("a", "(Ljava/io/File;)V", "GetA_Ljava_io_File_Handler:Com.Layer.Sdk.Internal.Utils.FileUtils/ILockedRunnableInvoker, Layer")]
			void A (global::Java.IO.File p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/FileUtils$LockedRunnable", DoNotGenerateAcw=true)]
		internal class ILockedRunnableInvoker : global::Java.Lang.Object, ILockedRunnable {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/FileUtils$LockedRunnable");
			IntPtr class_ref;

			public static ILockedRunnable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILockedRunnable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.FileUtils.LockedRunnable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILockedRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ILockedRunnableInvoker); }
			}

			static Delegate cb_a_Ljava_io_File_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_io_File_Handler ()
			{
				if (cb_a_Ljava_io_File_ == null)
					cb_a_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_io_File_);
				return cb_a_Ljava_io_File_;
			}

			static void n_A_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.FileUtils.ILockedRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.FileUtils.ILockedRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_io_File_;
			public void A (global::Java.IO.File p0)
			{
				if (id_a_Ljava_io_File_ == IntPtr.Zero)
					id_a_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/io/File;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_io_File_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FileUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileUtils)) {
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

		static IntPtr id_a_Ljava_io_File_Lcom_layer_sdk_internal_utils_FileUtils_LockedRunnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='FileUtils']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.layer.sdk.internal.utils.FileUtils.LockedRunnable']]"
		[Register ("a", "(Ljava/io/File;Lcom/layer/sdk/internal/utils/FileUtils$LockedRunnable;)Ljava/lang/Exception;", "")]
		public static global::Java.Lang.Exception A (global::Java.IO.File p0, global::Com.Layer.Sdk.Internal.Utils.FileUtils.ILockedRunnable p1)
		{
			if (id_a_Ljava_io_File_Lcom_layer_sdk_internal_utils_FileUtils_LockedRunnable_ == IntPtr.Zero)
				id_a_Ljava_io_File_Lcom_layer_sdk_internal_utils_FileUtils_LockedRunnable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/io/File;Lcom/layer/sdk/internal/utils/FileUtils$LockedRunnable;)Ljava/lang/Exception;");
			global::Java.Lang.Exception __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_io_File_Lcom_layer_sdk_internal_utils_FileUtils_LockedRunnable_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
