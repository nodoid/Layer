using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentTransport", DoNotGenerateAcw=true)]
	public partial class ContentTransport : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.ConsumingCallback']"
		[Register ("com/layer/sdk/internal/content/ContentTransport$ConsumingCallback", "", "Com.Layer.Sdk.Internal.Content.ContentTransport/IConsumingCallbackInvoker")]
		protected internal partial interface IConsumingCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.ConsumingCallback']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Lorg/apache/http/client/methods/HttpRequestBase;", "GetAHandler:Com.Layer.Sdk.Internal.Content.ContentTransport/IConsumingCallbackInvoker, Layer")]
			global::Org.Apache.Http.Client.Methods.HttpRequestBase A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.ConsumingCallback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
			[Register ("a", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;", "GetA_Lorg_apache_http_HttpResponse_Handler:Com.Layer.Sdk.Internal.Content.ContentTransport/IConsumingCallbackInvoker, Layer")]
			global::Java.Lang.Object A (global::Org.Apache.Http.IHttpResponse p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentTransport$ConsumingCallback", DoNotGenerateAcw=true)]
		internal class IConsumingCallbackInvoker : global::Java.Lang.Object, IConsumingCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentTransport$ConsumingCallback");
			IntPtr class_ref;

			public static IConsumingCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConsumingCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.content.ContentTransport.ConsumingCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConsumingCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IConsumingCallbackInvoker); }
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentTransport.IConsumingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentTransport.IConsumingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.A ());
			}
#pragma warning restore 0169

			IntPtr id_a;
			public global::Org.Apache.Http.Client.Methods.HttpRequestBase A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lorg/apache/http/client/methods/HttpRequestBase;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_a_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
			static Delegate GetA_Lorg_apache_http_HttpResponse_Handler ()
			{
				if (cb_a_Lorg_apache_http_HttpResponse_ == null)
					cb_a_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lorg_apache_http_HttpResponse_);
				return cb_a_Lorg_apache_http_HttpResponse_;
			}

			static IntPtr n_A_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentTransport.IConsumingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentTransport.IConsumingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_a_Lorg_apache_http_HttpResponse_;
			public global::Java.Lang.Object A (global::Org.Apache.Http.IHttpResponse p0)
			{
				if (id_a_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
					id_a_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "a", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_a_Lorg_apache_http_HttpResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.StreamingCallback']"
		[Register ("com/layer/sdk/internal/content/ContentTransport$StreamingCallback", "", "Com.Layer.Sdk.Internal.Content.ContentTransport/IStreamingCallbackInvoker")]
		protected internal partial interface IStreamingCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.StreamingCallback']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Lorg/apache/http/client/methods/HttpRequestBase;", "GetAHandler:Com.Layer.Sdk.Internal.Content.ContentTransport/IStreamingCallbackInvoker, Layer")]
			global::Org.Apache.Http.Client.Methods.HttpRequestBase A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentTransport.StreamingCallback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
			[Register ("a", "(Lorg/apache/http/HttpResponse;)V", "GetA_Lorg_apache_http_HttpResponse_Handler:Com.Layer.Sdk.Internal.Content.ContentTransport/IStreamingCallbackInvoker, Layer")]
			void A (global::Org.Apache.Http.IHttpResponse p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentTransport$StreamingCallback", DoNotGenerateAcw=true)]
		internal class IStreamingCallbackInvoker : global::Java.Lang.Object, IStreamingCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentTransport$StreamingCallback");
			IntPtr class_ref;

			public static IStreamingCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStreamingCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.content.ContentTransport.StreamingCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStreamingCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStreamingCallbackInvoker); }
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentTransport.IStreamingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentTransport.IStreamingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.A ());
			}
#pragma warning restore 0169

			IntPtr id_a;
			public global::Org.Apache.Http.Client.Methods.HttpRequestBase A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lorg/apache/http/client/methods/HttpRequestBase;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_a_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
			static Delegate GetA_Lorg_apache_http_HttpResponse_Handler ()
			{
				if (cb_a_Lorg_apache_http_HttpResponse_ == null)
					cb_a_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lorg_apache_http_HttpResponse_);
				return cb_a_Lorg_apache_http_HttpResponse_;
			}

			static void n_A_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentTransport.IStreamingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentTransport.IStreamingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lorg_apache_http_HttpResponse_;
			public void A (global::Org.Apache.Http.IHttpResponse p0)
			{
				if (id_a_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
					id_a_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "a", "(Lorg/apache/http/HttpResponse;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lorg_apache_http_HttpResponse_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentTransport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentTransport); }
		}

		protected ContentTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']/constructor[@name='ContentTransport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ContentTransport (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ContentTransport)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/layer/sdk/exceptions/LayerException;", "")]
		protected static global::Com.Layer.Sdk.Exceptions.LayerException A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(I)Lcom/layer/sdk/exceptions/LayerException;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_UploadEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.layer.sdk.internal.syncrecon.sync.UploadEntity']]"
		[Register ("a", "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/UploadEntity;)V", "")]
		public void A (global::Java.IO.File p0, string p1, long p2, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.UploadEntity p3)
		{
			if (id_a_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_UploadEntity_ == IntPtr.Zero)
				id_a_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_UploadEntity_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/io/File;Ljava/lang/String;JLcom/layer/sdk/internal/syncrecon/sync/UploadEntity;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_io_File_Ljava_lang_String_JLcom_layer_sdk_internal_syncrecon_sync_UploadEntity_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/Long;)J", "")]
		public long A (string p0, global::Java.Lang.Long p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/Long;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallLongMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentTransport']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("a", "(Ljava/lang/String;JJ)Ljava/io/InputStream;", "")]
		public global::System.IO.Stream A (string p0, long p1, long p2)
		{
			if (id_a_Ljava_lang_String_JJ == IntPtr.Zero)
				id_a_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;JJ)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_JJ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
