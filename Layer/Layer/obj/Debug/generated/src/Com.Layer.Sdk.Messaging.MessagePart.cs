using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']"
	[global::Android.Runtime.Register ("com/layer/sdk/messaging/MessagePart", DoNotGenerateAcw=true)]
	public abstract partial class MessagePart : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']"
		[global::Android.Runtime.Register ("com/layer/sdk/messaging/MessagePart$TransferStatus", DoNotGenerateAcw=true)]
		public sealed partial class TransferStatus : global::Java.Lang.Enum {


			static IntPtr AWAITING_UPLOAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/field[@name='AWAITING_UPLOAD']"
			[Register ("AWAITING_UPLOAD")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus AwaitingUpload {
				get {
					if (AWAITING_UPLOAD_jfieldId == IntPtr.Zero)
						AWAITING_UPLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AWAITING_UPLOAD", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AWAITING_UPLOAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AWAITING_UPLOAD_jfieldId == IntPtr.Zero)
						AWAITING_UPLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AWAITING_UPLOAD", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AWAITING_UPLOAD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus Complete {
				get {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, COMPLETE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOWNLOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/field[@name='DOWNLOADING']"
			[Register ("DOWNLOADING")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus Downloading {
				get {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOWNLOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr READY_FOR_DOWNLOAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/field[@name='READY_FOR_DOWNLOAD']"
			[Register ("READY_FOR_DOWNLOAD")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus ReadyForDownload {
				get {
					if (READY_FOR_DOWNLOAD_jfieldId == IntPtr.Zero)
						READY_FOR_DOWNLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READY_FOR_DOWNLOAD", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READY_FOR_DOWNLOAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (READY_FOR_DOWNLOAD_jfieldId == IntPtr.Zero)
						READY_FOR_DOWNLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READY_FOR_DOWNLOAD", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, READY_FOR_DOWNLOAD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPLOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/field[@name='UPLOADING']"
			[Register ("UPLOADING")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus Uploading {
				get {
					if (UPLOADING_jfieldId == IntPtr.Zero)
						UPLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADING", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPLOADING_jfieldId == IntPtr.Zero)
						UPLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADING", "Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPLOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/messaging/MessagePart$TransferStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TransferStatus); }
			}

			internal TransferStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getValue);
				}
			}

			static IntPtr id_fromOrdinal_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/method[@name='fromOrdinal' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromOrdinal", "(I)Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus FromOrdinal (int p0)
			{
				if (id_fromOrdinal_I == IntPtr.Zero)
					id_fromOrdinal_I = JNIEnv.GetStaticMethodID (class_ref, "fromOrdinal", "(I)Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromOrdinal_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart.TransferStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "")]
			public static global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
				return (global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/messaging/MessagePart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagePart); }
		}

		protected MessagePart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/constructor[@name='MessagePart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MessagePart () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MessagePart)) {
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.DataStream);
		}
#pragma warning restore 0169

		public abstract global::System.IO.Stream DataStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getDataStream' and count(parameter)=0]"
			[Register ("getDataStream", "()Ljava/io/InputStream;", "GetGetDataStreamHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContentReady;
		}
#pragma warning restore 0169

		public abstract bool IsContentReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='isContentReady' and count(parameter)=0]"
			[Register ("isContentReady", "()Z", "GetIsContentReadyHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		public abstract global::Com.Layer.Sdk.Messaging.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetMessageHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		public abstract string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public abstract long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")] get;
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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLocalContent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='deleteLocalContent' and count(parameter)=0]"
		[Register ("deleteLocalContent", "()V", "GetDeleteLocalContentHandler")]
		public abstract void DeleteLocalContent ();

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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Download (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='download' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetDownload_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public abstract void Download (global::Com.Layer.Sdk.Listeners.ILayerProgressListener p0);

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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public abstract byte[] GetData ();

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
			global::Com.Layer.Sdk.Messaging.MessagePart __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTransferStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getTransferStatus' and count(parameter)=0]"
		[Register ("getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "GetGetTransferStatusHandler")]
		public abstract global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus GetTransferStatus ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/messaging/MessagePart", DoNotGenerateAcw=true)]
	internal partial class MessagePartInvoker : MessagePart {

		public MessagePartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagePartInvoker); }
		}

		static IntPtr id_getDataStream;
		public override global::System.IO.Stream DataStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getDataStream' and count(parameter)=0]"
			[Register ("getDataStream", "()Ljava/io/InputStream;", "GetGetDataStreamHandler")]
			get {
				if (id_getDataStream == IntPtr.Zero)
					id_getDataStream = JNIEnv.GetMethodID (class_ref, "getDataStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDataStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getId;
		public override global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isContentReady;
		public override bool IsContentReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='isContentReady' and count(parameter)=0]"
			[Register ("isContentReady", "()Z", "GetIsContentReadyHandler")]
			get {
				if (id_isContentReady == IntPtr.Zero)
					id_isContentReady = JNIEnv.GetMethodID (class_ref, "isContentReady", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isContentReady);
			}
		}

		static IntPtr id_getMessage;
		public override global::Com.Layer.Sdk.Messaging.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/layer/sdk/messaging/Message;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/layer/sdk/messaging/Message;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMimeType;
		public override string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSize;
		public override long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getSize);
			}
		}

		static IntPtr id_deleteLocalContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='deleteLocalContent' and count(parameter)=0]"
		[Register ("deleteLocalContent", "()V", "GetDeleteLocalContentHandler")]
		public override void DeleteLocalContent ()
		{
			if (id_deleteLocalContent == IntPtr.Zero)
				id_deleteLocalContent = JNIEnv.GetMethodID (class_ref, "deleteLocalContent", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteLocalContent);
		}

		static IntPtr id_download_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='download' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V", "GetDownload_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override void Download (global::Com.Layer.Sdk.Listeners.ILayerProgressListener p0)
		{
			if (id_download_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_download_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "download", "(Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_download_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0));
		}

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public override byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_getTransferStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.messaging']/class[@name='MessagePart']/method[@name='getTransferStatus' and count(parameter)=0]"
		[Register ("getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;", "GetGetTransferStatusHandler")]
		public override global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus GetTransferStatus ()
		{
			if (id_getTransferStatus == IntPtr.Zero)
				id_getTransferStatus = JNIEnv.GetMethodID (class_ref, "getTransferStatus", "()Lcom/layer/sdk/messaging/MessagePart$TransferStatus;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus> (JNIEnv.CallObjectMethod  (Handle, id_getTransferStatus), JniHandleOwnership.TransferLocalRef);
		}

	}

}
