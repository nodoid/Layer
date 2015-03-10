using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']"
	[global::Android.Runtime.Register ("com/layer/sdk/query/Predicate", DoNotGenerateAcw=true)]
	public partial class Predicate : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/Predicate$Operator", DoNotGenerateAcw=true)]
		public sealed partial class Operator : global::Java.Lang.Enum {


			static IntPtr EQUAL_TO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='EQUAL_TO']"
			[Register ("EQUAL_TO")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator EqualTo {
				get {
					if (EQUAL_TO_jfieldId == IntPtr.Zero)
						EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EQUAL_TO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EQUAL_TO_jfieldId == IntPtr.Zero)
						EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EQUAL_TO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GREATER_THAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='GREATER_THAN']"
			[Register ("GREATER_THAN")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator GreaterThan {
				get {
					if (GREATER_THAN_jfieldId == IntPtr.Zero)
						GREATER_THAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GREATER_THAN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GREATER_THAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GREATER_THAN_jfieldId == IntPtr.Zero)
						GREATER_THAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GREATER_THAN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GREATER_THAN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GREATER_THAN_OR_EQUAL_TO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='GREATER_THAN_OR_EQUAL_TO']"
			[Register ("GREATER_THAN_OR_EQUAL_TO")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator GreaterThanOrEqualTo {
				get {
					if (GREATER_THAN_OR_EQUAL_TO_jfieldId == IntPtr.Zero)
						GREATER_THAN_OR_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GREATER_THAN_OR_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GREATER_THAN_OR_EQUAL_TO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GREATER_THAN_OR_EQUAL_TO_jfieldId == IntPtr.Zero)
						GREATER_THAN_OR_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GREATER_THAN_OR_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GREATER_THAN_OR_EQUAL_TO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='IN']"
			[Register ("IN")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator In {
				get {
					if (IN_jfieldId == IntPtr.Zero)
						IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IN_jfieldId == IntPtr.Zero)
						IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LESS_THAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='LESS_THAN']"
			[Register ("LESS_THAN")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator LessThan {
				get {
					if (LESS_THAN_jfieldId == IntPtr.Zero)
						LESS_THAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LESS_THAN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LESS_THAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LESS_THAN_jfieldId == IntPtr.Zero)
						LESS_THAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LESS_THAN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LESS_THAN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LESS_THAN_OR_EQUAL_TO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='LESS_THAN_OR_EQUAL_TO']"
			[Register ("LESS_THAN_OR_EQUAL_TO")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator LessThanOrEqualTo {
				get {
					if (LESS_THAN_OR_EQUAL_TO_jfieldId == IntPtr.Zero)
						LESS_THAN_OR_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LESS_THAN_OR_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LESS_THAN_OR_EQUAL_TO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LESS_THAN_OR_EQUAL_TO_jfieldId == IntPtr.Zero)
						LESS_THAN_OR_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LESS_THAN_OR_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LESS_THAN_OR_EQUAL_TO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_EQUAL_TO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='NOT_EQUAL_TO']"
			[Register ("NOT_EQUAL_TO")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator NotEqualTo {
				get {
					if (NOT_EQUAL_TO_jfieldId == IntPtr.Zero)
						NOT_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_EQUAL_TO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_EQUAL_TO_jfieldId == IntPtr.Zero)
						NOT_EQUAL_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_EQUAL_TO", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_EQUAL_TO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_IN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/field[@name='NOT_IN']"
			[Register ("NOT_IN")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator NotIn {
				get {
					if (NOT_IN_jfieldId == IntPtr.Zero)
						NOT_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_IN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_IN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_IN_jfieldId == IntPtr.Zero)
						NOT_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_IN", "Lcom/layer/sdk/query/Predicate$Operator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_IN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/Predicate$Operator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Operator); }
			}

			internal Operator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getType;
			public global::Com.Layer.Sdk.Query.Predicate.Type Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/layer/sdk/query/Predicate$Type;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/layer/sdk/query/Predicate$Type;");
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Predicate$Operator;", "")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Predicate$Operator;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Query.Predicate.Operator __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Operator']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/query/Predicate$Operator;", "")]
			public static global::Com.Layer.Sdk.Query.Predicate.Operator[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/query/Predicate$Operator;");
				return (global::Com.Layer.Sdk.Query.Predicate.Operator[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Query.Predicate.Operator));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/Predicate$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr EQUALITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']/field[@name='EQUALITY']"
			[Register ("EQUALITY")]
			public static global::Com.Layer.Sdk.Query.Predicate.Type Equality {
				get {
					if (EQUALITY_jfieldId == IntPtr.Zero)
						EQUALITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EQUALITY", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EQUALITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EQUALITY_jfieldId == IntPtr.Zero)
						EQUALITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EQUALITY", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EQUALITY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INCLUSIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']/field[@name='INCLUSIVE']"
			[Register ("INCLUSIVE")]
			public static global::Com.Layer.Sdk.Query.Predicate.Type Inclusive {
				get {
					if (INCLUSIVE_jfieldId == IntPtr.Zero)
						INCLUSIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUSIVE", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCLUSIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INCLUSIVE_jfieldId == IntPtr.Zero)
						INCLUSIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUSIVE", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INCLUSIVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RELATIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']/field[@name='RELATIVE']"
			[Register ("RELATIVE")]
			public static global::Com.Layer.Sdk.Query.Predicate.Type Relative {
				get {
					if (RELATIVE_jfieldId == IntPtr.Zero)
						RELATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RELATIVE", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RELATIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RELATIVE_jfieldId == IntPtr.Zero)
						RELATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RELATIVE", "Lcom/layer/sdk/query/Predicate$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RELATIVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/Predicate$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Predicate$Type;", "")]
			public static global::Com.Layer.Sdk.Query.Predicate.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/Predicate$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Query.Predicate.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/query/Predicate$Type;", "")]
			public static global::Com.Layer.Sdk.Query.Predicate.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/query/Predicate$Type;");
				return (global::Com.Layer.Sdk.Query.Predicate.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Query.Predicate.Type));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/query/Predicate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Predicate); }
		}

		protected Predicate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/constructor[@name='Predicate' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.Queryable.Property'] and parameter[2][@type='com.layer.sdk.query.Predicate.Operator'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)V", "")]
		public Predicate (global::Com.Layer.Sdk.Query.IQueryableProperty p0, global::Com.Layer.Sdk.Query.Predicate.Operator p1, global::Java.Lang.Object p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Predicate)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_isEquality;
#pragma warning disable 0169
		static Delegate GetIsEqualityHandler ()
		{
			if (cb_isEquality == null)
				cb_isEquality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEquality);
			return cb_isEquality;
		}

		static bool n_IsEquality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEquality;
		}
#pragma warning restore 0169

		static IntPtr id_isEquality;
		public virtual bool IsEquality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='isEquality' and count(parameter)=0]"
			[Register ("isEquality", "()Z", "GetIsEqualityHandler")]
			get {
				if (id_isEquality == IntPtr.Zero)
					id_isEquality = JNIEnv.GetMethodID (class_ref, "isEquality", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEquality);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEquality", "()Z"));
			}
		}

		static Delegate cb_isInclusion;
#pragma warning disable 0169
		static Delegate GetIsInclusionHandler ()
		{
			if (cb_isInclusion == null)
				cb_isInclusion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInclusion);
			return cb_isInclusion;
		}

		static bool n_IsInclusion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInclusion;
		}
#pragma warning restore 0169

		static IntPtr id_isInclusion;
		public virtual bool IsInclusion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='isInclusion' and count(parameter)=0]"
			[Register ("isInclusion", "()Z", "GetIsInclusionHandler")]
			get {
				if (id_isInclusion == IntPtr.Zero)
					id_isInclusion = JNIEnv.GetMethodID (class_ref, "isInclusion", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInclusion);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInclusion", "()Z"));
			}
		}

		static Delegate cb_isRelative;
#pragma warning disable 0169
		static Delegate GetIsRelativeHandler ()
		{
			if (cb_isRelative == null)
				cb_isRelative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRelative);
			return cb_isRelative;
		}

		static bool n_IsRelative (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRelative;
		}
