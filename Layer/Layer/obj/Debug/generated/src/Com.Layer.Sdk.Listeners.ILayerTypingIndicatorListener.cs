using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']"
	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator", DoNotGenerateAcw=true)]
	public sealed partial class LayerTypingIndicatorListenerTypingIndicator : global::Java.Lang.Enum {


		static IntPtr FINISHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/field[@name='FINISHED']"
		[Register ("FINISHED")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator Finished {
			get {
				if (FINISHED_jfieldId == IntPtr.Zero)
					FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FINISHED_jfieldId == IntPtr.Zero)
					FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FINISHED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PAUSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator Paused {
			get {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PAUSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/field[@name='STARTED']"
		[Register ("STARTED")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator Started {
			get {
				if (STARTED_jfieldId == IntPtr.Zero)
					STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STARTED_jfieldId == IntPtr.Zero)
					STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STARTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerTypingIndicatorListenerTypingIndicator); }
		}

		internal LayerTypingIndicatorListenerTypingIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_fromValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/method[@name='fromValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromValue", "(I)Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;", "")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator FromValue (int p0)
		{
			if (id_fromValue_I == IntPtr.Zero)
				id_fromValue_I = JNIEnv.GetStaticMethodID (class_ref, "fromValue", "(I)Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromValue_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;", "")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/class[@name='LayerTypingIndicatorListener.TypingIndicator']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;", "")]
		public static global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;");
			return (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerTypingIndicatorListener']"
	[Register ("com/layer/sdk/listeners/LayerTypingIndicatorListener", "", "Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListenerInvoker")]
	public partial interface ILayerTypingIndicatorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.listeners']/interface[@name='LayerTypingIndicatorListener']/method[@name='onTypingIndicator' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='com.layer.sdk.messaging.Conversation'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("onTypingIndicator", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V", "GetOnTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler:Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListenerInvoker, Layer")]
		void OnTypingIndicator (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Messaging.Conversation p1, string p2, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/listeners/LayerTypingIndicatorListener", DoNotGenerateAcw=true)]
	internal class ILayerTypingIndicatorListenerInvoker : global::Java.Lang.Object, ILayerTypingIndicatorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/listeners/LayerTypingIndicatorListener");
		IntPtr class_ref;

		public static ILayerTypingIndicatorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILayerTypingIndicatorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.listeners.LayerTypingIndicatorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILayerTypingIndicatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILayerTypingIndicatorListenerInvoker); }
		}

		static Delegate cb_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
		static Delegate GetOnTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
		{
			if (cb_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
				cb_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
			return cb_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		}

		static void n_OnTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnTypingIndicator (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		public void OnTypingIndicator (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Messaging.Conversation p1, string p2, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3)
		{
			if (id_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "onTypingIndicator", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod (Handle, id_onTypingIndicator_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class LayerTypingIndicatorEventArgs : global::System.EventArgs {

		public LayerTypingIndicatorEventArgs (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Messaging.Conversation p1, string p2, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Layer.Sdk.LayerClient p0;
		public global::Com.Layer.Sdk.LayerClient P0 {
			get { return p0; }
		}

		global::Com.Layer.Sdk.Messaging.Conversation p1;
		public global::Com.Layer.Sdk.Messaging.Conversation P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3;
		public global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/layer/sdk/listeners/LayerTypingIndicatorListenerImplementor")]
	internal sealed class ILayerTypingIndicatorListenerImplementor : global::Java.Lang.Object, ILayerTypingIndicatorListener {

		object sender;

		public ILayerTypingIndicatorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/listeners/LayerTypingIndicatorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LayerTypingIndicatorEventArgs> Handler;
#pragma warning restore 0649

		public void OnTypingIndicator (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Messaging.Conversation p1, string p2, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LayerTypingIndicatorEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (ILayerTypingIndicatorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
