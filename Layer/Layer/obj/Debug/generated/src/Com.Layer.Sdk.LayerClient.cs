using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']"
	[global::Android.Runtime.Register ("com/layer/sdk/LayerClient", DoNotGenerateAcw=true)]
	public abstract partial class LayerClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.DeletionMode']"
		[global::Android.Runtime.Register ("com/layer/sdk/LayerClient$DeletionMode", DoNotGenerateAcw=true)]
		public sealed partial class DeletionMode : global::Java.Lang.Enum {


			static IntPtr ALL_PARTICIPANTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.DeletionMode']/field[@name='ALL_PARTICIPANTS']"
			[Register ("ALL_PARTICIPANTS")]
			public static global::Com.Layer.Sdk.LayerClient.DeletionMode AllParticipants {
				get {
					if (ALL_PARTICIPANTS_jfieldId == IntPtr.Zero)
						ALL_PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_PARTICIPANTS", "Lcom/layer/sdk/LayerClient$DeletionMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_PARTICIPANTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALL_PARTICIPANTS_jfieldId == IntPtr.Zero)
						ALL_PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_PARTICIPANTS", "Lcom/layer/sdk/LayerClient$DeletionMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALL_PARTICIPANTS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOCAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.DeletionMode']/field[@name='LOCAL']"
			[Register ("LOCAL")]
			public static global::Com.Layer.Sdk.LayerClient.DeletionMode Local {
				get {
					if (LOCAL_jfieldId == IntPtr.Zero)
						LOCAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCAL", "Lcom/layer/sdk/LayerClient$DeletionMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOCAL_jfieldId == IntPtr.Zero)
						LOCAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCAL", "Lcom/layer/sdk/LayerClient$DeletionMode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOCAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/LayerClient$DeletionMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeletionMode); }
			}

			internal DeletionMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.DeletionMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$DeletionMode;", "")]
			public static global::Com.Layer.Sdk.LayerClient.DeletionMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$DeletionMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.LayerClient.DeletionMode __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.DeletionMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/LayerClient$DeletionMode;", "")]
			public static global::Com.Layer.Sdk.LayerClient.DeletionMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/LayerClient$DeletionMode;");
				return (global::Com.Layer.Sdk.LayerClient.DeletionMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.LayerClient.DeletionMode));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']"
		[global::Android.Runtime.Register ("com/layer/sdk/LayerClient$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {


			static IntPtr DETAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/field[@name='DETAILED']"
			[Register ("DETAILED")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel Detailed {
				get {
					if (DETAILED_jfieldId == IntPtr.Zero)
						DETAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DETAILED", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DETAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DETAILED_jfieldId == IntPtr.Zero)
						DETAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DETAILED", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DETAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MINIMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/field[@name='MINIMAL']"
			[Register ("MINIMAL")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel Minimal {
				get {
					if (MINIMAL_jfieldId == IntPtr.Zero)
						MINIMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINIMAL", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MINIMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MINIMAL_jfieldId == IntPtr.Zero)
						MINIMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINIMAL", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MINIMAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERBOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel Verbose {
				get {
					if (VERBOSE_jfieldId == IntPtr.Zero)
						VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERBOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERBOSE_jfieldId == IntPtr.Zero)
						VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/layer/sdk/LayerClient$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERBOSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/LayerClient$LogLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LogLevel); }
			}

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$LogLevel;", "")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$LogLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.LayerClient.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/LayerClient$LogLevel;", "")]
			public static global::Com.Layer.Sdk.LayerClient.LogLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/LayerClient$LogLevel;");
				return (global::Com.Layer.Sdk.LayerClient.LogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.LayerClient.LogLevel));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']"
		[global::Android.Runtime.Register ("com/layer/sdk/LayerClient$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object, global::Java.Lang.ICloneable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/LayerClient$Options", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Options); }
			}

			internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/constructor[@name='LayerClient.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Options () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Options)) {
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

			static IntPtr id_getGoogleCloudMessagingSenderId;
			public string GoogleCloudMessagingSenderId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/method[@name='getGoogleCloudMessagingSenderId' and count(parameter)=0]"
				[Register ("getGoogleCloudMessagingSenderId", "()Ljava/lang/String;", "GetGetGoogleCloudMessagingSenderIdHandler")]
				get {
					if (id_getGoogleCloudMessagingSenderId == IntPtr.Zero)
						id_getGoogleCloudMessagingSenderId = JNIEnv.GetMethodID (class_ref, "getGoogleCloudMessagingSenderId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGoogleCloudMessagingSenderId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_isBroadcastPushInForeground;
			public bool IsBroadcastPushInForeground {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/method[@name='isBroadcastPushInForeground' and count(parameter)=0]"
				[Register ("isBroadcastPushInForeground", "()Z", "GetIsBroadcastPushInForegroundHandler")]
				get {
					if (id_isBroadcastPushInForeground == IntPtr.Zero)
						id_isBroadcastPushInForeground = JNIEnv.GetMethodID (class_ref, "isBroadcastPushInForeground", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isBroadcastPushInForeground);
				}
			}

			static IntPtr id_broadcastPushInForeground_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/method[@name='broadcastPushInForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("broadcastPushInForeground", "(Z)Lcom/layer/sdk/LayerClient$Options;", "")]
			public global::Com.Layer.Sdk.LayerClient.Options BroadcastPushInForeground (bool p0)
			{
				if (id_broadcastPushInForeground_Z == IntPtr.Zero)
					id_broadcastPushInForeground_Z = JNIEnv.GetMethodID (class_ref, "broadcastPushInForeground", "(Z)Lcom/layer/sdk/LayerClient$Options;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.Options> (JNIEnv.CallObjectMethod  (Handle, id_broadcastPushInForeground_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Lcom/layer/sdk/LayerClient$Options;", "")]
			public global::Com.Layer.Sdk.LayerClient.Options Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/layer/sdk/LayerClient$Options;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.Options> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_googleCloudMessagingSenderId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient.Options']/method[@name='googleCloudMessagingSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("googleCloudMessagingSenderId", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$Options;", "")]
			public global::Com.Layer.Sdk.LayerClient.Options InvokeGoogleCloudMessagingSenderId (string p0)
			{
				if (id_googleCloudMessagingSenderId_Ljava_lang_String_ == IntPtr.Zero)
					id_googleCloudMessagingSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "googleCloudMessagingSenderId", "(Ljava/lang/String;)Lcom/layer/sdk/LayerClient$Options;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.LayerClient.Options __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.Options> (JNIEnv.CallObjectMethod  (Handle, id_googleCloudMessagingSenderId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/LayerClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerClient); }
		}

		protected LayerClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/constructor[@name='LayerClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LayerClient () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LayerClient)) {
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

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppId);
		}
#pragma warning restore 0169

		public abstract global::Java.Util.UUID AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/util/UUID;", "GetGetAppIdHandler")] get;
		}

		static Delegate cb_getAuthenticatedUserId;
#pragma warning disable 0169
		static Delegate GetGetAuthenticatedUserIdHandler ()
		{
			if (cb_getAuthenticatedUserId == null)
				cb_getAuthenticatedUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticatedUserId);
			return cb_getAuthenticatedUserId;
		}

		static IntPtr n_GetAuthenticatedUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthenticatedUserId);
		}
#pragma warning restore 0169

		public abstract string AuthenticatedUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAuthenticatedUserId' and count(parameter)=0]"
			[Register ("getAuthenticatedUserId", "()Ljava/lang/String;", "GetGetAuthenticatedUserIdHandler")] get;
		}

		static Delegate cb_getAutoDownloadMimeTypes;
#pragma warning disable 0169
		static Delegate GetGetAutoDownloadMimeTypesHandler ()
		{
			if (cb_getAutoDownloadMimeTypes == null)
				cb_getAutoDownloadMimeTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAutoDownloadMimeTypes);
			return cb_getAutoDownloadMimeTypes;
		}

		static IntPtr n_GetAutoDownloadMimeTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AutoDownloadMimeTypes);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.ICollection<string> AutoDownloadMimeTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAutoDownloadMimeTypes' and count(parameter)=0]"
			[Register ("getAutoDownloadMimeTypes", "()Ljava/util/Set;", "GetGetAutoDownloadMimeTypesHandler")] get;
		}

		static Delegate cb_getAutoDownloadSizeThreshold;
#pragma warning disable 0169
		static Delegate GetGetAutoDownloadSizeThresholdHandler ()
		{
			if (cb_getAutoDownloadSizeThreshold == null)
				cb_getAutoDownloadSizeThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAutoDownloadSizeThreshold);
			return cb_getAutoDownloadSizeThreshold;
		}

		static long n_GetAutoDownloadSizeThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoDownloadSizeThreshold;
		}
#pragma warning restore 0169

		public abstract long AutoDownloadSizeThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAutoDownloadSizeThreshold' and count(parameter)=0]"
			[Register ("getAutoDownloadSizeThreshold", "()J", "GetGetAutoDownloadSizeThresholdHandler")] get;
		}

		static Delegate cb_getConversationIds;
#pragma warning disable 0169
		static Delegate GetGetConversationIdsHandler ()
		{
			if (cb_getConversationIds == null)
				cb_getConversationIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationIds);
			return cb_getConversationIds;
		}

		static IntPtr n_GetConversationIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.ConversationIds);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Android.Net.Uri> ConversationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversationIds' and count(parameter)=0]"
			[Register ("getConversationIds", "()Ljava/util/List;", "GetGetConversationIdsHandler")] get;
		}

		static Delegate cb_getConversations;
#pragma warning disable 0169
		static Delegate GetGetConversationsHandler ()
		{
			if (cb_getConversations == null)
				cb_getConversations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversations);
			return cb_getConversations;
		}

		static IntPtr n_GetConversations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.ToLocalJniHandle (__this.Conversations);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> Conversations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversations' and count(parameter)=0]"
			[Register ("getConversations", "()Ljava/util/List;", "GetGetConversationsHandler")] get;
		}

		static Delegate cb_getDiskCapacity;
#pragma warning disable 0169
		static Delegate GetGetDiskCapacityHandler ()
		{
			if (cb_getDiskCapacity == null)
				cb_getDiskCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDiskCapacity);
			return cb_getDiskCapacity;
		}

		static long n_GetDiskCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiskCapacity;
		}