#pragma warning restore 0169

		static IntPtr id_isRelative;
		public virtual bool IsRelative {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='isRelative' and count(parameter)=0]"
			[Register ("isRelative", "()Z", "GetIsRelativeHandler")]
			get {
				if (id_isRelative == IntPtr.Zero)
					id_isRelative = JNIEnv.GetMethodID (class_ref, "isRelative", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRelative);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRelative", "()Z"));
			}
		}

		static Delegate cb_getProperty;
#pragma warning disable 0169
		static Delegate GetGetPropertyHandler ()
		{
			if (cb_getProperty == null)
				cb_getProperty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProperty);
			return cb_getProperty;
		}

		static IntPtr n_GetProperty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Property);
		}
#pragma warning restore 0169

		static IntPtr id_getProperty;
		public virtual global::Com.Layer.Sdk.Query.IQueryableProperty Property {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='getProperty' and count(parameter)=0]"
			[Register ("getProperty", "()Lcom/layer/sdk/query/Queryable$Property;", "GetGetPropertyHandler")]
			get {
				if (id_getProperty == IntPtr.Zero)
					id_getProperty = JNIEnv.GetMethodID (class_ref, "getProperty", "()Lcom/layer/sdk/query/Queryable$Property;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (JNIEnv.CallObjectMethod  (Handle, id_getProperty), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "()Lcom/layer/sdk/query/Queryable$Property;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOperator;
#pragma warning disable 0169
		static Delegate GetGetOperatorHandler ()
		{
			if (cb_getOperator == null)
				cb_getOperator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOperator);
			return cb_getOperator;
		}

		static IntPtr n_GetOperator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.Predicate __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOperator ());
		}
#pragma warning restore 0169

		static IntPtr id_getOperator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='Predicate']/method[@name='getOperator' and count(parameter)=0]"
		[Register ("getOperator", "()Lcom/layer/sdk/query/Predicate$Operator;", "GetGetOperatorHandler")]
		public virtual global::Com.Layer.Sdk.Query.Predicate.Operator GetOperator ()
		{
			if (id_getOperator == IntPtr.Zero)
				id_getOperator = JNIEnv.GetMethodID (class_ref, "getOperator", "()Lcom/layer/sdk/query/Predicate$Operator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (JNIEnv.CallObjectMethod  (Handle, id_getOperator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate.Operator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOperator", "()Lcom/layer/sdk/query/Predicate$Operator;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
