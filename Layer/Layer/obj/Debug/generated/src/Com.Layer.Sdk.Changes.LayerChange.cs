using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Changes {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']"
	[global::Android.Runtime.Register ("com/layer/sdk/changes/LayerChange", DoNotGenerateAcw=true)]
	public partial class LayerChange : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/field[@name='a']"
		[Register ("a")]
		protected global::Java.Lang.Object A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/field[@name='b']"
		[Register ("b")]
		protected global::Java.Lang.Object B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/changes/LayerChange$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr DELETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.Layer.Sdk.Changes.LayerChange.Type Delete {
				get {
					if (DELETE_jfieldId == IntPtr.Zero)
						DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DELETE_jfieldId == IntPtr.Zero)
						DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DELETE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INSERT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']/field[@name='INSERT']"
			[Register ("INSERT")]
			public static global::Com.Layer.Sdk.Changes.LayerChange.Type Insert {
				get {
					if (INSERT_jfieldId == IntPtr.Zero)
						INSERT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSERT", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSERT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSERT_jfieldId == IntPtr.Zero)
						INSERT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSERT", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INSERT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPDATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']/field[@name='UPDATE']"
			[Register ("UPDATE")]
			public static global::Com.Layer.Sdk.Changes.LayerChange.Type Update {
				get {
					if (UPDATE_jfieldId == IntPtr.Zero)
						UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPDATE_jfieldId == IntPtr.Zero)
						UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE", "Lcom/layer/sdk/changes/LayerChange$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPDATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/changes/LayerChange$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/changes/LayerChange$Type;", "")]
			public static global::Com.Layer.Sdk.Changes.LayerChange.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/changes/LayerChange$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Changes.LayerChange.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/changes/LayerChange$Type;", "")]
			public static global::Com.Layer.Sdk.Changes.LayerChange.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/changes/LayerChange$Type;");
				return (global::Com.Layer.Sdk.Changes.LayerChange.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Changes.LayerChange.Type));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/changes/LayerChange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerChange); }
		}

		protected LayerChange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_messaging_LayerObject_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/constructor[@name='LayerChange' and count(parameter)=5 and parameter[1][@type='com.layer.sdk.changes.LayerChange.Type'] and parameter[2][@type='com.layer.sdk.messaging.LayerObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/messaging/LayerObject;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public LayerChange (global::Com.Layer.Sdk.Changes.LayerChange.Type p0, global::Com.Layer.Sdk.Messaging.ILayerObject p1, string p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (LayerChange)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/messaging/LayerObject;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/messaging/LayerObject;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_messaging_LayerObject_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_messaging_LayerObject_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/changes/LayerChange$Type;Lcom/layer/sdk/messaging/LayerObject;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_messaging_LayerObject_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_changes_LayerChange_Type_Lcom_layer_sdk_messaging_LayerObject_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getAttributeName;
#pragma warning disable 0169
		static Delegate GetGetAttributeNameHandler ()
		{
			if (cb_getAttributeName == null)
				cb_getAttributeName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributeName);
			return cb_getAttributeName;
		}

		static IntPtr n_GetAttributeName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AttributeName);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeName;
		public virtual string AttributeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getAttributeName' and count(parameter)=0]"
			[Register ("getAttributeName", "()Ljava/lang/String;", "GetGetAttributeNameHandler")]
			get {
				if (id_getAttributeName == IntPtr.Zero)
					id_getAttributeName = JNIEnv.GetMethodID (class_ref, "getAttributeName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAttributeName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributeName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getChangeType;
#pragma warning disable 0169
		static Delegate GetGetChangeTypeHandler ()
		{
			if (cb_getChangeType == null)
				cb_getChangeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChangeType);
			return cb_getChangeType;
		}

		static IntPtr n_GetChangeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChangeType);
		}
