using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/models/MessagePartImpl", DoNotGenerateAcw=true)]
	public partial class MessagePartImpl : global::Com.Layer.Sdk.Messaging.MessagePart {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/models/MessagePartImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagePartImpl); }
		}

		protected MessagePartImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/constructor[@name='MessagePartImpl' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Long']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;)V", "")]
		public MessagePartImpl (global::Android.Net.Uri p0, global::Java.Lang.Long p1, string p2, global::Java.Lang.Long p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (MessagePartImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_ctor_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getDataStream;
#pragma warning disable 0169
		static Delegate GetGetDataStreamHandler ()
		{
			if (cb_getDataStream == null)
				cb_getDataStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataStream);
			return cb_getDataStream;
		}

		static IntPtr n_GetDataStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.DataStream);
		}
#pragma warning restore 0169

		static IntPtr id_getDataStream;
		public override global::System.IO.Stream DataStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getDataStream' and count(parameter)=0]"
			[Register ("getDataStream", "()Ljava/io/InputStream;", "GetGetDataStreamHandler")]
			get {
				if (id_getDataStream == IntPtr.Zero)
					id_getDataStream = JNIEnv.GetMethodID (class_ref, "getDataStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDataStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isContentReady;
#pragma warning disable 0169
		static Delegate GetIsContentReadyHandler ()
		{
			if (cb_isContentReady == null)
				cb_isContentReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContentReady);
			return cb_isContentReady;
		}

		static bool n_IsContentReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContentReady;
		}
#pragma warning restore 0169

		static IntPtr id_isContentReady;
		public override bool IsContentReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='isContentReady' and count(parameter)=0]"
			[Register ("isContentReady", "()Z", "GetIsContentReadyHandler")]
			get {
				if (id_isContentReady == IntPtr.Zero)
					id_isContentReady = JNIEnv.GetMethodID (class_ref, "isContentReady", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isContentReady);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContentReady", "()Z"));
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public override global::Com.Layer.Sdk.Messaging.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/layer/sdk/messaging/Message;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/layer/sdk/messaging/Message;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_getMimeType == null)
				cb_getMimeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeType);
			return cb_getMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		static IntPtr id_getMimeType;
		public override string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMimeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public override long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getSize);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()J"));
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/io/File;", "")]
		public global::Java.IO.File A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/io/File;");
			return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)V", "")]
		public void A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_net_Uri_, new JValue (p0));
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
		}

		static IntPtr id_a_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (byte[] p0)
		{
			if (id_a_arrayB == IntPtr.Zero)
				id_a_arrayB = JNIEnv.GetMethodID (class_ref, "a", "([B)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Message;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart.TransferStatus']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("a", "(Ljava/io/File;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (global::Java.IO.File p0)
		{
			if (id_a_Ljava_io_File_ == IntPtr.Zero)
				id_a_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/io/File;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("a", "(Ljava/io/InputStream;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (global::System.IO.Stream p0)
		{
			if (id_a_Ljava_io_InputStream_ == IntPtr.Zero)
				id_a_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/io/InputStream;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (string p0, global::Java.Lang.Long p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='com.layer.sdk.messaging.MessagePart.TransferStatus'] and parameter[5][@type='boolean']]"
		[Register ("a", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lcom/layer/sdk/messaging/MessagePart$TransferStatus;Z)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl A (string p0, global::Java.Util.Date p1, global::Java.Util.Date p2, global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus p3, bool p4)
		{
			if (id_a_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_Z == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_Z = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lcom/layer/sdk/messaging/MessagePart$TransferStatus;Z)Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_layer_sdk_messaging_MessagePart_TransferStatus_Z, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "")]
		public void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("b", "(Ljava/util/Date;)V", "")]
		public void B (global::Java.Util.Date p0)
		{
			if (id_b_Ljava_util_Date_ == IntPtr.Zero)
				id_b_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_Date_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public bool D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_d);
		}

		static Delegate cb_deleteLocalContent;
#pragma warning disable 0169
		static Delegate GetDeleteLocalContentHandler ()
		{
			if (cb_deleteLocalContent == null)
				cb_deleteLocalContent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteLocalContent);
			return cb_deleteLocalContent;
		}

		static void n_DeleteLocalContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLocalContent ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteLocalContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='deleteLocalContent' and count(parameter)=0]"
		[Register ("deleteLocalContent", "()V", "GetDeleteLocalContentHandler")]
		public override void DeleteLocalContent ()
		{
			if (id_deleteLocalContent == IntPtr.Zero)
				id_deleteLocalContent = JNIEnv.GetMethodID (class_ref, "deleteLocalContent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deleteLocalContent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteLocalContent", "()V"));
		}

		static Delegate cb_download_Lcom_layer_sdk_listeners_LayerProgressListener_;
#pragma warning disable 0169
		static Delegate GetDownload_Lcom_layer_sdk_listeners_LayerProgressListener_Handler ()
		{
			if (cb_download_Lcom_layer_sdk_listeners_LayerProgressListener_ == null)
				cb_download_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Download_Lcom_layer_sdk_listeners_LayerProgressListener_);
			return cb_download_Lcom_layer_sdk_listeners_LayerProgressListener_;
		}

		static void n_Download_Lcom_layer_sdk_listeners_LayerProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Download (p0);
		}
#pragma warning restore 0169

		static IntPtr id_download_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='download' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetDownload_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override void Download (global::Com.Layer.Sdk.Listeners.ILayerProgressListener p0)
		{
			if (id_download_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_download_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_download_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V"), new JValue (p0));
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()[B", "")]
		public byte[] F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "")]
		public string G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_g), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public override byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getTransferStatus;
#pragma warning disable 0169
		static Delegate GetGetTransferStatusHandler ()
		{
			if (cb_getTransferStatus == null)
				cb_getTransferStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferStatus);
			return cb_getTransferStatus;
		}

		static IntPtr n_GetTransferStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTransferStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getTransferStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='getTransferStatus' and count(parameter)=0]"
		[Register ("getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "GetGetTransferStatusHandler")]
		public override global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus GetTransferStatus ()
		{
			if (id_getTransferStatus == IntPtr.Zero)
				id_getTransferStatus = JNIEnv.GetMethodID (class_ref, "getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (JNIEnv.CallObjectMethod  (Handle, id_getTransferStatus), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/util/Date;", "")]
		public global::Java.Util.Date H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging.models']/class[@name='MessagePartImpl']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()I", "")]
		public int I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_i);
		}

	}
}
