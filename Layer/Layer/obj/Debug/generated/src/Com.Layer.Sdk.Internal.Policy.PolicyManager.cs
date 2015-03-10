using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/policy/PolicyManager", DoNotGenerateAcw=true)]
	public partial class PolicyManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.policy']/interface[@name='PolicyManager.PolicyManagerChangeListener']"
		[Register ("com/layer/sdk/internal/policy/PolicyManager$PolicyManagerChangeListener", "", "Com.Layer.Sdk.Internal.Policy.PolicyManager/IPolicyManagerChangeListenerInvoker")]
		public partial interface IPolicyManagerChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/interface[@name='PolicyManager.PolicyManagerChangeListener']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;Ljava/util/List;)V", "GetA_Ljava_util_List_Ljava_util_List_Handler:Com.Layer.Sdk.Internal.Policy.PolicyManager/IPolicyManagerChangeListenerInvoker, Layer")]
			void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/interface[@name='PolicyManager.PolicyManagerChangeListener']/method[@name='e' and count(parameter)=0]"
			[Register ("e", "()V", "GetEHandler:Com.Layer.Sdk.Internal.Policy.PolicyManager/IPolicyManagerChangeListenerInvoker, Layer")]
			void E ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/policy/PolicyManager$PolicyManagerChangeListener", DoNotGenerateAcw=true)]
		internal class IPolicyManagerChangeListenerInvoker : global::Java.Lang.Object, IPolicyManagerChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/policy/PolicyManager$PolicyManagerChangeListener");
			IntPtr class_ref;

			public static IPolicyManagerChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPolicyManagerChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.policy.PolicyManager.PolicyManagerChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPolicyManagerChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPolicyManagerChangeListenerInvoker); }
			}

			static Delegate cb_a_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_util_List_Ljava_util_List_Handler ()
			{
				if (cb_a_Ljava_util_List_Ljava_util_List_ == null)
					cb_a_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_List_Ljava_util_List_);
				return cb_a_Ljava_util_List_Ljava_util_List_;
			}

			static void n_A_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Policy.PolicyManager.IPolicyManagerChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Policy.PolicyManager.IPolicyManagerChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Com.Layer.Sdk.Policy.Policy> p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Com.Layer.Sdk.Policy.Policy> p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_a_Ljava_util_List_Ljava_util_List_;
			public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1)
			{
				if (id_a_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.ToLocalJniHandle (p1);
				JNIEnv.CallVoidMethod (Handle, id_a_Ljava_util_List_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
				global::Com.Layer.Sdk.Internal.Policy.PolicyManager.IPolicyManagerChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Policy.PolicyManager.IPolicyManagerChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		}

		public partial class AEventArgs : global::System.EventArgs {

			public AEventArgs (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p0;
			public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> P0 {
				get { return p0; }
			}

			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1;
			public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/layer/sdk/internal/policy/PolicyManager_PolicyManagerChangeListenerImplementor")]
		internal sealed class IPolicyManagerChangeListenerImplementor : global::Java.Lang.Object, IPolicyManagerChangeListener {

			object sender;

			public IPolicyManagerChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/layer/sdk/internal/policy/PolicyManager_PolicyManagerChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AEventArgs> AHandler;
#pragma warning restore 0649

			public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> p1)
			{
				var __h = AHandler;
				if (__h != null)
					__h (sender, new AEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler EHandler;
#pragma warning restore 0649

			public void E ()
			{
				var __h = EHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IPolicyManagerChangeListenerImplementor value)
			{
				return value.AHandler == null && value.EHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/policy/PolicyManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolicyManager); }
		}

		protected PolicyManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_LayerSession_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/constructor[@name='PolicyManager' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.LayerSession']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/LayerSession;)V", "")]
		public PolicyManager (global::Com.Layer.Sdk.Internal.LayerSession p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolicyManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/LayerSession;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/LayerSession;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_LayerSession_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_LayerSession_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/LayerSession;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_LayerSession_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_LayerSession_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/LinkedHashSet;", "")]
		public global::Java.Util.LinkedHashSet A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/LinkedHashSet;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashSet> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_policy_PolicyManager_PolicyManagerChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.policy.PolicyManager.PolicyManagerChangeListener']]"
		[Register ("a", "(Lcom/layer/sdk/internal/policy/PolicyManager$PolicyManagerChangeListener;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Policy.PolicyManager.IPolicyManagerChangeListener p0)
		{
			if (id_a_Lcom_layer_sdk_internal_policy_PolicyManager_PolicyManagerChangeListener_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_policy_PolicyManager_PolicyManagerChangeListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/policy/PolicyManager$PolicyManagerChangeListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_policy_PolicyManager_PolicyManagerChangeListener_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_policy_Policy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("a", "(Lcom/layer/sdk/policy/Policy;)Ljava/lang/Boolean;", "")]
		public global::Java.Lang.Boolean A (global::Com.Layer.Sdk.Policy.Policy p0)
		{
			if (id_a_Lcom_layer_sdk_policy_Policy_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_policy_Policy_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/policy/Policy;)Ljava/lang/Boolean;");
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_policy_Policy_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_LinkedHashSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.LinkedHashSet']]"
		[Register ("a", "(Ljava/util/LinkedHashSet;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> A (global::Java.Util.LinkedHashSet p0)
		{
			if (id_a_Ljava_util_LinkedHashSet_ == IntPtr.Zero)
				id_a_Ljava_util_LinkedHashSet_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/LinkedHashSet;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_LinkedHashSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_b_Lcom_layer_sdk_policy_Policy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("b", "(Lcom/layer/sdk/policy/Policy;)Ljava/lang/Boolean;", "")]
		public global::Java.Lang.Boolean B (global::Com.Layer.Sdk.Policy.Policy p0)
		{
			if (id_b_Lcom_layer_sdk_policy_Policy_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_policy_Policy_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/policy/Policy;)Ljava/lang/Boolean;");
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_b_Lcom_layer_sdk_policy_Policy_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyManager']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_d);
		}

	}
}
