using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableAttribute']"
	[Register ("com/layer/sdk/internal/messaging/ChangeableAttribute", "", "Com.Layer.Sdk.Internal.Messaging.IChangeableAttributeInvoker")]
	public partial interface IChangeableAttribute : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableAttribute']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableAttributeInvoker, Layer")]
		string A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableAttribute']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;", "GetBHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableAttributeInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter B ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='ChangeableAttribute']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "GetCHandler:Com.Layer.Sdk.Internal.Messaging.IChangeableAttributeInvoker, Layer")]
		bool C ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/ChangeableAttribute", DoNotGenerateAcw=true)]
	internal class IChangeableAttributeInvoker : global::Java.Lang.Object, IChangeableAttribute {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/ChangeableAttribute");
		IntPtr class_ref;

		public static IChangeableAttribute GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChangeableAttribute> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.ChangeableAttribute"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChangeableAttributeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IChangeableAttributeInvoker); }
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		IntPtr id_a;
		public string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		IntPtr id_b;
		public global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/messaging/AttributeFilter;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter> (JNIEnv.CallObjectMethod (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_C);
			return cb_c;
		}

		static bool n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		IntPtr id_c;
		public bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_c);
		}

	}

}
