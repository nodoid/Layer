using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/AppStateMonitor", DoNotGenerateAcw=true)]
	public partial class AppStateMonitor : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/AppStateMonitor$ActivityState", DoNotGenerateAcw=true)]
		public sealed partial class ActivityState : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='d']"
			[Register ("d")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='e']"
			[Register ("e")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr f_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='f']"
			[Register ("f")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState F {
				get {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/field[@name='g']"
			[Register ("g")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/AppStateMonitor$ActivityState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityState); }
			}

			internal ActivityState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.ActivityState']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/AppStateMonitor$ActivityState;");
				return (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ActivityState));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='AppStateMonitor.Callback']"
		[Register ("com/layer/sdk/internal/utils/AppStateMonitor$Callback", "", "Com.Layer.Sdk.Internal.Utils.AppStateMonitor/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/interface[@name='AppStateMonitor.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.utils.AppStateMonitor.State']]"
			[Register ("a", "(Lcom/layer/sdk/internal/utils/AppStateMonitor$State;)V", "GetA_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_Handler:Com.Layer.Sdk.Internal.Utils.AppStateMonitor/ICallbackInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/AppStateMonitor$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/AppStateMonitor$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.AppStateMonitor.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_Handler ()
			{
				if (cb_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_ == null)
					cb_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_);
				return cb_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_;
			}

			static void n_A_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_;
			public void A (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State p0)
			{
				if (id_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/utils/AppStateMonitor$State;)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_internal_utils_AppStateMonitor_State_, new JValue (p0));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.State']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/AppStateMonitor$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.State']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/AppStateMonitor$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/AppStateMonitor$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/AppStateMonitor$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor.State']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/AppStateMonitor$State;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/AppStateMonitor$State;");
				return (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/AppStateMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppStateMonitor); }
		}

		protected AppStateMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Application_Lcom_layer_sdk_internal_utils_AppStateMonitor_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/constructor[@name='AppStateMonitor' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.layer.sdk.internal.utils.AppStateMonitor.Callback']]"
		[Register (".ctor", "(Landroid/app/Application;Lcom/layer/sdk/internal/utils/AppStateMonitor$Callback;)V", "")]
		public AppStateMonitor (global::Android.App.Application p0, global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.ICallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AppStateMonitor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;Lcom/layer/sdk/internal/utils/AppStateMonitor$Callback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Application;Lcom/layer/sdk/internal/utils/AppStateMonitor$Callback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_app_Application_Lcom_layer_sdk_internal_utils_AppStateMonitor_Callback_ == IntPtr.Zero)
				id_ctor_Landroid_app_Application_Lcom_layer_sdk_internal_utils_AppStateMonitor_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Lcom/layer/sdk/internal/utils/AppStateMonitor$Callback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Lcom_layer_sdk_internal_utils_AppStateMonitor_Callback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Application_Lcom_layer_sdk_internal_utils_AppStateMonitor_Callback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/internal/utils/AppStateMonitor$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/internal/utils/AppStateMonitor$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor.State> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual void OnActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityDestroyed_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual void OnActivityPaused (global::Android.App.Activity p0)
		{
			if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityPaused_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityPaused", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual void OnActivityResumed (global::Android.App.Activity p0)
		{
			if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityResumed_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResumed", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual void OnActivityStarted (global::Android.App.Activity p0)
		{
			if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityStarted_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.AppStateMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='AppStateMonitor']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual void OnActivityStopped (global::Android.App.Activity p0)
		{
			if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityStopped_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

	}
}
