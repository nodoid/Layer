using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']"
	[global::Android.Runtime.Register ("com/layer/sdk/query/Query", DoNotGenerateAcw=true)]
	public partial class Query : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/Query$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/Query$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Layer.Sdk.Query.Query.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/layer/sdk/query/Query;", "GetBuildHandler")]
			public virtual global::Com.Layer.Sdk.Query.Query Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/layer/sdk/query/Query;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/layer/sdk/query/Query;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_limit_J;
#pragma warning disable 0169
			static Delegate GetLimit_JHandler ()
			{
				if (cb_limit_J == null)
					cb_limit_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Limit_J);
				return cb_limit_J;
			}

			static IntPtr n_Limit_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Layer.Sdk.Query.Query.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Limit (p0));
			}
#pragma warning restore 0169

			static IntPtr id_limit_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("limit", "(J)Lcom/layer/sdk/query/Query$Builder;", "GetLimit_JHandler")]
			public virtual global::Com.Layer.Sdk.Query.Query.Builder Limit (long p0)
			{
				if (id_limit_J == IntPtr.Zero)
					id_limit_J = JNIEnv.GetMethodID (class_ref, "limit", "(J)Lcom/layer/sdk/query/Query$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallObjectMethod  (Handle, id_limit_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "limit", "(J)Lcom/layer/sdk/query/Query$Builder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_offset_J;
#pragma warning disable 0169
			static Delegate GetOffset_JHandler ()
			{
				if (cb_offset_J == null)
					cb_offset_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Offset_J);
				return cb_offset_J;
			}

			static IntPtr n_Offset_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Layer.Sdk.Query.Query.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Offset (p0));
			}
#pragma warning restore 0169

			static IntPtr id_offset_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']/method[@name='offset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("offset", "(J)Lcom/layer/sdk/query/Query$Builder;", "GetOffset_JHandler")]
			public virtual global::Com.Layer.Sdk.Query.Query.Builder Offset (long p0)
			{
				if (id_offset_J == IntPtr.Zero)
					id_offset_J = JNIEnv.GetMethodID (class_ref, "offset", "(J)Lcom/layer/sdk/query/Query$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallObjectMethod  (Handle, id_offset_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offset", "(J)Lcom/layer/sdk/query/Query$Builder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_predicate_Lcom_layer_sdk_query_Predicate_;
#pragma warning disable 0169
			static Delegate GetPredicate_Lcom_layer_sdk_query_Predicate_Handler ()
			{
				if (cb_predicate_Lcom_layer_sdk_query_Predicate_ == null)
					cb_predicate_Lcom_layer_sdk_query_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Predicate_Lcom_layer_sdk_query_Predicate_);
				return cb_predicate_Lcom_layer_sdk_query_Predicate_;
			}

			static IntPtr n_Predicate_Lcom_layer_sdk_query_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Query.Query.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.Predicate p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Predicate (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_predicate_Lcom_layer_sdk_query_Predicate_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']/method[@name='predicate' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Predicate']]"
			[Register ("predicate", "(Lcom/layer/sdk/query/Predicate;)Lcom/layer/sdk/query/Query$Builder;", "GetPredicate_Lcom_layer_sdk_query_Predicate_Handler")]
			public virtual global::Com.Layer.Sdk.Query.Query.Builder Predicate (global::Com.Layer.Sdk.Query.Predicate p0)
			{
				if (id_predicate_Lcom_layer_sdk_query_Predicate_ == IntPtr.Zero)
					id_predicate_Lcom_layer_sdk_query_Predicate_ = JNIEnv.GetMethodID (class_ref, "predicate", "(Lcom/layer/sdk/query/Predicate;)Lcom/layer/sdk/query/Query$Builder;");

				global::Com.Layer.Sdk.Query.Query.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallObjectMethod  (Handle, id_predicate_Lcom_layer_sdk_query_Predicate_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predicate", "(Lcom/layer/sdk/query/Predicate;)Lcom/layer/sdk/query/Query$Builder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_;
#pragma warning disable 0169
			static Delegate GetSortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_Handler ()
			{
				if (cb_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_ == null)
					cb_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_);
				return cb_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_;
			}

			static IntPtr n_SortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Query.Query.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.SortDescriptor[] p0 = (global::Com.Layer.Sdk.Query.SortDescriptor[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Layer.Sdk.Query.SortDescriptor));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SortDescriptor (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.Builder']/method[@name='sortDescriptor' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.SortDescriptor...']]"
			[Register ("sortDescriptor", "([Lcom/layer/sdk/query/SortDescriptor;)Lcom/layer/sdk/query/Query$Builder;", "GetSortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_Handler")]
			public virtual global::Com.Layer.Sdk.Query.Query.Builder SortDescriptor (params global:: Com.Layer.Sdk.Query.SortDescriptor[] p0)
			{
				if (id_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_ == IntPtr.Zero)
					id_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_ = JNIEnv.GetMethodID (class_ref, "sortDescriptor", "([Lcom/layer/sdk/query/SortDescriptor;)Lcom/layer/sdk/query/Query$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Com.Layer.Sdk.Query.Query.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallObjectMethod  (Handle, id_sortDescriptor_arrayLcom_layer_sdk_query_SortDescriptor_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sortDescriptor", "([Lcom/layer/sdk/query/SortDescriptor;)Lcom/layer/sdk/query/Query$Builder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/Query$ResultType", DoNotGenerateAcw=true)]
		public sealed partial class ResultType : global::Java.Lang.Enum {


			static IntPtr COUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']/field[@name='COUNT']"
			[Register ("COUNT")]
			public static global::Com.Layer.Sdk.Query.Query.ResultType Count {
				get {
					if (COUNT_jfieldId == IntPtr.Zero)
						COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNT", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.ResultType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (COUNT_jfieldId == IntPtr.Zero)
						COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNT", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, COUNT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IDENTIFIERS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']/field[@name='IDENTIFIERS']"
			[Register ("IDENTIFIERS")]
			public static global::Com.Layer.Sdk.Query.Query.ResultType Identifiers {
				get {
					if (IDENTIFIERS_jfieldId == IntPtr.Zero)
						IDENTIFIERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTIFIERS", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDENTIFIERS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.ResultType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IDENTIFIERS_jfieldId == IntPtr.Zero)
						IDENTIFIERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTIFIERS", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IDENTIFIERS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OBJECTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']/field[@name='OBJECTS']"
			[Register ("OBJECTS")]
			public static global::Com.Layer.Sdk.Query.Query.ResultType Objects {
				get {
					if (OBJECTS_jfieldId == IntPtr.Zero)
						OBJECTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECTS", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OBJECTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.ResultType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OBJECTS_jfieldId == IntPtr.Zero)
						OBJECTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECTS", "Lcom/layer/sdk/query/Query$ResultType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OBJECTS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/Query$ResultType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResultType); }
			}

			internal ResultType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Query$ResultType;", "")]
			public static global::Com.Layer.Sdk.Query.Query.ResultType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Query$ResultType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Query.Query.ResultType __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.ResultType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query.ResultType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/query/Query$ResultType;", "")]
			public static global::Com.Layer.Sdk.Query.Query.ResultType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/query/Query$ResultType;");
				return (global::Com.Layer.Sdk.Query.Query.ResultType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Query.Query.ResultType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/query/Query", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Query); }
		}

		protected Query (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimit);
			return cb_getLimit;
		}

		static IntPtr n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Query __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit);
		}
#pragma warning restore 0169

		static IntPtr id_getLimit;
		public virtual global::Java.Lang.Long Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()Ljava/lang/Long;", "GetGetLimitHandler")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()Ljava/lang/Long;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getLimit), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimit", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Query __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		public virtual global::Java.Lang.Long Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Ljava/lang/Long;", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Ljava/lang/Long;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPredicate;
#pragma warning disable 0169
		static Delegate GetGetPredicateHandler ()
		{
			if (cb_getPredicate == null)
				cb_getPredicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPredicate);
			return cb_getPredicate;
		}

		static IntPtr n_GetPredicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Query __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Predicate);
		}
