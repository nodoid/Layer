using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncError']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/sync/SyncError", DoNotGenerateAcw=true)]
	public partial class SyncError : global::Java.Lang.Error {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/sync/SyncError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncError); }
		}

		protected SyncError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon.sync']/class[@name='SyncError']/constructor[@name='SyncError' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;)V", "")]
		public SyncError (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (SyncError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
