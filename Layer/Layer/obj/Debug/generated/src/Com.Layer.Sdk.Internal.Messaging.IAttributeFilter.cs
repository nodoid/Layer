using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Metadata']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/AttributeFilter$Metadata", DoNotGenerateAcw=true)]
	public partial class AttributeFilterMetadata : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/AttributeFilter$Metadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributeFilterMetadata); }
		}

		protected AttributeFilterMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Metadata']/constructor[@name='AttributeFilter.Metadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AttributeFilterMetadata () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttributeFilterMetadata)) {
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

		// This method is explicitly implemented as a member of an instantiated Com.Layer.Sdk.Internal.Messaging.IAttributeFilter
		global::Java.Lang.Object global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter.A (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(A (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>(p0)));
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Participants']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/AttributeFilter$Participants", DoNotGenerateAcw=true)]
	public partial class AttributeFilterParticipants : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/AttributeFilter$Participants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributeFilterParticipants); }
		}

		protected AttributeFilterParticipants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Participants']/constructor[@name='AttributeFilter.Participants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AttributeFilterParticipants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttributeFilterParticipants)) {
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

		// This method is explicitly implemented as a member of an instantiated Com.Layer.Sdk.Internal.Messaging.IAttributeFilter
		global::Java.Lang.Object global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter.A (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(A (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>>(p0)));
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Recipients']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/AttributeFilter$Recipients", DoNotGenerateAcw=true)]
	public partial class AttributeFilterRecipients : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/AttributeFilter$Recipients", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributeFilterRecipients); }
		}

		protected AttributeFilterRecipients (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Recipients']/constructor[@name='AttributeFilter.Recipients' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AttributeFilterRecipients () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttributeFilterRecipients)) {
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

		// This method is explicitly implemented as a member of an instantiated Com.Layer.Sdk.Internal.Messaging.IAttributeFilter
		global::Java.Lang.Object global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter.A (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(A (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl>>(p0)));
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Unity']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/AttributeFilter$Unity", DoNotGenerateAcw=true)]
	public partial class AttributeFilterUnity : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/messaging/AttributeFilter$Unity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributeFilterUnity); }
		}

		protected AttributeFilterUnity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Unity']/constructor[@name='AttributeFilter.Unity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AttributeFilterUnity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AttributeFilterUnity)) {
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

		static IntPtr id_a_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/class[@name='AttributeFilter.Unity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public global::Java.Lang.Object A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		// This method is explicitly implemented as a member of an instantiated Com.Layer.Sdk.Internal.Messaging.IAttributeFilter
		global::Java.Lang.Object global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter.A (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(A (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(p0)));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='AttributeFilter']"
	[Register ("com/layer/sdk/internal/messaging/AttributeFilter", "", "Com.Layer.Sdk.Internal.Messaging.IAttributeFilterInvoker")]
	public partial interface IAttributeFilter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.messaging']/interface[@name='AttributeFilter']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetA_Ljava_lang_Object_Handler:Com.Layer.Sdk.Internal.Messaging.IAttributeFilterInvoker, Layer")]
		global::Java.Lang.Object A (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/messaging/AttributeFilter", DoNotGenerateAcw=true)]
	internal class IAttributeFilterInvoker : global::Java.Lang.Object, IAttributeFilter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/messaging/AttributeFilter");
		IntPtr class_ref;

		public static IAttributeFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAttributeFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.messaging.AttributeFilter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAttributeFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAttributeFilterInvoker); }
		}

		static Delegate cb_a_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Object_Handler ()
		{
			if (cb_a_Ljava_lang_Object_ == null)
				cb_a_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Object_);
			return cb_a_Ljava_lang_Object_;
		}

		static IntPtr n_A_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IAttributeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_Object_;
		public global::Java.Lang.Object A (global::Java.Lang.Object p0)
		{
			if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_a_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
