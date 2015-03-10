using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']"
	[Register ("com/layer/sdk/internal/persistence/ChangeablePersistence", "", "Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker")]
	public partial interface IChangeablePersistence : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "GetA_Landroid_net_Uri_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl A (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.ConversationParticipantImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V", "GetA_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Conversation;)V", "GetA_Lcom_layer_sdk_messaging_Conversation_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Messaging.Conversation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Message;)V", "GetA_Lcom_layer_sdk_messaging_Message_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Messaging.Message p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)V", "GetA_Ljava_lang_Iterable_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void A (global::Java.Lang.IIterable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)Ljava/util/List;", "GetA_Ljava_util_List_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::System.Collections.Generic.IList<global::Android.Net.Uri> A (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "GetB_Landroid_net_Uri_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl B (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)Ljava/util/List;", "GetB_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Java.Lang.Long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("c", "(Ljava/lang/Long;)V", "GetC_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void C (global::Java.Lang.Long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/util/List;", "GetDHandler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::System.Collections.Generic.IList<global::Android.Net.Uri> D ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("d", "(Ljava/lang/Long;)V", "GetD_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		void D (global::Java.Lang.Long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/interface[@name='ChangeablePersistence']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("e", "(Ljava/lang/Long;)Ljava/lang/Integer;", "GetE_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Persistence.IChangeablePersistenceInvoker, Layer")]
		global::Java.Lang.Integer E (global::Java.Lang.Long p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/ChangeablePersistence", DoNotGenerateAcw=true)]
	internal class IChangeablePersistenceInvoker : global::Java.Lang.Object, IChangeablePersistence {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/persistence/ChangeablePersistence");
		IntPtr class_ref;

		public static IChangeablePersistence GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChangeablePersistence> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.persistence.ChangeablePersistence"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChangeablePersistenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IChangeablePersistenceInvoker); }
		}

		static Delegate cb_a_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_net_Uri_Handler ()
		{
			if (cb_a_Landroid_net_Uri_ == null)
				cb_a_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_net_Uri_);
			return cb_a_Landroid_net_Uri_;
		}

		static IntPtr n_A_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Landroid_net_Uri_;
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallObjectMethod (Handle, id_a_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ == null)
				cb_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_);
			return cb_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_;
		}

		static void n_A_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_;
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_, new JValue (p0));
		}

		static Delegate cb_a_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_a_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_messaging_Conversation_);
			return cb_a_Lcom_layer_sdk_messaging_Conversation_;
		}

		static void n_A_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_messaging_Conversation_;
		public void A (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0));
		}

		static Delegate cb_a_Lcom_layer_sdk_messaging_Message_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_messaging_Message_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_messaging_Message_ == null)
				cb_a_Lcom_layer_sdk_messaging_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_messaging_Message_);
			return cb_a_Lcom_layer_sdk_messaging_Message_;
		}

		static void n_A_Lcom_layer_sdk_messaging_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_messaging_Message_;
		public void A (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static Delegate cb_a_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Iterable_Handler ()
		{
			if (cb_a_Ljava_lang_Iterable_ == null)
				cb_a_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Iterable_);
			return cb_a_Ljava_lang_Iterable_;
		}

		static void n_A_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_Iterable_;
		public void A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_Iterable_, new JValue (p0));
		}

		static Delegate cb_a_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_List_Handler ()
		{
			if (cb_a_Ljava_util_List_ == null)
				cb_a_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_List_);
			return cb_a_Ljava_util_List_;
		}

		static IntPtr n_A_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> A (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_a_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_b_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_net_Uri_Handler ()
		{
			if (cb_b_Landroid_net_Uri_ == null)
				cb_b_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Landroid_net_Uri_);
			return cb_b_Landroid_net_Uri_;
		}

		static IntPtr n_B_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.B (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_b_Landroid_net_Uri_;
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl B (global::Android.Net.Uri p0)
		{
			if (id_b_Landroid_net_Uri_ == IntPtr.Zero)
				id_b_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallObjectMethod (Handle, id_b_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_b_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_Long_Handler ()
		{
			if (cb_b_Ljava_lang_Long_ == null)
				cb_b_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_Long_);
			return cb_b_Ljava_lang_Long_;
		}

		static IntPtr n_B_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.B (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_b_Ljava_lang_Long_;
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_b_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_c_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_lang_Long_Handler ()
		{
			if (cb_c_Ljava_lang_Long_ == null)
				cb_c_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_C_Ljava_lang_Long_);
			return cb_c_Ljava_lang_Long_;
		}

		static void n_C_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		IntPtr id_c_Ljava_lang_Long_;
		public void C (global::Java.Lang.Long p0)
		{
			if (id_c_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod (Handle, id_c_Ljava_lang_Long_, new JValue (p0));
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.D ());
		}
#pragma warning restore 0169

		IntPtr id_d;
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_d_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_Long_Handler ()
		{
			if (cb_d_Ljava_lang_Long_ == null)
				cb_d_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_Long_);
			return cb_d_Ljava_lang_Long_;
		}

		static void n_D_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_Long_;
		public void D (global::Java.Lang.Long p0)
		{
			if (id_d_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod (Handle, id_d_Ljava_lang_Long_, new JValue (p0));
		}

		static Delegate cb_e_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_Long_Handler ()
		{
			if (cb_e_Ljava_lang_Long_ == null)
				cb_e_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_Long_);
			return cb_e_Ljava_lang_Long_;
		}

		static IntPtr n_E_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.E (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_Long_;
		public global::Java.Lang.Integer E (global::Java.Lang.Long p0)
		{
			if (id_e_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Long;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (Handle, id_e_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
