using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate']"
	[global::Android.Runtime.Register ("com/layer/sdk/query/CompoundPredicate", DoNotGenerateAcw=true)]
	public partial class CompoundPredicate : global::Com.Layer.Sdk.Query.Predicate {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/CompoundPredicate$Type", DoNotGenerateAcw=true)]
		public new sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr AND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']/field[@name='AND']"
			[Register ("AND")]
			public static global::Com.Layer.Sdk.Query.CompoundPredicate.Type And {
				get {
					if (AND_jfieldId == IntPtr.Zero)
						AND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AND", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AND_jfieldId == IntPtr.Zero)
						AND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AND", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']/field[@name='NOT']"
			[Register ("NOT")]
			public static global::Com.Layer.Sdk.Query.CompoundPredicate.Type Not {
				get {
					if (NOT_jfieldId == IntPtr.Zero)
						NOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_jfieldId == IntPtr.Zero)
						NOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']/field[@name='OR']"
			[Register ("OR")]
			public static global::Com.Layer.Sdk.Query.CompoundPredicate.Type Or {
				get {
					if (OR_jfieldId == IntPtr.Zero)
						OR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OR", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OR_jfieldId == IntPtr.Zero)
						OR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OR", "Lcom/layer/sdk/query/CompoundPredicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/CompoundPredicate$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/CompoundPredicate$Type;", "")]
			public static global::Com.Layer.Sdk.Query.CompoundPredicate.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/CompoundPredicate$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Query.CompoundPredicate.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/query/CompoundPredicate$Type;", "")]
			public static global::Com.Layer.Sdk.Query.CompoundPredicate.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/query/CompoundPredicate$Type;");
				return (global::Com.Layer.Sdk.Query.CompoundPredicate.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Query.CompoundPredicate.Type));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/query/CompoundPredicate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompoundPredicate); }
		}

		protected CompoundPredicate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate']/constructor[@name='CompoundPredicate' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.CompoundPredicate.Type'] and parameter[2][@type='java.util.List']]"
		[Register (".ctor", "(Lcom/layer/sdk/query/CompoundPredicate$Type;Ljava/util/List;)V", "")]
		public CompoundPredicate (global::Com.Layer.Sdk.Query.CompoundPredicate.Type p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.Predicate> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.Predicate>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (CompoundPredicate)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/query/CompoundPredicate$Type;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/query/CompoundPredicate$Type;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/query/CompoundPredicate$Type;Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_arrayLcom_layer_sdk_query_Predicate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate']/constructor[@name='CompoundPredicate' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.CompoundPredicate.Type'] and parameter[2][@type='com.layer.sdk.query.Predicate...']]"
		[Register (".ctor", "(Lcom/layer/sdk/query/CompoundPredicate$Type;[Lcom/layer/sdk/query/Predicate;)V", "")]
		public CompoundPredicate (global::Com.Layer.Sdk.Query.CompoundPredicate.Type p0, params global:: Com.Layer.Sdk.Query.Predicate[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (CompoundPredicate)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/query/CompoundPredicate$Type;[Lcom/layer/sdk/query/Predicate;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/query/CompoundPredicate$Type;[Lcom/layer/sdk/query/Predicate;)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_arrayLcom_layer_sdk_query_Predicate_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_arrayLcom_layer_sdk_query_Predicate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/query/CompoundPredicate$Type;[Lcom/layer/sdk/query/Predicate;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_arrayLcom_layer_sdk_query_Predicate_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_query_CompoundPredicate_Type_arrayLcom_layer_sdk_query_Predicate_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getSubPredicates;
#pragma warning disable 0169
		static Delegate GetGetSubPredicatesHandler ()
		{
			if (cb_getSubPredicates == null)
				cb_getSubPredicates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubPredicates);
			return cb_getSubPredicates;
		}

		static IntPtr n_GetSubPredicates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.CompoundPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.Predicate>.ToLocalJniHandle (__this.SubPredicates);
		}
#pragma warning restore 0169

		static IntPtr id_getSubPredicates;
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.Predicate> SubPredicates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate']/method[@name='getSubPredicates' and count(parameter)=0]"
			[Register ("getSubPredicates", "()Ljava/util/List;", "GetGetSubPredicatesHandler")]
			get {
				if (id_getSubPredicates == IntPtr.Zero)
					id_getSubPredicates = JNIEnv.GetMethodID (class_ref, "getSubPredicates", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.Predicate>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSubPredicates), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.Predicate>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubPredicates", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Layer.Sdk.Query.CompoundPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='CompoundPredicate']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/layer/sdk/query/CompoundPredicate$Type;", "GetGetTypeHandler")]
		public virtual global::Com.Layer.Sdk.Query.CompoundPredicate.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/layer/sdk/query/CompoundPredicate$Type;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.CompoundPredicate.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/layer/sdk/query/CompoundPredicate$Type;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
