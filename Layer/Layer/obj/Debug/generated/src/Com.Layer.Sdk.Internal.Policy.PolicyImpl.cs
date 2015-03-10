using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyImpl']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/policy/PolicyImpl", DoNotGenerateAcw=true)]
	public partial class PolicyImpl : global::Com.Layer.Sdk.Policy.Policy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/policy/PolicyImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolicyImpl); }
		}

		protected PolicyImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.policy']/class[@name='PolicyImpl']/constructor[@name='PolicyImpl' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.policy.Policy.PolicyType'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/layer/sdk/policy/Policy$PolicyType;Ljava/lang/String;)V", "")]
		public PolicyImpl (global::Com.Layer.Sdk.Policy.Policy.PolicyType p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (PolicyImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/policy/Policy$PolicyType;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/policy/Policy$PolicyType;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/policy/Policy$PolicyType;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
