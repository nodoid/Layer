using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/LayerSession", DoNotGenerateAcw=true)]
	public partial class LayerSession : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator, global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/LayerSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerSession); }
		}

		protected LayerSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_net_Uri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;Landroid/net/Uri;)V", "")]
		public void A (global::Android.Net.Uri p0, global::Android.Net.Uri p1)
		{
			if (id_a_Landroid_net_Uri_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_net_Uri_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_util_UUID_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID']]"
		[Register ("a", "(Ljava/util/UUID;Ljava/util/UUID;)Z", "")]
		public bool A (global::Java.Util.UUID p0, global::Java.Util.UUID p1)
		{
			if (id_a_Ljava_util_UUID_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;Ljava/util/UUID;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Ljava_util_UUID_Ljava_util_UUID_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/syncrecon/SyncRecon;", "")]
		public global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/syncrecon/SyncRecon;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/layer/sdk/internal/policy/PolicyManager;", "")]
		public global::Com.Layer.Sdk.Internal.Policy.PolicyManager E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Lcom/layer/sdk/internal/policy/PolicyManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Policy.PolicyManager> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/layer/sdk/internal/content/ContentManager;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ContentManager F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/layer/sdk/internal/content/ContentManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "")]
		public string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;", "")]
		public global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence> (JNIEnv.CallObjectMethod  (Handle, id_i), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;", "")]
		public global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()V", "")]
		public void M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_m);
		}

		static IntPtr id_n;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal']/class[@name='LayerSession']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()V", "")]
		public void N ()
		{
			if (id_n == IntPtr.Zero)
				id_n = JNIEnv.GetMethodID (class_ref, "n", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_n);
		}

	}
}
