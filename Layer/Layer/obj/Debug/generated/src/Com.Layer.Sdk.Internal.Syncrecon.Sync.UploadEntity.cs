using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='UploadEntity']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/sync/UploadEntity", DoNotGenerateAcw=true)]
	public partial class UploadEntity : global::Org.Apache.Http.Entity.FileEntity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/sync/UploadEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadEntity); }
		}

		protected UploadEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='UploadEntity']/constructor[@name='UploadEntity' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.layer.sdk.internal.syncrecon.sync.ProgressOutputStream.Listener']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", "")]
		public UploadEntity (global::Java.IO.File p0, string p1, long p2, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.ProgressOutputStream.IListener p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (UploadEntity)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_ == IntPtr.Zero)
				id_ctor_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/ProgressOutputStream$Listener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_ProgressOutputStream_Listener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
