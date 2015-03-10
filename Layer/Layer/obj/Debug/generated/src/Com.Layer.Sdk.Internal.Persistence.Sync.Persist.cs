using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Persist", DoNotGenerateAcw=true)]
	public partial class Persist : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist.Values']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Persist$Values", DoNotGenerateAcw=true)]
		public partial class Values : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Persist$Values", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Values); }
			}

			protected Values (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist.Values']/constructor[@name='Persist.Values' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Values () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Values)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Persist", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Persist); }
		}

		protected Persist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/constructor[@name='Persist' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Persist () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Persist)) {
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

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V", "")]
		public static void B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V", "")]
		public static void C (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Persist']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V", "")]
		public static void D (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

	}
}
