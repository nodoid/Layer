using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Readcounter']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/Readcounter", DoNotGenerateAcw=true)]
	public partial class Readcounter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Readcounter.Persistence']"
		[Register ("com/layer/sdk/internal/syncrecon/Readcounter$Persistence", "", "Com.Layer.Sdk.Internal.Syncrecon.Readcounter/IPersistenceInvoker")]
		public partial interface IPersistence : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Readcounter.Persistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
			[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", "GetA_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Handler:Com.Layer.Sdk.Internal.Syncrecon.Readcounter/IPersistenceInvoker, Layer")]
			void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Readcounter.Persistence']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetF_Landroid_database_sqlite_SQLiteDatabase_Handler:Com.Layer.Sdk.Internal.Syncrecon.Readcounter/IPersistenceInvoker, Layer")]
			void F (global::Android.Database.Sqlite.SQLiteDatabase p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/Readcounter$Persistence", DoNotGenerateAcw=true)]
		internal class IPersistenceInvoker : global::Java.Lang.Object, IPersistence {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/Readcounter$Persistence");
			IntPtr class_ref;

			public static IPersistence GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPersistence> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.Readcounter.Persistence"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPersistenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPersistenceInvoker); }
			}

			static Delegate cb_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetA_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Handler ()
			{
				if (cb_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == null)
					cb_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_);
				return cb_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
			}

			static void n_A_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.A (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
			public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
			{
				if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
					id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_f_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetF_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_f_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_f_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_F_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_f_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_F_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.F (p0);
			}
#pragma warning restore 0169

			IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_;
			public void F (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_f_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_f_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;)V");
				JNIEnv.CallVoidMethod (Handle, id_f_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/Readcounter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Readcounter); }
		}

		protected Readcounter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Readcounter']/constructor[@name='Readcounter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Readcounter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Readcounter)) {
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

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Lcom_layer_sdk_internal_syncrecon_Readcounter_Persistence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Readcounter']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.layer.sdk.internal.syncrecon.Readcounter.Persistence']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Lcom/layer/sdk/internal/syncrecon/Readcounter$Persistence;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Lcom_layer_sdk_internal_syncrecon_Readcounter_Persistence_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Lcom_layer_sdk_internal_syncrecon_Readcounter_Persistence_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Lcom/layer/sdk/internal/syncrecon/Readcounter$Persistence;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Lcom_layer_sdk_internal_syncrecon_Readcounter_Persistence_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
