using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/CachingInboundReconPersistence", DoNotGenerateAcw=true)]
	public partial class CachingInboundReconPersistence : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/CachingInboundReconPersistence", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CachingInboundReconPersistence); }
		}

		protected CachingInboundReconPersistence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> A (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.SyncedChange']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V", "")]
		public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;", "")]
		public string A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, string p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> B (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> C (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_c_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public void D (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri D (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl E (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallObjectMethod  (Handle, id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri F (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void G (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='h' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void H (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='i' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri I (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='j' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl J (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> (JNIEnv.CallObjectMethod  (Handle, id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='CachingInboundReconPersistence']/method[@name='l' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void L (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

	}
}
