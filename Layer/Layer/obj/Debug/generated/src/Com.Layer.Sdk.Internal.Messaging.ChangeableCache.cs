using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableCache", DoNotGenerateAcw=true)]
	public partial class ChangeableCache : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator, global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent.IEmitter {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableCache.Listener']"
		[Register ("com/layer/sdk/internal/messaging/ChangeableCache$Listener", "", "Com.Layer.Sdk.Internal.Messaging.ChangeableCache/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableCache.Listener']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeEvent']]"
			[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V", "GetA_Lcom_layer_sdk_internal_messaging_ChangeEvent_Handler:Com.Layer.Sdk.Internal.Messaging.ChangeableCache/IListenerInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableCache$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableCache$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeableCache.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_messaging_ChangeEvent_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == null)
					cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_ChangeEvent_);
				return cb_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
			}

			static void n_A_Lcom_layer_sdk_internal_messaging_ChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
			public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
			{
				if (id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_, new JValue (p0));
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
			{
				this.p0 = p0;
			}

			global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0;
			public global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/layer/sdk/internal/messaging/ChangeableCache_ListenerImplementor")]
		internal sealed class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/internal/messaging/ChangeableCache_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache.Origin']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableCache$Origin", DoNotGenerateAcw=true)]
		public sealed partial class Origin : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache.Origin']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableCache$Origin", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Origin); }
			}

			internal Origin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache.Origin']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;", "")]
			public static global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;");
				return (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableCache.TransactionAlerter']"
		[Register ("com/layer/sdk/internal/messaging/ChangeableCache$TransactionAlerter", "", "Com.Layer.Sdk.Internal.Messaging.ChangeableCache/ITransactionAlerterInvoker")]
		public partial interface ITransactionAlerter : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableCache$TransactionAlerter", DoNotGenerateAcw=true)]
		internal class ITransactionAlerterInvoker : global::Java.Lang.Object, ITransactionAlerter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableCache$TransactionAlerter");
			IntPtr class_ref;

			public static ITransactionAlerter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITransactionAlerter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeableCache.TransactionAlerter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITransactionAlerterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITransactionAlerterInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeableCache); }
		}

		protected ChangeableCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/constructor[@name='ChangeableCache' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", "")]
		public ChangeableCache (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChangeableCache)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/Changeable;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeable A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/Changeable;");
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_net_Uri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;Landroid/net/Uri;)V", "")]
		public void A (global::Android.Net.Uri p0, global::Android.Net.Uri p1)
		{
			if (id_a_Landroid_net_Uri_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_net_Uri_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeEvent']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeEvent p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeEvent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeEvent_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_Changeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Changeable']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Changeable;)Lcom/layer/sdk/internal/messaging/Changeable;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.IChangeable A (global::Com.Layer.Sdk.Internal.Messaging.IChangeable p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Changeable_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Changeable_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Changeable;)Lcom/layer/sdk/internal/messaging/Changeable;");
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_Changeable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableCache.Listener']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Listener;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.IListener p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Listener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Origin_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_internal_messaging_Changeable_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableCache.Origin'] and parameter[2][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[3][@type='com.layer.sdk.internal.messaging.Changeable'] and parameter[4][@type='java.util.Date']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Lcom/layer/sdk/internal/messaging/Changeable;Ljava/util/Date;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.Origin p0, global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p1, global::Com.Layer.Sdk.Internal.Messaging.IChangeable p2, global::Java.Util.Date p3)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Origin_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_internal_messaging_Changeable_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Origin_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_internal_messaging_Changeable_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Origin;Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Lcom/layer/sdk/internal/messaging/Changeable;Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableCache_Origin_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Lcom_layer_sdk_internal_messaging_Changeable_Ljava_util_Date_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction.Type']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;)Lcom/layer/sdk/internal/messaging/ChangeableTransaction;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction.Type p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction$Type;)Lcom/layer/sdk/internal/messaging/ChangeableTransaction;");
			global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Type_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[2][@type='boolean']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Z)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, bool p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Z == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Z = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[2][@type='com.layer.sdk.internal.messaging.Changeable...']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;[Lcom/layer/sdk/internal/messaging/Changeable;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, params global:: Com.Layer.Sdk.Internal.Messaging.IChangeable[] p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;[Lcom/layer/sdk/internal/messaging/Changeable;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Ljava/lang/Iterable;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, global::Java.Lang.IIterable p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_ConversationImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.ConversationImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/ConversationImpl;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> A (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_ConversationImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_ConversationImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/ConversationImpl;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_ConversationImpl_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Iterable;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> A (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl B (global::Android.Net.Uri p0)
		{
			if (id_b_Landroid_net_Uri_ == IntPtr.Zero)
				id_b_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallObjectMethod  (Handle, id_b_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableCache.Listener']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Listener;)V", "")]
		public void B (global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache.IListener p0)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/ChangeableCache$Listener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_ChangeableCache_Listener_, new JValue (p0));
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='b' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction'] and parameter[2][@type='com.layer.sdk.internal.messaging.Changeable...']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;[Lcom/layer/sdk/internal/messaging/Changeable;)V", "")]
		public void B (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0, params global:: Com.Layer.Sdk.Internal.Messaging.IChangeable[] p1)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;[Lcom/layer/sdk/internal/messaging/Changeable;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_arrayLcom_layer_sdk_internal_messaging_Changeable_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_b_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("b", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> B (global::Java.Lang.IIterable p0)
		{
			if (id_b_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_b_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Iterable;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_c_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("c", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl C (global::Android.Net.Uri p0)
		{
			if (id_c_Landroid_net_Uri_ == IntPtr.Zero)
				id_c_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallObjectMethod  (Handle, id_c_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("c", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> C (global::Java.Lang.IIterable p0)
		{
			if (id_c_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_c_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Iterable;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_c_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("d", "(Landroid/net/Uri;)Z", "")]
		public bool D (global::Android.Net.Uri p0)
		{
			if (id_d_Landroid_net_Uri_ == IntPtr.Zero)
				id_d_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/net/Uri;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_d_Landroid_net_Uri_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_d_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='ChangeableCache']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("d", "(Ljava/lang/Iterable;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> D (global::Java.Lang.IIterable p0)
		{
			if (id_d_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_d_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Iterable;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_d_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
