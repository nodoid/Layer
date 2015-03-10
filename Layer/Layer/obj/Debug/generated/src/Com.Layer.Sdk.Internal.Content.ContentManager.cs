using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentManager", DoNotGenerateAcw=true)]
	public partial class ContentManager : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Content.ISettings {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.CacheManipulator']"
		[Register ("com/layer/sdk/internal/content/ContentManager$CacheManipulator", "", "Com.Layer.Sdk.Internal.Content.ContentManager/ICacheManipulatorInvoker")]
		public partial interface ICacheManipulator : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.CacheManipulator']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri']]"
			[Register ("a", "(Landroid/net/Uri;Landroid/net/Uri;)V", "GetA_Landroid_net_Uri_Landroid_net_Uri_Handler:Com.Layer.Sdk.Internal.Content.ContentManager/ICacheManipulatorInvoker, Layer")]
			void A (global::Android.Net.Uri p0, global::Android.Net.Uri p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.CacheManipulator']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
			[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V", "GetA_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Handler:Com.Layer.Sdk.Internal.Content.ContentManager/ICacheManipulatorInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentManager$CacheManipulator", DoNotGenerateAcw=true)]
		internal class ICacheManipulatorInvoker : global::Java.Lang.Object, ICacheManipulator {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentManager$CacheManipulator");
			IntPtr class_ref;

			public static ICacheManipulator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICacheManipulator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.content.ContentManager.CacheManipulator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICacheManipulatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICacheManipulatorInvoker); }
			}

			static Delegate cb_a_Landroid_net_Uri_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetA_Landroid_net_Uri_Landroid_net_Uri_Handler ()
			{
				if (cb_a_Landroid_net_Uri_Landroid_net_Uri_ == null)
					cb_a_Landroid_net_Uri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_net_Uri_Landroid_net_Uri_);
				return cb_a_Landroid_net_Uri_Landroid_net_Uri_;
			}

			static void n_A_Landroid_net_Uri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_a_Landroid_net_Uri_Landroid_net_Uri_;
			public void A (global::Android.Net.Uri p0, global::Android.Net.Uri p1)
			{
				if (id_a_Landroid_net_Uri_Landroid_net_Uri_ == IntPtr.Zero)
					id_a_Landroid_net_Uri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;Landroid/net/Uri;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Landroid_net_Uri_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == null)
					cb_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_);
				return cb_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
			}

			static void n_A_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ICacheManipulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
			public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
			{
				if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']"
		[Register ("com/layer/sdk/internal/content/ContentManager$Persistence", "", "Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker")]
		public partial interface IPersistence : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()J", "GetAHandler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			long A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart']]"
			[Register ("a", "(Lcom/layer/sdk/messaging/MessagePart;)V", "GetA_Lcom_layer_sdk_messaging_MessagePart_Handler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Messaging.MessagePart p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart.TransferStatus...']]"
			[Register ("a", "([Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;", "GetA_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_Handler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> A (params global:: Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("a", "(Ljava/lang/Long;)V", "GetA_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			void A (global::Java.Lang.Long p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/util/List;", "GetBHandler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath> B ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='ContentManager.Persistence']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()V", "GetCHandler:Com.Layer.Sdk.Internal.Content.ContentManager/IPersistenceInvoker, Layer")]
			void C ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentManager$Persistence", DoNotGenerateAcw=true)]
		internal class IPersistenceInvoker : global::Java.Lang.Object, IPersistence {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentManager$Persistence");
			IntPtr class_ref;

			public static IPersistence GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPersistence> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.content.ContentManager.Persistence"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPersistenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPersistenceInvoker); }
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_A);
				return cb_a;
			}

			static long n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.A ();
			}
#pragma warning restore 0169

			IntPtr id_a;
			public long A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()J");
				return JNIEnv.CallLongMethod (Handle, id_a);
			}

			static Delegate cb_a_Lcom_layer_sdk_messaging_MessagePart_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_messaging_MessagePart_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_messaging_MessagePart_ == null)
					cb_a_Lcom_layer_sdk_messaging_MessagePart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_messaging_MessagePart_);
				return cb_a_Lcom_layer_sdk_messaging_MessagePart_;
			}

			static void n_A_Lcom_layer_sdk_messaging_MessagePart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_messaging_MessagePart_;
			public void A (global::Com.Layer.Sdk.Messaging.MessagePart p0)
			{
				if (id_a_Lcom_layer_sdk_messaging_MessagePart_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_messaging_MessagePart_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/MessagePart;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_messaging_MessagePart_, new JValue (p0));
			}

			static Delegate cb_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_;
