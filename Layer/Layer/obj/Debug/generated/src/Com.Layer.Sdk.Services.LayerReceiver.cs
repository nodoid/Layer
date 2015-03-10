using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']"
	[global::Android.Runtime.Register ("com/layer/sdk/services/LayerReceiver", DoNotGenerateAcw=true)]
	public partial class LayerReceiver : global::Android.Content.BroadcastReceiver {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent']"
		[global::Android.Runtime.Register ("com/layer/sdk/services/LayerReceiver$ServiceEvent", DoNotGenerateAcw=true)]
		public partial class ServiceEvent : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']"
			[global::Android.Runtime.Register ("com/layer/sdk/services/LayerReceiver$ServiceEvent$Type", DoNotGenerateAcw=true)]
			public sealed partial class Type : global::Java.Lang.Enum {


				static IntPtr BOOT_COMPLETED_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']/field[@name='BOOT_COMPLETED']"
				[Register ("BOOT_COMPLETED")]
				public static global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type BootCompleted {
					get {
						if (BOOT_COMPLETED_jfieldId == IntPtr.Zero)
							BOOT_COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOT_COMPLETED", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOT_COMPLETED_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (BOOT_COMPLETED_jfieldId == IntPtr.Zero)
							BOOT_COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOT_COMPLETED", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, BOOT_COMPLETED_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr CONNECTION_AVAILABLE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']/field[@name='CONNECTION_AVAILABLE']"
				[Register ("CONNECTION_AVAILABLE")]
				public static global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type ConnectionAvailable {
					get {
						if (CONNECTION_AVAILABLE_jfieldId == IntPtr.Zero)
							CONNECTION_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_AVAILABLE", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_AVAILABLE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (CONNECTION_AVAILABLE_jfieldId == IntPtr.Zero)
							CONNECTION_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_AVAILABLE", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, CONNECTION_AVAILABLE_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr CONNECTION_UNAVAILABLE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']/field[@name='CONNECTION_UNAVAILABLE']"
				[Register ("CONNECTION_UNAVAILABLE")]
				public static global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type ConnectionUnavailable {
					get {
						if (CONNECTION_UNAVAILABLE_jfieldId == IntPtr.Zero)
							CONNECTION_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_UNAVAILABLE", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_UNAVAILABLE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (CONNECTION_UNAVAILABLE_jfieldId == IntPtr.Zero)
							CONNECTION_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_UNAVAILABLE", "Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, CONNECTION_UNAVAILABLE_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/layer/sdk/services/LayerReceiver$ServiceEvent$Type", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Type); }
				}

				internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;", "")]
				public static global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent.Type']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;", "")]
				public static global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");
					return (global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type));
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/services/LayerReceiver$ServiceEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ServiceEvent); }
			}

			protected ServiceEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Type_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent']/constructor[@name='LayerReceiver.ServiceEvent' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.services.LayerReceiver.ServiceEvent.Type']]"
			[Register (".ctor", "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;)V", "")]
			public ServiceEvent (global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ServiceEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Type_ == IntPtr.Zero)
					id_ctor_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Type_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_services_LayerReceiver_ServiceEvent_Type_, new JValue (p0));
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetType ());
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver.ServiceEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;", "GetGetTypeHandler")]
			public virtual global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type GetType ()
			{
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver.ServiceEvent.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/layer/sdk/services/LayerReceiver$ServiceEvent$Type;")), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/services/LayerReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerReceiver); }
		}

		protected LayerReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']/constructor[@name='LayerReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LayerReceiver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LayerReceiver)) {
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

		static IntPtr id_isNetworkConnected_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']/method[@name='isNetworkConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkConnected", "(Landroid/content/Context;)Z", "")]
		public static bool IsNetworkConnected (global::Android.Content.Context p0)
		{
			if (id_isNetworkConnected_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkConnected_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkConnected", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkConnected_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Services.LayerReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Services.LayerReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
		}

		static IntPtr id_register_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("register", "(Ljava/lang/Object;)V", "")]
		public static void Register (global::Java.Lang.Object p0)
		{
			if (id_register_Ljava_lang_Object_ == IntPtr.Zero)
				id_register_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/Object;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_unregister_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.services']/class[@name='LayerReceiver']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "")]
		public static void Unregister (global::Java.Lang.Object p0)
		{
			if (id_unregister_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "unregister", "(Ljava/lang/Object;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unregister_Ljava_lang_Object_, new JValue (p0));
		}

	}
}
