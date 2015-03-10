using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Helper", DoNotGenerateAcw=true)]
	public partial class Helper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessageIndex']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Helper$MessageIndex", DoNotGenerateAcw=true)]
		public partial class MessageIndex : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Helper$MessageIndex", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageIndex); }
			}

			protected MessageIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_Integer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessageIndex']/constructor[@name='Helper.MessageIndex' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Integer']]"
			[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/Integer;)V", "")]
			public MessageIndex (global::Android.Net.Uri p0, global::Java.Lang.Integer p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MessageIndex)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Ljava/lang/Integer;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Landroid_net_Uri_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Integer_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_Integer_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessageIndex']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Landroid/net/Uri;", "")]
			public global::Android.Net.Uri A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessageIndex']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/lang/Integer;", "")]
			public global::Java.Lang.Integer B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Helper$MessagePartPath", DoNotGenerateAcw=true)]
		public partial class MessagePartPath : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Helper$MessagePartPath", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessagePartPath); }
			}

			protected MessagePartPath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/constructor[@name='Helper.MessagePartPath' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V", "")]
			public MessagePartPath (global::Android.Net.Uri p0, global::Android.Net.Uri p1, global::Java.Lang.Long p2, global::Java.Lang.Long p3, string p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p4 = JNIEnv.NewString (p4);;
				if (GetType () != typeof (MessagePartPath)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
					JNIEnv.DeleteLocalRef (native_p4);
					return;
				}

				if (id_ctor_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Landroid_net_Uri_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
				JNIEnv.DeleteLocalRef (native_p4);
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Landroid/net/Uri;", "")]
			public global::Android.Net.Uri A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Landroid/net/Uri;", "")]
			public global::Android.Net.Uri B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Ljava/lang/Long;", "")]
			public global::Java.Lang.Long C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Long;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()Ljava/lang/Long;", "")]
			public global::Java.Lang.Long D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/Long;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_e;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper.MessagePartPath']/method[@name='e' and count(parameter)=0]"
			[Register ("e", "()Ljava/lang/String;", "")]
			public string E ()
			{
				if (id_e == IntPtr.Zero)
					id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Helper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Helper); }
		}

		protected Helper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/constructor[@name='Helper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Helper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Helper)) {
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

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.ConversationParticipantImpl']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.ObjectType'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Date']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType p1, global::Java.Lang.Long p2, string p3, global::Java.Util.Date p4)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.ObjectType'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Date']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.ObjectType p1, global::Java.Lang.Long p2, string p3, global::Java.Util.Date p4)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncableChange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.SyncableChange']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncableChange;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncableChange;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncableChange_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.SyncedChange']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/Conversation;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Messaging.Conversation p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.messaging.Message']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/Message;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Messaging.Message p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_Message_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_MessagePart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.messaging.MessagePart']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/MessagePart;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Messaging.MessagePart p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_MessagePart_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_MessagePart_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/messaging/MessagePart;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_messaging_MessagePart_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Iterable']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.IIterable p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Iterable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Iterable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/UUID;", "")]
		public static global::Java.Util.UUID A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/UUID;");
			global::Java.Util.UUID __ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Integer;)Z", "")]
		public static bool A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, global::Java.Lang.Integer p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Integer;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, global::Java.Lang.Integer p2, global::Java.Lang.Integer p3)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Long;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, global::Java.Lang.Long p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, string p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Z)Ljava/lang/Boolean;", "")]
		public static global::Java.Lang.Boolean A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, bool p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Z == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Z)Ljava/lang/Boolean;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Boolean']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, global::Java.Lang.Boolean p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/Boolean;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public static global::Java.Lang.Integer A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, global::Java.Lang.Long p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Integer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_Long_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String[]']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string p2, string p3, string[] p4)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string[] p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.util.List']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/List;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Net.Uri> A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_List_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_List_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.util.UUID']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Util.UUID p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;Ljava/lang/Integer;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Util.UUID p1, global::Java.Lang.Integer p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;Ljava/lang/Integer;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;Ljava/lang/Long;)V", "")]
		public static void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Util.UUID p1, global::Java.Lang.Long p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_Ljava_lang_Long_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath> B (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public static global::Java.Lang.Integer B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Long']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Long;)V", "")]
		public static void B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, global::Java.Lang.Long p2)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", "")]
		public static void B (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string[] p2)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public static void C (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long C (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public static global::Java.Lang.Boolean C (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public static void D (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void D (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='e' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public static void E (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void E (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Net.Uri> F (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_f_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void F (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='g' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public static void G (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void G (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='h' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Models.StreamSeq> H (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Models.StreamSeq> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Models.StreamSeq>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_h_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='h' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void H (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='i' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/LinkedList;", "")]
		public static global::Java.Util.LinkedList I (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/LinkedList;");
			global::Java.Util.LinkedList __ret = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_i_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='i' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void I (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='j' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/LinkedList;", "")]
		public static global::Java.Util.LinkedList J (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/LinkedList;");
			global::Java.Util.LinkedList __ret = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_j_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='j' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public static void J (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='k' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("k", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri K (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "k", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='l' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri L (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='m' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("m", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri M (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "m", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='n' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri N (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='o' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Net.Uri> O (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='p' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("p", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> P (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "p", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='q' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("q", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public static global::Java.Lang.Integer Q (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "q", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='r' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("r", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri R (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "r", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Helper']/method[@name='s' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("s", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long S (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "s", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
