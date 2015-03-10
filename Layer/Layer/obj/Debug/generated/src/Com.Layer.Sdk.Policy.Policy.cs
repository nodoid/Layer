using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']"
	[global::Android.Runtime.Register ("com/layer/sdk/policy/Policy", DoNotGenerateAcw=true)]
	public abstract partial class Policy : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/field[@name='a']"
		[Register ("a")]
		protected global::Com.Layer.Sdk.Policy.Policy.PolicyType A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lcom/layer/sdk/policy/Policy$PolicyType;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.PolicyType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lcom/layer/sdk/policy/Policy$PolicyType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/field[@name='b']"
		[Register ("b")]
		protected string B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.Builder']"
		[global::Android.Runtime.Register ("com/layer/sdk/policy/Policy$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/policy/Policy$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.Builder']/constructor[@name='Policy.Builder' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy.PolicyType']]"
			[Register (".ctor", "(Lcom/layer/sdk/policy/Policy$PolicyType;)V", "")]
			public Builder (global::Com.Layer.Sdk.Policy.Policy.PolicyType p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/policy/Policy$PolicyType;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/policy/Policy$PolicyType;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_ == IntPtr.Zero)
					id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/policy/Policy$PolicyType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_, new JValue (p0));
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Policy.Policy.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/layer/sdk/policy/Policy;", "GetBuildHandler")]
			public virtual global::Com.Layer.Sdk.Policy.Policy Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/layer/sdk/policy/Policy;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/layer/sdk/policy/Policy;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_sentByUserId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSentByUserId_Ljava_lang_String_Handler ()
			{
				if (cb_sentByUserId_Ljava_lang_String_ == null)
					cb_sentByUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SentByUserId_Ljava_lang_String_);
				return cb_sentByUserId_Ljava_lang_String_;
			}

			static IntPtr n_SentByUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Policy.Policy.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SentByUserId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_sentByUserId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.Builder']/method[@name='sentByUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("sentByUserId", "(Ljava/lang/String;)Lcom/layer/sdk/policy/Policy$Builder;", "GetSentByUserId_Ljava_lang_String_Handler")]
			public virtual global::Com.Layer.Sdk.Policy.Policy.Builder SentByUserId (string p0)
			{
				if (id_sentByUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_sentByUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sentByUserId", "(Ljava/lang/String;)Lcom/layer/sdk/policy/Policy$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Layer.Sdk.Policy.Policy.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.Builder> (JNIEnv.CallObjectMethod  (Handle, id_sentByUserId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sentByUserId", "(Ljava/lang/String;)Lcom/layer/sdk/policy/Policy$Builder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.PolicyType']"
		[global::Android.Runtime.Register ("com/layer/sdk/policy/Policy$PolicyType", DoNotGenerateAcw=true)]
		public sealed partial class PolicyType : global::Java.Lang.Enum {


			static IntPtr BLOCK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.PolicyType']/field[@name='BLOCK']"
			[Register ("BLOCK")]
			public static global::Com.Layer.Sdk.Policy.Policy.PolicyType Block {
				get {
					if (BLOCK_jfieldId == IntPtr.Zero)
						BLOCK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK", "Lcom/layer/sdk/policy/Policy$PolicyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLOCK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.PolicyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BLOCK_jfieldId == IntPtr.Zero)
						BLOCK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK", "Lcom/layer/sdk/policy/Policy$PolicyType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BLOCK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/policy/Policy$PolicyType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PolicyType); }
			}

			internal PolicyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.PolicyType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/policy/Policy$PolicyType;", "")]
			public static global::Com.Layer.Sdk.Policy.Policy.PolicyType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/policy/Policy$PolicyType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Policy.Policy.PolicyType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.PolicyType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy.PolicyType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/policy/Policy$PolicyType;", "")]
			public static global::Com.Layer.Sdk.Policy.Policy.PolicyType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/policy/Policy$PolicyType;");
				return (global::Com.Layer.Sdk.Policy.Policy.PolicyType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Policy.Policy.PolicyType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/policy/Policy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Policy); }
		}

		protected Policy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_policy_Policy_PolicyType_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/constructor[@name='Policy' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.policy.Policy.PolicyType'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/layer/sdk/policy/Policy$PolicyType;Ljava/lang/String;)V", "")]
		protected Policy (global::Com.Layer.Sdk.Policy.Policy.PolicyType p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Policy)) {
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

		static Delegate cb_getSentByUserID;
#pragma warning disable 0169
		static Delegate GetGetSentByUserIDHandler ()
		{
			if (cb_getSentByUserID == null)
				cb_getSentByUserID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentByUserID);
			return cb_getSentByUserID;
		}

		static IntPtr n_GetSentByUserID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Policy.Policy __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentByUserID);
		}
#pragma warning restore 0169

		static IntPtr id_getSentByUserID;
		public virtual string SentByUserID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/method[@name='getSentByUserID' and count(parameter)=0]"
			[Register ("getSentByUserID", "()Ljava/lang/String;", "GetGetSentByUserIDHandler")]
			get {
				if (id_getSentByUserID == IntPtr.Zero)
					id_getSentByUserID = JNIEnv.GetMethodID (class_ref, "getSentByUserID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSentByUserID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentByUserID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_builder_Lcom_layer_sdk_policy_Policy_PolicyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy.PolicyType']]"
		[Register ("builder", "(Lcom/layer/sdk/policy/Policy$PolicyType;)Lcom/layer/sdk/policy/Policy$Builder;", "")]
		public static global::Com.Layer.Sdk.Policy.Policy.Builder InvokeBuilder (global::Com.Layer.Sdk.Policy.Policy.PolicyType p0)
		{
			if (id_builder_Lcom_layer_sdk_policy_Policy_PolicyType_ == IntPtr.Zero)
				id_builder_Lcom_layer_sdk_policy_Policy_PolicyType_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "(Lcom/layer/sdk/policy/Policy$PolicyType;)Lcom/layer/sdk/policy/Policy$Builder;");
			global::Com.Layer.Sdk.Policy.Policy.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_Lcom_layer_sdk_policy_Policy_PolicyType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getPolicyType;
#pragma warning disable 0169
		static Delegate GetGetPolicyTypeHandler ()
		{
			if (cb_getPolicyType == null)
				cb_getPolicyType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolicyType);
			return cb_getPolicyType;
		}

		static IntPtr n_GetPolicyType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Policy.Policy __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPolicyType ());
		}
#pragma warning restore 0169

		static IntPtr id_getPolicyType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.policy']/class[@name='Policy']/method[@name='getPolicyType' and count(parameter)=0]"
		[Register ("getPolicyType", "()Lcom/layer/sdk/policy/Policy$PolicyType;", "GetGetPolicyTypeHandler")]
		public virtual global::Com.Layer.Sdk.Policy.Policy.PolicyType GetPolicyType ()
		{
			if (id_getPolicyType == IntPtr.Zero)
				id_getPolicyType = JNIEnv.GetMethodID (class_ref, "getPolicyType", "()Lcom/layer/sdk/policy/Policy$PolicyType;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.PolicyType> (JNIEnv.CallObjectMethod  (Handle, id_getPolicyType), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy.PolicyType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPolicyType", "()Lcom/layer/sdk/policy/Policy$PolicyType;")), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/layer/sdk/policy/Policy", DoNotGenerateAcw=true)]
	internal partial class PolicyInvoker : Policy {

		public PolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolicyInvoker); }
		}

	}

}
