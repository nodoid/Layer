using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Transport.Thrift.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/layer/transport/thrift/sync/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr APP_DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='APP_DELETED']"
		[Register ("APP_DELETED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode AppDeleted {
			get {
				if (APP_DELETED_jfieldId == IntPtr.Zero)
					APP_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_DELETED_jfieldId == IntPtr.Zero)
					APP_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APP_DELETED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr APP_DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='APP_DISABLED']"
		[Register ("APP_DISABLED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode AppDisabled {
			get {
				if (APP_DISABLED_jfieldId == IntPtr.Zero)
					APP_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_DISABLED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_DISABLED_jfieldId == IntPtr.Zero)
					APP_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_DISABLED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APP_DISABLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr APP_ID_MALFORMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='APP_ID_MALFORMED']"
		[Register ("APP_ID_MALFORMED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode AppIdMalformed {
			get {
				if (APP_ID_MALFORMED_jfieldId == IntPtr.Zero)
					APP_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_MALFORMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_ID_MALFORMED_jfieldId == IntPtr.Zero)
					APP_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APP_ID_MALFORMED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr APP_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='APP_NOT_FOUND']"
		[Register ("APP_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode AppNotFound {
			get {
				if (APP_NOT_FOUND_jfieldId == IntPtr.Zero)
					APP_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_NOT_FOUND_jfieldId == IntPtr.Zero)
					APP_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APP_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr APP_SUSPENDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='APP_SUSPENDED']"
		[Register ("APP_SUSPENDED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode AppSuspended {
			get {
				if (APP_SUSPENDED_jfieldId == IntPtr.Zero)
					APP_SUSPENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_SUSPENDED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_SUSPENDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_SUSPENDED_jfieldId == IntPtr.Zero)
					APP_SUSPENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_SUSPENDED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, APP_SUSPENDED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CLIENT_ID_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='CLIENT_ID_REQUIRED']"
		[Register ("CLIENT_ID_REQUIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode ClientIdRequired {
			get {
				if (CLIENT_ID_REQUIRED_jfieldId == IntPtr.Zero)
					CLIENT_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_ID_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLIENT_ID_REQUIRED_jfieldId == IntPtr.Zero)
					CLIENT_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLIENT_ID_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CONFLICT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='CONFLICT']"
		[Register ("CONFLICT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode Conflict {
			get {
				if (CONFLICT_jfieldId == IntPtr.Zero)
					CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFLICT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONFLICT_jfieldId == IntPtr.Zero)
					CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CONFLICT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CONTENT_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='CONTENT_NOT_FOUND']"
		[Register ("CONTENT_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode ContentNotFound {
			get {
				if (CONTENT_NOT_FOUND_jfieldId == IntPtr.Zero)
					CONTENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTENT_NOT_FOUND_jfieldId == IntPtr.Zero)
					CONTENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CONTENT_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVICE_ID_MALFORMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='DEVICE_ID_MALFORMED']"
		[Register ("DEVICE_ID_MALFORMED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode DeviceIdMalformed {
			get {
				if (DEVICE_ID_MALFORMED_jfieldId == IntPtr.Zero)
					DEVICE_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ID_MALFORMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVICE_ID_MALFORMED_jfieldId == IntPtr.Zero)
					DEVICE_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVICE_ID_MALFORMED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVICE_ID_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='DEVICE_ID_REQUIRED']"
		[Register ("DEVICE_ID_REQUIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode DeviceIdRequired {
			get {
				if (DEVICE_ID_REQUIRED_jfieldId == IntPtr.Zero)
					DEVICE_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ID_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVICE_ID_REQUIRED_jfieldId == IntPtr.Zero)
					DEVICE_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVICE_ID_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVICE_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='DEVICE_NOT_FOUND']"
		[Register ("DEVICE_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode DeviceNotFound {
			get {
				if (DEVICE_NOT_FOUND_jfieldId == IntPtr.Zero)
					DEVICE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVICE_NOT_FOUND_jfieldId == IntPtr.Zero)
					DEVICE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVICE_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_CLAIM_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_CLAIM_NOT_FOUND']"
		[Register ("EIT_CLAIM_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitClaimNotFound {
			get {
				if (EIT_CLAIM_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_CLAIM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_CLAIM_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_CLAIM_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_CLAIM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_CLAIM_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_CLAIM_WRONG_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_CLAIM_WRONG_TYPE']"
		[Register ("EIT_CLAIM_WRONG_TYPE")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitClaimWrongType {
			get {
				if (EIT_CLAIM_WRONG_TYPE_jfieldId == IntPtr.Zero)
					EIT_CLAIM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_WRONG_TYPE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_CLAIM_WRONG_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_CLAIM_WRONG_TYPE_jfieldId == IntPtr.Zero)
					EIT_CLAIM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_WRONG_TYPE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_CLAIM_WRONG_TYPE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_EXPIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_EXPIRED']"
		[Register ("EIT_EXPIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitExpired {
			get {
				if (EIT_EXPIRED_jfieldId == IntPtr.Zero)
					EIT_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_EXPIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_EXPIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_EXPIRED_jfieldId == IntPtr.Zero)
					EIT_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_EXPIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_EXPIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_HEADER_PARAM_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_HEADER_PARAM_NOT_FOUND']"
		[Register ("EIT_HEADER_PARAM_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitHeaderParamNotFound {
			get {
				if (EIT_HEADER_PARAM_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_HEADER_PARAM_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_HEADER_PARAM_WRONG_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_HEADER_PARAM_WRONG_TYPE']"
		[Register ("EIT_HEADER_PARAM_WRONG_TYPE")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitHeaderParamWrongType {
			get {
				if (EIT_HEADER_PARAM_WRONG_TYPE_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_TYPE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_WRONG_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_HEADER_PARAM_WRONG_TYPE_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_TYPE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_WRONG_TYPE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_HEADER_PARAM_WRONG_VALUE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_HEADER_PARAM_WRONG_VALUE']"
		[Register ("EIT_HEADER_PARAM_WRONG_VALUE")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitHeaderParamWrongValue {
			get {
				if (EIT_HEADER_PARAM_WRONG_VALUE_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_WRONG_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_VALUE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_WRONG_VALUE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_HEADER_PARAM_WRONG_VALUE_jfieldId == IntPtr.Zero)
					EIT_HEADER_PARAM_WRONG_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_VALUE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_WRONG_VALUE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_KEY_DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_KEY_DELETED']"
		[Register ("EIT_KEY_DELETED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitKeyDeleted {
			get {
				if (EIT_KEY_DELETED_jfieldId == IntPtr.Zero)
					EIT_KEY_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_KEY_DELETED_jfieldId == IntPtr.Zero)
					EIT_KEY_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_KEY_DELETED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_KEY_DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_KEY_DISABLED']"
		[Register ("EIT_KEY_DISABLED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitKeyDisabled {
			get {
				if (EIT_KEY_DISABLED_jfieldId == IntPtr.Zero)
					EIT_KEY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DISABLED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_KEY_DISABLED_jfieldId == IntPtr.Zero)
					EIT_KEY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DISABLED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_KEY_DISABLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_KEY_MALFORMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_KEY_MALFORMED']"
		[Register ("EIT_KEY_MALFORMED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitKeyMalformed {
			get {
				if (EIT_KEY_MALFORMED_jfieldId == IntPtr.Zero)
					EIT_KEY_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_MALFORMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_KEY_MALFORMED_jfieldId == IntPtr.Zero)
					EIT_KEY_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_KEY_MALFORMED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_KEY_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_KEY_NOT_FOUND']"
		[Register ("EIT_KEY_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitKeyNotFound {
			get {
				if (EIT_KEY_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_KEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_KEY_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_KEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_KEY_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_MALFORMED_BASE64URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_MALFORMED_BASE64URL']"
		[Register ("EIT_MALFORMED_BASE64URL")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitMalformedBase64url {
			get {
				if (EIT_MALFORMED_BASE64URL_jfieldId == IntPtr.Zero)
					EIT_MALFORMED_BASE64URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_BASE64URL", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_MALFORMED_BASE64URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_MALFORMED_BASE64URL_jfieldId == IntPtr.Zero)
					EIT_MALFORMED_BASE64URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_BASE64URL", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_MALFORMED_BASE64URL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_MALFORMED_JSON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_MALFORMED_JSON']"
		[Register ("EIT_MALFORMED_JSON")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitMalformedJson {
			get {
				if (EIT_MALFORMED_JSON_jfieldId == IntPtr.Zero)
					EIT_MALFORMED_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_JSON", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_MALFORMED_JSON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_MALFORMED_JSON_jfieldId == IntPtr.Zero)
					EIT_MALFORMED_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_JSON", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_MALFORMED_JSON_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_NONCE_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_NONCE_NOT_FOUND']"
		[Register ("EIT_NONCE_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitNonceNotFound {
			get {
				if (EIT_NONCE_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_NONCE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NONCE_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_NONCE_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_NONCE_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_NONCE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NONCE_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_NONCE_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_NOT_BEFORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_NOT_BEFORE']"
		[Register ("EIT_NOT_BEFORE")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitNotBefore {
			get {
				if (EIT_NOT_BEFORE_jfieldId == IntPtr.Zero)
					EIT_NOT_BEFORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NOT_BEFORE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_NOT_BEFORE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_NOT_BEFORE_jfieldId == IntPtr.Zero)
					EIT_NOT_BEFORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NOT_BEFORE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_NOT_BEFORE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_PROVIDER_NOT_BOUND_TO_APP']"
		[Register ("EIT_PROVIDER_NOT_BOUND_TO_APP")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitProviderNotBoundToApp {
			get {
				if (EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId == IntPtr.Zero)
					EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_BOUND_TO_APP", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId == IntPtr.Zero)
					EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_BOUND_TO_APP", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_PROVIDER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_PROVIDER_NOT_FOUND']"
		[Register ("EIT_PROVIDER_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitProviderNotFound {
			get {
				if (EIT_PROVIDER_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_PROVIDER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_PROVIDER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_PROVIDER_NOT_FOUND_jfieldId == IntPtr.Zero)
					EIT_PROVIDER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_PROVIDER_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_SIGNATURE_VERIFICATION_FAILED']"
		[Register ("EIT_SIGNATURE_VERIFICATION_FAILED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitSignatureVerificationFailed {
			get {
				if (EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId == IntPtr.Zero)
					EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_SIGNATURE_VERIFICATION_FAILED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId == IntPtr.Zero)
					EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_SIGNATURE_VERIFICATION_FAILED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_USER_BLACKLISTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_USER_BLACKLISTED']"
		[Register ("EIT_USER_BLACKLISTED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitUserBlacklisted {
			get {
				if (EIT_USER_BLACKLISTED_jfieldId == IntPtr.Zero)
					EIT_USER_BLACKLISTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_USER_BLACKLISTED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_USER_BLACKLISTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_USER_BLACKLISTED_jfieldId == IntPtr.Zero)
					EIT_USER_BLACKLISTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_USER_BLACKLISTED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_USER_BLACKLISTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EIT_WRONG_JWS_PART_COUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EIT_WRONG_JWS_PART_COUNT']"
		[Register ("EIT_WRONG_JWS_PART_COUNT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EitWrongJwsPartCount {
			get {
				if (EIT_WRONG_JWS_PART_COUNT_jfieldId == IntPtr.Zero)
					EIT_WRONG_JWS_PART_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_WRONG_JWS_PART_COUNT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_WRONG_JWS_PART_COUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EIT_WRONG_JWS_PART_COUNT_jfieldId == IntPtr.Zero)
					EIT_WRONG_JWS_PART_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_WRONG_JWS_PART_COUNT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EIT_WRONG_JWS_PART_COUNT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EVENT_DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EVENT_DELETED']"
		[Register ("EVENT_DELETED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EventDeleted {
			get {
				if (EVENT_DELETED_jfieldId == IntPtr.Zero)
					EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVENT_DELETED_jfieldId == IntPtr.Zero)
					EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EVENT_DELETED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EVENT_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='EVENT_NOT_FOUND']"
		[Register ("EVENT_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode EventNotFound {
			get {
				if (EVENT_NOT_FOUND_jfieldId == IntPtr.Zero)
					EVENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVENT_NOT_FOUND_jfieldId == IntPtr.Zero)
					EVENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EVENT_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HTTP_HEADER_MALFORMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='HTTP_HEADER_MALFORMED']"
		[Register ("HTTP_HEADER_MALFORMED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode HttpHeaderMalformed {
			get {
				if (HTTP_HEADER_MALFORMED_jfieldId == IntPtr.Zero)
					HTTP_HEADER_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_HEADER_MALFORMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HTTP_HEADER_MALFORMED_jfieldId == IntPtr.Zero)
					HTTP_HEADER_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_MALFORMED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HTTP_HEADER_MALFORMED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HTTP_HEADER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='HTTP_HEADER_NOT_FOUND']"
		[Register ("HTTP_HEADER_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode HttpHeaderNotFound {
			get {
				if (HTTP_HEADER_NOT_FOUND_jfieldId == IntPtr.Zero)
					HTTP_HEADER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_HEADER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HTTP_HEADER_NOT_FOUND_jfieldId == IntPtr.Zero)
					HTTP_HEADER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HTTP_HEADER_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERNAL_SERVER_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='INTERNAL_SERVER_ERROR']"
		[Register ("INTERNAL_SERVER_ERROR")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode InternalServerError {
			get {
				if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_SERVER_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERNAL_SERVER_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INVALID_CONTENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='INVALID_CONTENT']"
		[Register ("INVALID_CONTENT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode InvalidContent {
			get {
				if (INVALID_CONTENT_jfieldId == IntPtr.Zero)
					INVALID_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CONTENT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_CONTENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INVALID_CONTENT_jfieldId == IntPtr.Zero)
					INVALID_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CONTENT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INVALID_CONTENT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MEMBER_ID_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='MEMBER_ID_REQUIRED']"
		[Register ("MEMBER_ID_REQUIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode MemberIdRequired {
			get {
				if (MEMBER_ID_REQUIRED_jfieldId == IntPtr.Zero)
					MEMBER_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_ID_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MEMBER_ID_REQUIRED_jfieldId == IntPtr.Zero)
					MEMBER_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MEMBER_ID_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MEMBER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='MEMBER_NOT_FOUND']"
		[Register ("MEMBER_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode MemberNotFound {
			get {
				if (MEMBER_NOT_FOUND_jfieldId == IntPtr.Zero)
					MEMBER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MEMBER_NOT_FOUND_jfieldId == IntPtr.Zero)
					MEMBER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MEMBER_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONCE_LIMIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='NONCE_LIMIT']"
		[Register ("NONCE_LIMIT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode NonceLimit {
			get {
				if (NONCE_LIMIT_jfieldId == IntPtr.Zero)
					NONCE_LIMIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONCE_LIMIT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONCE_LIMIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONCE_LIMIT_jfieldId == IntPtr.Zero)
					NONCE_LIMIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONCE_LIMIT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONCE_LIMIT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr REQUEST_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='REQUEST_TIMEOUT']"
		[Register ("REQUEST_TIMEOUT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode RequestTimeout {
			get {
				if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
					REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
					REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, REQUEST_TIMEOUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_UNAVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='SERVICE_UNAVAILABLE']"
		[Register ("SERVICE_UNAVAILABLE")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode ServiceUnavailable {
			get {
				if (SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
					SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_UNAVAILABLE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_UNAVAILABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
					SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_UNAVAILABLE", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_UNAVAILABLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SESSION_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='SESSION_NOT_FOUND']"
		[Register ("SESSION_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode SessionNotFound {
			get {
				if (SESSION_NOT_FOUND_jfieldId == IntPtr.Zero)
					SESSION_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SESSION_NOT_FOUND_jfieldId == IntPtr.Zero)
					SESSION_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SESSION_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='STREAM_DELETED']"
		[Register ("STREAM_DELETED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode StreamDeleted {
			get {
				if (STREAM_DELETED_jfieldId == IntPtr.Zero)
					STREAM_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_DELETED_jfieldId == IntPtr.Zero)
					STREAM_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_DELETED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_DELETED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='STREAM_NOT_FOUND']"
		[Register ("STREAM_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode StreamNotFound {
			get {
				if (STREAM_NOT_FOUND_jfieldId == IntPtr.Zero)
					STREAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_NOT_FOUND_jfieldId == IntPtr.Zero)
					STREAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_SEQ_CONTENTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='STREAM_SEQ_CONTENTION']"
		[Register ("STREAM_SEQ_CONTENTION")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode StreamSeqContention {
			get {
				if (STREAM_SEQ_CONTENTION_jfieldId == IntPtr.Zero)
					STREAM_SEQ_CONTENTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_SEQ_CONTENTION", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_SEQ_CONTENTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_SEQ_CONTENTION_jfieldId == IntPtr.Zero)
					STREAM_SEQ_CONTENTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_SEQ_CONTENTION", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_SEQ_CONTENTION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TARGET_SEQ_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='TARGET_SEQ_REQUIRED']"
		[Register ("TARGET_SEQ_REQUIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode TargetSeqRequired {
			get {
				if (TARGET_SEQ_REQUIRED_jfieldId == IntPtr.Zero)
					TARGET_SEQ_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TARGET_SEQ_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TARGET_SEQ_REQUIRED_jfieldId == IntPtr.Zero)
					TARGET_SEQ_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TARGET_SEQ_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNAUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='UNAUTHORIZED']"
		[Register ("UNAUTHORIZED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode Unauthorized {
			get {
				if (UNAUTHORIZED_jfieldId == IntPtr.Zero)
					UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNAUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNAUTHORIZED_jfieldId == IntPtr.Zero)
					UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNAUTHORIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNSPECIFIED_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='UNSPECIFIED_ERROR']"
		[Register ("UNSPECIFIED_ERROR")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode UnspecifiedError {
			get {
				if (UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
					UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED_ERROR", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
					UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED_ERROR", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNSPECIFIED_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr USER_BLOCKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='USER_BLOCKED']"
		[Register ("USER_BLOCKED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode UserBlocked {
			get {
				if (USER_BLOCKED_jfieldId == IntPtr.Zero)
					USER_BLOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_BLOCKED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_BLOCKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USER_BLOCKED_jfieldId == IntPtr.Zero)
					USER_BLOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_BLOCKED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, USER_BLOCKED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr USER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='USER_NOT_FOUND']"
		[Register ("USER_NOT_FOUND")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode UserNotFound {
			get {
				if (USER_NOT_FOUND_jfieldId == IntPtr.Zero)
					USER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USER_NOT_FOUND_jfieldId == IntPtr.Zero)
					USER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_NOT_FOUND", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, USER_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr VERSION_INCORRECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='VERSION_INCORRECT']"
		[Register ("VERSION_INCORRECT")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode VersionIncorrect {
			get {
				if (VERSION_INCORRECT_jfieldId == IntPtr.Zero)
					VERSION_INCORRECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_INCORRECT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_INCORRECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERSION_INCORRECT_jfieldId == IntPtr.Zero)
					VERSION_INCORRECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_INCORRECT", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, VERSION_INCORRECT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr VERSION_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/field[@name='VERSION_REQUIRED']"
		[Register ("VERSION_REQUIRED")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode VersionRequired {
			get {
				if (VERSION_REQUIRED_jfieldId == IntPtr.Zero)
					VERSION_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERSION_REQUIRED_jfieldId == IntPtr.Zero)
					VERSION_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_REQUIRED", "Lcom/layer/transport/thrift/sync/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, VERSION_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/transport/thrift/sync/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_findByValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/method[@name='findByValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findByValue", "(I)Lcom/layer/transport/thrift/sync/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode FindByValue (int p0)
		{
			if (id_findByValue_I == IntPtr.Zero)
				id_findByValue_I = JNIEnv.GetStaticMethodID (class_ref, "findByValue", "(I)Lcom/layer/transport/thrift/sync/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findByValue_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/transport/thrift/sync/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Layer.Transport.Thrift.Sync.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Transport.Thrift.Sync.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.transport.thrift.sync']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/layer/transport/thrift/sync/ErrorCode;", "")]
		public static global::Com.Layer.Transport.Thrift.Sync.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/transport/thrift/sync/ErrorCode;");
			return (global::Com.Layer.Transport.Thrift.Sync.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Transport.Thrift.Sync.ErrorCode));
		}

	}
}
