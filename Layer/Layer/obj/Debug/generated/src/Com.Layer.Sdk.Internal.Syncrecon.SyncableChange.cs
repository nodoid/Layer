using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncableChange", DoNotGenerateAcw=true)]
	public partial class SyncableChange : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.ChangeType']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncableChange$ChangeType", DoNotGenerateAcw=true)]
		public sealed partial class ChangeType : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.ChangeType']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.ChangeType']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncableChange$ChangeType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ChangeType); }
			}

			internal ChangeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.ChangeType']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;", "")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
				return (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType));
			}

			static IntPtr id_a_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.ChangeType']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("a", "(I)Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;", "")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType A (int p0)
			{
				if (id_a_I == IntPtr.Zero)
					id_a_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(I)Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncableChange$Table", DoNotGenerateAcw=true)]
		public sealed partial class Table : global::Java.Lang.Enum {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/field[@name='b']"
			[Register ("b")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/field[@name='c']"
			[Register ("c")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/field[@name='d']"
			[Register ("d")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/field[@name='e']"
			[Register ("e")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncableChange$Table", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Table); }
			}

			internal Table (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()[Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;", "")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table[] A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()[Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
				return (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table));
			}

			static IntPtr id_a_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange.Table']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("a", "(Ljava/lang/String;)Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;", "")]
			public static global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table A (string p0)
			{
				if (id_a_Ljava_lang_String_ == IntPtr.Zero)
					id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncableChange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncableChange); }
		}

		protected SyncableChange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/constructor[@name='SyncableChange' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SyncableChange () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SyncableChange)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ChangeType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.SyncableChange.ChangeType']]"
		[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType p0)
		{
			if (id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ChangeType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ChangeType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ChangeType_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_Table_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.SyncableChange.Table']]"
		[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table p0)
		{
			if (id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_Table_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_Table_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_Table_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;", "")]
		public global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/syncrecon/SyncableChange$Table;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.Table> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Long;", "")]
		public global::Java.Lang.Long C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Long;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncableChange']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;", "")]
		public global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/syncrecon/SyncableChange$ChangeType;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange.ChangeType> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

	}
}
