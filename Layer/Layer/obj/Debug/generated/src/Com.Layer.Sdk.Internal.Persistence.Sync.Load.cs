using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Persistence.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Load", DoNotGenerateAcw=true)]
	public partial class Load : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.CursorToModel']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Load$CursorToModel", DoNotGenerateAcw=true)]
		public partial class CursorToModel : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Load$CursorToModel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CursorToModel); }
			}

			protected CursorToModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.CursorToModel']/constructor[@name='Load.CursorToModel' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public CursorToModel () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CursorToModel)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.Cursors']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Load$Cursors", DoNotGenerateAcw=true)]
		public partial class Cursors : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Load$Cursors", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Cursors); }
			}

			protected Cursors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.Cursors']/constructor[@name='Load.Cursors' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Cursors () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Cursors)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.Hydrate']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/persistence/sync/Load$Hydrate", DoNotGenerateAcw=true)]
		public partial class Hydrate : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Load$Hydrate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Hydrate); }
			}

			protected Hydrate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load.Hydrate']/constructor[@name='Load.Hydrate' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Hydrate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Hydrate)) {
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
				return JNIEnv.FindClass ("com/layer/sdk/internal/persistence/sync/Load", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Load); }
		}

		protected Load (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/constructor[@name='Load' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Load () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Load)) {
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

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Android.Net.Uri p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.ObjectType'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.layer.sdk.internal.messaging.models.LocalKeyedValueImpl.KeyType']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.ObjectType p1, global::Java.Lang.Long p2, global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl.KeyType p3)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl$KeyType;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_LocalKeyedValueImpl_KeyType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.ObjectType'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.layer.sdk.internal.messaging.models.RemoteKeyedValueImpl.KeyType']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$KeyType;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.ObjectType p1, global::Java.Lang.Long p2, global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl.KeyType p3)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$ObjectType;Ljava/lang/Long;Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl$KeyType;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_ObjectType_Ljava_lang_Long_Lcom_layer_sdk_internal_messaging_models_RemoteKeyedValueImpl_KeyType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='com.layer.sdk.messaging.MessagePart.TransferStatus...']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;[Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> A (global::Android.Database.Sqlite.SQLiteDatabase p0, params global:: Com.Layer.Sdk.Messaging.MessagePart.TransferStatus[] p1)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;[Lcom/layer/sdk/messaging/MessagePart$TransferStatus;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_arrayLcom_layer_sdk_messaging_MessagePart_TransferStatus_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='boolean']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Z)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, bool p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Z == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Z)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Z, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl A (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1, string p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;Ljava/lang/String;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> A (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string[] p2)
		{
			if (id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='android.net.Uri']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Android.Net.Uri p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/net/Uri;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Landroid_net_Uri_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> B (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string[] p2)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.util.UUID']]"
		[Register ("b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl B (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Util.UUID p1)
		{
			if (id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_ == IntPtr.Zero)
				id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/util/UUID;)Lcom/layer/sdk/internal/messaging/models/ConversationImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_database_sqlite_SQLiteDatabase_Ljava_util_UUID_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<string> C (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, string> D (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_d_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='e' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange> E (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncableChange>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_e_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static string E (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_e_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_f_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("f", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> F (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_f_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_f_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_f_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='g' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> G (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_g_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Transport.Thrift.Sync.Content> G (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Transport.Thrift.Sync.Content> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Transport.Thrift.Sync.Content>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_g_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='h' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> H (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Syncrecon.SyncedChange>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_h_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='h' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> H (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_h_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='i' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> I (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_i_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='i' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, string> I (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_i_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='j' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/lang/Long;", "")]
		public static global::Java.Lang.Long J (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_j_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='j' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> J (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_j_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='k' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("k", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl K (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "k", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_k_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='l' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl L (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "l", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/ConversationParticipantImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.ConversationParticipantImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_l_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='m' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("m", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl M (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "m", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_m_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='n' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl N (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "n", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_n_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='o' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> O (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "o", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Messaging.Models.MessagePartImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_o_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='p' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("p", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageRecipientImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl P (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "p", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/MessageRecipientImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_p_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='q' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("q", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> Q (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "q", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl> __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Layer.Sdk.Internal.Messaging.Models.MessageRecipientImpl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_q_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='r' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("r", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl R (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "r", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/LocalKeyedValueImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.LocalKeyedValueImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_r_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.persistence.sync']/class[@name='Load']/method[@name='s' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.Long']]"
		[Register ("s", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;", "")]
		public static global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl S (global::Android.Database.Sqlite.SQLiteDatabase p0, global::Java.Lang.Long p1)
		{
			if (id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ == IntPtr.Zero)
				id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "s", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/Long;)Lcom/layer/sdk/internal/messaging/models/RemoteKeyedValueImpl;");
			global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.Models.RemoteKeyedValueImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_s_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_Long_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
