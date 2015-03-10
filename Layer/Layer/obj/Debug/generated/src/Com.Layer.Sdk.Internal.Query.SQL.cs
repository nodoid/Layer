using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/query/SQL", DoNotGenerateAcw=true)]
	public partial class SQL : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Conjunction']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/SQL$Conjunction", DoNotGenerateAcw=true)]
		public sealed partial class Conjunction : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Conjunction']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/query/SQL$Conjunction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/query/SQL$Conjunction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Conjunction']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/query/SQL$Conjunction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/query/SQL$Conjunction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/SQL$Conjunction", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Conjunction); }
			}

			internal Conjunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Conjunction']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/SQL$Statement", DoNotGenerateAcw=true)]
		public partial class Statement : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']"
			[global::Android.Runtime.Register ("com/layer/sdk/internal/query/SQL$Statement$Builder", DoNotGenerateAcw=true)]
			public partial class Builder : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/layer/sdk/internal/query/SQL$Statement$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/constructor[@name='SQL.Statement.Builder' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (Handle != IntPtr.Zero)
						return;

					if (GetType () != typeof (Builder)) {
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=0]"
				[Register ("a", "()Lcom/layer/sdk/internal/query/SQL$Statement;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement A ()
				{
					if (id_a == IntPtr.Zero)
						id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/query/SQL$Statement;");
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_a_Lcom_layer_sdk_internal_query_SQL_Conjunction_Ljava_lang_String_arrayLjava_lang_Object_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Conjunction'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
				[Register ("a", "(Lcom/layer/sdk/internal/query/SQL$Conjunction;Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p0, string p1, params global:: Java.Lang.Object[] p2)
				{
					if (id_a_Lcom_layer_sdk_internal_query_SQL_Conjunction_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
						id_a_Lcom_layer_sdk_internal_query_SQL_Conjunction_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/query/SQL$Conjunction;Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p1 = JNIEnv.NewString (p1);
					IntPtr native_p2 = JNIEnv.NewArray (p2);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_query_SQL_Conjunction_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					return __ret;
				}

				static IntPtr id_a_Ljava_lang_Long_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
				[Register ("a", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (global::Java.Lang.Long p0)
				{
					if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
						id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_a_Ljava_lang_String_Lcom_layer_sdk_query_SortDescriptor_Order_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.layer.sdk.query.SortDescriptor.Order']]"
				[Register ("a", "(Ljava/lang/String;Lcom/layer/sdk/query/SortDescriptor$Order;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (string p0, global::Com.Layer.Sdk.Query.SortDescriptor.Order p1)
				{
					if (id_a_Ljava_lang_String_Lcom_layer_sdk_query_SortDescriptor_Order_ == IntPtr.Zero)
						id_a_Ljava_lang_String_Lcom_layer_sdk_query_SortDescriptor_Order_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/layer/sdk/query/SortDescriptor$Order;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Lcom_layer_sdk_query_SortDescriptor_Order_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_a_Ljava_lang_String_arrayLjava_lang_Object_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
				[Register ("a", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (string p0, params global:: Java.Lang.Object[] p1)
				{
					if (id_a_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
						id_a_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					IntPtr native_p1 = JNIEnv.NewArray (p1);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return __ret;
				}

				static IntPtr id_a_arrayLjava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
				[Register ("a", "([Ljava/lang/String;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (params  string[] p0)
				{
					if (id_a_arrayLjava_lang_String_ == IntPtr.Zero)
						id_a_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "([Ljava/lang/String;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = JNIEnv.NewArray (p0);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					return __ret;
				}

				static IntPtr id_a_Ljava_util_Collection_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
				[Register ("a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder A (global::System.Collections.Generic.ICollection<string> p0)
				{
					if (id_a_Ljava_util_Collection_ == IntPtr.Zero)
						id_a_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_b_Ljava_lang_Long_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
				[Register ("b", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder B (global::Java.Lang.Long p0)
				{
					if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
						id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_b_Ljava_lang_String_arrayLjava_lang_Object_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
				[Register ("b", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder B (string p0, params global:: Java.Lang.Object[] p1)
				{
					if (id_b_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
						id_b_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					IntPtr native_p1 = JNIEnv.NewArray (p1);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return __ret;
				}

				static IntPtr id_b_arrayLjava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement.Builder']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
				[Register ("b", "([Ljava/lang/String;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;", "")]
				public global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder B (params  string[] p0)
				{
					if (id_b_arrayLjava_lang_String_ == IntPtr.Zero)
						id_b_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "([Ljava/lang/String;)Lcom/layer/sdk/internal/query/SQL$Statement$Builder;");
					IntPtr native_p0 = JNIEnv.NewArray (p0);
					global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (JNIEnv.CallObjectMethod  (Handle, id_b_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/SQL$Statement", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Statement); }
			}

			protected Statement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_lang_Long_Ljava_lang_Long_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement']/constructor[@name='SQL.Statement' and count(parameter)=7 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.util.Collection'] and parameter[3][@type='java.util.Collection'] and parameter[4][@type='java.util.Collection'] and parameter[5][@type='java.util.Collection'] and parameter[6][@type='java.lang.Long'] and parameter[7][@type='java.lang.Long']]"
			[Register (".ctor", "(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Long;Ljava/lang/Long;)V", "")]
			public Statement (global::System.Collections.Generic.ICollection<string> p0, global::System.Collections.Generic.ICollection<string> p1, global::System.Collections.Generic.ICollection<global::Com.Layer.Sdk.Internal.Query.SQL.WhereClause> p2, global::System.Collections.Generic.ICollection<string> p3, global::System.Collections.Generic.ICollection<string> p4, global::Java.Lang.Long p5, global::Java.Lang.Long p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);;
				IntPtr native_p1 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p1);;
				IntPtr native_p2 = global::Android.Runtime.JavaCollection<global::Com.Layer.Sdk.Internal.Query.SQL.WhereClause>.ToLocalJniHandle (p2);;
				IntPtr native_p3 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p3);;
				IntPtr native_p4 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p4);;
				if (GetType () != typeof (Statement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Long;Ljava/lang/Long;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (p6)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Long;Ljava/lang/Long;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (p6));
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
					return;
				}

				if (id_ctor_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Long;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_lang_Long_Ljava_lang_Long_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_util_Collection_Ljava_lang_Long_Ljava_lang_Long_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (p6));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.Statement']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/util/Set;", "")]
			public global::System.Collections.Generic.ICollection<string> B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.WhereClause']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/SQL$WhereClause", DoNotGenerateAcw=true)]
		public partial class WhereClause : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/SQL$WhereClause", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WhereClause); }
			}

			protected WhereClause (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_layer_sdk_internal_query_SQL_Conjunction_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.WhereClause']/constructor[@name='SQL.WhereClause' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.layer.sdk.internal.query.SQL.Conjunction']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", "")]
			public WhereClause (string p0, global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (WhereClause)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", new JValue (native_p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", new JValue (native_p0), new JValue (p1));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_layer_sdk_internal_query_SQL_Conjunction_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_layer_sdk_internal_query_SQL_Conjunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_layer_sdk_internal_query_SQL_Conjunction_, new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_layer_sdk_internal_query_SQL_Conjunction_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.WhereClause']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL.WhereClause']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/String;", "")]
			public string B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/query/SQL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQL); }
		}

		protected SQL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Predicate.Operator'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string A (global::Com.Layer.Sdk.Query.Predicate.Operator p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/query/Predicate$Operator;Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_layer_sdk_query_Predicate_Operator_Ljava_lang_Object_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_query_SortDescriptor_Order_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.SortDescriptor.Order']]"
		[Register ("a", "(Lcom/layer/sdk/query/SortDescriptor$Order;)Ljava/lang/String;", "")]
		public static string A (global::Com.Layer.Sdk.Query.SortDescriptor.Order p0)
		{
			if (id_a_Lcom_layer_sdk_query_SortDescriptor_Order_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_query_SortDescriptor_Order_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/query/SortDescriptor$Order;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_layer_sdk_query_SortDescriptor_Order_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("b", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string B (global::Java.Lang.Object p0)
		{
			if (id_b_Ljava_lang_Object_ == IntPtr.Zero)
				id_b_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("c", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string C (global::Java.Lang.Object p0)
		{
			if (id_c_Ljava_lang_Object_ == IntPtr.Zero)
				id_c_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='SQL']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("d", "(Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public static global::Java.Lang.IIterable D (global::Java.Lang.Object p0)
		{
			if (id_d_Ljava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/Object;)Ljava/lang/Iterable;");
			global::Java.Lang.IIterable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_d_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