#pragma warning restore 0169

		public abstract long DiskCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getDiskCapacity' and count(parameter)=0]"
			[Register ("getDiskCapacity", "()J", "GetGetDiskCapacityHandler")] get;
		}

		static Delegate cb_getDiskUtilization;
#pragma warning disable 0169
		static Delegate GetGetDiskUtilizationHandler ()
		{
			if (cb_getDiskUtilization == null)
				cb_getDiskUtilization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDiskUtilization);
			return cb_getDiskUtilization;
		}

		static long n_GetDiskUtilization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiskUtilization;
		}
#pragma warning restore 0169

		public abstract long DiskUtilization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getDiskUtilization' and count(parameter)=0]"
			[Register ("getDiskUtilization", "()J", "GetGetDiskUtilizationHandler")] get;
		}

		static Delegate cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticated);
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		public abstract bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")] get;
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public abstract bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")] get;
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public abstract bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")] get;
		}

		static Delegate cb_getPolicies;
#pragma warning disable 0169
		static Delegate GetGetPoliciesHandler ()
		{
			if (cb_getPolicies == null)
				cb_getPolicies = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolicies);
			return cb_getPolicies;
		}

		static IntPtr n_GetPolicies (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.ToLocalJniHandle (__this.Policies);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> Policies {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getPolicies' and count(parameter)=0]"
			[Register ("getPolicies", "()Ljava/util/List;", "GetGetPoliciesHandler")] get;
		}

		static Delegate cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_Handler ()
		{
			if (cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ == null)
				cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_);
			return cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
		}

		static void n_AddParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.AddParticipants (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='addParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String...']]"
		[Register ("addParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V", "GetAddParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_Handler")]
		public virtual void AddParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, params  string[] p1)
		{
			if (id_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler ()
		{
			if (cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ == null)
				cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_);
			return cb_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
		}

		static void n_AddParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddParticipants (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='addParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.List']]"
		[Register ("addParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V", "GetAddParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler")]
		public abstract void AddParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IList<string> p1);

		static Delegate cb_addPolicy_Lcom_layer_sdk_policy_Policy_;
#pragma warning disable 0169
		static Delegate GetAddPolicy_Lcom_layer_sdk_policy_Policy_Handler ()
		{
			if (cb_addPolicy_Lcom_layer_sdk_policy_Policy_ == null)
				cb_addPolicy_Lcom_layer_sdk_policy_Policy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddPolicy_Lcom_layer_sdk_policy_Policy_);
			return cb_addPolicy_Lcom_layer_sdk_policy_Policy_;
		}

		static bool n_AddPolicy_Lcom_layer_sdk_policy_Policy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Policy.Policy p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPolicy (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='addPolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("addPolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetAddPolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public abstract bool AddPolicy (global::Com.Layer.Sdk.Policy.Policy p0);

		static Delegate cb_answerAuthenticationChallenge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAnswerAuthenticationChallenge_Ljava_lang_String_Handler ()
		{
			if (cb_answerAuthenticationChallenge_Ljava_lang_String_ == null)
				cb_answerAuthenticationChallenge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnswerAuthenticationChallenge_Ljava_lang_String_);
			return cb_answerAuthenticationChallenge_Ljava_lang_String_;
		}

		static void n_AnswerAuthenticationChallenge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnswerAuthenticationChallenge (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='answerAuthenticationChallenge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("answerAuthenticationChallenge", "(Ljava/lang/String;)V", "GetAnswerAuthenticationChallenge_Ljava_lang_String_Handler")]
		public abstract void AnswerAuthenticationChallenge (string p0);

		static Delegate cb_authenticate;
#pragma warning disable 0169
		static Delegate GetAuthenticateHandler ()
		{
			if (cb_authenticate == null)
				cb_authenticate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Authenticate);
			return cb_authenticate;
		}

		static IntPtr n_Authenticate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Authenticate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='authenticate' and count(parameter)=0]"
		[Register ("authenticate", "()Lcom/layer/sdk/LayerClient;", "GetAuthenticateHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient Authenticate ();

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static IntPtr n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lcom/layer/sdk/LayerClient;", "GetConnectHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient Connect ();

		static Delegate cb_deauthenticate;
#pragma warning disable 0169
		static Delegate GetDeauthenticateHandler ()
		{
			if (cb_deauthenticate == null)
				cb_deauthenticate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Deauthenticate);
			return cb_deauthenticate;
		}

		static IntPtr n_Deauthenticate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Deauthenticate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deauthenticate' and count(parameter)=0]"
		[Register ("deauthenticate", "()Lcom/layer/sdk/LayerClient;", "GetDeauthenticateHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient Deauthenticate ();

		static Delegate cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteConversation_Lcom_layer_sdk_messaging_Conversation_);
			return cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_;
		}

		static void n_DeleteConversation_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteConversation' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;)V", "GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public abstract void DeleteConversation (global::Com.Layer.Sdk.Messaging.Conversation p0);

		static Delegate cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_;
#pragma warning disable 0169
		static Delegate GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_Handler ()
		{
			if (cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_ == null)
				cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_);
			return cb_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_;
		}

		static void n_DeleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversation (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteConversation' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public abstract void DeleteConversation (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.LayerClient.DeletionMode p1);

		static Delegate cb_deleteMessage_Lcom_layer_sdk_messaging_Message_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Handler ()
		{
			if (cb_deleteMessage_Lcom_layer_sdk_messaging_Message_ == null)
				cb_deleteMessage_Lcom_layer_sdk_messaging_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_layer_sdk_messaging_Message_);
			return cb_deleteMessage_Lcom_layer_sdk_messaging_Message_;
		}

		static void n_DeleteMessage_Lcom_layer_sdk_messaging_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("deleteMessage", "(Lcom/layer/sdk/messaging/Message;)V", "GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Handler")]
		public abstract void DeleteMessage (global::Com.Layer.Sdk.Messaging.Message p0);

		static Delegate cb_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_Handler ()
		{
			if (cb_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_ == null)
				cb_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_);
			return cb_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_;
		}

		static void n_DeleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.LayerClient.DeletionMode p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient.DeletionMode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteMessage' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("deleteMessage", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public abstract void DeleteMessage (global::Com.Layer.Sdk.Messaging.Message p0, global::Com.Layer.Sdk.LayerClient.DeletionMode p1);

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static IntPtr n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Lcom/layer/sdk/LayerClient;", "GetDisconnectHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient Disconnect ();

		static Delegate cb_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_;
