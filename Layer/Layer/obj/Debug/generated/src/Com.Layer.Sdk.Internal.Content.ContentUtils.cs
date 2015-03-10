using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentUtils']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentUtils", DoNotGenerateAcw=true)]
	public partial class ContentUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentUtils); }
		}

		protected ContentUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentUtils']/constructor[@name='ContentUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ContentUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContentUtils)) {
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

		static IntPtr id_a_Landroid_content_Context_Ljava_util_UUID_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentUtils']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID']]"
		[Register ("a", "(Landroid/content/Context;Ljava/util/UUID;Ljava/util/UUID;)Ljava/io/File;", "")]
		public static global::Java.IO.File A (global::Android.Content.Context p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2)
		{
			if (id_a_Landroid_content_Context_Ljava_util_UUID_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_util_UUID_Ljava_util_UUID_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/util/UUID;Ljava/util/UUID;)Ljava/io/File;");
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_util_UUID_Ljava_util_UUID_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_io_File_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentUtils']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("a", "(Ljava/io/File;Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Ljava/io/File;", "")]
		public static global::Java.IO.File A (global::Java.IO.File p0, global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p1)
		{
			if (id_a_Ljava_io_File_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_a_Ljava_io_File_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/io/File;Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Ljava/io/File;");
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_io_File_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