#pragma warning disable 0169
			static Delegate GetA_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_Handler ()
			{
				if (cb_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ == null)
					cb_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_);
				return cb_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_;
			}

			static IntPtr n_A_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] p0 = (global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Layer.Sdk.Messaging.MessagePart.TransferStatus));
				IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.ToLocalJniHandle (__this.A (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_;
			public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> A (params global:: Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] p0)
			{
				if (id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ == IntPtr.Zero)
					id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ = JNIEnv.GetMethodID (class_ref, "a", "([Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_a_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_Long_Handler ()
			{
				if (cb_a_Ljava_lang_Long_ == null)
					cb_a_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Long_);
				return cb_a_Ljava_lang_Long_;
			}

			static void n_A_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_Long_;
			public void A (global::Java.Lang.Long p0)
			{
				if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
					id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
			}

			static Delegate cb_b;
#pragma warning disable 0169
			static Delegate GetBHandler ()
			{
				if (cb_b == null)
					cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
				return cb_b;
			}

			static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath>.ToLocalJniHandle (__this.B ());
			}
#pragma warning restore 0169

			IntPtr id_b;
			public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath> B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_c;
#pragma warning disable 0169
			static Delegate GetCHandler ()
			{
				if (cb_c == null)
					cb_c = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_C);
				return cb_c;
			}

			static void n_C (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.C ();
			}
#pragma warning restore 0169

			IntPtr id_c;
			public void C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
				JNIEnv.CallVoidMethod (Handle, id_c);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager.ResolveType']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/content/ContentManager$ResolveType", DoNotGenerateAcw=true)]
		public sealed partial class ResolveType : global::Java.Lang.Enum {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager.ResolveType']/field[@name='a']"
			[Register ("a")]
			public static global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager.ResolveType']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentManager$ResolveType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResolveType); }
			}

			internal ResolveType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/content/ContentManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentManager); }
		}

		protected ContentManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Z", "")]
		public bool A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener;)Z", "")]
		public bool A (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_a_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_a_Ljava_util_Collection_ == IntPtr.Zero)
				id_a_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Internal.Content.ISettings __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_a_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Lcom/layer/sdk/internal/content/ContentManager$ResolveType;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType B (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
			global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType> (JNIEnv.CallObjectMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='b' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener;)Z", "")]
		public bool B (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;Lcom/layer/sdk/listeners/LayerProgressListener;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_b_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='b' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("b", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)V", "")]
		public void B (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_b_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("b", "(J)Lcom/layer/sdk/internal/content/Settings;", "")]
		public global::Com.Layer.Sdk.Internal.Content.ISettings B (long p0)
		{
			if (id_b_J == IntPtr.Zero)
				id_b_J = JNIEnv.GetMethodID (class_ref, "b", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod  (Handle, id_b_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Set;", "")]
		public global::System.Collections.Generic.ICollection<string> C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='c' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("c", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Lcom/layer/sdk/internal/content/ContentManager$ResolveType;", "")]
		public static global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType C (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_c_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_c_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Lcom/layer/sdk/internal/content/ContentManager$ResolveType;");
			global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ContentManager.ResolveType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()J", "")]
		public long D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_d);
		}

		static IntPtr id_d_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='d' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.MessagePartImpl']]"
		[Register ("d", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Z", "")]
		public bool D (global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl p0)
		{
			if (id_d_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ == IntPtr.Zero)
				id_d_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_ = JNIEnv.GetMethodID (class_ref, "d", "(Lcom/layer/sdk/internal/messaging/models/MessagePartImpl;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_d_Lcom_layer_sdk_internal_messaging_models_MessagePartImpl_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/class[@name='ContentManager']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()J", "")]
		public long E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_e);
		}

	}
}
