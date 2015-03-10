using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata", DoNotGenerateAcw=true)]
	public partial class Metadata : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Diff']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata$Diff", DoNotGenerateAcw=true)]
		public partial class Diff : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata$Diff", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Diff); }
			}

			protected Diff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Diff']/constructor[@name='Metadata.Diff' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Diff () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Diff)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Diff']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Z", "")]
			public bool A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_a);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.DiffEntry']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata$DiffEntry", DoNotGenerateAcw=true)]
		public partial class DiffEntry : global::Java.Lang.Object {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.DiffEntry']/field[@name='a']"
			[Register ("a")]
			public static global::Java.Lang.Object A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Ljava/lang/Object;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata$DiffEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DiffEntry); }
			}

			protected DiffEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.DiffEntry']/constructor[@name='Metadata.DiffEntry' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public DiffEntry (global::Java.Lang.Object p0, global::Java.Lang.Object p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DiffEntry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Path']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata$Path", DoNotGenerateAcw=true)]
		public sealed partial class Path : global::Java.Lang.Enum {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Path']/field[@name='a']"
			[Register ("a")]
			public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Path A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/utils/Metadata$Path;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Metadata.Path> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/layer/sdk/internal/utils/Metadata$Path;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Path']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Path B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/Metadata$Path;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Metadata.Path> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/Metadata$Path;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata$Path", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Path); }
			}

			internal Path (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Type']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Type B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/Metadata$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Metadata.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/utils/Metadata$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Type']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/utils/Metadata$Type;", "")]
			public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Type[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/utils/Metadata$Type;");
				return (global::Com.Layer.Sdk.Internal.Utils.Metadata.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Utils.Metadata.Type));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Value']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/Metadata$Value", DoNotGenerateAcw=true)]
		public partial class Value : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata$Value", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Value); }
			}

			protected Value (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Long_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Value']/constructor[@name='Metadata.Value' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Long;)V", "")]
			public Value (string p0, global::Java.Lang.Long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (Value)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Long;)V", new JValue (native_p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Long;)V", new JValue (native_p0), new JValue (p1));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Value']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/lang/String;", "")]
			public string A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata.Value']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/Long;", "")]
			public global::Java.Lang.Long B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Long;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/Metadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metadata); }
		}

		protected Metadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Metadata () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Metadata)) {
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

		static IntPtr id_a_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Iterable;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> A (global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Map_Lcom_layer_sdk_internal_utils_Metadata_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='com.layer.sdk.internal.utils.Metadata.Type']]"
		[Register ("a", "(Ljava/util/Map;Lcom/layer/sdk/internal/utils/Metadata$Type;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Layer.Sdk.Internal.Utils.Metadata.Type p1)
		{
			if (id_a_Ljava_util_Map_Lcom_layer_sdk_internal_utils_Metadata_Type_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Lcom_layer_sdk_internal_utils_Metadata_Type_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Map;Lcom/layer/sdk/internal/utils/Metadata$Type;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Map_Lcom_layer_sdk_internal_utils_Metadata_Type_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Map_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.layer.sdk.internal.utils.Metadata.Value']]"
		[Register ("a", "(Ljava/util/Map;Ljava/lang/String;Lcom/layer/sdk/internal/utils/Metadata$Value;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, string p1, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value p2)
		{
			if (id_a_Ljava_util_Map_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Map;Ljava/lang/String;Lcom/layer/sdk/internal/utils/Metadata$Value;)Ljava/lang/Object;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Map_Ljava_lang_String_Lcom_layer_sdk_internal_utils_Metadata_Value_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;Ljava/util/Map;)Lcom/layer/sdk/internal/utils/Metadata$Diff;", "")]
		public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_a_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Map;Ljava/util/Map;)Lcom/layer/sdk/internal/utils/Metadata$Diff;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_b_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("b", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> B (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_b_Ljava_util_Map_ == IntPtr.Zero)
				id_b_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_b_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map']]"
		[Register ("b", "(Ljava/util/Map;Ljava/util/Map;)Lcom/layer/sdk/internal/utils/Metadata$Diff;", "")]
		public static global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff B (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_b_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_b_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/util/Map;Ljava/util/Map;)Lcom/layer/sdk/internal/utils/Metadata$Diff;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Utils.Metadata.Diff> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_c_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='Metadata']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map']]"
		[Register ("c", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<string> C (global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> p0, global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value> p1)
		{
			if (id_c_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_c_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Utils.Metadata.Value>.ToLocalJniHandle (p1);
			global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
