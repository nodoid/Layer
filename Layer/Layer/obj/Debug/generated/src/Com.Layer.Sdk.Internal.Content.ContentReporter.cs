using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentReporter", DoNotGenerateAcw=true)]
	public partial class ContentReporter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter.ProgressReport']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentReporter$ProgressReport", DoNotGenerateAcw=true)]
		public partial class ProgressReport : global::Java.Lang.Object {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter.ProgressReport']/field[@name='a']"
			[Register ("a")]
			public global::Java.Lang.Long A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Long;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Long;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter.ProgressReport']/field[@name='b']"
			[Register ("b")]
			public global::Java.Lang.Long B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Long;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Long;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentReporter$ProgressReport", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProgressReport); }
			}

			protected ProgressReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_Long_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter.ProgressReport']/constructor[@name='ContentReporter.ProgressReport' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long']]"
			[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/Long;)V", "")]
			public ProgressReport (global::Java.Lang.Long p0, global::Java.Lang.Long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ProgressReport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Long;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Long;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentReporter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentReporter); }
		}

		protected ContentReporter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_MainThreadRunner_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/constructor[@name='ContentReporter' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.MainThreadRunner']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/MainThreadRunner;)V", "")]
		public ContentReporter (global::Com.Layer.Sdk.Internal.IMainThreadRunner p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContentReporter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/MainThreadRunner;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/MainThreadRunner;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_MainThreadRunner_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_MainThreadRunner_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/MainThreadRunner;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_MainThreadRunner_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_MainThreadRunner_, new JValue (p0));
		}

		static IntPtr id_a_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("a", "(Landroid/net/Uri;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "")]
		public void A (global::Android.Net.Uri p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_a_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;Ljava/lang/Throwable;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, global::Java.Lang.Throwable p2)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;Ljava/lang/Throwable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='a' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;JJ)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1, long p2, long p3)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JJ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JJ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;JJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_JJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_b_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("b", "(Landroid/net/Uri;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "")]
		public void B (global::Android.Net.Uri p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_b_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_b_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/net/Uri;Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Landroid_net_Uri_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentReporter']/method[@name='b' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener.Operation']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V", "")]
		public void B (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.LayerProgressListenerOperation p1)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener$Operation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_Operation_, new JValue (p0), new JValue (p1));
		}

	}
}
