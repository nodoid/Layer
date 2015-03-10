using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/SyncPersistence", DoNotGenerateAcw=true)]
	public partial class SyncPersistence : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Content.ContentManager.IPersistence, global::Com.Layer.Sdk.Internal.Persistence.IChangeablePersistence, global::Com.Layer.Sdk.Internal.Syncrecon.Readcounter.IPersistence, global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/SyncPersistence", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncPersistence); }
		}

		protected SyncPersistence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/constructor[@name='SyncPersistence' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public SyncPersistence (global::Android.Content.Context p0, string p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SyncPersistence)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()J", "")]
		public long A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_a);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> A (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.SyncedChange']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V", "")]
		public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/syncrecon/SyncedChange;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_syncrecon_SyncedChange_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;", "")]
		public string A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, string p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", "")]
		public void A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl A (global::Android.Net.Uri p0)
		{
			if (id_a_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallObjectMethod  (Handle, id_a_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.models.ConversationParticipantImpl']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl p0)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_ConversationParticipantImpl_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.ObjectType'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.KeyType']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> A (global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType p0, global::Java.Lang.Long p1, global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType p2)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.ObjectType'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.KeyType']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$KeyType;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> A (global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.ObjectType p0, global::Java.Lang.Long p1, global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.KeyType p2)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$KeyType;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.ObjectType'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date']]"
		[Register ("a", "(Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.ObjectType p0, global::Java.Lang.Long p1, string p2, global::Java.Util.Date p3)
		{
			if (id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Ljava_lang_String_Ljava_util_Date_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.SyncableChange']]"
		[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange;)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange p0)
		{
			if (id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/SyncableChange;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_SyncableChange_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Conversation;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/Message;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_layer_sdk_messaging_MessagePart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart']]"
		[Register ("a", "(Lcom/layer/sdk/messaging/MessagePart;)V", "")]
		public void A (global::Com.Layer.Sdk.Messaging.MessagePart p0)
		{
			if (id_a_Lcom_layer_sdk_messaging_MessagePart_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_messaging_MessagePart_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/messaging/MessagePart;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_messaging_MessagePart_, new JValue (p0));
		}

		static IntPtr id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart.TransferStatus...']]"
		[Register ("a", "([Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> A (params global:: Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] p0)
		{
			if (id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ == IntPtr.Zero)
				id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ = JNIEnv.GetMethodID (class_ref, "a", "([Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)V", "")]
		public void A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0)
		{
			if (id_a_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_a_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/util/Set;", "")]
		public global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> A (global::Java.Lang.Long p0, global::Java.Lang.Integer p1, global::Java.Lang.Integer p2)
		{
			if (id_a_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Long_Ljava_lang_Integer_Ljava_lang_Integer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/Long;Ljava/lang/Long;)V", "")]
		public void A (global::Java.Lang.Long p0, global::Java.Lang.Long p1)
		{
			if (id_a_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Long;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public global::Java.Lang.Boolean A (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer A (string p0, global::Java.Lang.Long p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> A (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_a_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_UUID_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.lang.Long']]"
		[Register ("a", "(Ljava/util/UUID;Ljava/lang/Long;)V", "")]
		public void A (global::Java.Util.UUID p0, global::Java.Lang.Long p1)
		{
			if (id_a_Ljava_util_UUID_Ljava_lang_Long_ == IntPtr.Zero)
				id_a_Ljava_util_UUID_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/UUID;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_UUID_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath> B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessagePartPath>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> B (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl B (global::Android.Net.Uri p0)
		{
			if (id_b_Landroid_net_Uri_ == IntPtr.Zero)
				id_b_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallObjectMethod  (Handle, id_b_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("b", "(Ljava/lang/Iterable;)V", "")]
		public void B (global::Java.Lang.IIterable p0)
		{
			if (id_b_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_b_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_b_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Java.Lang.Long p0)
		{
			if (id_b_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long']]"
		[Register ("b", "(Ljava/lang/Long;Ljava/lang/Long;)V", "")]
		public void B (global::Java.Lang.Long p0, global::Java.Lang.Long p1)
		{
			if (id_b_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_b_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Long;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Long_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public void B (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("b", "(Ljava/util/UUID;)V", "")]
		public void B (global::Java.Util.UUID p0)
		{
			if (id_b_Ljava_util_UUID_ == IntPtr.Zero)
				id_b_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/UUID;)V");
			JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_util_UUID_, new JValue (p0));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> C (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_c_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("c", "(Ljava/lang/Iterable;)V", "")]
		public void C (global::Java.Lang.IIterable p0)
		{
			if (id_c_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_c_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("c", "(Ljava/lang/Long;)V", "")]
		public void C (global::Java.Lang.Long p0)
		{
			if (id_c_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		public global::Java.Lang.Long C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_c_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_c_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("c", "(Ljava/util/UUID;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl C (global::Java.Util.UUID p0)
		{
			if (id_c_Ljava_util_UUID_ == IntPtr.Zero)
				id_c_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/util/UUID;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallObjectMethod  (Handle, id_c_Ljava_util_UUID_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public void D (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri D (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("d", "(Ljava/lang/Iterable;)V", "")]
		public void D (global::Java.Lang.IIterable p0)
		{
			if (id_d_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_d_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_d_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("d", "(Ljava/lang/Long;)V", "")]
		public void D (global::Java.Lang.Long p0)
		{
			if (id_d_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Android.Net.Uri> D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_d_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_e);
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public void E (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_e_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl E (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallObjectMethod  (Handle, id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_e_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("e", "(Ljava/lang/Iterable;)V", "")]
		public void E (global::Java.Lang.IIterable p0)
		{
			if (id_e_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_e_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Iterable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_Iterable_, new JValue (p0));
		}

		static IntPtr id_e_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("e", "(Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer E (global::Java.Lang.Long p0)
		{
			if (id_e_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Long;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_e_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_f);
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public void F (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_f_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri F (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_f_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_f_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='f' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("f", "(Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public global::Java.Lang.Boolean F (string p0)
		{
			if (id_f_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "f", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_f_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		public void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_g);
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void G (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "")]
		public void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_h);
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='h' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void H (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_h_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='h' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("h", "(Ljava/lang/Long;)V", "")]
		public void H (global::Java.Lang.Long p0)
		{
			if (id_h_Ljava_lang_Long_ == IntPtr.Zero)
				id_h_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "h", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_h_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "")]
		public void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_i);
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='i' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri I (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_i_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("i", "(Ljava/lang/Long;)Ljava/lang/Long;", "")]
		public global::Java.Lang.Long I (global::Java.Lang.Long p0)
		{
			if (id_i_Ljava_lang_Long_ == IntPtr.Zero)
				id_i_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/Long;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_i_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()V", "")]
		public void J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_j);
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='j' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl J (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> (JNIEnv.CallObjectMethod  (Handle, id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='j' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("j", "(Ljava/lang/Long;)Ljava/lang/Integer;", "")]
		public global::Java.Lang.Integer J (global::Java.Lang.Long p0)
		{
			if (id_j_Ljava_lang_Long_ == IntPtr.Zero)
				id_j_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "j", "(Ljava/lang/Long;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_j_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Landroid/database/sqlite/SQLiteDatabase;", "")]
		public global::Android.Database.Sqlite.SQLiteDatabase K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Landroid/database/sqlite/SQLiteDatabase;");
			return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_k_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='k' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("k", "(Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri K (global::Java.Lang.Long p0)
		{
			if (id_k_Ljava_lang_Long_ == IntPtr.Zero)
				id_k_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "k", "(Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_k_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Models.StreamSeq> L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Models.StreamSeq>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='l' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V", "")]
		public void L (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_l_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='l' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("l", "(Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri L (global::Java.Lang.Long p0)
		{
			if (id_l_Ljava_lang_Long_ == IntPtr.Zero)
				id_l_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "l", "(Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_l_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_m_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='m' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("m", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl M (global::Java.Lang.Long p0)
		{
			if (id_m_Ljava_lang_Long_ == IntPtr.Zero)
				id_m_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "m", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallObjectMethod  (Handle, id_m_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_n;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> N ()
		{
			if (id_n == IntPtr.Zero)
				id_n = JNIEnv.GetMethodID (class_ref, "n", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_n), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='n' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> N (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Persistence.Sync.Helper.MessageIndex>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_n_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='n' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("n", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageRecipientImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl N (global::Java.Lang.Long p0)
		{
			if (id_n_Ljava_lang_Long_ == IntPtr.Zero)
				id_n_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "n", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageRecipientImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> (JNIEnv.CallObjectMethod  (Handle, id_n_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='o' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri O (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Landroid/net/Uri;");
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_o_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='o' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("o", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl;", "")]
		public global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl O (global::Java.Lang.Long p0)
		{
			if (id_o_Ljava_lang_Long_ == IntPtr.Zero)
				id_o_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "o", "(Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> (JNIEnv.CallObjectMethod  (Handle, id_o_Ljava_lang_Long_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_p_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='p' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("p", "(Ljava/lang/Long;)V", "")]
		public void P (global::Java.Lang.Long p0)
		{
			if (id_p_Ljava_lang_Long_ == IntPtr.Zero)
				id_p_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "p", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_p_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_q_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='q' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("q", "(Ljava/lang/Long;)V", "")]
		public void Q (global::Java.Lang.Long p0)
		{
			if (id_q_Ljava_lang_Long_ == IntPtr.Zero)
				id_q_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "q", "(Ljava/lang/Long;)V");
			JNIEnv.CallVoidMethod  (Handle, id_q_Ljava_lang_Long_, new JValue (p0));
		}

		static IntPtr id_r;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='r' and count(parameter)=0]"
		[Register ("r", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange> R ()
		{
			if (id_r == IntPtr.Zero)
				id_r = JNIEnv.GetMethodID (class_ref, "r", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_r), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_s;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='s' and count(parameter)=0]"
		[Register ("s", "()Ljava/util/LinkedList;", "")]
		public global::Java.Util.LinkedList S ()
		{
			if (id_s == IntPtr.Zero)
				id_s = JNIEnv.GetMethodID (class_ref, "s", "()Ljava/util/LinkedList;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (JNIEnv.CallObjectMethod  (Handle, id_s), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_t;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='t' and count(parameter)=0]"
		[Register ("t", "()Ljava/util/LinkedList;", "")]
		public global::Java.Util.LinkedList T ()
		{
			if (id_t == IntPtr.Zero)
				id_t = JNIEnv.GetMethodID (class_ref, "t", "()Ljava/util/LinkedList;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (JNIEnv.CallObjectMethod  (Handle, id_t), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence']/class[@name='SyncPersistence']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()V", "")]
		public void U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_u);
		}

	}
}
