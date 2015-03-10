using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Typingindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine", DoNotGenerateAcw=true)]
	public partial class TypingIndicatorStateMachine : global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']"
		[Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$Callback", "", "Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()V", "GetBHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void B ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()V", "GetCHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void C ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()V", "GetDHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void D ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='e' and count(parameter)=0]"
			[Register ("e", "()V", "GetEHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void E ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='f' and count(parameter)=0]"
			[Register ("f", "()V", "GetFHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void F ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='g' and count(parameter)=0]"
			[Register ("g", "()V", "GetGHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void G ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/interface[@name='TypingIndicatorStateMachine.Callback']/method[@name='h' and count(parameter)=0]"
			[Register ("h", "()V", "GetHHandler:Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine/ICallbackInvoker, Layer")]
			void H ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.typingindicator.TypingIndicatorStateMachine.Callback"));
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

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			IntPtr id_a;
			public void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				JNIEnv.CallVoidMethod (Handle, id_a);
			}

			static Delegate cb_b;
#pragma warning disable 0169
			static Delegate GetBHandler ()
			{
				if (cb_b == null)
					cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
				return cb_b;
			}

			static void n_B (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.B ();
			}
#pragma warning restore 0169

			IntPtr id_b;
			public void B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
				JNIEnv.CallVoidMethod (Handle, id_b);
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
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_e;
#pragma warning disable 0169
			static Delegate GetEHandler ()
			{
				if (cb_e == null)
					cb_e = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_E);
				return cb_e;
			}

			static void n_E (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.E ();
			}
#pragma warning restore 0169

			IntPtr id_e;
			public void E ()
			{
				if (id_e == IntPtr.Zero)
					id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
				JNIEnv.CallVoidMethod (Handle, id_e);
			}

			static Delegate cb_f;
#pragma warning disable 0169
			static Delegate GetFHandler ()
			{
				if (cb_f == null)
					cb_f = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_F);
				return cb_f;
			}

			static void n_F (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.F ();
			}
#pragma warning restore 0169

			IntPtr id_f;
			public void F ()
			{
				if (id_f == IntPtr.Zero)
					id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
				JNIEnv.CallVoidMethod (Handle, id_f);
			}

			static Delegate cb_g;
#pragma warning disable 0169
			static Delegate GetGHandler ()
			{
				if (cb_g == null)
					cb_g = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_G);
				return cb_g;
			}

			static void n_G (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.G ();
			}
#pragma warning restore 0169

			IntPtr id_g;
			public void G ()
			{
				if (id_g == IntPtr.Zero)
					id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
				JNIEnv.CallVoidMethod (Handle, id_g);
			}

			static Delegate cb_h;
#pragma warning disable 0169
			static Delegate GetHHandler ()
			{
				if (cb_h == null)
					cb_h = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_H);
				return cb_h;
			}

			static void n_H (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.H ();
			}
#pragma warning restore 0169

			IntPtr id_h;
			public void H ()
			{
				if (id_h == IntPtr.Zero)
					id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
				JNIEnv.CallVoidMethod (Handle, id_h);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine.State']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine.State']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine.State']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine.State']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
				return (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypingIndicatorStateMachine); }
		}

		protected TypingIndicatorStateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']/constructor[@name='TypingIndicatorStateMachine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TypingIndicatorStateMachine () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TypingIndicatorStateMachine)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("a", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State A (global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p0)
		{
			if (id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
			global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.typingindicator']/class[@name='TypingIndicatorStateMachine']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/internal/utils/typingindicator/TypingIndicatorStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Typingindicator.TypingIndicatorStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

	}
}
