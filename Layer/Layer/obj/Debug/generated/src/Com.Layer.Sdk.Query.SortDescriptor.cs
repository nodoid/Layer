using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor']"
	[global::Android.Runtime.Register ("com/layer/sdk/query/SortDescriptor", DoNotGenerateAcw=true)]
	public partial class SortDescriptor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor.Order']"
		[global::Android.Runtime.Register ("com/layer/sdk/query/SortDescriptor$Order", DoNotGenerateAcw=true)]
		public sealed partial class Order : global::Java.Lang.Enum {


			static IntPtr ASCENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor.Order']/field[@name='ASCENDING']"
			[Register ("ASCENDING")]
			public static global::Com.Layer.Sdk.Query.SortDescriptor.Order Ascending {
				get {
					if (ASCENDING_jfieldId == IntPtr.Zero)
						ASCENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCENDING", "Lcom/layer/sdk/query/SortDescriptor$Order;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor.Order> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ASCENDING_jfieldId == IntPtr.Zero)
						ASCENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCENDING", "Lcom/layer/sdk/query/SortDescriptor$Order;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ASCENDING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DESCENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor.Order']/field[@name='DESCENDING']"
			[Register ("DESCENDING")]
			public static global::Com.Layer.Sdk.Query.SortDescriptor.Order Descending {
				get {
					if (DESCENDING_jfieldId == IntPtr.Zero)
						DESCENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESCENDING", "Lcom/layer/sdk/query/SortDescriptor$Order;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DESCENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor.Order> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DESCENDING_jfieldId == IntPtr.Zero)
						DESCENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESCENDING", "Lcom/layer/sdk/query/SortDescriptor$Order;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DESCENDING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/query/SortDescriptor$Order", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Order); }
			}

			internal Order (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor.Order']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/SortDescriptor$Order;", "")]
			public static global::Com.Layer.Sdk.Query.SortDescriptor.Order ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/query/SortDescriptor$Order;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Query.SortDescriptor.Order __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor.Order> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor.Order']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/query/SortDescriptor$Order;", "")]
			public static global::Com.Layer.Sdk.Query.SortDescriptor.Order[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/query/SortDescriptor$Order;");
				return (global::Com.Layer.Sdk.Query.SortDescriptor.Order[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Query.SortDescriptor.Order));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/query/SortDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SortDescriptor); }
		}

		protected SortDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_SortDescriptor_Order_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor']/constructor[@name='SortDescriptor' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Queryable.Property'] and parameter[2][@type='com.layer.sdk.query.SortDescriptor.Order']]"
		[Register (".ctor", "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/SortDescriptor$Order;)V", "")]
		public SortDescriptor (global::Com.Layer.Sdk.Query.IQueryableProperty p0, global::Com.Layer.Sdk.Query.SortDescriptor.Order p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SortDescriptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/SortDescriptor$Order;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/SortDescriptor$Order;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_SortDescriptor_Order_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_SortDescriptor_Order_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/query/Queryable$Property;Lcom/layer/sdk/query/SortDescriptor$Order;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_SortDescriptor_Order_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_query_Queryable_Property_Lcom_layer_sdk_query_SortDescriptor_Order_, new JValue (p0), new JValue (p1));
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
			global::Com.Layer.Sdk.Query.SortDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Property);
		}
#pragma warning restore 0169

		static IntPtr id_getProperty;
		public virtual global::Com.Layer.Sdk.Query.IQueryableProperty Property {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor']/method[@name='getProperty' and count(parameter)=0]"
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

		static Delegate cb_getOrder;
#pragma warning disable 0169
		static Delegate GetGetOrderHandler ()
		{
			if (cb_getOrder == null)
				cb_getOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrder);
			return cb_getOrder;
		}

		static IntPtr n_GetOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.SortDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOrder ());
		}
#pragma warning restore 0169

		static IntPtr id_getOrder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='SortDescriptor']/method[@name='getOrder' and count(parameter)=0]"
		[Register ("getOrder", "()Lcom/layer/sdk/query/SortDescriptor$Order;", "GetGetOrderHandler")]
		public virtual global::Com.Layer.Sdk.Query.SortDescriptor.Order GetOrder ()
		{
			if (id_getOrder == IntPtr.Zero)
				id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()Lcom/layer/sdk/query/SortDescriptor$Order;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor.Order> (JNIEnv.CallObjectMethod  (Handle, id_getOrder), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.SortDescriptor.Order> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrder", "()Lcom/layer/sdk/query/SortDescriptor$Order;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