#pragma warning disable 0169
		static Delegate GetExecuteQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_Handler ()
		{
			if (cb_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ == null)
				cb_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_);
			return cb_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_;
		}

		static IntPtr n_ExecuteQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query.ResultType p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query.ResultType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ExecuteQuery (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQuery' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Query'] and parameter[2][@type='com.layer.sdk.query.Query.ResultType']]"
		[Register ("executeQuery", "(Lcom/layer/sdk/query/Query;Lcom/layer/sdk/query/Query$ResultType;)Ljava/util/List;", "GetExecuteQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_Handler")]
		public abstract global::System.Collections.IList ExecuteQuery (global::Com.Layer.Sdk.Query.Query p0, global::Com.Layer.Sdk.Query.Query.ResultType p1);

		static Delegate cb_executeQueryForCount_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetExecuteQueryForCount_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_executeQueryForCount_Lcom_layer_sdk_query_Query_ == null)
				cb_executeQueryForCount_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteQueryForCount_Lcom_layer_sdk_query_Query_);
			return cb_executeQueryForCount_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_ExecuteQueryForCount_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteQueryForCount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForCount' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForCount", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;", "GetExecuteQueryForCount_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::Java.Lang.Long ExecuteQueryForCount (global::Com.Layer.Sdk.Query.Query p0);

		static Delegate cb_executeQueryForIds_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetExecuteQueryForIds_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_executeQueryForIds_Lcom_layer_sdk_query_Query_ == null)
				cb_executeQueryForIds_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteQueryForIds_Lcom_layer_sdk_query_Query_);
			return cb_executeQueryForIds_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_ExecuteQueryForIds_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.ExecuteQueryForIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForIds' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForIds", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetExecuteQueryForIds_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Android.Net.Uri> ExecuteQueryForIds (global::Com.Layer.Sdk.Query.Query p0);

		static Delegate cb_executeQueryForObjects_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetExecuteQueryForObjects_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_executeQueryForObjects_Lcom_layer_sdk_query_Query_ == null)
				cb_executeQueryForObjects_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteQueryForObjects_Lcom_layer_sdk_query_Query_);
			return cb_executeQueryForObjects_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_ExecuteQueryForObjects_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.IQueryable>.ToLocalJniHandle (__this.ExecuteQueryForObjects (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForObjects' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForObjects", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetExecuteQueryForObjects_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.IQueryable> ExecuteQueryForObjects (global::Com.Layer.Sdk.Query.Query p0);

		static Delegate cb_get_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_net_Uri_Handler ()
		{
			if (cb_get_Landroid_net_Uri_ == null)
				cb_get_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_net_Uri_);
			return cb_get_Landroid_net_Uri_;
		}

		static IntPtr n_Get_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("get", "(Landroid/net/Uri;)Lcom/layer/sdk/query/Queryable;", "GetGet_Landroid_net_Uri_Handler")]
		public abstract global::Com.Layer.Sdk.Query.IQueryable Get (global::Android.Net.Uri p0);

		static Delegate cb_getConversation_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetConversation_Landroid_net_Uri_Handler ()
		{
			if (cb_getConversation_Landroid_net_Uri_ == null)
				cb_getConversation_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversation_Landroid_net_Uri_);
			return cb_getConversation_Landroid_net_Uri_;
		}

		static IntPtr n_GetConversation_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getConversation", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Conversation;", "GetGetConversation_Landroid_net_Uri_Handler")]
		public abstract global::Com.Layer.Sdk.Messaging.Conversation GetConversation (global::Android.Net.Uri p0);

		static Delegate cb_getConversations_arrayLandroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetConversations_arrayLandroid_net_Uri_Handler ()
		{
			if (cb_getConversations_arrayLandroid_net_Uri_ == null)
				cb_getConversations_arrayLandroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversations_arrayLandroid_net_Uri_);
			return cb_getConversations_arrayLandroid_net_Uri_;
		}

		static IntPtr n_GetConversations_arrayLandroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri[] p0 = (global::Android.Net.Uri[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Net.Uri));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.ToLocalJniHandle (__this.GetConversations (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversations_arrayLandroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversations' and count(parameter)=1 and parameter[1][@type='android.net.Uri...']]"
		[Register ("getConversations", "([Landroid/net/Uri;)Ljava/util/List;", "GetGetConversations_arrayLandroid_net_Uri_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversations (params global:: Android.Net.Uri[] p0)
		{
			if (id_getConversations_arrayLandroid_net_Uri_ == IntPtr.Zero)
				id_getConversations_arrayLandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getConversations", "([Landroid/net/Uri;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversations_arrayLandroid_net_Uri_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversations", "([Landroid/net/Uri;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getConversations_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetConversations_Ljava_util_List_Handler ()
		{
			if (cb_getConversations_Ljava_util_List_ == null)
				cb_getConversations_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversations_Ljava_util_List_);
			return cb_getConversations_Ljava_util_List_;
		}

		static IntPtr n_GetConversations_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Net.Uri> p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.ToLocalJniHandle (__this.GetConversations (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversations' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getConversations", "(Ljava/util/List;)Ljava/util/List;", "GetGetConversations_Ljava_util_List_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversations (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0);

		static Delegate cb_getConversationsWithParticipants_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationsWithParticipants_arrayLjava_lang_String_Handler ()
		{
			if (cb_getConversationsWithParticipants_arrayLjava_lang_String_ == null)
				cb_getConversationsWithParticipants_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationsWithParticipants_arrayLjava_lang_String_);
			return cb_getConversationsWithParticipants_arrayLjava_lang_String_;
		}

		static IntPtr n_GetConversationsWithParticipants_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.ToLocalJniHandle (__this.GetConversationsWithParticipants (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationsWithParticipants_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversationsWithParticipants' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getConversationsWithParticipants", "([Ljava/lang/String;)Ljava/util/List;", "GetGetConversationsWithParticipants_arrayLjava_lang_String_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversationsWithParticipants (params  string[] p0)
		{
			if (id_getConversationsWithParticipants_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getConversationsWithParticipants_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationsWithParticipants", "([Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversationsWithParticipants_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationsWithParticipants", "([Ljava/lang/String;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getConversationsWithParticipants_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetConversationsWithParticipants_Ljava_util_List_Handler ()
		{
			if (cb_getConversationsWithParticipants_Ljava_util_List_ == null)
				cb_getConversationsWithParticipants_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationsWithParticipants_Ljava_util_List_);
			return cb_getConversationsWithParticipants_Ljava_util_List_;
		}

		static IntPtr n_GetConversationsWithParticipants_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.ToLocalJniHandle (__this.GetConversationsWithParticipants (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversationsWithParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getConversationsWithParticipants", "(Ljava/util/List;)Ljava/util/List;", "GetGetConversationsWithParticipants_Ljava_util_List_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversationsWithParticipants (global::System.Collections.Generic.IList<string> p0);

		static Delegate cb_getMessage_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetMessage_Landroid_net_Uri_Handler ()
		{
			if (cb_getMessage_Landroid_net_Uri_ == null)
				cb_getMessage_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessage_Landroid_net_Uri_);
			return cb_getMessage_Landroid_net_Uri_;
		}

		static IntPtr n_GetMessage_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getMessage", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Message;", "GetGetMessage_Landroid_net_Uri_Handler")]
		public abstract global::Com.Layer.Sdk.Messaging.Message GetMessage (global::Android.Net.Uri p0);

		static Delegate cb_getMessageIds_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetGetMessageIds_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_getMessageIds_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_getMessageIds_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageIds_Lcom_layer_sdk_messaging_Conversation_);
			return cb_getMessageIds_Lcom_layer_sdk_messaging_Conversation_;
		}

		static IntPtr n_GetMessageIds_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.GetMessageIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessageIds' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getMessageIds", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;", "GetGetMessageIds_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Android.Net.Uri> GetMessageIds (global::Com.Layer.Sdk.Messaging.Conversation p0);

		static Delegate cb_getMessages_arrayLandroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetMessages_arrayLandroid_net_Uri_Handler ()
		{
			if (cb_getMessages_arrayLandroid_net_Uri_ == null)
				cb_getMessages_arrayLandroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_arrayLandroid_net_Uri_);
			return cb_getMessages_arrayLandroid_net_Uri_;
		}

		static IntPtr n_GetMessages_arrayLandroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri[] p0 = (global::Android.Net.Uri[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Net.Uri));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.ToLocalJniHandle (__this.GetMessages (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_arrayLandroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='android.net.Uri...']]"
		[Register ("getMessages", "([Landroid/net/Uri;)Ljava/util/List;", "GetGetMessages_arrayLandroid_net_Uri_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> GetMessages (params global:: Android.Net.Uri[] p0)
		{
			if (id_getMessages_arrayLandroid_net_Uri_ == IntPtr.Zero)
				id_getMessages_arrayLandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getMessages", "([Landroid/net/Uri;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessages_arrayLandroid_net_Uri_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "([Landroid/net/Uri;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getMessages_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_getMessages_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_getMessages_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Lcom_layer_sdk_messaging_Conversation_);
			return cb_getMessages_Lcom_layer_sdk_messaging_Conversation_;
		}

		static IntPtr n_GetMessages_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.ToLocalJniHandle (__this.GetMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getMessages", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;", "GetGetMessages_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> GetMessages (global::Com.Layer.Sdk.Messaging.Conversation p0);

		static Delegate cb_getMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_util_List_Handler ()
		{
			if (cb_getMessages_Ljava_util_List_ == null)
				cb_getMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Ljava_util_List_);
			return cb_getMessages_Ljava_util_List_;
		}

		static IntPtr n_GetMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Net.Uri> p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.ToLocalJniHandle (__this.GetMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getMessages", "(Ljava/util/List;)Ljava/util/List;", "GetGetMessages_Ljava_util_List_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> GetMessages (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0);

		static Delegate cb_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_Handler ()
		{
			if (cb_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_ == null)
				cb_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_);
			return cb_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_;
		}

		static IntPtr n_GetUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUnreadMessageCount (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getUnreadMessageCount' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getUnreadMessageCount", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/lang/Integer;", "GetGetUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public abstract global::Java.Lang.Integer GetUnreadMessageCount (global::Com.Layer.Sdk.Messaging.Conversation p0);

		static Delegate cb_insertPolicy_Lcom_layer_sdk_policy_Policy_I;
#pragma warning disable 0169
		static Delegate GetInsertPolicy_Lcom_layer_sdk_policy_Policy_IHandler ()
		{
			if (cb_insertPolicy_Lcom_layer_sdk_policy_Policy_I == null)
				cb_insertPolicy_Lcom_layer_sdk_policy_Policy_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_InsertPolicy_Lcom_layer_sdk_policy_Policy_I);
			return cb_insertPolicy_Lcom_layer_sdk_policy_Policy_I;
		}

		static bool n_InsertPolicy_Lcom_layer_sdk_policy_Policy_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Policy.Policy p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InsertPolicy (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='insertPolicy' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.policy.Policy'] and parameter[2][@type='int']]"
		[Register ("insertPolicy", "(Lcom/layer/sdk/policy/Policy;I)Z", "GetInsertPolicy_Lcom_layer_sdk_policy_Policy_IHandler")]
		public abstract bool InsertPolicy (global::Com.Layer.Sdk.Policy.Policy p0, int p1);

		static Delegate cb_markMessageAsRead_Lcom_layer_sdk_messaging_Message_;
#pragma warning disable 0169
		static Delegate GetMarkMessageAsRead_Lcom_layer_sdk_messaging_Message_Handler ()
		{
			if (cb_markMessageAsRead_Lcom_layer_sdk_messaging_Message_ == null)
				cb_markMessageAsRead_Lcom_layer_sdk_messaging_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkMessageAsRead_Lcom_layer_sdk_messaging_Message_);
			return cb_markMessageAsRead_Lcom_layer_sdk_messaging_Message_;
		}

		static void n_MarkMessageAsRead_Lcom_layer_sdk_messaging_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkMessageAsRead (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='markMessageAsRead' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("markMessageAsRead", "(Lcom/layer/sdk/messaging/Message;)V", "GetMarkMessageAsRead_Lcom_layer_sdk_messaging_Message_Handler")]
		public abstract void MarkMessageAsRead (global::Com.Layer.Sdk.Messaging.Message p0);

		static Delegate cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_Handler ()
		{
			if (cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_ == null)
				cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_);
			return cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_;
		}

		static IntPtr n_NewConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.ConversationOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewConversation (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newConversation' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.ConversationOptions'] and parameter[2][@type='java.lang.String...']]"
		[Register ("newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;[Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;", "GetNewConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_Handler")]
		public virtual global::Com.Layer.Sdk.Messaging.Conversation NewConversation (global::Com.Layer.Sdk.Messaging.ConversationOptions p0, params  string[] p1)
		{
			if (id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_ == IntPtr.Zero)
				id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;[Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::Com.Layer.Sdk.Messaging.Conversation __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;[Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetNewConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_Handler ()
		{
			if (cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ == null)
				cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_);
			return cb_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_;
		}

		static IntPtr n_NewConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.ConversationOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.ConversationOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewConversation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newConversation' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.ConversationOptions'] and parameter[2][@type='java.util.List']]"
		[Register ("newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;", "GetNewConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_Handler")]
		public abstract global::Com.Layer.Sdk.Messaging.Conversation NewConversation (global::Com.Layer.Sdk.Messaging.ConversationOptions p0, global::System.Collections.Generic.IList<string> p1);

		static Delegate cb_newConversation_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewConversation_arrayLjava_lang_String_Handler ()
		{
			if (cb_newConversation_arrayLjava_lang_String_ == null)
				cb_newConversation_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewConversation_arrayLjava_lang_String_);
			return cb_newConversation_arrayLjava_lang_String_;
		}

		static IntPtr n_NewConversation_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewConversation (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newConversation_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("newConversation", "([Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;", "GetNewConversation_arrayLjava_lang_String_Handler")]
		public virtual global::Com.Layer.Sdk.Messaging.Conversation NewConversation (params  string[] p0)
		{
			if (id_newConversation_arrayLjava_lang_String_ == IntPtr.Zero)
				id_newConversation_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newConversation", "([Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Layer.Sdk.Messaging.Conversation __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_newConversation_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newConversation", "([Ljava/lang/String;)Lcom/layer/sdk/messaging/Conversation;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_newConversation_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetNewConversation_Ljava_util_List_Handler ()
		{
			if (cb_newConversation_Ljava_util_List_ == null)
				cb_newConversation_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewConversation_Ljava_util_List_);
			return cb_newConversation_Ljava_util_List_;
		}

		static IntPtr n_NewConversation_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newConversation_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newConversation' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("newConversation", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;", "GetNewConversation_Ljava_util_List_Handler")]
		public virtual global::Com.Layer.Sdk.Messaging.Conversation NewConversation (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_newConversation_Ljava_util_List_ == IntPtr.Zero)
				id_newConversation_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "newConversation", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			global::Com.Layer.Sdk.Messaging.Conversation __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_newConversation_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newConversation", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("newInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/layer/sdk/LayerClient;", "")]
		public static global::Com.Layer.Sdk.LayerClient NewInstance (global::Android.Content.Context p0, string p1)
		{
			if (id_newInstance_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/layer/sdk/LayerClient;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newInstance_Landroid_content_Context_Ljava_lang_String_Lcom_layer_sdk_LayerClient_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.layer.sdk.LayerClient.Options']]"
		[Register ("newInstance", "(Landroid/content/Context;Ljava/lang/String;Lcom/layer/sdk/LayerClient$Options;)Lcom/layer/sdk/LayerClient;", "")]
		public static global::Com.Layer.Sdk.LayerClient NewInstance (global::Android.Content.Context p0, string p1, global::Com.Layer.Sdk.LayerClient.Options p2)
		{
			if (id_newInstance_Landroid_content_Context_Ljava_lang_String_Lcom_layer_sdk_LayerClient_Options_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Ljava_lang_String_Lcom_layer_sdk_LayerClient_Options_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Ljava/lang/String;Lcom/layer/sdk/LayerClient$Options;)Lcom/layer/sdk/LayerClient;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Ljava_lang_String_Lcom_layer_sdk_LayerClient_Options_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newInstance_Landroid_content_Context_Ljava_util_UUID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.lang.String']]"
		[Register ("newInstance", "(Landroid/content/Context;Ljava/util/UUID;Ljava/lang/String;)Lcom/layer/sdk/LayerClient;", "")]
		public static global::Com.Layer.Sdk.LayerClient NewInstance (global::Android.Content.Context p0, global::Java.Util.UUID p1, string p2)
		{
			if (id_newInstance_Landroid_content_Context_Ljava_util_UUID_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Context_Ljava_util_UUID_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Context;Ljava/util/UUID;Ljava/lang/String;)Lcom/layer/sdk/LayerClient;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Context_Ljava_util_UUID_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_;
#pragma warning disable 0169
		static Delegate GetNewMessage_arrayLcom_layer_sdk_messaging_MessagePart_Handler ()
		{
			if (cb_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_ == null)
				cb_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewMessage_arrayLcom_layer_sdk_messaging_MessagePart_);
			return cb_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_;
		}

		static IntPtr n_NewMessage_arrayLcom_layer_sdk_messaging_MessagePart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart[] p0 = (global::Com.Layer.Sdk.Messaging.MessagePart[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Layer.Sdk.Messaging.MessagePart));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMessage (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessage' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.MessagePart...']]"
		[Register ("newMessage", "([Lcom/layer/sdk/messaging/MessagePart;)Lcom/layer/sdk/messaging/Message;", "GetNewMessage_arrayLcom_layer_sdk_messaging_MessagePart_Handler")]
		public virtual global::Com.Layer.Sdk.Messaging.Message NewMessage (params global:: Com.Layer.Sdk.Messaging.MessagePart[] p0)
		{
			if (id_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_ == IntPtr.Zero)
				id_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_ = JNIEnv.GetMethodID (class_ref, "newMessage", "([Lcom/layer/sdk/messaging/MessagePart;)Lcom/layer/sdk/messaging/Message;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Layer.Sdk.Messaging.Message __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_newMessage_arrayLcom_layer_sdk_messaging_MessagePart_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newMessage", "([Lcom/layer/sdk/messaging/MessagePart;)Lcom/layer/sdk/messaging/Message;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_newMessage_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetNewMessage_Ljava_util_List_Handler ()
		{
			if (cb_newMessage_Ljava_util_List_ == null)
				cb_newMessage_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewMessage_Ljava_util_List_);
			return cb_newMessage_Ljava_util_List_;
		}

		static IntPtr n_NewMessage_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Layer.Sdk.Messaging.MessagePart> p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessage' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("newMessage", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Message;", "GetNewMessage_Ljava_util_List_Handler")]
		public abstract global::Com.Layer.Sdk.Messaging.Message NewMessage (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> p0);

		static Delegate cb_newMessagePart_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewMessagePart_Ljava_lang_String_Handler ()
		{
			if (cb_newMessagePart_Ljava_lang_String_ == null)
				cb_newMessagePart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewMessagePart_Ljava_lang_String_);
			return cb_newMessagePart_Ljava_lang_String_;
		}

		static IntPtr n_NewMessagePart_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMessagePart (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newMessagePart_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessagePart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newMessagePart", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/MessagePart;", "GetNewMessagePart_Ljava_lang_String_Handler")]
		public virtual global::Com.Layer.Sdk.Messaging.MessagePart NewMessagePart (string p0)
		{
			if (id_newMessagePart_Ljava_lang_String_ == IntPtr.Zero)
				id_newMessagePart_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newMessagePart", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/MessagePart;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Layer.Sdk.Messaging.MessagePart __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (JNIEnv.CallObjectMethod  (Handle, id_newMessagePart_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newMessagePart", "(Ljava/lang/String;)Lcom/layer/sdk/messaging/MessagePart;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_newMessagePart_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetNewMessagePart_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_newMessagePart_Ljava_lang_String_arrayB == null)
				cb_newMessagePart_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewMessagePart_Ljava_lang_String_arrayB);
			return cb_newMessagePart_Ljava_lang_String_arrayB;
		}

		static IntPtr n_NewMessagePart_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMessagePart (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessagePart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("newMessagePart", "(Ljava/lang/String;[B)Lcom/layer/sdk/messaging/MessagePart;", "GetNewMessagePart_Ljava_lang_String_arrayBHandler")]
		public abstract global::Com.Layer.Sdk.Messaging.MessagePart NewMessagePart (string p0, byte[] p1);

		static Delegate cb_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J;
#pragma warning disable 0169
		static Delegate GetNewMessagePart_Ljava_lang_String_Ljava_io_InputStream_JHandler ()
		{
			if (cb_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J == null)
				cb_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_NewMessagePart_Ljava_lang_String_Ljava_io_InputStream_J);
			return cb_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J;
		}

		static IntPtr n_NewMessagePart_Ljava_lang_String_Ljava_io_InputStream_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMessagePart (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessagePart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='long']]"
		[Register ("newMessagePart", "(Ljava/lang/String;Ljava/io/InputStream;J)Lcom/layer/sdk/messaging/MessagePart;", "GetNewMessagePart_Ljava_lang_String_Ljava_io_InputStream_JHandler")]
		public abstract global::Com.Layer.Sdk.Messaging.MessagePart NewMessagePart (string p0, global::System.IO.Stream p1, long p2);

		static Delegate cb_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_;
#pragma warning disable 0169
		static Delegate GetNewRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_Handler ()
		{
			if (cb_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_ == null)
				cb_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_);
			return cb_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_;
		}

		static IntPtr n_NewRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p1 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback p2 = (global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewRecyclerViewController (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newRecyclerViewController' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.Query'] and parameter[2][@type='java.util.Collection'] and parameter[3][@type='com.layer.sdk.query.RecyclerViewController.Callback']]"
		[Register ("newRecyclerViewController", "(Lcom/layer/sdk/query/Query;Ljava/util/Collection;Lcom/layer/sdk/query/RecyclerViewController$Callback;)Lcom/layer/sdk/query/RecyclerViewController;", "GetNewRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_Handler")]
		public abstract global::Com.Layer.Sdk.Query.RecyclerViewController NewRecyclerViewController (global::Com.Layer.Sdk.Query.Query p0, global::System.Collections.Generic.ICollection<string> p1, global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback p2);

		static Delegate cb_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z;
#pragma warning disable 0169
		static Delegate GetPutMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_ZHandler ()
		{
			if (cb_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z == null)
				cb_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_PutMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z);
			return cb_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z;
		}

		static void n_PutMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadata (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='putMetadata' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='boolean']]"
		[Register ("putMetadata", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/Map;Z)V", "GetPutMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_ZHandler")]
		public abstract void PutMetadata (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, bool p2);

		static Delegate cb_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PutMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_);
			return cb_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PutMetadataAtKeyPath (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='putMetadataAtKeyPath' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("putMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;Ljava/lang/String;)V", "GetPutMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void PutMetadataAtKeyPath (global::Com.Layer.Sdk.Messaging.Conversation p0, string p1, string p2);

		static Delegate cb_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
#pragma warning disable 0169
		static Delegate GetRegisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler ()
		{
			if (cb_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ == null)
				cb_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_);
			return cb_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
		}

		static IntPtr n_RegisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterAuthenticationListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerAuthenticationListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerAuthenticationListener']]"
		[Register ("registerAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterAuthenticationListener (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0);

		static Delegate cb_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
#pragma warning disable 0169
		static Delegate GetRegisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler ()
		{
			if (cb_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ == null)
				cb_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_);
			return cb_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
		}

		static IntPtr n_RegisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterConnectionListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerConnectionListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerConnectionListener']]"
		[Register ("registerConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterConnectionListener (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0);

		static Delegate cb_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler ()
		{
			if (cb_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ == null)
				cb_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_);
			return cb_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
		}

		static IntPtr n_RegisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterEventListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerEventListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerChangeEventListener']]"
		[Register ("registerEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterEventListener (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0);

		static Delegate cb_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
#pragma warning disable 0169
		static Delegate GetRegisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler ()
		{
			if (cb_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ == null)
				cb_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_);
			return cb_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
		}

		static IntPtr n_RegisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerPolicyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterPolicyListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerPolicyListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerPolicyListener']]"
		[Register ("registerPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterPolicyListener (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0);

		static Delegate cb_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
#pragma warning disable 0169
		static Delegate GetRegisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler ()
		{
			if (cb_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == null)
				cb_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_);
			return cb_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		}

		static IntPtr n_RegisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterProgressListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerProgressListener' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("registerProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterProgressListener (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1);

		static Delegate cb_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
#pragma warning disable 0169
		static Delegate GetRegisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler ()
		{
			if (cb_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ == null)
				cb_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_);
			return cb_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
		}

		static IntPtr n_RegisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerSyncListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerSyncListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterSyncListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerSyncListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerSyncListener']]"
		[Register ("registerSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterSyncListener (global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0);

		static Delegate cb_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
#pragma warning disable 0169
		static Delegate GetRegisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler ()
		{
			if (cb_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ == null)
				cb_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_);
			return cb_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
		}

		static IntPtr n_RegisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterTypingIndicator (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerTypingIndicator' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener']]"
		[Register ("registerTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient RegisterTypingIndicator (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0);

		static Delegate cb_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Handler ()
		{
			if (cb_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_ == null)
				cb_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_);
			return cb_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_;
		}

		static void n_RemoveMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMetadataAtKeyPath (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removeMetadataAtKeyPath' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;)V", "GetRemoveMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Handler")]
		public abstract void RemoveMetadataAtKeyPath (global::Com.Layer.Sdk.Messaging.Conversation p0, string p1);

		static Delegate cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ == null)
				cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_);
			return cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
		}

		static void n_RemoveParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RemoveParticipants (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removeParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String...']]"
		[Register ("removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V", "GetRemoveParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_Handler")]
		public virtual void RemoveParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, params  string[] p1)
		{
			if (id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ == IntPtr.Zero)
				id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;[Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRemoveParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler ()
		{
			if (cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ == null)
				cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_);
			return cb_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
		}

		static void n_RemoveParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParticipants (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removeParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.List']]"
		[Register ("removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V", "GetRemoveParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler")]
		public abstract void RemoveParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IList<string> p1);

		static Delegate cb_removePolicy_Lcom_layer_sdk_policy_Policy_;
#pragma warning disable 0169
		static Delegate GetRemovePolicy_Lcom_layer_sdk_policy_Policy_Handler ()
		{
			if (cb_removePolicy_Lcom_layer_sdk_policy_Policy_ == null)
				cb_removePolicy_Lcom_layer_sdk_policy_Policy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemovePolicy_Lcom_layer_sdk_policy_Policy_);
			return cb_removePolicy_Lcom_layer_sdk_policy_Policy_;
		}

		static bool n_RemovePolicy_Lcom_layer_sdk_policy_Policy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Policy.Policy p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemovePolicy (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removePolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("removePolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetRemovePolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public abstract bool RemovePolicy (global::Com.Layer.Sdk.Policy.Policy p0);

		static IntPtr id_sendLogs_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='sendLogs' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='android.app.Activity']]"
		[Register ("sendLogs", "(Lcom/layer/sdk/LayerClient;Landroid/app/Activity;)V", "")]
		public static void SendLogs (global::Com.Layer.Sdk.LayerClient p0, global::Android.App.Activity p1)
		{
			if (id_sendLogs_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_ == IntPtr.Zero)
				id_sendLogs_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "sendLogs", "(Lcom/layer/sdk/LayerClient;Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendLogs_Lcom_layer_sdk_LayerClient_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_Handler ()
		{
			if (cb_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_ == null)
				cb_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_);
			return cb_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_;
		}

		static void n_SendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.messaging.Message']]"
		[Register ("sendMessage", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/messaging/Message;)V", "GetSendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_Handler")]
		public abstract void SendMessage (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.Messaging.Message p1);

		static Delegate cb_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
#pragma warning disable 0169
		static Delegate GetSendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler ()
		{
			if (cb_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == null)
				cb_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_);
			return cb_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		}

		static IntPtr n_SendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendTypingIndicator (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='sendTypingIndicator' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("sendTypingIndicator", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)Lcom/layer/sdk/LayerClient;", "GetSendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient SendTypingIndicator (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1);

		static Delegate cb_setAutoDownloadMimeTypes_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetAutoDownloadMimeTypes_Ljava_util_Collection_Handler ()
		{
			if (cb_setAutoDownloadMimeTypes_Ljava_util_Collection_ == null)
				cb_setAutoDownloadMimeTypes_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAutoDownloadMimeTypes_Ljava_util_Collection_);
			return cb_setAutoDownloadMimeTypes_Ljava_util_Collection_;
		}

		static IntPtr n_SetAutoDownloadMimeTypes_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAutoDownloadMimeTypes (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setAutoDownloadMimeTypes' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("setAutoDownloadMimeTypes", "(Ljava/util/Collection;)Lcom/layer/sdk/LayerClient;", "GetSetAutoDownloadMimeTypes_Ljava_util_Collection_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient SetAutoDownloadMimeTypes (global::System.Collections.Generic.ICollection<string> p0);

		static Delegate cb_setAutoDownloadSizeThreshold_J;
#pragma warning disable 0169
		static Delegate GetSetAutoDownloadSizeThreshold_JHandler ()
		{
			if (cb_setAutoDownloadSizeThreshold_J == null)
				cb_setAutoDownloadSizeThreshold_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetAutoDownloadSizeThreshold_J);
			return cb_setAutoDownloadSizeThreshold_J;
		}

		static IntPtr n_SetAutoDownloadSizeThreshold_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAutoDownloadSizeThreshold (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setAutoDownloadSizeThreshold' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAutoDownloadSizeThreshold", "(J)Lcom/layer/sdk/LayerClient;", "GetSetAutoDownloadSizeThreshold_JHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient SetAutoDownloadSizeThreshold (long p0);

		static Delegate cb_setDiskCapacity_J;
#pragma warning disable 0169
		static Delegate GetSetDiskCapacity_JHandler ()
		{
			if (cb_setDiskCapacity_J == null)
				cb_setDiskCapacity_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDiskCapacity_J);
			return cb_setDiskCapacity_J;
		}

		static IntPtr n_SetDiskCapacity_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDiskCapacity (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setDiskCapacity' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDiskCapacity", "(J)Lcom/layer/sdk/LayerClient;", "GetSetDiskCapacity_JHandler")]
		public abstract global::Com.Layer.Sdk.LayerClient SetDiskCapacity (long p0);

		static Delegate cb_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_);
			return cb_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetGcmRegistrationId (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setGcmRegistrationId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGcmRegistrationId", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void SetGcmRegistrationId (string p0, string p1);

		static IntPtr id_setLogEnablePersonallyIdentifiableInformation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setLogEnablePersonallyIdentifiableInformation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogEnablePersonallyIdentifiableInformation", "(Z)V", "")]
		public static void SetLogEnablePersonallyIdentifiableInformation (bool p0)
		{
			if (id_setLogEnablePersonallyIdentifiableInformation_Z == IntPtr.Zero)
				id_setLogEnablePersonallyIdentifiableInformation_Z = JNIEnv.GetStaticMethodID (class_ref, "setLogEnablePersonallyIdentifiableInformation", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogEnablePersonallyIdentifiableInformation_Z, new JValue (p0));
		}

		static IntPtr id_setLogLevel_Lcom_layer_sdk_LayerClient_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.LayerClient.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/layer/sdk/LayerClient$LogLevel;)V", "")]
		public static void SetLogLevel (global::Com.Layer.Sdk.LayerClient.LogLevel p0)
		{
			if (id_setLogLevel_Lcom_layer_sdk_LayerClient_LogLevel_ == IntPtr.Zero)
				id_setLogLevel_Lcom_layer_sdk_LayerClient_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(Lcom/layer/sdk/LayerClient$LogLevel;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_Lcom_layer_sdk_LayerClient_LogLevel_, new JValue (p0));
		}

		static Delegate cb_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_ == null)
				cb_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_);
			return cb_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_;
		}

		static void n_SetMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMetadata (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setMetadata' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='java.util.Map']]"
		[Register ("setMetadata", "(Lcom/layer/sdk/messaging/Message;Ljava/util/Map;)V", "GetSetMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_Handler")]
		public abstract void SetMetadata (global::Com.Layer.Sdk.Messaging.Message p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		static Delegate cb_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler ()
		{
			if (cb_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ == null)
				cb_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_);
			return cb_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
		}

		static IntPtr n_UnregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterAuthenticationListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterAuthenticationListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerAuthenticationListener']]"
		[Register ("unregisterAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterAuthenticationListener (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0);

		static Delegate cb_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler ()
		{
			if (cb_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ == null)
				cb_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_);
			return cb_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
		}

		static IntPtr n_UnregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerConnectionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterConnectionListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterConnectionListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerConnectionListener']]"
		[Register ("unregisterConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterConnectionListener (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0);

		static Delegate cb_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler ()
		{
			if (cb_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ == null)
				cb_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_);
			return cb_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
		}

		static IntPtr n_UnregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterEventListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterEventListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerChangeEventListener']]"
		[Register ("unregisterEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterEventListener (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0);

		static Delegate cb_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler ()
		{
			if (cb_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ == null)
				cb_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_);
			return cb_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
		}

		static IntPtr n_UnregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerPolicyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterPolicyListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterPolicyListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerPolicyListener']]"
		[Register ("unregisterPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterPolicyListener (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0);

		static Delegate cb_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler ()
		{
			if (cb_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == null)
				cb_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_);
			return cb_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		}

		static IntPtr n_UnregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Messaging.MessagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1 = (global::Com.Layer.Sdk.Listeners.ILayerProgressListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterProgressListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterProgressListener' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("unregisterProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterProgressListener (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1);

		static Delegate cb_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler ()
		{
			if (cb_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ == null)
				cb_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_);
			return cb_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
		}

		static IntPtr n_UnregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerSyncListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerSyncListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterSyncListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterSyncListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerSyncListener']]"
		[Register ("unregisterSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterSyncListener (global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0);

		static Delegate cb_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler ()
		{
			if (cb_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ == null)
				cb_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_);
			return cb_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
		}

		static IntPtr n_UnregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0 = (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener)global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnregisterTypingIndicator (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterTypingIndicator' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener']]"
		[Register ("unregisterTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler")]
		public abstract global::Com.Layer.Sdk.LayerClient UnregisterTypingIndicator (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0);

		static Delegate cb_validatePolicy_Lcom_layer_sdk_policy_Policy_;
#pragma warning disable 0169
		static Delegate GetValidatePolicy_Lcom_layer_sdk_policy_Policy_Handler ()
		{
			if (cb_validatePolicy_Lcom_layer_sdk_policy_Policy_ == null)
				cb_validatePolicy_Lcom_layer_sdk_policy_Policy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ValidatePolicy_Lcom_layer_sdk_policy_Policy_);
			return cb_validatePolicy_Lcom_layer_sdk_policy_Policy_;
		}

		static bool n_ValidatePolicy_Lcom_layer_sdk_policy_Policy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.LayerClient __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Policy.Policy p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Policy.Policy> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ValidatePolicy (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='validatePolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("validatePolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetValidatePolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public abstract bool ValidatePolicy (global::Com.Layer.Sdk.Policy.Policy p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/LayerClient", DoNotGenerateAcw=true)]
	internal partial class LayerClientInvoker : LayerClient {

		public LayerClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerClientInvoker); }
		}

		static IntPtr id_getAppId;
		public override global::Java.Util.UUID AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/util/UUID;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/util/UUID;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAuthenticatedUserId;
		public override string AuthenticatedUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAuthenticatedUserId' and count(parameter)=0]"
			[Register ("getAuthenticatedUserId", "()Ljava/lang/String;", "GetGetAuthenticatedUserIdHandler")]
			get {
				if (id_getAuthenticatedUserId == IntPtr.Zero)
					id_getAuthenticatedUserId = JNIEnv.GetMethodID (class_ref, "getAuthenticatedUserId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthenticatedUserId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAutoDownloadMimeTypes;
		public override global::System.Collections.Generic.ICollection<string> AutoDownloadMimeTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAutoDownloadMimeTypes' and count(parameter)=0]"
			[Register ("getAutoDownloadMimeTypes", "()Ljava/util/Set;", "GetGetAutoDownloadMimeTypesHandler")]
			get {
				if (id_getAutoDownloadMimeTypes == IntPtr.Zero)
					id_getAutoDownloadMimeTypes = JNIEnv.GetMethodID (class_ref, "getAutoDownloadMimeTypes", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAutoDownloadMimeTypes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAutoDownloadSizeThreshold;
		public override long AutoDownloadSizeThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getAutoDownloadSizeThreshold' and count(parameter)=0]"
			[Register ("getAutoDownloadSizeThreshold", "()J", "GetGetAutoDownloadSizeThresholdHandler")]
			get {
				if (id_getAutoDownloadSizeThreshold == IntPtr.Zero)
					id_getAutoDownloadSizeThreshold = JNIEnv.GetMethodID (class_ref, "getAutoDownloadSizeThreshold", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getAutoDownloadSizeThreshold);
			}
		}

		static IntPtr id_getConversationIds;
		public override global::System.Collections.Generic.IList<global::Android.Net.Uri> ConversationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversationIds' and count(parameter)=0]"
			[Register ("getConversationIds", "()Ljava/util/List;", "GetGetConversationIdsHandler")]
			get {
				if (id_getConversationIds == IntPtr.Zero)
					id_getConversationIds = JNIEnv.GetMethodID (class_ref, "getConversationIds", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversationIds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getConversations;
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> Conversations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversations' and count(parameter)=0]"
			[Register ("getConversations", "()Ljava/util/List;", "GetGetConversationsHandler")]
			get {
				if (id_getConversations == IntPtr.Zero)
					id_getConversations = JNIEnv.GetMethodID (class_ref, "getConversations", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversations), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDiskCapacity;
		public override long DiskCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getDiskCapacity' and count(parameter)=0]"
			[Register ("getDiskCapacity", "()J", "GetGetDiskCapacityHandler")]
			get {
				if (id_getDiskCapacity == IntPtr.Zero)
					id_getDiskCapacity = JNIEnv.GetMethodID (class_ref, "getDiskCapacity", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getDiskCapacity);
			}
		}

		static IntPtr id_getDiskUtilization;
		public override long DiskUtilization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getDiskUtilization' and count(parameter)=0]"
			[Register ("getDiskUtilization", "()J", "GetGetDiskUtilizationHandler")]
			get {
				if (id_getDiskUtilization == IntPtr.Zero)
					id_getDiskUtilization = JNIEnv.GetMethodID (class_ref, "getDiskUtilization", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getDiskUtilization);
			}
		}

		static IntPtr id_isAuthenticated;
		public override bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")]
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAuthenticated);
			}
		}

		static IntPtr id_isConnected;
		public override bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
			}
		}

		static IntPtr id_isConnecting;
		public override bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnecting);
			}
		}

		static IntPtr id_getPolicies;
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Policy.Policy> Policies {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getPolicies' and count(parameter)=0]"
			[Register ("getPolicies", "()Ljava/util/List;", "GetGetPoliciesHandler")]
			get {
				if (id_getPolicies == IntPtr.Zero)
					id_getPolicies = JNIEnv.GetMethodID (class_ref, "getPolicies", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Policy.Policy>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPolicies), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='addParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.List']]"
		[Register ("addParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V", "GetAddParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler")]
		public override void AddParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ == IntPtr.Zero)
				id_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_addParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_addPolicy_Lcom_layer_sdk_policy_Policy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='addPolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("addPolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetAddPolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public override bool AddPolicy (global::Com.Layer.Sdk.Policy.Policy p0)
		{
			if (id_addPolicy_Lcom_layer_sdk_policy_Policy_ == IntPtr.Zero)
				id_addPolicy_Lcom_layer_sdk_policy_Policy_ = JNIEnv.GetMethodID (class_ref, "addPolicy", "(Lcom/layer/sdk/policy/Policy;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_addPolicy_Lcom_layer_sdk_policy_Policy_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_answerAuthenticationChallenge_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='answerAuthenticationChallenge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("answerAuthenticationChallenge", "(Ljava/lang/String;)V", "GetAnswerAuthenticationChallenge_Ljava_lang_String_Handler")]
		public override void AnswerAuthenticationChallenge (string p0)
		{
			if (id_answerAuthenticationChallenge_Ljava_lang_String_ == IntPtr.Zero)
				id_answerAuthenticationChallenge_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "answerAuthenticationChallenge", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_answerAuthenticationChallenge_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_authenticate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='authenticate' and count(parameter)=0]"
		[Register ("authenticate", "()Lcom/layer/sdk/LayerClient;", "GetAuthenticateHandler")]
		public override global::Com.Layer.Sdk.LayerClient Authenticate ()
		{
			if (id_authenticate == IntPtr.Zero)
				id_authenticate = JNIEnv.GetMethodID (class_ref, "authenticate", "()Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_authenticate), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lcom/layer/sdk/LayerClient;", "GetConnectHandler")]
		public override global::Com.Layer.Sdk.LayerClient Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_connect), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_deauthenticate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deauthenticate' and count(parameter)=0]"
		[Register ("deauthenticate", "()Lcom/layer/sdk/LayerClient;", "GetDeauthenticateHandler")]
		public override global::Com.Layer.Sdk.LayerClient Deauthenticate ()
		{
			if (id_deauthenticate == IntPtr.Zero)
				id_deauthenticate = JNIEnv.GetMethodID (class_ref, "deauthenticate", "()Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_deauthenticate), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteConversation' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;)V", "GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public override void DeleteConversation (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0));
		}

		static IntPtr id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteConversation' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDeleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public override void DeleteConversation (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.LayerClient.DeletionMode p1)
		{
			if (id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_ == IntPtr.Zero)
				id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNIEnv.GetMethodID (class_ref, "deleteConversation", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/LayerClient$DeletionMode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteConversation_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_LayerClient_DeletionMode_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_deleteMessage_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("deleteMessage", "(Lcom/layer/sdk/messaging/Message;)V", "GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Handler")]
		public override void DeleteMessage (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_deleteMessage_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_deleteMessage_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteMessage_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='deleteMessage' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='com.layer.sdk.LayerClient.DeletionMode']]"
		[Register ("deleteMessage", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/LayerClient$DeletionMode;)V", "GetDeleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_Handler")]
		public override void DeleteMessage (global::Com.Layer.Sdk.Messaging.Message p0, global::Com.Layer.Sdk.LayerClient.DeletionMode p1)
		{
			if (id_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_ == IntPtr.Zero)
				id_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/layer/sdk/messaging/Message;Lcom/layer/sdk/LayerClient$DeletionMode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteMessage_Lcom_layer_sdk_messaging_Message_Lcom_layer_sdk_LayerClient_DeletionMode_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Lcom/layer/sdk/LayerClient;", "GetDisconnectHandler")]
		public override global::Com.Layer.Sdk.LayerClient Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_disconnect), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQuery' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Query'] and parameter[2][@type='com.layer.sdk.query.Query.ResultType']]"
		[Register ("executeQuery", "(Lcom/layer/sdk/query/Query;Lcom/layer/sdk/query/Query$ResultType;)Ljava/util/List;", "GetExecuteQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_Handler")]
		public override global::System.Collections.IList ExecuteQuery (global::Com.Layer.Sdk.Query.Query p0, global::Com.Layer.Sdk.Query.Query.ResultType p1)
		{
			if (id_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ == IntPtr.Zero)
				id_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ = JNIEnv.GetMethodID (class_ref, "executeQuery", "(Lcom/layer/sdk/query/Query;Lcom/layer/sdk/query/Query$ResultType;)Ljava/util/List;");
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_executeQuery_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeQueryForCount_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForCount' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForCount", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;", "GetExecuteQueryForCount_Lcom_layer_sdk_query_Query_Handler")]
		public override global::Java.Lang.Long ExecuteQueryForCount (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_executeQueryForCount_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_executeQueryForCount_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "executeQueryForCount", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_executeQueryForCount_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeQueryForIds_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForIds' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForIds", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetExecuteQueryForIds_Lcom_layer_sdk_query_Query_Handler")]
		public override global::System.Collections.Generic.IList<global::Android.Net.Uri> ExecuteQueryForIds (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_executeQueryForIds_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_executeQueryForIds_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "executeQueryForIds", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_executeQueryForIds_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeQueryForObjects_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='executeQueryForObjects' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("executeQueryForObjects", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetExecuteQueryForObjects_Lcom_layer_sdk_query_Query_Handler")]
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.IQueryable> ExecuteQueryForObjects (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_executeQueryForObjects_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_executeQueryForObjects_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "executeQueryForObjects", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.IQueryable> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.IQueryable>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_executeQueryForObjects_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_get_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("get", "(Landroid/net/Uri;)Lcom/layer/sdk/query/Queryable;", "GetGet_Landroid_net_Uri_Handler")]
		public override global::Com.Layer.Sdk.Query.IQueryable Get (global::Android.Net.Uri p0)
		{
			if (id_get_Landroid_net_Uri_ == IntPtr.Zero)
				id_get_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/net/Uri;)Lcom/layer/sdk/query/Queryable;");
			global::Com.Layer.Sdk.Query.IQueryable __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryable> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getConversation_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getConversation", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Conversation;", "GetGetConversation_Landroid_net_Uri_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Conversation GetConversation (global::Android.Net.Uri p0)
		{
			if (id_getConversation_Landroid_net_Uri_ == IntPtr.Zero)
				id_getConversation_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getConversation", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Conversation;");
			global::Com.Layer.Sdk.Messaging.Conversation __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_getConversation_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getConversations_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversations' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getConversations", "(Ljava/util/List;)Ljava/util/List;", "GetGetConversations_Ljava_util_List_Handler")]
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversations (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
		{
			if (id_getConversations_Ljava_util_List_ == IntPtr.Zero)
				id_getConversations_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getConversations", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversations_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getConversationsWithParticipants_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getConversationsWithParticipants' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getConversationsWithParticipants", "(Ljava/util/List;)Ljava/util/List;", "GetGetConversationsWithParticipants_Ljava_util_List_Handler")]
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> GetConversationsWithParticipants (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getConversationsWithParticipants_Ljava_util_List_ == IntPtr.Zero)
				id_getConversationsWithParticipants_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getConversationsWithParticipants", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Conversation> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getConversationsWithParticipants_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMessage_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getMessage", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Message;", "GetGetMessage_Landroid_net_Uri_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Message GetMessage (global::Android.Net.Uri p0)
		{
			if (id_getMessage_Landroid_net_Uri_ == IntPtr.Zero)
				id_getMessage_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getMessage", "(Landroid/net/Uri;)Lcom/layer/sdk/messaging/Message;");
			global::Com.Layer.Sdk.Messaging.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_getMessage_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getMessageIds_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessageIds' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getMessageIds", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;", "GetGetMessageIds_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public override global::System.Collections.Generic.IList<global::Android.Net.Uri> GetMessageIds (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_getMessageIds_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_getMessageIds_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "getMessageIds", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageIds_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getMessages_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getMessages", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;", "GetGetMessages_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> GetMessages (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_getMessages_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_getMessages_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessages_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getMessages_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("getMessages", "(Ljava/util/List;)Ljava/util/List;", "GetGetMessages_Ljava_util_List_Handler")]
		public override global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> GetMessages (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
		{
			if (id_getMessages_Ljava_util_List_ == IntPtr.Zero)
				id_getMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessages_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='getUnreadMessageCount' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Conversation']]"
		[Register ("getUnreadMessageCount", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/lang/Integer;", "GetGetUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_Handler")]
		public override global::Java.Lang.Integer GetUnreadMessageCount (global::Com.Layer.Sdk.Messaging.Conversation p0)
		{
			if (id_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_ == IntPtr.Zero)
				id_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_ = JNIEnv.GetMethodID (class_ref, "getUnreadMessageCount", "(Lcom/layer/sdk/messaging/Conversation;)Ljava/lang/Integer;");
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getUnreadMessageCount_Lcom_layer_sdk_messaging_Conversation_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_insertPolicy_Lcom_layer_sdk_policy_Policy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='insertPolicy' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.policy.Policy'] and parameter[2][@type='int']]"
		[Register ("insertPolicy", "(Lcom/layer/sdk/policy/Policy;I)Z", "GetInsertPolicy_Lcom_layer_sdk_policy_Policy_IHandler")]
		public override bool InsertPolicy (global::Com.Layer.Sdk.Policy.Policy p0, int p1)
		{
			if (id_insertPolicy_Lcom_layer_sdk_policy_Policy_I == IntPtr.Zero)
				id_insertPolicy_Lcom_layer_sdk_policy_Policy_I = JNIEnv.GetMethodID (class_ref, "insertPolicy", "(Lcom/layer/sdk/policy/Policy;I)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_insertPolicy_Lcom_layer_sdk_policy_Policy_I, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_markMessageAsRead_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='markMessageAsRead' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.messaging.Message']]"
		[Register ("markMessageAsRead", "(Lcom/layer/sdk/messaging/Message;)V", "GetMarkMessageAsRead_Lcom_layer_sdk_messaging_Message_Handler")]
		public override void MarkMessageAsRead (global::Com.Layer.Sdk.Messaging.Message p0)
		{
			if (id_markMessageAsRead_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_markMessageAsRead_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "markMessageAsRead", "(Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_markMessageAsRead_Lcom_layer_sdk_messaging_Message_, new JValue (p0));
		}

		static IntPtr id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newConversation' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.ConversationOptions'] and parameter[2][@type='java.util.List']]"
		[Register ("newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;", "GetNewConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Conversation NewConversation (global::Com.Layer.Sdk.Messaging.ConversationOptions p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ == IntPtr.Zero)
				id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "newConversation", "(Lcom/layer/sdk/messaging/ConversationOptions;Ljava/util/List;)Lcom/layer/sdk/messaging/Conversation;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			global::Com.Layer.Sdk.Messaging.Conversation __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Conversation> (JNIEnv.CallObjectMethod  (Handle, id_newConversation_Lcom_layer_sdk_messaging_ConversationOptions_Ljava_util_List_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newMessage_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessage' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("newMessage", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Message;", "GetNewMessage_Ljava_util_List_Handler")]
		public override global::Com.Layer.Sdk.Messaging.Message NewMessage (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.MessagePart> p0)
		{
			if (id_newMessage_Ljava_util_List_ == IntPtr.Zero)
				id_newMessage_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "newMessage", "(Ljava/util/List;)Lcom/layer/sdk/messaging/Message;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.MessagePart>.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.Messaging.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.Message> (JNIEnv.CallObjectMethod  (Handle, id_newMessage_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newMessagePart_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessagePart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("newMessagePart", "(Ljava/lang/String;[B)Lcom/layer/sdk/messaging/MessagePart;", "GetNewMessagePart_Ljava_lang_String_arrayBHandler")]
		public override global::Com.Layer.Sdk.Messaging.MessagePart NewMessagePart (string p0, byte[] p1)
		{
			if (id_newMessagePart_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_newMessagePart_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "newMessagePart", "(Ljava/lang/String;[B)Lcom/layer/sdk/messaging/MessagePart;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Layer.Sdk.Messaging.MessagePart __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (JNIEnv.CallObjectMethod  (Handle, id_newMessagePart_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newMessagePart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='long']]"
		[Register ("newMessagePart", "(Ljava/lang/String;Ljava/io/InputStream;J)Lcom/layer/sdk/messaging/MessagePart;", "GetNewMessagePart_Ljava_lang_String_Ljava_io_InputStream_JHandler")]
		public override global::Com.Layer.Sdk.Messaging.MessagePart NewMessagePart (string p0, global::System.IO.Stream p1, long p2)
		{
			if (id_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J == IntPtr.Zero)
				id_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J = JNIEnv.GetMethodID (class_ref, "newMessagePart", "(Ljava/lang/String;Ljava/io/InputStream;J)Lcom/layer/sdk/messaging/MessagePart;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			global::Com.Layer.Sdk.Messaging.MessagePart __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Messaging.MessagePart> (JNIEnv.CallObjectMethod  (Handle, id_newMessagePart_Ljava_lang_String_Ljava_io_InputStream_J, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='newRecyclerViewController' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.Query'] and parameter[2][@type='java.util.Collection'] and parameter[3][@type='com.layer.sdk.query.RecyclerViewController.Callback']]"
		[Register ("newRecyclerViewController", "(Lcom/layer/sdk/query/Query;Ljava/util/Collection;Lcom/layer/sdk/query/RecyclerViewController$Callback;)Lcom/layer/sdk/query/RecyclerViewController;", "GetNewRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_Handler")]
		public override global::Com.Layer.Sdk.Query.RecyclerViewController NewRecyclerViewController (global::Com.Layer.Sdk.Query.Query p0, global::System.Collections.Generic.ICollection<string> p1, global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback p2)
		{
			if (id_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_ == IntPtr.Zero)
				id_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_ = JNIEnv.GetMethodID (class_ref, "newRecyclerViewController", "(Lcom/layer/sdk/query/Query;Ljava/util/Collection;Lcom/layer/sdk/query/RecyclerViewController$Callback;)Lcom/layer/sdk/query/RecyclerViewController;");
			IntPtr native_p1 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p1);
			global::Com.Layer.Sdk.Query.RecyclerViewController __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (JNIEnv.CallObjectMethod  (Handle, id_newRecyclerViewController_Lcom_layer_sdk_query_Query_Ljava_util_Collection_Lcom_layer_sdk_query_RecyclerViewController_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='putMetadata' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='boolean']]"
		[Register ("putMetadata", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/Map;Z)V", "GetPutMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_ZHandler")]
		public override void PutMetadata (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, bool p2)
		{
			if (id_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z == IntPtr.Zero)
				id_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "putMetadata", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/Map;Z)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_putMetadata_Lcom_layer_sdk_messaging_Conversation_Ljava_util_Map_Z, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='putMetadataAtKeyPath' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("putMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;Ljava/lang/String;)V", "GetPutMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void PutMetadataAtKeyPath (global::Com.Layer.Sdk.Messaging.Conversation p0, string p1, string p2)
		{
			if (id_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod  (Handle, id_putMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerAuthenticationListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerAuthenticationListener']]"
		[Register ("registerAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterAuthenticationListener (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0)
		{
			if (id_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ == IntPtr.Zero)
				id_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ = JNIEnv.GetMethodID (class_ref, "registerAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerConnectionListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerConnectionListener']]"
		[Register ("registerConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterConnectionListener (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0)
		{
			if (id_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ == IntPtr.Zero)
				id_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ = JNIEnv.GetMethodID (class_ref, "registerConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerEventListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerChangeEventListener']]"
		[Register ("registerEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterEventListener (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0)
		{
			if (id_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ == IntPtr.Zero)
				id_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ = JNIEnv.GetMethodID (class_ref, "registerEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerPolicyListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerPolicyListener']]"
		[Register ("registerPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterPolicyListener (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0)
		{
			if (id_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ == IntPtr.Zero)
				id_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ = JNIEnv.GetMethodID (class_ref, "registerPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerProgressListener' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("registerProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterProgressListener (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "registerProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerSyncListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerSyncListener']]"
		[Register ("registerSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterSyncListener (global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0)
		{
			if (id_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ == IntPtr.Zero)
				id_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ = JNIEnv.GetMethodID (class_ref, "registerSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='registerTypingIndicator' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener']]"
		[Register ("registerTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;", "GetRegisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient RegisterTypingIndicator (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0)
		{
			if (id_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ == IntPtr.Zero)
				id_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ = JNIEnv.GetMethodID (class_ref, "registerTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_registerTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removeMetadataAtKeyPath' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;)V", "GetRemoveMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_Handler")]
		public override void RemoveMetadataAtKeyPath (global::Com.Layer.Sdk.Messaging.Conversation p0, string p1)
		{
			if (id_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMetadataAtKeyPath", "(Lcom/layer/sdk/messaging/Conversation;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_removeMetadataAtKeyPath_Lcom_layer_sdk_messaging_Conversation_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removeParticipants' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='java.util.List']]"
		[Register ("removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V", "GetRemoveParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_Handler")]
		public override void RemoveParticipants (global::Com.Layer.Sdk.Messaging.Conversation p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ == IntPtr.Zero)
				id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "removeParticipants", "(Lcom/layer/sdk/messaging/Conversation;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_removeParticipants_Lcom_layer_sdk_messaging_Conversation_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_removePolicy_Lcom_layer_sdk_policy_Policy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='removePolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("removePolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetRemovePolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public override bool RemovePolicy (global::Com.Layer.Sdk.Policy.Policy p0)
		{
			if (id_removePolicy_Lcom_layer_sdk_policy_Policy_ == IntPtr.Zero)
				id_removePolicy_Lcom_layer_sdk_policy_Policy_ = JNIEnv.GetMethodID (class_ref, "removePolicy", "(Lcom/layer/sdk/policy/Policy;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_removePolicy_Lcom_layer_sdk_policy_Policy_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.messaging.Message']]"
		[Register ("sendMessage", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/messaging/Message;)V", "GetSendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_Handler")]
		public override void SendMessage (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.Messaging.Message p1)
		{
			if (id_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_ == IntPtr.Zero)
				id_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/messaging/Message;)V");
			JNIEnv.CallVoidMethod  (Handle, id_sendMessage_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_messaging_Message_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='sendTypingIndicator' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Conversation'] and parameter[2][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener.TypingIndicator']]"
		[Register ("sendTypingIndicator", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)Lcom/layer/sdk/LayerClient;", "GetSendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_Handler")]
		public override global::Com.Layer.Sdk.LayerClient SendTypingIndicator (global::Com.Layer.Sdk.Messaging.Conversation p0, global::Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator p1)
		{
			if (id_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ == IntPtr.Zero)
				id_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_ = JNIEnv.GetMethodID (class_ref, "sendTypingIndicator", "(Lcom/layer/sdk/messaging/Conversation;Lcom/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_sendTypingIndicator_Lcom_layer_sdk_messaging_Conversation_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_TypingIndicator_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_setAutoDownloadMimeTypes_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setAutoDownloadMimeTypes' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("setAutoDownloadMimeTypes", "(Ljava/util/Collection;)Lcom/layer/sdk/LayerClient;", "GetSetAutoDownloadMimeTypes_Ljava_util_Collection_Handler")]
		public override global::Com.Layer.Sdk.LayerClient SetAutoDownloadMimeTypes (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_setAutoDownloadMimeTypes_Ljava_util_Collection_ == IntPtr.Zero)
				id_setAutoDownloadMimeTypes_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setAutoDownloadMimeTypes", "(Ljava/util/Collection;)Lcom/layer/sdk/LayerClient;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_setAutoDownloadMimeTypes_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_setAutoDownloadSizeThreshold_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setAutoDownloadSizeThreshold' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAutoDownloadSizeThreshold", "(J)Lcom/layer/sdk/LayerClient;", "GetSetAutoDownloadSizeThreshold_JHandler")]
		public override global::Com.Layer.Sdk.LayerClient SetAutoDownloadSizeThreshold (long p0)
		{
			if (id_setAutoDownloadSizeThreshold_J == IntPtr.Zero)
				id_setAutoDownloadSizeThreshold_J = JNIEnv.GetMethodID (class_ref, "setAutoDownloadSizeThreshold", "(J)Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_setAutoDownloadSizeThreshold_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setDiskCapacity_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setDiskCapacity' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDiskCapacity", "(J)Lcom/layer/sdk/LayerClient;", "GetSetDiskCapacity_JHandler")]
		public override global::Com.Layer.Sdk.LayerClient SetDiskCapacity (long p0)
		{
			if (id_setDiskCapacity_J == IntPtr.Zero)
				id_setDiskCapacity_J = JNIEnv.GetMethodID (class_ref, "setDiskCapacity", "(J)Lcom/layer/sdk/LayerClient;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_setDiskCapacity_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setGcmRegistrationId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGcmRegistrationId", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override void SetGcmRegistrationId (string p0, string p1)
		{
			if (id_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGcmRegistrationId", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_setGcmRegistrationId_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='setMetadata' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.Message'] and parameter[2][@type='java.util.Map']]"
		[Register ("setMetadata", "(Lcom/layer/sdk/messaging/Message;Ljava/util/Map;)V", "GetSetMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_Handler")]
		public override void SetMetadata (global::Com.Layer.Sdk.Messaging.Message p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_ == IntPtr.Zero)
				id_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Lcom/layer/sdk/messaging/Message;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_setMetadata_Lcom_layer_sdk_messaging_Message_Ljava_util_Map_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterAuthenticationListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerAuthenticationListener']]"
		[Register ("unregisterAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterAuthenticationListener (global::Com.Layer.Sdk.Listeners.ILayerAuthenticationListener p0)
		{
			if (id_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ == IntPtr.Zero)
				id_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_ = JNIEnv.GetMethodID (class_ref, "unregisterAuthenticationListener", "(Lcom/layer/sdk/listeners/LayerAuthenticationListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterAuthenticationListener_Lcom_layer_sdk_listeners_LayerAuthenticationListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterConnectionListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerConnectionListener']]"
		[Register ("unregisterConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterConnectionListener (global::Com.Layer.Sdk.Listeners.ILayerConnectionListener p0)
		{
			if (id_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ == IntPtr.Zero)
				id_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionListener", "(Lcom/layer/sdk/listeners/LayerConnectionListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterConnectionListener_Lcom_layer_sdk_listeners_LayerConnectionListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterEventListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerChangeEventListener']]"
		[Register ("unregisterEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterEventListener (global::Com.Layer.Sdk.Listeners.ILayerChangeEventListener p0)
		{
			if (id_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ == IntPtr.Zero)
				id_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_ = JNIEnv.GetMethodID (class_ref, "unregisterEventListener", "(Lcom/layer/sdk/listeners/LayerChangeEventListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterEventListener_Lcom_layer_sdk_listeners_LayerChangeEventListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterPolicyListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerPolicyListener']]"
		[Register ("unregisterPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterPolicyListener (global::Com.Layer.Sdk.Listeners.ILayerPolicyListener p0)
		{
			if (id_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ == IntPtr.Zero)
				id_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_ = JNIEnv.GetMethodID (class_ref, "unregisterPolicyListener", "(Lcom/layer/sdk/listeners/LayerPolicyListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterPolicyListener_Lcom_layer_sdk_listeners_LayerPolicyListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterProgressListener' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.messaging.MessagePart'] and parameter[2][@type='com.layer.sdk.listeners.LayerProgressListener']]"
		[Register ("unregisterProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterProgressListener (global::Com.Layer.Sdk.Messaging.MessagePart p0, global::Com.Layer.Sdk.Listeners.ILayerProgressListener p1)
		{
			if (id_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ == IntPtr.Zero)
				id_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_ = JNIEnv.GetMethodID (class_ref, "unregisterProgressListener", "(Lcom/layer/sdk/messaging/MessagePart;Lcom/layer/sdk/listeners/LayerProgressListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterProgressListener_Lcom_layer_sdk_messaging_MessagePart_Lcom_layer_sdk_listeners_LayerProgressListener_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterSyncListener' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerSyncListener']]"
		[Register ("unregisterSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterSyncListener (global::Com.Layer.Sdk.Listeners.ILayerSyncListener p0)
		{
			if (id_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ == IntPtr.Zero)
				id_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_ = JNIEnv.GetMethodID (class_ref, "unregisterSyncListener", "(Lcom/layer/sdk/listeners/LayerSyncListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterSyncListener_Lcom_layer_sdk_listeners_LayerSyncListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='unregisterTypingIndicator' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.listeners.LayerTypingIndicatorListener']]"
		[Register ("unregisterTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;", "GetUnregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_Handler")]
		public override global::Com.Layer.Sdk.LayerClient UnregisterTypingIndicator (global::Com.Layer.Sdk.Listeners.ILayerTypingIndicatorListener p0)
		{
			if (id_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ == IntPtr.Zero)
				id_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_ = JNIEnv.GetMethodID (class_ref, "unregisterTypingIndicator", "(Lcom/layer/sdk/listeners/LayerTypingIndicatorListener;)Lcom/layer/sdk/LayerClient;");
			global::Com.Layer.Sdk.LayerClient __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.LayerClient> (JNIEnv.CallObjectMethod  (Handle, id_unregisterTypingIndicator_Lcom_layer_sdk_listeners_LayerTypingIndicatorListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_validatePolicy_Lcom_layer_sdk_policy_Policy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk']/class[@name='LayerClient']/method[@name='validatePolicy' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.policy.Policy']]"
		[Register ("validatePolicy", "(Lcom/layer/sdk/policy/Policy;)Z", "GetValidatePolicy_Lcom_layer_sdk_policy_Policy_Handler")]
		public override bool ValidatePolicy (global::Com.Layer.Sdk.Policy.Policy p0)
		{
			if (id_validatePolicy_Lcom_layer_sdk_policy_Policy_ == IntPtr.Zero)
				id_validatePolicy_Lcom_layer_sdk_policy_Policy_ = JNIEnv.GetMethodID (class_ref, "validatePolicy", "(Lcom/layer/sdk/policy/Policy;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_validatePolicy_Lcom_layer_sdk_policy_Policy_, new JValue (p0));
			return __ret;
		}

	}

}