#pragma warning restore 0169

		static IntPtr id_getChangeType;
		public virtual global::Com.Layer.Sdk.Changes.LayerChange.Type ChangeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getChangeType' and count(parameter)=0]"
			[Register ("getChangeType", "()Lcom/layer/sdk/changes/LayerChange$Type;", "GetGetChangeTypeHandler")]
			get {
				if (id_getChangeType == IntPtr.Zero)
					id_getChangeType = JNIEnv.GetMethodID (class_ref, "getChangeType", "()Lcom/layer/sdk/changes/LayerChange$Type;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (JNIEnv.CallObjectMethod  (Handle, id_getChangeType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChangeType", "()Lcom/layer/sdk/changes/LayerChange$Type;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNewValue;
#pragma warning disable 0169
		static Delegate GetGetNewValueHandler ()
		{
			if (cb_getNewValue == null)
				cb_getNewValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewValue);
			return cb_getNewValue;
		}

		static IntPtr n_GetNewValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewValue);
		}
#pragma warning restore 0169

		static IntPtr id_getNewValue;
		public virtual global::Java.Lang.Object NewValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getNewValue' and count(parameter)=0]"
			[Register ("getNewValue", "()Ljava/lang/Object;", "GetGetNewValueHandler")]
			get {
				if (id_getNewValue == IntPtr.Zero)
					id_getNewValue = JNIEnv.GetMethodID (class_ref, "getNewValue", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getNewValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getObject;
#pragma warning disable 0169
		static Delegate GetGetObjectHandler ()
		{
			if (cb_getObject == null)
				cb_getObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObject);
			return cb_getObject;
		}

		static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		static IntPtr id_getObject;
		public virtual global::Com.Layer.Sdk.Messaging.ILayerObject Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Lcom/layer/sdk/messaging/LayerObject;", "GetGetObjectHandler")]
			get {
				if (id_getObject == IntPtr.Zero)
					id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Lcom/layer/sdk/messaging/LayerObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ILayerObject> (JNIEnv.CallObjectMethod  (Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ILayerObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObject", "()Lcom/layer/sdk/messaging/LayerObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getObjectType;
#pragma warning disable 0169
		static Delegate GetGetObjectTypeHandler ()
		{
			if (cb_getObjectType == null)
				cb_getObjectType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectType);
			return cb_getObjectType;
		}

		static IntPtr n_GetObjectType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectType);
		}
#pragma warning restore 0169

		static IntPtr id_getObjectType;
		public virtual global::Com.Layer.Sdk.Messaging.LayerObjectType ObjectType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getObjectType' and count(parameter)=0]"
			[Register ("getObjectType", "()Lcom/layer/sdk/messaging/LayerObject$Type;", "GetGetObjectTypeHandler")]
			get {
				if (id_getObjectType == IntPtr.Zero)
					id_getObjectType = JNIEnv.GetMethodID (class_ref, "getObjectType", "()Lcom/layer/sdk/messaging/LayerObject$Type;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (JNIEnv.CallObjectMethod  (Handle, id_getObjectType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.LayerObjectType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectType", "()Lcom/layer/sdk/messaging/LayerObject$Type;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOldValue;
#pragma warning disable 0169
		static Delegate GetGetOldValueHandler ()
		{
			if (cb_getOldValue == null)
				cb_getOldValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOldValue);
			return cb_getOldValue;
		}

		static IntPtr n_GetOldValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Changes.LayerChange __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldValue);
		}
#pragma warning restore 0169

		static IntPtr id_getOldValue;
		public virtual global::Java.Lang.Object OldValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.changes']/class[@name='LayerChange']/method[@name='getOldValue' and count(parameter)=0]"
			[Register ("getOldValue", "()Ljava/lang/Object;", "GetGetOldValueHandler")]
			get {
				if (id_getOldValue == IntPtr.Zero)
					id_getOldValue = JNIEnv.GetMethodID (class_ref, "getOldValue", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getOldValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOldValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
