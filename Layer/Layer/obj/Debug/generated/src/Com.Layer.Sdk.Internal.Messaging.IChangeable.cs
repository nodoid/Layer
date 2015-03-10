using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']"
	[Register ("com/layer/sdk/internal/messaging/Changeable", "", "Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker")]
	public partial interface IChangeable : global::Com.Layer.Sdk.Messaging.ILayerObject {

		global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")] get;
		}

		bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/Queue;", "GetAHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		global::Java.Util.IQueue A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/Change;)V", "GetA_Lcom_layer_sdk_internal_messaging_Change_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Messaging.Change p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableContext']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V", "GetA_Lcom_layer_sdk_internal_messaging_ChangeableContext_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		void A (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "GetA_Ljava_util_Date_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		void A (global::Java.Util.Date p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "GetBHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		bool B ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.Change']]"
		[Register ("b", "(Lcom/layer/sdk/internal/messaging/Change;)V", "GetB_Lcom_layer_sdk_internal_messaging_Change_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		void B (global::Com.Layer.Sdk.Internal.Messaging.Change p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("b", "(Ljava/util/Date;)V", "GetB_Ljava_util_Date_Handler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		void B (global::Java.Util.Date p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='Changeable']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Date;", "GetCHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableInvoker, Layer")]
		global::Java.Util.Date C ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/Changeable", DoNotGenerateAcw=true)]
	internal class IChangeableInvoker : global::Java.Lang.Object, IChangeable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/Changeable");
		IntPtr class_ref;

		public static IChangeable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChangeable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.Changeable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChangeableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IChangeableInvoker); }
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
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public global::Android.Net.Uri Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isDeleted;
#pragma warning disable 0169
		static Delegate GetIsDeletedHandler ()
		{
			if (cb_isDeleted == null)
				cb_isDeleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeleted);
			return cb_isDeleted;
		}

		static bool n_IsDeleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		IntPtr id_isDeleted;
		public bool IsDeleted {
			get {
				if (id_isDeleted == IntPtr.Zero)
					id_isDeleted = JNIEnv.GetMethodID (class_ref, "isDeleted", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDeleted);
			}
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
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		IntPtr id_a;
		public global::Java.Util.IQueue A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/Queue;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_messaging_Change_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_messaging_Change_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_messaging_Change_ == null)
				cb_a_Lcom_layer_sdk_internal_messaging_Change_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_Change_);
			return cb_a_Lcom_layer_sdk_internal_messaging_Change_;
		}

		static void n_A_Lcom_layer_sdk_internal_messaging_Change_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Messaging.Change p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Change> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_messaging_Change_;
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_messaging_ChangeableContext_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == null)
				cb_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_messaging_ChangeableContext_);
			return cb_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		}

		static void n_A_Lcom_layer_sdk_internal_messaging_ChangeableContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0 = (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_;
		public void A (global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableContext;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableContext_, new JValue (p0));
		}

		static Delegate cb_a_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Date_Handler ()
		{
			if (cb_a_Ljava_util_Date_ == null)
				cb_a_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Date_);
			return cb_a_Ljava_util_Date_;
		}

		static void n_A_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_util_Date_;
		public void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_util_Date_, new JValue (p0));
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_B);
			return cb_b;
		}

		static bool n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		IntPtr id_b;
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_b);
		}

		static Delegate cb_b_Lcom_layer_sdk_internal_messaging_Change_;
#pragma warning disable 0169
		static Delegate GetB_Lcom_layer_sdk_internal_messaging_Change_Handler ()
		{
			if (cb_b_Lcom_layer_sdk_internal_messaging_Change_ == null)
				cb_b_Lcom_layer_sdk_internal_messaging_Change_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Lcom_layer_sdk_internal_messaging_Change_);
			return cb_b_Lcom_layer_sdk_internal_messaging_Change_;
		}

		static void n_B_Lcom_layer_sdk_internal_messaging_Change_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Messaging.Change p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Change> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		IntPtr id_b_Lcom_layer_sdk_internal_messaging_Change_;
		public void B (global::Com.Layer.Sdk.Internal.Messaging.Change p0)
		{
			if (id_b_Lcom_layer_sdk_internal_messaging_Change_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_internal_messaging_Change_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/internal/messaging/Change;)V");
			JNIEnv.CallVoidMethod (Handle, id_b_Lcom_layer_sdk_internal_messaging_Change_, new JValue (p0));
		}

		static Delegate cb_b_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_util_Date_Handler ()
		{
			if (cb_b_Ljava_util_Date_ == null)
				cb_b_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Ljava_util_Date_);
			return cb_b_Ljava_util_Date_;
		}

		static void n_B_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		IntPtr id_b_Ljava_util_Date_;
		public void B (global::Java.Util.Date p0)
		{
			if (id_b_Ljava_util_Date_ == IntPtr.Zero)
				id_b_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/Date;)V");
			JNIEnv.CallVoidMethod (Handle, id_b_Ljava_util_Date_, new JValue (p0));
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		IntPtr id_c;
		public global::Java.Util.Date C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

	}

}
