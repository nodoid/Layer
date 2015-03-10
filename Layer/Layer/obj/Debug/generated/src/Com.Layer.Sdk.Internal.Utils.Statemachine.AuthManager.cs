using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/AuthManager", DoNotGenerateAcw=true)]
	public partial class AuthManager : global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.AuthType']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/AuthManager$AuthType", DoNotGenerateAcw=true)]
		public sealed partial class AuthType : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.AuthType']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/AuthManager$AuthType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AuthType); }
			}

			internal AuthType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.AuthType']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;");
				return (global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']"
		[Register ("com/layer/sdk/internal/utils/statemachine/AuthManager$Callback", "", "Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.exceptions.LayerException'] and parameter[2][@type='boolean']]"
			[Register ("a", "(Lcom/layer/sdk/exceptions/LayerException;Z)V", "GetA_Lcom_layer_sdk_exceptions_LayerException_ZHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			void A (global::Com.Layer.Sdk.Exceptions.LayerException p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			void A (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.layer.sdk.internal.utils.statemachine.AuthManager.AuthType']]"
			[Register ("a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;)V", "GetA_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_Handler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			void A (string p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Z", "GetBHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			bool B ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()V", "GetCHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			void C ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='AuthManager.Callback']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()V", "GetDHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager/ICallbackInvoker, Layer")]
			void D ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/AuthManager$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/AuthManager$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.statemachine.AuthManager.Callback"));
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

			static Delegate cb_a_Lcom_layer_sdk_exceptions_LayerException_Z;
#pragma warning disable 0169
			static Delegate GetA_Lcom_layer_sdk_exceptions_LayerException_ZHandler ()
			{
				if (cb_a_Lcom_layer_sdk_exceptions_LayerException_Z == null)
					cb_a_Lcom_layer_sdk_exceptions_LayerException_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_A_Lcom_layer_sdk_exceptions_LayerException_Z);
				return cb_a_Lcom_layer_sdk_exceptions_LayerException_Z;
			}

			static void n_A_Lcom_layer_sdk_exceptions_LayerException_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Exceptions.LayerException p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_layer_sdk_exceptions_LayerException_Z;
			public void A (global::Com.Layer.Sdk.Exceptions.LayerException p0, bool p1)
			{
				if (id_a_Lcom_layer_sdk_exceptions_LayerException_Z == IntPtr.Zero)
					id_a_Lcom_layer_sdk_exceptions_LayerException_Z = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/exceptions/LayerException;Z)V");
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_layer_sdk_exceptions_LayerException_Z, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_String_Handler ()
			{
				if (cb_a_Ljava_lang_String_ == null)
					cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
				return cb_a_Ljava_lang_String_;
			}

			static void n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_String_;
			public void A (string p0)
			{
				if (id_a_Ljava_lang_String_ == IntPtr.Zero)
					id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_Handler ()
			{
				if (cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ == null)
					cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_);
				return cb_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_;
			}

			static void n_A_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType p2 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_;
			public void A (string p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType p2)
			{
				if (id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ == IntPtr.Zero)
					id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_, new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
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
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_d;
#pragma warning disable 0169
			static Delegate GetDHandler ()
			{
				if (cb_d == null)
					cb_d = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_D);
				return cb_d;
			}

			static void n_D (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.D ();
			}
#pragma warning restore 0169

			IntPtr id_d;
			public void D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
				JNIEnv.CallVoidMethod (Handle, id_d);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/AuthManager$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='d']"
			[Register ("d")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='e']"
			[Register ("e")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr f_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='f']"
			[Register ("f")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State F {
				get {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='g']"
			[Register ("g")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr h_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='h']"
			[Register ("h")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State H {
				get {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, h_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, h_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr i_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='i']"
			[Register ("i")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State I {
				get {
					if (i_jfieldId == IntPtr.Zero)
						i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, i_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (i_jfieldId == IntPtr.Zero)
						i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, i_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr j_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/field[@name='j']"
			[Register ("j")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State J {
				get {
					if (j_jfieldId == IntPtr.Zero)
						j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, j_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (j_jfieldId == IntPtr.Zero)
						j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, j_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/AuthManager$State", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager.State']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
				return (global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/AuthManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthManager); }
		}

		protected AuthManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.layer.sdk.internal.utils.statemachine.AuthManager.AuthType']]"
		[Register ("a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;)Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		protected global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State A (string p0, global::Java.Util.UUID p1, global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.AuthType p2)
		{
			if (id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/UUID;Lcom/layer/sdk/internal/utils/statemachine/AuthManager$AuthType;)Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_util_UUID_Lcom_layer_sdk_internal_utils_statemachine_AuthManager_AuthType_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/util/UUID;", "")]
		public global::Java.Util.UUID E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/util/UUID;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_g);
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Z", "")]
		public bool H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_h);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Z", "")]
		public bool I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_i);
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()V", "")]
		public void J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_j);
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		protected global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='AuthManager']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;", "")]
		protected global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/utils/statemachine/AuthManager$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.AuthManager.State> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

	}
}