#pragma warning restore 0169

		static IntPtr id_getPredicate;
		public virtual global::Com.Layer.Sdk.Query.Predicate Predicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='getPredicate' and count(parameter)=0]"
			[Register ("getPredicate", "()Lcom/layer/sdk/query/Predicate;", "GetGetPredicateHandler")]
			get {
				if (id_getPredicate == IntPtr.Zero)
					id_getPredicate = JNIEnv.GetMethodID (class_ref, "getPredicate", "()Lcom/layer/sdk/query/Predicate;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (JNIEnv.CallObjectMethod  (Handle, id_getPredicate), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPredicate", "()Lcom/layer/sdk/query/Predicate;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getQueryClass;
#pragma warning disable 0169
		static Delegate GetGetQueryClassHandler ()
		{
			if (cb_getQueryClass == null)
				cb_getQueryClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQueryClass);
			return cb_getQueryClass;
		}

		static IntPtr n_GetQueryClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Query __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QueryClass);
		}
#pragma warning restore 0169

		static IntPtr id_getQueryClass;
		public virtual global::Java.Lang.Class QueryClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='getQueryClass' and count(parameter)=0]"
			[Register ("getQueryClass", "()Ljava/lang/Class;", "GetGetQueryClassHandler")]
			get {
				if (id_getQueryClass == IntPtr.Zero)
					id_getQueryClass = JNIEnv.GetMethodID (class_ref, "getQueryClass", "()Ljava/lang/Class;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getQueryClass), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQueryClass", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSortDescriptors;
#pragma warning disable 0169
		static Delegate GetGetSortDescriptorsHandler ()
		{
			if (cb_getSortDescriptors == null)
				cb_getSortDescriptors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSortDescriptors);
			return cb_getSortDescriptors;
		}

		static IntPtr n_GetSortDescriptors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Query __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.SortDescriptor>.ToLocalJniHandle (__this.SortDescriptors);
		}
#pragma warning restore 0169

		static IntPtr id_getSortDescriptors;
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.SortDescriptor> SortDescriptors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='getSortDescriptors' and count(parameter)=0]"
			[Register ("getSortDescriptors", "()Ljava/util/List;", "GetGetSortDescriptorsHandler")]
			get {
				if (id_getSortDescriptors == IntPtr.Zero)
					id_getSortDescriptors = JNIEnv.GetMethodID (class_ref, "getSortDescriptors", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.SortDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSortDescriptors), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.SortDescriptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSortDescriptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_builder_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Query']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("builder", "(Ljava/lang/Class;)Lcom/layer/sdk/query/Query$Builder;", "")]
		public static global::Com.Layer.Sdk.Query.Query.Builder InvokeBuilder (global::Java.Lang.Class p0)
		{
			if (id_builder_Ljava_lang_Class_ == IntPtr.Zero)
				id_builder_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "(Ljava/lang/Class;)Lcom/layer/sdk/query/Query$Builder;");
			global::Com.Layer.Sdk.Query.Query.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
