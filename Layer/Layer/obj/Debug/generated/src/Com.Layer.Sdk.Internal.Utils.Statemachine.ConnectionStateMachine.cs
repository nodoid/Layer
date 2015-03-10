using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine", DoNotGenerateAcw=true)]
	public partial class ConnectionStateMachine : global::Com.Layer.Sdk.Internal.Utils.Statemachine.StateMachine {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']"
		[Register ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$Callback", "", "Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']/method[@name='g' and count(parameter)=0]"
			[Register ("g", "()V", "GetGHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker, Layer")]
			void G ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']/method[@name='h' and count(parameter)=0]"
			[Register ("h", "()V", "GetHHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker, Layer")]
			void H ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']/method[@name='i' and count(parameter)=0]"
			[Register ("i", "()V", "GetIHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker, Layer")]
			void I ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']/method[@name='j' and count(parameter)=0]"
			[Register ("j", "()V", "GetJHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker, Layer")]
			void J ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/interface[@name='ConnectionStateMachine.Callback']/method[@name='k' and count(parameter)=0]"
			[Register ("k", "()V", "GetKHandler:Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine/ICallbackInvoker, Layer")]
			void K ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.utils.statemachine.ConnectionStateMachine.Callback"));
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
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_i;
#pragma warning disable 0169
			static Delegate GetIHandler ()
			{
				if (cb_i == null)
					cb_i = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_I);
				return cb_i;
			}

			static void n_I (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.I ();
			}
#pragma warning restore 0169

			IntPtr id_i;
			public void I ()
			{
				if (id_i == IntPtr.Zero)
					id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
				JNIEnv.CallVoidMethod (Handle, id_i);
			}

			static Delegate cb_j;
#pragma warning disable 0169
			static Delegate GetJHandler ()
			{
				if (cb_j == null)
					cb_j = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_J);
				return cb_j;
			}

			static void n_J (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.J ();
			}
#pragma warning restore 0169

			IntPtr id_j;
			public void J ()
			{
				if (id_j == IntPtr.Zero)
					id_j = JNIEnv.GetMethodID (class_ref, "j", "()V");
				JNIEnv.CallVoidMethod (Handle, id_j);
			}

			static Delegate cb_k;
#pragma warning disable 0169
			static Delegate GetKHandler ()
			{
				if (cb_k == null)
					cb_k = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_K);
				return cb_k;
			}

			static void n_K (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.K ();
			}
#pragma warning restore 0169

			IntPtr id_k;
			public void K ()
			{
				if (id_k == IntPtr.Zero)
					id_k = JNIEnv.GetMethodID (class_ref, "k", "()V");
				JNIEnv.CallVoidMethod (Handle, id_k);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine.State']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine.State']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine.State']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine.State']/field[@name='d']"
			[Register ("d")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine.State']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
				return (global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/statemachine/ConnectionStateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStateMachine); }
		}

		protected ConnectionStateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/constructor[@name='ConnectionStateMachine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public ConnectionStateMachine (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConnectionStateMachine)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", new JValue (p0));
				return;
			}

			if (id_ctor_Z == IntPtr.Zero)
				id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils.statemachine']/class[@name='ConnectionStateMachine']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;", "")]
		public global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/layer/sdk/internal/utils/statemachine/ConnectionStateMachine$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Statemachine.ConnectionStateMachine.State> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
		}

	}
}
