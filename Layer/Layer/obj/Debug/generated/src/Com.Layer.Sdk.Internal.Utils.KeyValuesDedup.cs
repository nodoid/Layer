using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='KeyValuesDedup']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/utils/KeyValuesDedup", DoNotGenerateAcw=true)]
	public partial class KeyValuesDedup : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/utils/KeyValuesDedup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyValuesDedup); }
		}

		protected KeyValuesDedup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='KeyValuesDedup']/constructor[@name='KeyValuesDedup' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public KeyValuesDedup (long p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyValuesDedup)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", new JValue (p0));
				return;
			}

			if (id_ctor_J == IntPtr.Zero)
				id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Object_Ljava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.utils']/class[@name='KeyValuesDedup']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Comparable']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/Comparable;)Z", "")]
		public bool A (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_a_Ljava_lang_Object_Ljava_lang_Comparable_ == IntPtr.Zero)
				id_a_Ljava_lang_Object_Ljava_lang_Comparable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;Ljava/lang/Comparable;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Ljava_lang_Object_Ljava_lang_Comparable_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
