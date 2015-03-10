using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Reindexer']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/Reindexer", DoNotGenerateAcw=true)]
	public partial class Reindexer : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Reindexer.Persistence']"
		[Register ("com/layer/sdk/internal/syncrecon/Reindexer$Persistence", "", "Com.Layer.Sdk.Internal.Syncrecon.Reindexer/IPersistenceInvoker")]
		public partial interface IPersistence : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Reindexer.Persistence']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
			[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "GetF_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Syncrecon.Reindexer/IPersistenceInvoker, Layer")]
			global::Android.Net.Uri F (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Reindexer.Persistence']/method[@name='n' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
			[Register ("n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "GetN_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Syncrecon.Reindexer/IPersistenceInvoker, Layer")]
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> N (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='Reindexer.Persistence']/method[@name='o' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
			[Register ("o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "GetO_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler:Com.Layer.Sdk.Internal.Syncrecon.Reindexer/IPersistenceInvoker, Layer")]
			global::Android.Net.Uri O (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/Reindexer$Persistence", DoNotGenerateAcw=true)]
		internal class IPersistenceInvoker : global::Java.Lang.Object, IPersistence {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/Reindexer$Persistence");
			IntPtr class_ref;

			public static IPersistence GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPersistence> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.Reindexer.Persistence"));
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

			static Delegate cb_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetF_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler ()
			{
				if (cb_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == null)
					cb_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_F_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_);
				return cb_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			}

			static IntPtr n_F_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.F (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			public global::Android.Net.Uri F (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
			{
				if (id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
					id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetN_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler ()
			{
				if (cb_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == null)
					cb_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_N_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_);
				return cb_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			}

			static IntPtr n_N_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex>.ToLocalJniHandle (__this.N (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> N (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
			{
				if (id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
					id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
				global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetO_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Handler ()
			{
				if (cb_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == null)
					cb_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_O_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_);
				return cb_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			}

			static IntPtr n_O_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.O (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
			public global::Android.Net.Uri O (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
			{
				if (id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
					id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/Reindexer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Reindexer); }
		}

		protected Reindexer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Reindexer']/constructor[@name='Reindexer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Reindexer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Reindexer)) {
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

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_Lcom_layer_sdk_internal_syncrecon_Reindexer_Persistence_Lcom_layer_sdk_internal_messaging_ChangeableCache_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='Reindexer']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable'] and parameter[3][@type='com.layer.sdk.internal.syncrecon.Reindexer.Persistence'] and parameter[4][@type='com.layer.sdk.internal.messaging.ChangeableCache'] and parameter[5][@type='com.layer.sdk.internal.messaging.ChangeableTransaction']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;Lcom/layer/sdk/internal/syncrecon/Reindexer$Persistence;Lcom/layer/sdk/internal/messaging/ChangeableCache;Lcom/layer/sdk/internal/messaging/ChangeableTransaction;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1, global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence p2, global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache p3, global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p4)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_Lcom_layer_sdk_internal_syncrecon_Reindexer_Persistence_Lcom_layer_sdk_internal_messaging_ChangeableCache_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_Lcom_layer_sdk_internal_syncrecon_Reindexer_Persistence_Lcom_layer_sdk_internal_messaging_ChangeableCache_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;Lcom/layer/sdk/internal/syncrecon/Reindexer$Persistence;Lcom/layer/sdk/internal/messaging/ChangeableCache;Lcom/layer/sdk/internal/messaging/ChangeableTransaction;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_Lcom_layer_sdk_internal_syncrecon_Reindexer_Persistence_Lcom_layer_sdk_internal_messaging_ChangeableCache_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}
}
