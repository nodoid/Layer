using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableContext$BackgroundContext", DoNotGenerateAcw=true)]
	public partial class ChangeableContextBackgroundContext : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableContext$BackgroundContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableContextBackgroundContext); }
		}

		protected ChangeableContextBackgroundContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/constructor[@name='ChangeableContext.BackgroundContext' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", "")]
		public ChangeableContextBackgroundContext (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChangeableContextBackgroundContext)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0));
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/layer/sdk/internal/content/ContentManager;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ContentManager F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/layer/sdk/internal/content/ContentManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "")]
		public string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;", "")]
		public global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.BackgroundContext']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableContext$GenericContext", DoNotGenerateAcw=true)]
	public partial class ChangeableContextGenericContext : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableContext$GenericContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableContextGenericContext); }
		}

		protected ChangeableContextGenericContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/layer/sdk/internal/content/ContentManager;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ContentManager F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/layer/sdk/internal/content/ContentManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "")]
		public string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;", "")]
		public global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableContext.GenericContext']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']"
	[Register ("com/layer/sdk/internal/messaging/ChangeableContext", "", "Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker")]
	public partial interface IChangeableContext : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/layer/sdk/internal/content/ContentManager;", "GetFHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Content.ContentManager F ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "GetHHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker, Layer")]
		string H ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;", "GetJHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence J ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "GetKHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache K ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableContext']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;", "GetLHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableContextInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor L ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableContext", DoNotGenerateAcw=true)]
	internal class IChangeableContextInvoker : global::Java.Lang.Object, IChangeableContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableContext");
		IntPtr class_ref;

		public static IChangeableContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChangeableContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeableContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChangeableContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IChangeableContextInvoker); }
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static IntPtr n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.F ());
		}
#pragma warning restore 0169

		IntPtr id_f;
		public global::Com.Layer.Sdk.Internal.Content.ContentManager F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/layer/sdk/internal/content/ContentManager;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager> (JNIEnv.CallObjectMethod (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_H);
			return cb_h;
		}

		static IntPtr n_H (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H ());
		}
#pragma warning restore 0169

		IntPtr id_h;
		public string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_h), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_J);
			return cb_j;
		}

		static IntPtr n_J (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.J ());
		}
#pragma warning restore 0169

		IntPtr id_j;
		public global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Lcom/layer/sdk/internal/persistence/ChangeablePersistence;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (JNIEnv.CallObjectMethod (Handle, id_j), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_k;
#pragma warning disable 0169
		static Delegate GetKHandler ()
		{
			if (cb_k == null)
				cb_k = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_K);
			return cb_k;
		}

		static IntPtr n_K (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.K ());
		}
#pragma warning restore 0169

		IntPtr id_k;
		public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_l;
#pragma warning disable 0169
		static Delegate GetLHandler ()
		{
			if (cb_l == null)
				cb_l = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_L);
			return cb_l;
		}

		static IntPtr n_L (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.L ());
		}
#pragma warning restore 0169

		IntPtr id_l;
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/messaging/ChangeableExecutor;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableExecutor> (JNIEnv.CallObjectMethod (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

	}

}
