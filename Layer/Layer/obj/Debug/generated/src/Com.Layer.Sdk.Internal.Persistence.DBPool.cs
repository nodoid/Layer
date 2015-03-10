using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='DBPool']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/DBPool", DoNotGenerateAcw=true)]
	public partial class DBPool : global::Java.Lang.Object, global::Android.Database.IDatabaseErrorHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/DBPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DBPool); }
		}

		protected DBPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='DBPool']/constructor[@name='DBPool' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public DBPool (global::Android.Content.Context p0, string p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (DBPool)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Z)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Z)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='DBPool']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='DBPool']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_b);
		}

		static Delegate cb_onCorruption_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
		static Delegate GetOnCorruption_Landroid_database_sqlite_SQLiteDatabase_Handler ()
		{
			if (cb_onCorruption_Landroid_database_sqlite_SQLiteDatabase_ == null)
				cb_onCorruption_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCorruption_Landroid_database_sqlite_SQLiteDatabase_);
			return cb_onCorruption_Landroid_database_sqlite_SQLiteDatabase_;
		}

		static void n_OnCorruption_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Persistence.DBPool __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.DBPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCorruption (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCorruption_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='DBPool']/method[@name='onCorruption' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCorruption_Landroid_database_sqlite_SQLiteDatabase_Handler")]
		public virtual void OnCorruption (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_onCorruption_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_onCorruption_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCorruption_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V"), new JValue (p0));
		}

	}
}
