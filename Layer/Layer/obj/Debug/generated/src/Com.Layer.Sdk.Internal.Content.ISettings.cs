using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']"
	[Register ("com/layer/sdk/internal/content/Settings", "", "Com.Layer.Sdk.Internal.Content.ISettingsInvoker")]
	public partial interface ISettings : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;", "GetA_Ljava_util_Collection_Handler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Content.ISettings A (global::System.Collections.Generic.ICollection<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)Lcom/layer/sdk/internal/content/Settings;", "GetA_JHandler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Content.ISettings A (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='b' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("b", "(J)Lcom/layer/sdk/internal/content/Settings;", "GetB_JHandler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		global::Com.Layer.Sdk.Internal.Content.ISettings B (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/Set;", "GetCHandler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		global::System.Collections.Generic.ICollection<string> C ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()J", "GetDHandler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		long D ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.content']/interface[@name='Settings']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()J", "GetEHandler:Com.Layer.Sdk.Internal.Content.ISettingsInvoker, Layer")]
		long E ();

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/content/Settings", DoNotGenerateAcw=true)]
	internal class ISettingsInvoker : global::Java.Lang.Object, ISettings {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/content/Settings");
		IntPtr class_ref;

		public static ISettings GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISettings> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.content.Settings"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISettingsInvoker); }
		}

		static Delegate cb_a_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Collection_Handler ()
		{
			if (cb_a_Ljava_util_Collection_ == null)
				cb_a_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Collection_);
			return cb_a_Ljava_util_Collection_;
		}

		static IntPtr n_A_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_util_Collection_;
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_a_Ljava_util_Collection_ == IntPtr.Zero)
				id_a_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Collection;)Lcom/layer/sdk/internal/content/Settings;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Internal.Content.ISettings __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod (Handle, id_a_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_a_J;
#pragma warning disable 0169
		static Delegate GetA_JHandler ()
		{
			if (cb_a_J == null)
				cb_a_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_A_J);
			return cb_a_J;
		}

		static IntPtr n_A_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A (p0));
		}
#pragma warning restore 0169

		IntPtr id_a_J;
		public global::Com.Layer.Sdk.Internal.Content.ISettings A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod (Handle, id_a_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_b_J;
#pragma warning disable 0169
		static Delegate GetB_JHandler ()
		{
			if (cb_b_J == null)
				cb_b_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_B_J);
			return cb_b_J;
		}

		static IntPtr n_B_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.B (p0));
		}
#pragma warning restore 0169

		IntPtr id_b_J;
		public global::Com.Layer.Sdk.Internal.Content.ISettings B (long p0)
		{
			if (id_b_J == IntPtr.Zero)
				id_b_J = JNIEnv.GetMethodID (class_ref, "b", "(J)Lcom/layer/sdk/internal/content/Settings;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (JNIEnv.CallObjectMethod (Handle, id_b_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		IntPtr id_c;
		public global::System.Collections.Generic.ICollection<string> C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_D);
			return cb_d;
		}

		static long n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.D ();
		}
#pragma warning restore 0169

		IntPtr id_d;
		public long D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()J");
			return JNIEnv.CallLongMethod (Handle, id_d);
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_E);
			return cb_e;
		}

		static long n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Internal.Content.ISettings __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Content.ISettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.E ();
		}
#pragma warning restore 0169

		IntPtr id_e;
		public long E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()J");
			return JNIEnv.CallLongMethod (Handle, id_e);
		}

	}

}
